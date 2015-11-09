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
using Microsoft.VisualBasic;

namespace as2edit
{
    public partial class AdventureEditor : Form
    {
        const int width = 25;
        const int height = 13;

        Adventure currentAdventure;
        Room currentRoom;
        int roomX = -1;
        int roomY = -1;

        Bitmap[] tiles;
        Bitmap tileset;

        int _currentTile;
        int currentTile
        {
            get { return _currentTile; }
            set
            {
                currentTileBox.Image = tiles[value];
                _currentTile = value;
                tileTypeList.SelectedIndex = currentAdventure.key[value];
            }
        }

        enum tileType
        {
            Clear = 0,
            Solid = 1,
            Crevasse = 2,
            Injury = 3,
            Warp = 4,
            Heal = 5,
            Lock = 6,
            Wood = 7,
        }

        public AdventureEditor()
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            InitializeComponent();

            Initialize();
            ClearMap();
        }

        void Initialize()
        {
            List<string> music = new List<string>();
            for (int i = -1; i < 19; i++)
            {
                music.Add(((Main.SongName)i).ToString());
            }
            advMusicList.DataSource = music;
            string[] music2 = new string[music.Count];
            music.CopyTo(music2);
            roomMusicList.DataSource = music2;

            List<string> adventures = new List<string>();
            string label;
            for (int i = 0; i < Main.currentFile.adventures.Count; i++)
            {
                if (Main.currentFile.adventures[i].name != "")
                    label = Main.currentFile.adventures[i].name;
                else
                    label = string.Concat("Adventure #", i);
                adventures.Add(label);
            }
            advList.DataSource = adventures;

            List<string> types = new List<string>();
            types.Add(tileType.Clear.ToString());
            types.Add(tileType.Solid.ToString());
            types.Add(tileType.Crevasse.ToString());
            types.Add(tileType.Injury.ToString());
            types.Add(tileType.Warp.ToString());
            types.Add(tileType.Heal.ToString());
            types.Add(tileType.Lock.ToString());
            types.Add(tileType.Wood.ToString());
            tileTypeList.DataSource = types;
        }

        void ClearMap()
        {
            Bitmap nullBitmap = new Bitmap(32, 32);
            Graphics g = Graphics.FromImage(nullBitmap);
            g.FillRectangle(new SolidBrush(Color.DarkGray), 0, 0, 16, 16);
            g.FillRectangle(new SolidBrush(Color.Gray), 16, 0, 16, 16);
            g.FillRectangle(new SolidBrush(Color.DarkGray), 16, 16, 16, 16);
            g.FillRectangle(new SolidBrush(Color.Gray), 0, 16, 16, 16);

            Bitmap nullMap = new Bitmap(width * 32, height * 32);
            g = Graphics.FromImage(nullMap);
            int x, y;
            for (int i = 0; i < width * height; i++)
            {
                x = i % width;
                y = i / width;

                g.DrawImage(nullBitmap, x * 32, y * 32);
            }
            advBox.Image = nullMap;
            currentTileBox.Image = nullBitmap;

            bool check;
            Color currentColor;

            int square = 8;
            Bitmap mapGrid = new Bitmap(128, 128);
            g = Graphics.FromImage(mapGrid);
            for (int i = 0; i < 16 * 16; i++)
            {
                x = i % 16;
                y = i / 16;
                check = (x % 2 == 0);
                if (y % 2 == 0)
                    check = !check;
                currentColor = check ? Color.Gray : Color.DarkGray;
                g.FillRectangle(new SolidBrush(currentColor), x * square, y * square, square, square);
            }
            roomGrid.Image = mapGrid;

            roomOptions.Enabled = false;
        }

        void DrawRoomGrid()
        {
            int square = 8;
            Bitmap mapGrid = new Bitmap(128,128);
            Graphics g = Graphics.FromImage(mapGrid);

            int x, y;
            bool check;
            Color currentColor;

            for (int i = 0; i < 16*16; i++)
            {
                x = i % 16;
                y = i / 16;
                check = (x % 2 == 0);
                if (y % 2 == 0)
                    check = !check;
                if (currentAdventure.rooms[x, y] != null)
                    currentColor = check ? Color.Red : Color.DarkRed;
                else
                    currentColor = check ? Color.Gray : Color.DarkGray;
                if ((x == roomX) && (y == roomY))
                    currentColor = Color.Cyan;
                g.FillRectangle(new SolidBrush(currentColor),x*square, y*square, square, square);
            }

            roomGrid.Image = mapGrid;
        }

