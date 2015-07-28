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

        public MapObjectDialog(MapEditor caller, List<MapObject> objectList, MapObject toEdit = null)
        {
            this.caller = caller;
            this.objectList = objectList;
            this.toEdit = toEdit;
            InitializeComponent();

            if (toEdit == null)
                deleteButton.Enabled = false;
            else
            {
                xBox.Text = toEdit.x.ToString();
                yBox.Text = toEdit.y.ToString();
                if (toEdit is MapTeleporter)
                {
                    MapTeleporter mT = (MapTeleporter)toEdit;
                    TeleporterxBox.Text = mT.destx.ToString();
                    TeleporteryBox.Text = mT.desty.ToString();
                    TeleporterScreenBox.Text = mT.destscreen.ToString();
                    // TODO: Handle adventures
                }
            }
        }

        private void MapObjectDialog_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int x, y;

            if (teleportRadio.Checked)
            {
                int dest, destx, desty, destscreen;

                bool dummy = int.TryParse(xBox.Text, out x);
                if (!dummy) x = 0;
                dummy = int.TryParse(yBox.Text, out y);
                if (!dummy) y = 0;
                dummy = int.TryParse(TeleporterxBox.Text, out destx);
                if (!dummy) destx = 0;
                dummy = int.TryParse(TeleporteryBox.Text, out desty);
                if (!dummy) desty = 0;

                dest = -1; // Map
                destscreen = 0;
                // At the moment, assume all teleporters are on map
                MapTeleporter newObject = new MapTeleporter(x, y, dest, destscreen, destx, desty);
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
    }
}
