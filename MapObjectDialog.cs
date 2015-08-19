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
    public partial class MapObjectDialog : Form
    {
        MapEditor caller;
        List<MapObject> objectList;
        MapObject toEdit;

        int roomX = -1; int roomY = -1;

        public MapObjectDialog(MapEditor caller, List<MapObject> objectList, MapObject toEdit = null)
        {
            this.caller = caller;
            this.objectList = objectList;
            this.toEdit = toEdit;
            InitializeComponent();

            List<string> adventures = new List<string>();
            for (int i = 0; i < Main.currentFile.adventures.Count; i++)
            {
                if (Main.currentFile.adventures[i].name == "")
                    adventures.Add(String.Concat("Adventure #", i));
                else
                    adventures.Add(Main.currentFile.adventures[i].name);
            }
            TeleporterDestList.DataSource = adventures;
            ClearRoomGrid();

            if (toEdit == null)
                deleteButton.Enabled = false;
            else
            {
                xBox.Text = toEdit.x.ToString();
                yBox.Text = toEdit.y.ToString();
                if (toEdit is MapTeleporter)
                {
                    MapTeleporter mT = (MapTeleporter)toEdit;
                    teleportRadio.Checked = true;
                    TeleporterxBox.Text = mT.destx.ToString();
                    TeleporteryBox.Text = mT.desty.ToString();
                    if (mT.dest != -1)
                    {
                        roomX = mT.destroomX;
                        roomY = mT.destroomY;
                        teleporterToMapCheck.Checked = false;
                        TeleporterDestList.Enabled = true;
                        TeleporterDestList.SelectedIndex = mT.dest;
                        DrawRoomGrid(Main.currentFile.adventures[mT.dest]);
                    }
                }
                else if (toEdit is MapLock)
                {
                    lockRadio.Checked = true;
                    lockTileUpDown.Value = ((MapLock)toEdit).tile;
                }
            }

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

        private void MapObjectDialog_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int x, y;
            bool dummy = int.TryParse(xBox.Text, out x);
            if (!dummy) x = 0;
            dummy = int.TryParse(yBox.Text, out y);
            if (!dummy) y = 0;

            if (teleportRadio.Checked)
            {
                int dest, destx, desty;

                dummy = int.TryParse(TeleporterxBox.Text, out destx);
                if (!dummy) destx = 0;
                dummy = int.TryParse(TeleporteryBox.Text, out desty);
                if (!dummy) desty = 0;

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
                }
                MapTeleporter newObject = new MapTeleporter(x, y, dest, roomX, roomY, destx, desty);
                objectList.Add(newObject);
                if (this.toEdit != null)
                {
                    objectList.Remove(toEdit);
                }
                caller.getNewObjectList(objectList);
                this.Close();
            }
            else if (lockRadio.Checked)
            {
                MapLock newObject = new MapLock(x, y, (int)lockTileUpDown.Value);
                objectList.Add(newObject);
                if (this.toEdit != null)
                {
                    objectList.Remove(toEdit);
                }
                caller.getNewObjectList(objectList);
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.toEdit != null)
            {
                objectList.Remove(toEdit);
                caller.getNewObjectList(objectList);
                this.Close();
            }
        }

        private void MapObjectDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            caller.gotNewObjects();
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

        private void teleportRadio_CheckedChanged(object sender, EventArgs e)
        {
            teleporterOptions.Enabled = teleportRadio.Checked;
        }

        private void lockRadio_CheckedChanged(object sender, EventArgs e)
        {
            lockOptions.Enabled = lockRadio.Checked;
        }
    }
}