        void DisassembleTileset()
        {
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStream;
            switch (currentAdventure.tileset)
            {
                case 1:
                    myStream = myAssembly.GetManifestResourceStream("as2edit.town.png");
                    break;
                case 2:
                    myStream = myAssembly.GetManifestResourceStream("as2edit.dungeon2.png");
                    break;
                case 3:
                    myStream = myAssembly.GetManifestResourceStream("as2edit.dungeon3.png");
                    break;
                case 4:
                    myStream = myAssembly.GetManifestResourceStream("as2edit.dungeon4.png");
                    break;
                case 5:
                    myStream = myAssembly.GetManifestResourceStream("as2edit.dungeon5.png");
                    break;
                case 6:
                    myStream = myAssembly.GetManifestResourceStream("as2edit.dungeon6.png");
                    break;
                case 7:
                    myStream = myAssembly.GetManifestResourceStream("as2edit.town2.png");
                    break;
                default:
                    myStream = myAssembly.GetManifestResourceStream("as2edit.dungeon1.png");
                    break;
            } 
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
            //currentTile = 0;

            Bitmap tileList = new Bitmap(32, (width * height * 32));
            Graphics g = Graphics.FromImage(tileList);
            TextureBrush theBrush;
            for (int i = 0; i < width * height; i++)
            {
                theBrush = new TextureBrush(tiles[i]);
                g.DrawImage(tiles[i], 0, i * 32);
            }
            tilesBox.Image = tileList;

            if (currentAdventure.key.Length != (width * height))
            {
                currentAdventure.key = new int[width * height];
            }
        }

        void DrawRoom()
        {
            int x, y;
            Bitmap imageMap = new Bitmap(width * 32, height * 32);
            Graphics g = Graphics.FromImage(imageMap);
            for (int i = 0; i < width * height; i++)
            {
                x = i % width;
                y = i / width;

                g.DrawImage(tiles[currentRoom.tileMap[i]], x * 32, y * 32);
            }

            advBox.Image = imageMap;

            if (showObjectCheck.Checked)
                DrawObjects();
        }
        
        void DrawObjects()
        {
            Bitmap imageMap = (Bitmap)advBox.Image;
            Graphics g = Graphics.FromImage(imageMap);
            foreach (StoredObject obj in currentRoom.storedObjects)
            {
                bool drawn = false;
                if (obj.type == StoredObject.ObjectType.entity || obj.type == StoredObject.ObjectType.stock)
                {
                    EntityData data;
                    if (obj.type == StoredObject.ObjectType.stock)
                        data = Main.currentFile.stockEntities[obj.enemyType];
                    else
                        data = obj.data;

                    if (data.gfxtype == EntityData.GraphicsType.Maptile)
                    {
                        g.DrawImage(tiles[data.graphics], obj.x - 16, obj.y - 16);
                        g.DrawRectangle(new Pen(obj.getColor(), 4), obj.x - 16, obj.y - 16, 32, 32);
                        drawn = true;
                    }
                    else if (data.gfxtype == EntityData.GraphicsType.Null)
                    {
                        g.DrawEllipse(new Pen(obj.getColor(), 4), obj.x - 8, obj.y - 8, 16, 16);
                        drawn = true;
                    }
                }
                else if (obj.type == StoredObject.ObjectType.goldkey || obj.type == StoredObject.ObjectType.heart 
                    || obj.type == StoredObject.ObjectType.key || obj.type == StoredObject.ObjectType.special
                    || obj.type == StoredObject.ObjectType.teleporter )
                {
                    g.FillRectangle(new SolidBrush(obj.getColor()), new Rectangle((int)obj.x - 6, (int)obj.y - 6, 12, 12));
                    g.DrawRectangle(new Pen(Color.Black, 2), obj.x - 6, obj.y - 6, 12, 12);
                    drawn = true;
                }

                if (!drawn)
                {
                    g.FillEllipse(new SolidBrush(obj.getColor()), new Rectangle((int)obj.x - 8, (int)obj.y - 8, 16, 16));
                }
            }
        }

