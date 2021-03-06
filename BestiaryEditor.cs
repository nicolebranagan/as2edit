﻿using System;
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
    public partial class BestiaryEditor : Form
    {
        int currentEntry = -1;

        public BestiaryEditor()
        {
            InitializeComponent();
            RegenerateEnemyList();
        }

        void RegenerateEnemyList()
        {
            List<string> enemies = new List<string>();
            foreach (BestiaryEntry bE in Main.currentFile.bestiary)
            {
                enemies.Add(bE.ToString());
            }

            enemyList.DataSource = enemies;
        }

        BestiaryEntry CompileEntry()
        {
            BestiaryEntry newEntry = new BestiaryEntry();
            newEntry.name = nameBox.Text;
            newEntry.graphicsRow = (int)graphicsUpDown.Value;
            newEntry.ghost = ghostCheck.Checked;
            newEntry.dependent = dependentBox.Text;

            newEntry.xOffset = (int)xOffsetUpDown.Value;
            newEntry.yOffset = (int)yOffsetUpDown.Value;

            newEntry.width = (int)widthUpDown.Value;
            newEntry.height = (int)heightUpDown.Value;

            newEntry.speed = (int)speedUpDown.Value;
            newEntry.decisiveness = (int)decisiveUpDown.Value;
            newEntry.health = (int)healthUpDown.Value;

            if (stationaryRadio.Checked)
                newEntry.movementType = BestiaryEntry.MovementTypes.stationary;
            else if (randomRadio.Checked)
                newEntry.movementType = BestiaryEntry.MovementTypes.random;
            else
            {
                newEntry.movementType = BestiaryEntry.MovementTypes.intelligent;
                newEntry.wanderer = wanderCheck.Checked;
                newEntry.intelligence = (int)intelligentUpDown.Value;
            }

            return newEntry;
        }

        void DisplayEntry(BestiaryEntry entry)
        {
            nameBox.Text = entry.name;
            graphicsUpDown.Value = entry.graphicsRow;
            ghostCheck.Checked = entry.ghost;
            dependentBox.Text = entry.dependent;

            xOffsetUpDown.Value = entry.xOffset;
            yOffsetUpDown.Value = entry.yOffset;

            widthUpDown.Value = entry.width;
            heightUpDown.Value = entry.height;

            speedUpDown.Value = entry.speed;
            decisiveUpDown.Value = entry.decisiveness;
            healthUpDown.Value = entry.health;

            stationaryRadio.Checked = false;
            randomRadio.Checked = false;
            intelligentRadio.Checked = false;

            switch (entry.movementType)
            {
                case BestiaryEntry.MovementTypes.stationary:
                    stationaryRadio.Checked = true;
                    break;
                case BestiaryEntry.MovementTypes.random:
                    randomRadio.Checked = true;
                    break;
                default:
                    intelligentRadio.Checked = true;
                    intelligentUpDown.Value = entry.intelligence;
                    wanderCheck.Checked = entry.wanderer;
                    break;
            }
        }

        private void enemyList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void intelligentRadio_CheckedChanged(object sender, EventArgs e)
        {
            intelligentUpDown.Enabled = intelligentRadio.Checked;
            wanderCheck.Enabled = intelligentRadio.Checked;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            currentEntry = enemyList.SelectedIndex;
            DisplayEntry(Main.currentFile.bestiary[currentEntry]);
            addButton.Text = "Save";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            BestiaryEntry newEntry = CompileEntry();

            if (currentEntry != -1)
                Main.currentFile.bestiary[currentEntry] = newEntry;
            else
                Main.currentFile.bestiary.Add(newEntry);

            RegenerateEnemyList();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            currentEntry = -1;
            DisplayEntry(new BestiaryEntry());
            addButton.Text = "Add";
        }
    }
}
