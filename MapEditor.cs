using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace as2edit
{
    public partial class MapEditor : Form
    {
        Map currentMap;
        TextureBrush nullBrush;
        Bitmap tileset;
        Bitmap[] tiles;
        MapTile[] mapTiles;
        bool awaitingNewObjects = false;

        MapTile _currentTile;
        MapTile currentTile
        {
            get { return _currentTile; }
            set
            {
                _currentTile = value;
                currentTileBox.Image = tiles[_currentTile.ID];
                currentTileLabel.Text = string.Concat("Tile ID#", _currentTile.ID);
                tileTypeList.SelectedIndex = currentMap.key[_currentTile.ID];
            }
        }

        enum tileType
        {
            Clear = 0,
            Solid = 1
        }

        public MapEditor()
        {
            InitializeComponent();
            mapBox.SizeMode = PictureBoxSizeMode.AutoSize;
            currentMap = Main.currentFile.map.Clone();

            Bitmap nullBitmap = new Bitmap(32, 32);
            Graphics g = Graphics.FromImage(nullBitmap);
            g.FillRectangle(new SolidBrush(Color.DarkGray), 0, 0, 16, 16);
            g.FillRectangle(new SolidBrush(Color.Gray), 16, 0, 16, 16);
            g.FillRectangle(new SolidBrush(Color.DarkGray), 16, 16, 16, 16);
            g.FillRectangle(new SolidBrush(Color.Gray), 0, 16, 16, 16);

            nullBrush = new TextureBrush(nullBitmap);

            Initialize();
            DisassembleTileset();
            DrawMap();
        }

        void Initialize()
        {
            List<string> types = new List<string>();
            types.Add(tileType.Clear.ToString());
            types.Add(tileType.Solid.ToString());
            tileTypeList.DataSource = types;

            startX.Text = this.currentMap.startX.ToString();
            startY.Text = this.currentMap.startY.ToString();
            
        }

        void DisassembleTileset()
        {
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("as2edit.protoworld.png");
            tileset = new Bitmap(myStream);

            int width = tileset.Width / 32;
            int height = tileset.Height / 32;
            tiles = new Bitmap[width * height];

            int count = 0; Rectangle cropRect;
            for (int j = 0; j < height; j++)
                for (int i = 0; i < width; i++)
                {
                    cropRect = new Rectangle(i * 32, j * 32, 32, 32);
                    tiles[count] = new Bitmap(tileset.Clone(cropRect, tileset.PixelFormat));
                    count = count + 1;
                }

            mapTiles = new MapTile[width * height];
            for (int i = 0; i < width*height; i++)
            {
                MapTile tile = new MapTile();
                tile.ID = i;
                mapTiles[i] = tile;
            }
            currentTile = mapTiles[0];

            Bitmap tileList = new Bitmap(32, (width * height * 32));
            Graphics g = Graphics.FromImage(tileList);
            TextureBrush theBrush;
            for (int i = 0; i < width*height; i++)
            {
                theBrush = new TextureBrush(tiles[i]);
                g.DrawImage(tiles[i], 0, i * 32);
            }
            tilesBox.Image = tileList;

            if (currentMap.key.Length != (width * height))
            {
                currentMap.key = new int[width * height];
            }
        }

        void DrawMap()
        {
            int x, y;
            Bitmap imageMap = new Bitmap(Map.width * 32, Map.height * 32);
            Graphics g = Graphics.FromImage(imageMap);
            for (int i = 0; i < Map.width * Map.height; i++)
            {
                x = i % Map.width;
                y = i / Map.width;

                g.DrawImage(tiles[currentMap.tileMap[i]], x * 32, y * 32);
            }

            mapBox.Image = imageMap;
            drawObjects();
        }

        void quickDraw(int x, int y)
        {
            Bitmap mapImage = (Bitmap)mapBox.Image;
            Graphics g = Graphics.FromImage(mapImage);
            int i = (Map.width) * y + x;
            g.DrawImage(tiles[currentMap.tileMap[i]], x * 32, y * 32);
            mapBox.Image = mapImage;
            drawObjects();
        }

        void drawObjects()
        {
            if (seeObjectCheck.Checked)
            {
                Bitmap mapImage = (Bitmap)mapBox.Image;
                Graphics g = Graphics.FromImage(mapImage);
                foreach (MapObject m in this.currentMap.objects)
                {
                    g.DrawRectangle(new Pen(Color.Red, 3), m.x * 32, m.y * 32, 32, 32);
                }
                mapBox.Image = mapImage;
            }
        }

        public void getNewObjectList(List<MapObject> objList)
        {
            this.currentMap.objects = objList;
            drawObjects();
            DrawMap();
        }

        public void gotNewObjects()
        {
            awaitingNewObjects = false;
        }

        private void mapBox_MouseMove(object sender, MouseEventArgs e)
        {
            int x = (int)Math.Floor((double)e.X / 32);
            int y = (int)Math.Floor((double)e.Y / 32);
            if (x >= 0 && y >= 0 && x < (32 * Map.width) && y < (32 * Map.height))
            {
                statusBarLabel.Text = String.Concat("X: ", x.ToString(), "; Y: ", y.ToString());
                if ((e.Button == MouseButtons.Left))
                {
                    bool foundObject = false;
                    if (!awaitingNewObjects && seeObjectCheck.Checked)
                    {
                        foreach (MapObject m in currentMap.objects)
                        {
                            if ((m.x == x) && (m.y == y))
                            {
                                foundObject = true;
                                MapObjectDialog mod = new MapObjectDialog(this, currentMap.objects, m);
                                mod.Show();
                                awaitingNewObjects = true;
                                break;
                            }
                        }
                    }
                    if (!foundObject)
                    {
                        currentMap.tileMap[(Map.width * y) + x] = currentTile.ID;
                        quickDraw(x, y);
                    }
                }
                else if ((e.Button == MouseButtons.Right))
                {
                    currentTile = mapTiles[currentMap.tileMap[(Map.width * y) + x]];
                }
            }
        }

        private void tilesBox_MouseMove(object sender, MouseEventArgs e)
        {
            int y = (int)Math.Floor((double)e.Y / 32);
            if (y >= 0)
            {
                statusBarLabel.Text = String.Concat("Tile ID#", mapTiles[y].ID);
                if ((e.Button == MouseButtons.Left))
                {
                    currentTile = mapTiles[y];
                }
            }
        }

        private void tileTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentMap.key[currentTile.ID] = tileTypeList.SelectedIndex;
        }

        private void mapPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int tryX; int tryY;
            bool checkX = int.TryParse(startX.Text, out tryX);
            bool checkY = int.TryParse(startY.Text, out tryY);
            if (checkX && checkY)
            {
                this.currentMap.startX = tryX;
                this.currentMap.startY = tryY;
            }

            Main.currentFile.map = this.currentMap;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < (Map.width * Map.height); i++)
            {
                currentMap.tileMap[i] = currentTile.ID;
            }
            DrawMap();
        }

        private void seeObjectCheck_CheckedChanged(object sender, EventArgs e)
        {
            drawObjects();
            if (!seeObjectCheck.Checked)
            {
                DrawMap();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!awaitingNewObjects)
            {
                MapObjectDialog mod = new MapObjectDialog(this, currentMap.objects);
                awaitingNewObjects = true;
                mod.Show();
            }
        }
    }

    struct MapTile
    {
        public int ID;
    }
}
