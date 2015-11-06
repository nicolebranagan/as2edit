using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace as2edit
{
    public partial class AdventureObjectDialog : Form
    {
        AdventureEditor caller;
        List<StoredObject> objectList;
        StoredObject toEdit;
        EntityData currentEntityData = new EntityData();
        int roomX = -1;
        int roomY = -1;

        public AdventureObjectDialog(AdventureEditor caller, Room currentRoom)
        {
            InitializeComponent();

            this.caller = caller;
            this.objectList = currentRoom.storedObjects;

            List<string> objLabels = new List<string>();
            foreach (StoredObject obj in objectList)
                objLabels.Add(obj.ToString());
            objectListBox.DataSource = objLabels;

            if (Main.currentFile.bestiary.Count == 0)
                enemyRadio.Enabled = false;
            else
            {
                List<string> enemies = new List<string>();

                BestiaryEntry bE;
                //foreach (BestiaryEntry bE in Main.currentFile.bestiary)
                for (int i = 0; i < Main.currentFile.bestiary.Count; i++)
                {
                    bE = Main.currentFile.bestiary[i];
                    enemies.Add(string.Concat("#", i, ": ", bE.ToString()));
                }
                enemyList.DataSource = enemies;
            }

            if (Main.currentFile.stockEntities.Count == 0)
                stockEntityRadio.Enabled = false;
            else
            {
                List<string> entities = new List<string>();
                foreach (EntityData eD in Main.currentFile.stockEntities)
                    entities.Add(eD.name);
                stockEntityList.DataSource = entities;
            }

            List<string> entityGfxTypes = new List<string>();
            entityGfxTypes.Add("MapTile");
            entityGfxTypes.Add("Enemies");
            entityGfxTypes.Add("Characters");
            entityGfxTypes.Add("Null");
            entityGfxList.DataSource = entityGfxTypes;

            List<string> adventures = new List<string>();
            for (int i = 0; i < Main.currentFile.adventures.Count; i++)
            {
                if (Main.currentFile.adventures[i].name == "")
                    adventures.Add(String.Concat("Adventure #", i));
                else
                    adventures.Add(Main.currentFile.adventures[i].name);
            }
            TeleporterDestList.DataSource = adventures;

            if (Main.currentFile.specialStages.Count == 0)
                specialRadio.Enabled = false;
            else
                stageUpDown.Maximum = Main.currentFile.specialStages.Count - 1;

            ClearRoomGrid();
        }

        void ClearRoomGrid()
        {
            int x, y, square = 8;
            bool check; Color currentColor;
            Bitmap mapGrid = new Bitmap(128, 128);
            Graphics g = Graphics.FromImage(mapGrid);
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
        }

        void DrawRoomGrid(Adventure currentAdventure)
        {
            int square = 8;
            Bitmap mapGrid = new Bitmap(128, 128);
            Graphics g = Graphics.FromImage(mapGrid);

            int x, y;
            bool check;
            Color currentColor;

            for (int i = 0; i < 16 * 16; i++)
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
                g.FillRectangle(new SolidBrush(currentColor), x * square, y * square, square, square);
            }

            roomGrid.Image = mapGrid;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            caller.getNewObjects(objectList);
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            StoredObject newObject = new StoredObject();
            float dummy;
            float.TryParse(xBox.Text, out dummy);
            newObject.x = dummy * 32;
            float.TryParse(yBox.Text, out dummy);
            newObject.y = dummy * 32;
            if (keyRadio.Checked)
                newObject.type = StoredObject.ObjectType.key;
            else if (heartRadio.Checked)
                newObject.type = StoredObject.ObjectType.heart;
            else if (goldkeyRadio.Checked)
                newObject.type = StoredObject.ObjectType.goldkey;
            else if (enemyRadio.Checked)
            {
                newObject.type = StoredObject.ObjectType.enemy;
                newObject.enemyType = enemyList.SelectedIndex;
            }
            else if (shooterRadio.Checked)
            {
                newObject.type = StoredObject.ObjectType.shooter;
                if (trackCheck.Checked)
                    newObject.enemyType = 1;
                else
                    newObject.enemyType = 0;
            }
            else if (bossRadio.Checked)
            {
                newObject.type = StoredObject.ObjectType.boss;
                newObject.enemyType = (int)bossUpDown.Value;
            }
            else if (entityRadio.Checked)
            {
                newObject.type = StoredObject.ObjectType.entity;
                currentEntityData.name = nameBox.Text;
                currentEntityData.gfxtype = (EntityData.GraphicsType)entityGfxList.SelectedIndex;
                currentEntityData.graphics = (int)graphicsUpDown.Value;
                newObject.data = currentEntityData;
            }
            else if (teleportRadio.Checked)
            {
                newObject.type = StoredObject.ObjectType.teleporter;
                int dest, destx, desty; bool check;

                check = int.TryParse(TeleporterxBox.Text, out destx);
                if (!check) destx = 0;
                check = int.TryParse(TeleporteryBox.Text, out desty);
                if (!check) desty = 0;

                newObject.destx = destx;
                newObject.desty = desty;

                if (teleporterToMapCheck.Checked)
                    dest = -1; // Map
                else
                {
                    if ((roomX == -1) || (roomY == -1))
                    {
                        MessageBox.Show("Must select a room", "Error");
                        return;
                    }
                    dest = TeleporterDestList.SelectedIndex;
                    newObject.destroomX = roomX;
                    newObject.destroomY = roomY;
                }
                newObject.dest = dest;
            }
            else if (stockEntityRadio.Checked)
            {
                newObject.type = StoredObject.ObjectType.stock;
                newObject.enemyType = stockEntityList.SelectedIndex;
            }
            else if (specialRadio.Checked)
            {
                newObject.type = StoredObject.ObjectType.special;
                newObject.key = (int)keyUpDown.Value;
                newObject.screen = (int)stageUpDown.Value;
            }

            newObject.x = newObject.x + 16;
            newObject.y = newObject.y + 16;

            if (toEdit != null)
            {
                objectList.Remove(toEdit);
                addButton.Text = "Add";
            }
            objectList.Add(newObject);

            List<string> objLabels = new List<string>();
            foreach (StoredObject obj in objectList)
                objLabels.Add(obj.ToString());
            objectListBox.DataSource = objLabels;

            currentEntityData = new EntityData();
            currentEntityData.name = "";
            currentEntityData.code = "";
            currentEntityData.gfxtype = 0;
            currentEntityData.graphics = 0;

            nameBox.Text = "";
            entityGfxList.SelectedIndex = 0;
            graphicsUpDown.Value = 0;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            toEdit = objectList[objectListBox.SelectedIndex];
            xBox.Text = ((toEdit.x - 16) / 32).ToString();
            yBox.Text = ((toEdit.y - 16) / 32).ToString();
            if (toEdit.type == StoredObject.ObjectType.key)
            {
                keyRadio.Checked = true;
                heartRadio.Checked = false;
                goldkeyRadio.Checked = false;
                enemyRadio.Checked = false;
                shooterRadio.Checked = false;
                bossRadio.Checked = false;
                entityRadio.Checked = false;
                teleportRadio.Checked = false;
                stockEntityRadio.Checked = false;
                specialRadio.Checked = false;
            }
            else if (toEdit.type == StoredObject.ObjectType.heart)
            {
                keyRadio.Checked = false;
                heartRadio.Checked = true;
                goldkeyRadio.Checked = false;
                enemyRadio.Checked = false;
                shooterRadio.Checked = false;
                bossRadio.Checked = false;
                entityRadio.Checked = false;
                teleportRadio.Checked = false;
                stockEntityRadio.Checked = false;
                specialRadio.Checked = false;
            }
            else if (toEdit.type == StoredObject.ObjectType.goldkey)
            {
                keyRadio.Checked = false;
                heartRadio.Checked = false;
                goldkeyRadio.Checked = true;
                enemyRadio.Checked = false;
                shooterRadio.Checked = false;
                bossRadio.Checked = false;
                entityRadio.Checked = false;
                teleportRadio.Checked = false;
                stockEntityRadio.Checked = false;
                specialRadio.Checked = false;
            }
            else if (toEdit.type == StoredObject.ObjectType.enemy)
            {
                keyRadio.Checked = false;
                heartRadio.Checked = false;
                goldkeyRadio.Checked = false;
                enemyRadio.Checked = true;
                shooterRadio.Checked = false;
                bossRadio.Checked = false;
                entityRadio.Checked = false;
                teleportRadio.Checked = false;
                stockEntityRadio.Checked = false;
                specialRadio.Checked = false;

                enemyList.SelectedIndex = toEdit.enemyType;
            }
            else if (toEdit.type == StoredObject.ObjectType.shooter)
            {
                keyRadio.Checked = false;
                heartRadio.Checked = false;
                goldkeyRadio.Checked = false;
                enemyRadio.Checked = false;
                shooterRadio.Checked = true;
                bossRadio.Checked = false;
                entityRadio.Checked = false;
                teleportRadio.Checked = false;
                stockEntityRadio.Checked = false;
                specialRadio.Checked = false;

                trackCheck.Checked = toEdit.enemyType == 1;
            }
            else if (toEdit.type == StoredObject.ObjectType.boss)
            {
                keyRadio.Checked = false;
                heartRadio.Checked = false;
                goldkeyRadio.Checked = false;
                enemyRadio.Checked = false;
                shooterRadio.Checked = false;
                bossRadio.Checked = true;
                entityRadio.Checked = false;
                teleportRadio.Checked = false;
                stockEntityRadio.Checked = false;
                specialRadio.Checked = false;

                if (toEdit.enemyType == 0)
                    toEdit.enemyType = 1;
                bossUpDown.Value = toEdit.enemyType;
            }
            else if (toEdit.type == StoredObject.ObjectType.entity)
            {
                keyRadio.Checked = false;
                heartRadio.Checked = false;
                goldkeyRadio.Checked = false;
                enemyRadio.Checked = false;
                shooterRadio.Checked = false;
                bossRadio.Checked = false;
                entityRadio.Checked = true;
                teleportRadio.Checked = false;
                stockEntityRadio.Checked = false;
                specialRadio.Checked = false;

                currentEntityData = toEdit.data;
                nameBox.Text = toEdit.data.name;
                graphicsUpDown.Value = toEdit.data.graphics;
                entityGfxList.SelectedIndex = (int)toEdit.data.gfxtype;
            }
            else if (toEdit.type == StoredObject.ObjectType.teleporter)
            {
                keyRadio.Checked = false;
                heartRadio.Checked = false;
                goldkeyRadio.Checked = false;
                enemyRadio.Checked = false;
                shooterRadio.Checked = false;
                bossRadio.Checked = false;
                entityRadio.Checked = false;
                teleportRadio.Checked = true;
                stockEntityRadio.Checked = false;
                specialRadio.Checked = false;

                TeleporterxBox.Text = toEdit.destx.ToString();
                TeleporteryBox.Text = toEdit.desty.ToString();

                if (toEdit.dest == -1)
                    teleporterToMapCheck.Checked = true;
                else
                {
                    teleporterToMapCheck.Checked = false;
                    roomX = toEdit.destroomX;
                    roomY = toEdit.destroomY;
                    TeleporterDestList.SelectedIndex = toEdit.dest;
                }
            }
            else if (toEdit.type == StoredObject.ObjectType.stock)
            {
                keyRadio.Checked = false;
                heartRadio.Checked = false;
                goldkeyRadio.Checked = false;
                enemyRadio.Checked = false;
                shooterRadio.Checked = false;
                bossRadio.Checked = false;
                entityRadio.Checked = false;
                teleportRadio.Checked = false;
                stockEntityRadio.Checked = true;
                specialRadio.Checked = false;

                stockEntityList.SelectedIndex = toEdit.enemyType;
            }
            else if (toEdit.type == StoredObject.ObjectType.special)
            {
                keyRadio.Checked = false;
                heartRadio.Checked = false;
                goldkeyRadio.Checked = false;
                enemyRadio.Checked = false;
                shooterRadio.Checked = false;
                bossRadio.Checked = false;
                entityRadio.Checked = false;
                teleportRadio.Checked = false;
                stockEntityRadio.Checked = false;
                specialRadio.Checked = true;

                stageUpDown.Value = toEdit.screen;
                keyUpDown.Value = toEdit.key;
            }

            addButton.Text = "Save changes";
        }

        public void receiveCode(string code)
        {
            currentEntityData.code = code;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (toEdit != objectList[objectListBox.SelectedIndex])
                toEdit = objectList[objectListBox.SelectedIndex];
            objectList.Remove(toEdit);

            List<string> objLabels = new List<string>();
            foreach (StoredObject obj in objectList)
                objLabels.Add(obj.ToString());
            objectListBox.DataSource = objLabels;
            addButton.Text = "Add";
        }

        private void enemyRadio_CheckedChanged(object sender, EventArgs e)
        {
            enemyList.Enabled = enemyRadio.Checked;
        }

        private void entityRadio_CheckedChanged(object sender, EventArgs e)
        {
            entityOptions.Enabled = entityRadio.Checked;
        }

        private void codeButton_Click(object sender, EventArgs e)
        {
            string text = @"function onLoad() { }
function update() { }
function inRange() { }
function touch() { }
function hurt() { }";
            if (currentEntityData.code != "" && currentEntityData.code != null)
                text = currentEntityData.code;
            CodeDialog cD = new CodeDialog(receiveCode, text);
            cD.Show();
        }

        private void teleportRadio_CheckedChanged(object sender, EventArgs e)
        {
            teleportOptions.Enabled = teleportRadio.Checked;
        }

        private void teleporterToMapCheck_CheckedChanged(object sender, EventArgs e)
        {
            TeleporterDestList.Enabled = !(teleporterToMapCheck.Checked);
            if (!TeleporterDestList.Enabled)
            {
                ClearRoomGrid();
                roomX = -1;
                roomY = -1;
            }
        }

        private void TeleporterDestList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawRoomGrid(Main.currentFile.adventures[TeleporterDestList.SelectedIndex]);
        }

        private void roomGrid_MouseClick(object sender, MouseEventArgs e)
        {
            int x = (int)Math.Floor((double)e.X / 8);
            int y = (int)Math.Floor((double)e.Y / 8);
            if (!teleporterToMapCheck.Checked && x >= 0 && y >= 0 && x < (16) && y < (16))
            {
                Adventure currentAdventure = Main.currentFile.adventures[TeleporterDestList.SelectedIndex];
                if (currentAdventure.rooms[x, y] != null)
                {
                    roomX = x;
                    roomY = y;
                }

                DrawRoomGrid(currentAdventure);
            }
        }

        private void bossRadio_CheckedChanged(object sender, EventArgs e)
        {
            bossUpDown.Enabled = bossRadio.Checked;
        }

        private void stockEntityRadio_CheckedChanged(object sender, EventArgs e)
        {
            stockEntityList.Enabled = stockEntityRadio.Checked;
        }

        private void specialRadio_CheckedChanged(object sender, EventArgs e)
        {
            stageUpDown.Enabled = specialRadio.Checked;
            keyUpDown.Enabled = specialRadio.Checked;
        }

        private void shooterRadio_CheckedChanged(object sender, EventArgs e)
        {
            trackCheck.Enabled = shooterRadio.Checked;
        }
    }
}
