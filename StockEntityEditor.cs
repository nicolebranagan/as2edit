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
    public partial class StockEntityEditor : Form
    {
        int currentEntry = -1;
        string currentCode;

        public StockEntityEditor()
        {
            InitializeComponent();

            List<string> entityGfxTypes = new List<string>();
            entityGfxTypes.Add("MapTile");
            entityGfxTypes.Add("Enemies");
            entityGfxTypes.Add("Characters");
            entityGfxTypes.Add("Null");
            entityGfxList.DataSource = entityGfxTypes;

            RegenerateEntityList();
        }

        void RegenerateEntityList()
        {
            List<string> entities = new List<string>();
            foreach (EntityData eD in Main.currentFile.stockEntities)
            {
                entities.Add(eD.name);
            }

            entityList.DataSource = entities;
        }

        EntityData CompileEntity()
        {
            EntityData eD = new EntityData();
            eD.name = nameBox.Text;
            eD.gfxtype = (EntityData.GraphicsType)entityGfxList.SelectedIndex;
            eD.graphics = (int)graphicsUpDown.Value;
            eD.code = currentCode;
            return eD;
        }

        void DisplayEntity(EntityData entity)
        {
            nameBox.Text = entity.name;
            entityGfxList.SelectedIndex = (int)entity.gfxtype;
            graphicsUpDown.Value = entity.graphics;
            currentCode = entity.code;
        }

        public void getCode(string code)
        {
            currentCode = code;
        }

        private void codeButton_Click(object sender, EventArgs e)
        {
            string text = @"function onLoad() { }
function update() { }
function inRange() { }
function touch() { }
function hurt() { }";
            if (currentCode != "" && currentCode != null)
                text = currentCode;
            CodeDialog cD = new CodeDialog(getCode, text);
            cD.Show();
        }

        private void entityGfxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (entityGfxList.SelectedIndex == 0)
                graphicsLabel.Text = "Tile:";
            else
                graphicsLabel.Text = "Graphics Row:";
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            currentEntry = -1;
            nameBox.Text = "";
            entityGfxList.SelectedIndex = 0;
            graphicsUpDown.Value = 0;
            currentCode = "";

            addButton.Text = "Add";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            currentEntry = entityList.SelectedIndex;
            DisplayEntity(Main.currentFile.stockEntities[currentEntry]);

            addButton.Text = "Save";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            EntityData newEntity = CompileEntity();

            if (currentEntry != -1)
                Main.currentFile.stockEntities[currentEntry] = newEntity;
            else
                Main.currentFile.stockEntities.Add(newEntity);

            RegenerateEntityList();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
