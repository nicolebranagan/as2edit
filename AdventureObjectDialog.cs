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

            List<string> entityGfxTypes = new List<string>();
            entityGfxTypes.Add("MapTile");
            entityGfxTypes.Add("Enemies");
            entityGfxList.DataSource = entityGfxTypes;
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
                newObject.type = StoredObject.ObjectType.shooter;
            else if (bossRadio.Checked)
                newObject.type = StoredObject.ObjectType.boss;
            else if (entityRadio.Checked)
            {
                newObject.type = StoredObject.ObjectType.entity;
                currentEntityData.name = nameBox.Text;
                currentEntityData.gfxtype = (EntityData.GraphicsType)entityGfxList.SelectedIndex;
                currentEntityData.graphics = (int)graphicsUpDown.Value;
                newObject.data = currentEntityData;
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
                entityRadio.Checked = true;
            }
            else if (toEdit.type == StoredObject.ObjectType.heart)
            {
                keyRadio.Checked = false;
                heartRadio.Checked = true;
                goldkeyRadio.Checked = false;
                enemyRadio.Checked = false;
                shooterRadio.Checked = false;
                bossRadio.Checked = false;
                entityRadio.Checked = true;
            }
            else if (toEdit.type == StoredObject.ObjectType.goldkey)
            {
                keyRadio.Checked = false;
                heartRadio.Checked = false;
                goldkeyRadio.Checked = true;
                enemyRadio.Checked = false;
                shooterRadio.Checked = false;
                bossRadio.Checked = false;
                entityRadio.Checked = true;
            }
            else if (toEdit.type == StoredObject.ObjectType.enemy)
            {
                keyRadio.Checked = false;
                heartRadio.Checked = false;
                goldkeyRadio.Checked = false;
                enemyRadio.Checked = true;
                shooterRadio.Checked = false;
                bossRadio.Checked = false;
                entityRadio.Checked = true;

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
                entityRadio.Checked = true;
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

                currentEntityData = toEdit.data;
                nameBox.Text = toEdit.data.name;
                graphicsUpDown.Value = toEdit.data.graphics;
                entityGfxList.SelectedIndex = (int)toEdit.data.gfxtype;
            }
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
    }
}
