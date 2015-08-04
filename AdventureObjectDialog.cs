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

        public AdventureObjectDialog(AdventureEditor caller, Room currentRoom)
        {
            InitializeComponent();

            this.caller = caller;
            this.objectList = currentRoom.storedObjects;

            List<string> objLabels = new List<string>();
            foreach (StoredObject obj in objectList)
                objLabels.Add(obj.ToString());
            objectListBox.DataSource = objLabels;

            List<string> enemies = new List<string>();
            foreach (BestiaryEntry bE in Main.currentFile.bestiary)
                enemies.Add(bE.ToString());
            enemyList.DataSource = enemies;
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

            newObject.x = newObject.x + 16;
            newObject.y = newObject.y + 16;

            if (toEdit != null)
                objectList.Remove(toEdit);
            objectList.Add(newObject);

            List<string> objLabels = new List<string>();
            foreach (StoredObject obj in objectList)
                objLabels.Add(obj.ToString());
            objectListBox.DataSource = objLabels;
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
            }
            else if (toEdit.type == StoredObject.ObjectType.heart)
            {
                keyRadio.Checked = false;
                heartRadio.Checked = true;
                goldkeyRadio.Checked = false;
                enemyRadio.Checked = false;
            }
            else if (toEdit.type == StoredObject.ObjectType.goldkey)
            {
                keyRadio.Checked = false;
                heartRadio.Checked = false;
                goldkeyRadio.Checked = true;
                enemyRadio.Checked = false;
            }
            else if (toEdit.type == StoredObject.ObjectType.enemy)
            {
                keyRadio.Checked = false;
                heartRadio.Checked = false;
                goldkeyRadio.Checked = false;
                enemyRadio.Checked = true;

                enemyList.SelectedIndex = toEdit.enemyType;
            }
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
        }

        private void enemyRadio_CheckedChanged(object sender, EventArgs e)
        {
            enemyList.Enabled = enemyRadio.Checked;
        }
    }
}
