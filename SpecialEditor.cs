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

namespace as2edit
{
    public partial class SpecialEditor : Form
    {
        Bitmap[] tiles;
        int[] currentMap;

        int _currentTile;
        int currentTile
        {
            get { return _currentTile; }
            set
            {
                currentTileBox.Image = tiles[value];
                _currentTile = value;
            }
        }

        const int width = 19;
        int height = 15;

        public SpecialEditor()
        {
            InitializeComponent();
            DisassembleTileset();
            ClearMap();
            Initialize();
        }

        private void SpecialEditor_Load(object sender, EventArgs e)
        {

        }

        void Initialize()
        {
            int i = 0;
            List<string> specialStages = new List<string>();
            foreach (SpecialStage sS in Main.currentFile.specialStages)
            {
                specialStages.Add(String.Concat("Stage ",i.ToString()));
                i++;
            }
            stageSelectList.DataSource = specialStages;
        }

        void DisassembleTileset()
        {
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStream;
            myStream = myAssembly.GetManifestResourceStream("as2edit.specialstage.png");
            Bitmap tileset = new Bitmap(myStream);

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
            currentTile = 0;

            Bitmap tileList = new Bitmap(32, (width * height * 32));
            Graphics g = Graphics.FromImage(tileList);
            TextureBrush theBrush;
            for (int i = 0; i < width * height; i++)
            {
                theBrush = new TextureBrush(tiles[i]);
                g.DrawImage(tiles[i], 0, i * 32);
            }
            tilesBox.Image = tileList;
        }

        void ClearMap()
        {
            int height = (int)heightUpDown.Value;

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
            specialBox.Image = nullMap;
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
            currentStageGroup.Enabled = false;
            stageObjectsBox.Enabled = false;
        }

        void DrawMap()
        {
            Bitmap Map = new Bitmap(width * 32, height * 32);
            Graphics g = Graphics.FromImage(Map);
            int x, y;
            for (int i = 0; i < width * height; i++)
            {
                x = i % width;
                y = i / width;

                g.DrawImage(tiles[currentMap[i]], x * 32, y * 32);
            }

            specialBox.Image = Map;

            if (showCheck.Checked)
                DrawObjects();
        }

        void quickDraw(int x, int y)
        {
            Bitmap mapImage = (Bitmap)specialBox.Image;
            Graphics g = Graphics.FromImage(mapImage);
            int i = (width) * y + x;
            g.DrawImage(tiles[currentMap[i]], x * 32, y * 32);
            specialBox.Image = mapImage;
        }

        void populateObjectList(SpecialStage stage)
        {
            List<string> enemies = new List<string>();
            foreach (StoredSpecial sS in stage.objects)
                enemies.Add(string.Concat("X: ", sS.x.ToString(), " Y: ", sS.y.ToString()));
            objectListBox.DataSource = enemies;

            if (enemies.Count == 0)
                enemyOptionsGroup.Enabled = false;
;        }

        void populateEnemyOptions(StoredSpecial enemy)
        {
            xUpDown.Value = enemy.x;
            yUpDown.Value = enemy.y;
            rowUpDown.Value = enemy.row;
            shootingRateUpDown.Value = enemy.shootingrate;
            behaviorUpDown.Value = enemy.behavior;
            speedUpDown.Value = enemy.speed;
            amplitudeUpDown.Value = enemy.amplitude;
            timeUpDown.Value = enemy.time;
            trackCheck.Checked = enemy.track;

            enemyOptionsGroup.Enabled = true;
        }

        StoredSpecial getEnemy()
        {
            return new StoredSpecial(
                (int)rowUpDown.Value, (int)xUpDown.Value, (int)yUpDown.Value,
                (int)shootingRateUpDown.Value, (int)speedUpDown.Value,
                (int)amplitudeUpDown.Value, (int)timeUpDown.Value, (int)behaviorUpDown.Value, trackCheck.Checked);
        }

