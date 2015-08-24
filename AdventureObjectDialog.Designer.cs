﻿namespace as2edit
{
    partial class AdventureObjectDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deleteButton = new System.Windows.Forms.Button();
            this.typeBox = new System.Windows.Forms.GroupBox();
            this.teleportRadio = new System.Windows.Forms.RadioButton();
            this.entityRadio = new System.Windows.Forms.RadioButton();
            this.bossUpDown = new System.Windows.Forms.NumericUpDown();
            this.bossRadio = new System.Windows.Forms.RadioButton();
            this.shooterRadio = new System.Windows.Forms.RadioButton();
            this.enemyList = new System.Windows.Forms.ListBox();
            this.enemyRadio = new System.Windows.Forms.RadioButton();
            this.goldkeyRadio = new System.Windows.Forms.RadioButton();
            this.heartRadio = new System.Windows.Forms.RadioButton();
            this.keyRadio = new System.Windows.Forms.RadioButton();
            this.okButton = new System.Windows.Forms.Button();
            this.yBox = new System.Windows.Forms.TextBox();
            this.xBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.objectListBox = new System.Windows.Forms.ListBox();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.entityOptions = new System.Windows.Forms.GroupBox();
            this.codeButton = new System.Windows.Forms.Button();
            this.entityGfxList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.graphicsUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teleportOptions = new System.Windows.Forms.GroupBox();
            this.roomGrid = new System.Windows.Forms.PictureBox();
            this.TeleporteryBox = new System.Windows.Forms.TextBox();
            this.TeleporterxBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TeleporterDestList = new System.Windows.Forms.ListBox();
            this.teleporterToMapCheck = new System.Windows.Forms.CheckBox();
            this.typeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bossUpDown)).BeginInit();
            this.entityOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphicsUpDown)).BeginInit();
            this.teleportOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(84, 335);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // typeBox
            // 
            this.typeBox.Controls.Add(this.teleportRadio);
            this.typeBox.Controls.Add(this.entityRadio);
            this.typeBox.Controls.Add(this.bossUpDown);
            this.typeBox.Controls.Add(this.bossRadio);
            this.typeBox.Controls.Add(this.shooterRadio);
            this.typeBox.Controls.Add(this.enemyList);
            this.typeBox.Controls.Add(this.enemyRadio);
            this.typeBox.Controls.Add(this.goldkeyRadio);
            this.typeBox.Controls.Add(this.heartRadio);
            this.typeBox.Controls.Add(this.keyRadio);
            this.typeBox.Location = new System.Drawing.Point(165, 65);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(188, 268);
            this.typeBox.TabIndex = 15;
            this.typeBox.TabStop = false;
            this.typeBox.Text = "Object Type";
            // 
            // teleportRadio
            // 
            this.teleportRadio.AutoSize = true;
            this.teleportRadio.Location = new System.Drawing.Point(91, 99);
            this.teleportRadio.Name = "teleportRadio";
            this.teleportRadio.Size = new System.Drawing.Size(95, 21);
            this.teleportRadio.TabIndex = 9;
            this.teleportRadio.Text = "Teleporter";
            this.teleportRadio.UseVisualStyleBackColor = true;
            this.teleportRadio.CheckedChanged += new System.EventHandler(this.teleportRadio_CheckedChanged);
            // 
            // entityRadio
            // 
            this.entityRadio.AutoSize = true;
            this.entityRadio.Location = new System.Drawing.Point(90, 72);
            this.entityRadio.Name = "entityRadio";
            this.entityRadio.Size = new System.Drawing.Size(64, 21);
            this.entityRadio.TabIndex = 8;
            this.entityRadio.Text = "Entity";
            this.entityRadio.UseVisualStyleBackColor = true;
            this.entityRadio.CheckedChanged += new System.EventHandler(this.entityRadio_CheckedChanged);
            // 
            // bossUpDown
            // 
            this.bossUpDown.Enabled = false;
            this.bossUpDown.Location = new System.Drawing.Point(27, 98);
            this.bossUpDown.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.bossUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bossUpDown.Name = "bossUpDown";
            this.bossUpDown.Size = new System.Drawing.Size(56, 22);
            this.bossUpDown.TabIndex = 7;
            this.bossUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bossRadio
            // 
            this.bossRadio.AutoSize = true;
            this.bossRadio.Location = new System.Drawing.Point(3, 72);
            this.bossRadio.Name = "bossRadio";
            this.bossRadio.Size = new System.Drawing.Size(60, 21);
            this.bossRadio.TabIndex = 6;
            this.bossRadio.Text = "Boss";
            this.bossRadio.UseVisualStyleBackColor = true;
            this.bossRadio.CheckedChanged += new System.EventHandler(this.bossRadio_CheckedChanged);
            // 
            // shooterRadio
            // 
            this.shooterRadio.AutoSize = true;
            this.shooterRadio.Location = new System.Drawing.Point(90, 45);
            this.shooterRadio.Name = "shooterRadio";
            this.shooterRadio.Size = new System.Drawing.Size(79, 21);
            this.shooterRadio.TabIndex = 5;
            this.shooterRadio.Text = "Shooter";
            this.shooterRadio.UseVisualStyleBackColor = true;
            // 
            // enemyList
            // 
            this.enemyList.Enabled = false;
            this.enemyList.FormattingEnabled = true;
            this.enemyList.ItemHeight = 16;
            this.enemyList.Location = new System.Drawing.Point(27, 153);
            this.enemyList.Name = "enemyList";
            this.enemyList.Size = new System.Drawing.Size(155, 100);
            this.enemyList.TabIndex = 4;
            // 
            // enemyRadio
            // 
            this.enemyRadio.AutoSize = true;
            this.enemyRadio.Location = new System.Drawing.Point(3, 126);
            this.enemyRadio.Name = "enemyRadio";
            this.enemyRadio.Size = new System.Drawing.Size(72, 21);
            this.enemyRadio.TabIndex = 3;
            this.enemyRadio.Text = "Enemy";
            this.enemyRadio.UseVisualStyleBackColor = true;
            this.enemyRadio.CheckedChanged += new System.EventHandler(this.enemyRadio_CheckedChanged);
            // 
            // goldkeyRadio
            // 
            this.goldkeyRadio.AutoSize = true;
            this.goldkeyRadio.Location = new System.Drawing.Point(90, 18);
            this.goldkeyRadio.Name = "goldkeyRadio";
            this.goldkeyRadio.Size = new System.Drawing.Size(87, 21);
            this.goldkeyRadio.TabIndex = 2;
            this.goldkeyRadio.Text = "Gold Key";
            this.goldkeyRadio.UseVisualStyleBackColor = true;
            // 
            // heartRadio
            // 
            this.heartRadio.AutoSize = true;
            this.heartRadio.Location = new System.Drawing.Point(3, 45);
            this.heartRadio.Name = "heartRadio";
            this.heartRadio.Size = new System.Drawing.Size(64, 21);
            this.heartRadio.TabIndex = 1;
            this.heartRadio.Text = "Heart";
            this.heartRadio.UseVisualStyleBackColor = true;
            // 
            // keyRadio
            // 
            this.keyRadio.AutoSize = true;
            this.keyRadio.Checked = true;
            this.keyRadio.Location = new System.Drawing.Point(3, 18);
            this.keyRadio.Name = "keyRadio";
            this.keyRadio.Size = new System.Drawing.Size(53, 21);
            this.keyRadio.TabIndex = 0;
            this.keyRadio.TabStop = true;
            this.keyRadio.Text = "Key";
            this.keyRadio.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(278, 335);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 14;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // yBox
            // 
            this.yBox.Location = new System.Drawing.Point(192, 37);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(100, 22);
            this.yBox.TabIndex = 12;
            this.yBox.Text = "0";
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(192, 9);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(100, 22);
            this.xBox.TabIndex = 11;
            this.xBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "X:";
            // 
            // objectListBox
            // 
            this.objectListBox.FormattingEnabled = true;
            this.objectListBox.ItemHeight = 16;
            this.objectListBox.Location = new System.Drawing.Point(3, 9);
            this.objectListBox.Name = "objectListBox";
            this.objectListBox.Size = new System.Drawing.Size(156, 324);
            this.objectListBox.TabIndex = 18;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(3, 335);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 19;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(165, 335);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 20;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // entityOptions
            // 
            this.entityOptions.Controls.Add(this.codeButton);
            this.entityOptions.Controls.Add(this.entityGfxList);
            this.entityOptions.Controls.Add(this.label4);
            this.entityOptions.Controls.Add(this.graphicsUpDown);
            this.entityOptions.Controls.Add(this.nameBox);
            this.entityOptions.Controls.Add(this.label3);
            this.entityOptions.Enabled = false;
            this.entityOptions.Location = new System.Drawing.Point(359, 65);
            this.entityOptions.Name = "entityOptions";
            this.entityOptions.Size = new System.Drawing.Size(177, 268);
            this.entityOptions.TabIndex = 21;
            this.entityOptions.TabStop = false;
            this.entityOptions.Text = "Entity Options";
            // 
            // codeButton
            // 
            this.codeButton.Location = new System.Drawing.Point(14, 163);
            this.codeButton.Name = "codeButton";
            this.codeButton.Size = new System.Drawing.Size(103, 26);
            this.codeButton.TabIndex = 22;
            this.codeButton.Text = "Edit Code";
            this.codeButton.UseVisualStyleBackColor = true;
            this.codeButton.Click += new System.EventHandler(this.codeButton_Click);
            // 
            // entityGfxList
            // 
            this.entityGfxList.FormattingEnabled = true;
            this.entityGfxList.ItemHeight = 16;
            this.entityGfxList.Location = new System.Drawing.Point(14, 73);
            this.entityGfxList.Name = "entityGfxList";
            this.entityGfxList.Size = new System.Drawing.Size(152, 84);
            this.entityGfxList.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Graphics:";
            // 
            // graphicsUpDown
            // 
            this.graphicsUpDown.Location = new System.Drawing.Point(86, 45);
            this.graphicsUpDown.Name = "graphicsUpDown";
            this.graphicsUpDown.Size = new System.Drawing.Size(80, 22);
            this.graphicsUpDown.TabIndex = 9;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(66, 18);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 22);
            this.nameBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name:";
            // 
            // teleportOptions
            // 
            this.teleportOptions.Controls.Add(this.roomGrid);
            this.teleportOptions.Controls.Add(this.TeleporteryBox);
            this.teleportOptions.Controls.Add(this.TeleporterxBox);
            this.teleportOptions.Controls.Add(this.label5);
            this.teleportOptions.Controls.Add(this.label6);
            this.teleportOptions.Controls.Add(this.TeleporterDestList);
            this.teleportOptions.Controls.Add(this.teleporterToMapCheck);
            this.teleportOptions.Location = new System.Drawing.Point(553, 65);
            this.teleportOptions.Name = "teleportOptions";
            this.teleportOptions.Size = new System.Drawing.Size(350, 268);
            this.teleportOptions.TabIndex = 22;
            this.teleportOptions.TabStop = false;
            this.teleportOptions.Text = "Teleporter Options";
            // 
            // roomGrid
            // 
            this.roomGrid.Location = new System.Drawing.Point(173, 18);
            this.roomGrid.Name = "roomGrid";
            this.roomGrid.Size = new System.Drawing.Size(128, 128);
            this.roomGrid.TabIndex = 20;
            this.roomGrid.TabStop = false;
            this.roomGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.roomGrid_MouseClick);
            // 
            // TeleporteryBox
            // 
            this.TeleporteryBox.Location = new System.Drawing.Point(38, 237);
            this.TeleporteryBox.Name = "TeleporteryBox";
            this.TeleporteryBox.Size = new System.Drawing.Size(100, 22);
            this.TeleporteryBox.TabIndex = 19;
            this.TeleporteryBox.Text = "0";
            // 
            // TeleporterxBox
            // 
            this.TeleporterxBox.Location = new System.Drawing.Point(38, 208);
            this.TeleporterxBox.Name = "TeleporterxBox";
            this.TeleporterxBox.Size = new System.Drawing.Size(100, 22);
            this.TeleporterxBox.TabIndex = 18;
            this.TeleporterxBox.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "X:";
            // 
            // TeleporterDestList
            // 
            this.TeleporterDestList.Enabled = false;
            this.TeleporterDestList.FormattingEnabled = true;
            this.TeleporterDestList.ItemHeight = 16;
            this.TeleporterDestList.Location = new System.Drawing.Point(8, 21);
            this.TeleporterDestList.Name = "TeleporterDestList";
            this.TeleporterDestList.Size = new System.Drawing.Size(159, 148);
            this.TeleporterDestList.TabIndex = 15;
            this.TeleporterDestList.SelectedIndexChanged += new System.EventHandler(this.TeleporterDestList_SelectedIndexChanged);
            // 
            // teleporterToMapCheck
            // 
            this.teleporterToMapCheck.AutoSize = true;
            this.teleporterToMapCheck.Checked = true;
            this.teleporterToMapCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.teleporterToMapCheck.Location = new System.Drawing.Point(13, 181);
            this.teleporterToMapCheck.Name = "teleporterToMapCheck";
            this.teleporterToMapCheck.Size = new System.Drawing.Size(116, 21);
            this.teleporterToMapCheck.TabIndex = 14;
            this.teleporterToMapCheck.Text = "Leads to map";
            this.teleporterToMapCheck.UseVisualStyleBackColor = true;
            this.teleporterToMapCheck.CheckedChanged += new System.EventHandler(this.teleporterToMapCheck_CheckedChanged);
            // 
            // AdventureObjectDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(949, 369);
            this.Controls.Add(this.teleportOptions);
            this.Controls.Add(this.entityOptions);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.objectListBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdventureObjectDialog";
            this.Text = "AdventureObjectDialog";
            this.typeBox.ResumeLayout(false);
            this.typeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bossUpDown)).EndInit();
            this.entityOptions.ResumeLayout(false);
            this.entityOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphicsUpDown)).EndInit();
            this.teleportOptions.ResumeLayout(false);
            this.teleportOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox typeBox;
        private System.Windows.Forms.RadioButton keyRadio;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox yBox;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox objectListBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RadioButton heartRadio;
        private System.Windows.Forms.RadioButton goldkeyRadio;
        private System.Windows.Forms.ListBox enemyList;
        private System.Windows.Forms.RadioButton enemyRadio;
        private System.Windows.Forms.RadioButton shooterRadio;
        private System.Windows.Forms.RadioButton bossRadio;
        private System.Windows.Forms.NumericUpDown bossUpDown;
        private System.Windows.Forms.RadioButton entityRadio;
        private System.Windows.Forms.GroupBox entityOptions;
        private System.Windows.Forms.Button codeButton;
        private System.Windows.Forms.ListBox entityGfxList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown graphicsUpDown;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton teleportRadio;
        private System.Windows.Forms.GroupBox teleportOptions;
        private System.Windows.Forms.PictureBox roomGrid;
        private System.Windows.Forms.TextBox TeleporteryBox;
        private System.Windows.Forms.TextBox TeleporterxBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox TeleporterDestList;
        private System.Windows.Forms.CheckBox teleporterToMapCheck;
    }
}