        void quickDraw(int x, int y)
        {

            Bitmap mapImage = (Bitmap)advBox.Image;
            Graphics g = Graphics.FromImage(mapImage);
            int i = (width) * y + x;
            g.DrawImage(tiles[currentRoom.tileMap[i]], x * 32, y * 32);
            advBox.Image = mapImage;
        }

        public void getNewObjects(List<StoredObject> objectList)
        {

        }

        private void tilesPanel_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void advBox_MouseMove(object sender, MouseEventArgs e)
        {
            int x = (int)Math.Floor((double)e.X / 32);
            int y = (int)Math.Floor((double)e.Y / 32);
            if (x >= 0 && y >= 0 && x < (32 * width) && y < (32 * height))
            {
                statusBarLabel.Text = String.Concat("X: ", x.ToString(), "; Y: ", y.ToString());
                if ((e.Button == MouseButtons.Left))
                {
                    if (((width * y + x) < currentRoom.tileMap.Length) && ((width * y + x) >= 0))
                    {
                        currentRoom.tileMap[(width * y) + x] = currentTile;
                        quickDraw(x, y);
                    }
                }
                else if ((e.Button == MouseButtons.Right))
                {
                    if (((width * y + x) < currentRoom.tileMap.Length) && ((width * y + x) >= 0))
                        currentTile = currentRoom.tileMap[(width * y) + x];
                }
            }
        }

        private void tilesBox_MouseMove(object sender, MouseEventArgs e)
        {
            int y = (int)Math.Floor((double)e.Y / 32);
            if (y >= 0)
            {
                statusBarLabel.Text = String.Concat("Tile ID#", y);
                if ((e.Button == MouseButtons.Left))
                {
                    currentTile = y;
                }
            }
        }

        private void addAdvBox_Click(object sender, EventArgs e)
        {
            Main.currentFile.adventures.Add(new Adventure());

            List<string> adventures = new List<string>();
            string label;
            for (int i = 0; i < Main.currentFile.adventures.Count; i++)
            {
                if (Main.currentFile.adventures[i].name != "")
                    label = Main.currentFile.adventures[i].name;
                else
                    label = string.Concat("Adventure #", i);
                adventures.Add(label);
            }
            advList.DataSource = adventures;
        }