        private void specialBox_MouseMove(object sender, MouseEventArgs e)
        {
            statusBarLabel.Text = String.Concat("X: ", e.X.ToString(), "; Y: ", e.Y.ToString());
            int x = (int)Math.Floor((double)e.X / 32);
            int y = (int)Math.Floor((double)e.Y / 32);
            if (x >= 0 && y >= 0 && x < (32 * width) && y < (32 * height))
            {
                if ((showCheck.Checked) && (e.Button == MouseButtons.Left))
                {
                    StoredSpecial s;
                    bool foundObject = false;
                    for (int i = 0; i < Main.currentFile.specialStages[stageSelectList.SelectedIndex].objects.Count; i++)
                    {
                        s = Main.currentFile.specialStages[stageSelectList.SelectedIndex].objects[i];
                        if (Math.Pow(e.X - s.x, 2) + Math.Pow(e.Y - s.y, 2) < Math.Pow(6,2))
                        {
                            objectListBox.SelectedIndex = i;
                            foundObject = true;
                        }
                    }

                    if (!foundObject)
                    {
                        xUpDown.Value = e.X;
                        yUpDown.Value = e.Y;
                    }
                }
                else
                {
                    if ((e.Button == MouseButtons.Left))
                    {
                        if (((width * y + x) < currentMap.Length) && ((width * y + x) >= 0))
                        {
                            currentMap[(width * y) + x] = currentTile;
                            quickDraw(x, y);
                        }
                    }
                    else if ((e.Button == MouseButtons.Right))
                    {
                        if (((width * y + x) < currentMap.Length) && ((width * y + x) >= 0))
                            currentTile = currentMap[(width * y) + x];
                    }
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

        private void heightUpDown_ValueChanged(object sender, EventArgs e)
        {
            int newHeight = (int)heightUpDown.Value;
            int[] newMap = new int[newHeight * width];

            if (currentMap != null)
            {
                for (int i = 0; i < Math.Min(newMap.Length, currentMap.Length); i++)
                    newMap[i] = currentMap[i];
            }

            height = newHeight;
            currentMap = newMap;

            DrawMap();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Main.currentFile.specialStages.Add(new SpecialStage());
            Initialize();
        }

        private void stageSelectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpecialStage currentStage = Main.currentFile.specialStages[stageSelectList.SelectedIndex];
            if (currentStage.height != 0)
            {
                height = currentStage.height;
                heightUpDown.Value = currentStage.height;
            }

            currentMap = new int[width * height];
            if (currentStage.tileMap != null)
                currentStage.tileMap.CopyTo(currentMap, 0);

            DrawMap();
            currentStageGroup.Enabled = true;
            stageObjectsBox.Enabled = true;
            populateObjectList(currentStage);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SpecialStage newStage = new SpecialStage();
            newStage.height = (int)heightUpDown.Value;
            newStage.tileMap = currentMap;
            newStage.objects = Main.currentFile.specialStages[stageSelectList.SelectedIndex].objects;
            Main.currentFile.specialStages[stageSelectList.SelectedIndex] = newStage;

            statusBarLabel.Text = "Saved tilemap";
        }

        void DrawObjects()
        {
            Bitmap mapImage = (Bitmap)specialBox.Image;
            Graphics g = Graphics.FromImage(mapImage);
            foreach (StoredSpecial m in Main.currentFile.specialStages[stageSelectList.SelectedIndex].objects)
            {
                g.FillEllipse(new SolidBrush(Color.Red), m.x - 6, m.y - 6, 12, 12);
            }
            specialBox.Image = mapImage;
        }

        private void objectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateEnemyOptions(Main.currentFile.specialStages[stageSelectList.SelectedIndex].objects[objectListBox.SelectedIndex]);
        }

        private void newObjectButton_Click(object sender, EventArgs e)
        {
            Main.currentFile.specialStages[stageSelectList.SelectedIndex].objects.Add(new StoredSpecial(0, 0, 0, 0, 0, 0, 0, 0, false));
            populateObjectList(Main.currentFile.specialStages[stageSelectList.SelectedIndex]);
        }

        private void deleteObjectButton_Click(object sender, EventArgs e)
        {
            Main.currentFile.specialStages[stageSelectList.SelectedIndex].objects.Remove(
                Main.currentFile.specialStages[stageSelectList.SelectedIndex].objects[objectListBox.SelectedIndex]);

            populateObjectList(Main.currentFile.specialStages[stageSelectList.SelectedIndex]);
        }

        private void saveEnemyButton_Click(object sender, EventArgs e)
        {
            int lastObject = objectListBox.SelectedIndex;
            Main.currentFile.specialStages[stageSelectList.SelectedIndex].objects[objectListBox.SelectedIndex] = 
                getEnemy();
            populateObjectList(Main.currentFile.specialStages[stageSelectList.SelectedIndex]);
            objectListBox.SelectedIndex = lastObject;

            DrawMap();
        }

        private void dupeButton_Click(object sender, EventArgs e)
        {
            Main.currentFile.specialStages[stageSelectList.SelectedIndex].objects.Add(
                Main.currentFile.specialStages[stageSelectList.SelectedIndex].objects[objectListBox.SelectedIndex].Clone());
            populateObjectList(Main.currentFile.specialStages[stageSelectList.SelectedIndex]);
        }

        private void showCheck_CheckedChanged(object sender, EventArgs e)
        {
            DrawMap();
        }
    }
}
