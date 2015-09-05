﻿using System;
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
            //currentStageGroup.Enabled = false;
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
        }

        void quickDraw(int x, int y)
        {
            Bitmap mapImage = (Bitmap)specialBox.Image;
            Graphics g = Graphics.FromImage(mapImage);
            int i = (width) * y + x;
            g.DrawImage(tiles[currentMap[i]], x * 32, y * 32);
            specialBox.Image = mapImage;
        }

        private void specialBox_MouseMove(object sender, MouseEventArgs e)
        {
            int x = (int)Math.Floor((double)e.X / 32);
            int y = (int)Math.Floor((double)e.Y / 32);
            if (x >= 0 && y >= 0 && x < (32 * width) && y < (32 * height))
            {
                //statusBarLabel.Text = String.Concat("X: ", x.ToString(), "; Y: ", y.ToString());
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

        private void tilesBox_MouseMove(object sender, MouseEventArgs e)
        {
            int y = (int)Math.Floor((double)e.Y / 32);
            if (y >= 0)
            {
               // statusBarLabel.Text = String.Concat("Tile ID#", y);
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

            for (int i = 0; i < Math.Min(newMap.Length, currentMap.Length); i++)
                newMap[i] = currentMap[i];

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
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SpecialStage newStage = new SpecialStage();
            newStage.height = (int)heightUpDown.Value;
            newStage.tileMap = currentMap;
            Main.currentFile.specialStages[stageSelectList.SelectedIndex] = newStage;
        }
    }
}