        private void advList_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentAdventure = Main.currentFile.adventures[advList.SelectedIndex];
            tilesetUpDown.Value = currentAdventure.tileset;
            tilesetUpDown.Enabled = true;
            advMusicList.SelectedIndex = currentAdventure.music + 1;
            roomX = -1; roomY = -1;
            ClearMap();
            DrawRoomGrid();
            DisassembleTileset();
        }

        private void delAdvBox_Click(object sender, EventArgs e)
        {
            Main.currentFile.adventures.Remove(Main.currentFile.adventures[advList.SelectedIndex]);
            tilesetUpDown.Value = 0;
            tilesetUpDown.Enabled = false;
            List<string> adventures = new List<string>();
            string label;
            for (int i = 0; i < Main.currentFile.adventures.Count; i++)
            {
                if (Main.currentFile.adventures[i].name != "")
                    label = Main.currentFile.adventures[i].name;
                else
                    label = string.Concat("Adventure #", i);
                adventures.Add(label);
            }
            advList.DataSource = adventures;
            currentAdventure = null;
            roomX = -1; roomY = -1;
            ClearMap();
        }

        private void delRoomBox_Click(object sender, EventArgs e)
        {
            currentAdventure.rooms[roomX, roomY] = null;
            roomX = -1; roomY = -1;
            ClearMap();
            DrawRoomGrid();
        }

        private void roomGrid_MouseClick(object sender, MouseEventArgs e)
        {
            int x = (int)Math.Floor((double)e.X / 8);
            int y = (int)Math.Floor((double)e.Y / 8);
            if (currentAdventure != null && x >= 0 && y >= 0 && x < (16) && y < (16))
            {
                if (currentAdventure.rooms[x,y] == null)
                {
                    currentAdventure.rooms[x, y] = currentAdventure.templateRoom.copyRoom();
                }
                currentRoom = currentAdventure.rooms[x, y];
                roomMusicList.SelectedIndex = currentRoom.music + 1;
                roomX = x;
                roomY = y;
                DrawRoom();
                DrawRoomGrid();
                roomOptions.Enabled = true;
                darkRoomCheck.Checked = currentRoom.dark;
                hblockCheck.Checked = currentRoom.hblock;
                vblockCheck.Checked = currentRoom.vblock;
            }
        }

        private void templateButton_Click(object sender, EventArgs e)
        {
            this.currentAdventure.templateRoom = currentRoom.copyRoom();
            statusBarLabel.Text = "Made new room template.";
        }

        private void tileTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentAdventure != null)
                currentAdventure.key[currentTile] = tileTypeList.SelectedIndex;
        }

        private void objectButton_Click(object sender, EventArgs e)
        {
            AdventureObjectDialog aod = new AdventureObjectDialog(this, currentRoom);
            aod.Show();
        }

        private void codeButton_Click(object sender, EventArgs e)
        {
            string text = @"function onLoad() { }
function update() { }";
            if (currentRoom.code != null)
                text = currentRoom.code;
            CodeDialog cD = new CodeDialog(newRoomCode, text);
            cD.Show();
        }

        void newRoomCode(string code)
        {
            currentRoom.code = code;
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            string response = Interaction.InputBox("Choose new name", "Editor", currentAdventure.name);
            currentAdventure.name = response;

            List<string> adventures = new List<string>();
            string label;
            for (int i = 0; i < Main.currentFile.adventures.Count; i++)
            {
                if (Main.currentFile.adventures[i].name != "")
                    label = Main.currentFile.adventures[i].name;
                else
                    label = string.Concat("Adventure #", i);
                adventures.Add(label);
            }
            advList.DataSource = adventures;
        }

        private void tilesetUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (tilesetUpDown.Value != currentAdventure.tileset)
            {
                currentAdventure.tileset = (int)tilesetUpDown.Value;
                DisassembleTileset();
                if (currentRoom != null)
                    DrawRoom();
            }
        }

        private void darkRoomCheck_CheckedChanged(object sender, EventArgs e)
        {
            currentRoom.dark = darkRoomCheck.Checked;
        }

        private void showObjectCheck_CheckedChanged(object sender, EventArgs e)
        {
            DrawRoom();
        }

        private void advMusicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentAdventure != null)
                currentAdventure.music = advMusicList.SelectedIndex - 1;
        }

        private void roomMusicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentRoom != null)
                currentRoom.music = roomMusicList.SelectedIndex - 1;
        }

        private void pngButton_Click(object sender, EventArgs e)
        {
            int roomx, roomy;
            int x, y;

            Bitmap totalMap = new Bitmap(32 * width * 16, 32 * height * 16);
            Graphics g = Graphics.FromImage(totalMap);
            for (int i = 0; i < 16 * 16; i++)
            {
                roomx = i % 16;
                roomy = i / 16;

                if (currentAdventure.rooms[roomx, roomy] != null)
                {
                    for (int j = 0; j < width * height; j++)
                    {
                        x = j % width;
                        y = j / width;

                        g.DrawImage(tiles[currentAdventure.rooms[roomx, roomy].tileMap[j]], 
                            roomx * 32 * width + x * 32, roomy * 32 * height + y * 32);
                    }
                }
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PNG Image|*.png|All Files|*.*";
            saveFileDialog1.Title = "Save Map As Image";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                totalMap.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void hblockCheck_CheckedChanged(object sender, EventArgs e)
        {
            currentRoom.hblock = hblockCheck.Checked;
        }

        private void vblockCheck_CheckedChanged(object sender, EventArgs e)
        {
            currentRoom.vblock = vblockCheck.Checked;
        }

        private void roomGrid_MouseMove(object sender, MouseEventArgs e)
        {
            int x = (int)Math.Floor((double)e.X / 8);
            int y = (int)Math.Floor((double)e.Y / 8);
            bool vacant = true;
            if (currentAdventure != null && x >= 0 && y >= 0 && x < (16) && y < (16))
            {
                if (currentAdventure.rooms[x, y] != null) vacant = false;
                statusBarLabel.Text = string.Concat("Room X: ", x, ", Room Y: ", y,
                    vacant ? " (Empty)" : "");
            }
        }
    }
}
