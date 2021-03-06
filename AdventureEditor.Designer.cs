﻿namespace as2edit
{
    partial class AdventureEditor
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
            this.advBox = new System.Windows.Forms.PictureBox();
            this.tilesPanel = new System.Windows.Forms.Panel();
            this.tilesBox = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentTileBox = new System.Windows.Forms.PictureBox();
            this.advList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addAdvBox = new System.Windows.Forms.Button();
            this.delRoomBox = new System.Windows.Forms.Button();
            this.delAdvBox = new System.Windows.Forms.Button();
            this.roomGrid = new System.Windows.Forms.PictureBox();
            this.roomOptions = new System.Windows.Forms.GroupBox();
            this.vblockCheck = new System.Windows.Forms.CheckBox();
            this.hblockCheck = new System.Windows.Forms.CheckBox();
            this.roomMusicList = new System.Windows.Forms.ListBox();
            this.showObjectCheck = new System.Windows.Forms.CheckBox();
            this.darkRoomCheck = new System.Windows.Forms.CheckBox();
            this.codeButton = new System.Windows.Forms.Button();
            this.objectButton = new System.Windows.Forms.Button();
            this.templateButton = new System.Windows.Forms.Button();
            this.tileOptions = new System.Windows.Forms.GroupBox();
            this.tileTypeList = new System.Windows.Forms.ListBox();
            this.renameButton = new System.Windows.Forms.Button();
            this.tilesetUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.advMusicList = new System.Windows.Forms.ListBox();
            this.pngButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.advBox)).BeginInit();
            this.tilesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tilesBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentTileBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomGrid)).BeginInit();
            this.roomOptions.SuspendLayout();
            this.tileOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tilesetUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // advBox
            // 
            this.advBox.Location = new System.Drawing.Point(0, 0);
            this.advBox.Name = "advBox";
            this.advBox.Size = new System.Drawing.Size(800, 416);
            this.advBox.TabIndex = 0;
            this.advBox.TabStop = false;
            this.advBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.advBox_MouseMove);
            // 
            // tilesPanel
            // 
            this.tilesPanel.AutoScroll = true;
            this.tilesPanel.Controls.Add(this.tilesBox);
            this.tilesPanel.Location = new System.Drawing.Point(797, 0);
            this.tilesPanel.Name = "tilesPanel";
            this.tilesPanel.Size = new System.Drawing.Size(59, 591);
            this.tilesPanel.TabIndex = 1;
            this.tilesPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tilesPanel_MouseMove);
            // 
            // tilesBox
            // 
            this.tilesBox.Location = new System.Drawing.Point(0, 0);
            this.tilesBox.Name = "tilesBox";
            this.tilesBox.Size = new System.Drawing.Size(47, 50);
            this.tilesBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tilesBox.TabIndex = 0;
            this.tilesBox.TabStop = false;
            this.tilesBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tilesBox_MouseMove);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(856, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBarLabel
            // 
            this.statusBarLabel.Name = "statusBarLabel";
            this.statusBarLabel.Size = new System.Drawing.Size(103, 20);
            this.statusBarLabel.Text = "Select options";
            // 
            // currentTileBox
            // 
            this.currentTileBox.Location = new System.Drawing.Point(6, 21);
            this.currentTileBox.Name = "currentTileBox";
            this.currentTileBox.Size = new System.Drawing.Size(32, 32);
            this.currentTileBox.TabIndex = 3;
            this.currentTileBox.TabStop = false;
            // 
            // advList
            // 
            this.advList.FormattingEnabled = true;
            this.advList.ItemHeight = 16;
            this.advList.Location = new System.Drawing.Point(12, 443);
            this.advList.Name = "advList";
            this.advList.Size = new System.Drawing.Size(142, 132);
            this.advList.TabIndex = 4;
            this.advList.SelectedIndexChanged += new System.EventHandler(this.advList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adventures";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rooms:";
            // 
            // addAdvBox
            // 
            this.addAdvBox.Location = new System.Drawing.Point(161, 419);
            this.addAdvBox.Name = "addAdvBox";
            this.addAdvBox.Size = new System.Drawing.Size(51, 23);
            this.addAdvBox.TabIndex = 8;
            this.addAdvBox.Text = "Add";
            this.addAdvBox.UseVisualStyleBackColor = true;
            this.addAdvBox.Click += new System.EventHandler(this.addAdvBox_Click);
            // 
            // delRoomBox
            // 
            this.delRoomBox.Location = new System.Drawing.Point(361, 419);
            this.delRoomBox.Name = "delRoomBox";
            this.delRoomBox.Size = new System.Drawing.Size(57, 23);
            this.delRoomBox.TabIndex = 10;
            this.delRoomBox.Text = "Delete";
            this.delRoomBox.UseVisualStyleBackColor = true;
            this.delRoomBox.Click += new System.EventHandler(this.delRoomBox_Click);
            // 
            // delAdvBox
            // 
            this.delAdvBox.Location = new System.Drawing.Point(98, 419);
            this.delAdvBox.Name = "delAdvBox";
            this.delAdvBox.Size = new System.Drawing.Size(57, 23);
            this.delAdvBox.TabIndex = 11;
            this.delAdvBox.Text = "Delete";
            this.delAdvBox.UseVisualStyleBackColor = true;
            this.delAdvBox.Click += new System.EventHandler(this.delAdvBox_Click);
            // 
            // roomGrid
            // 
            this.roomGrid.Location = new System.Drawing.Point(290, 443);
            this.roomGrid.Name = "roomGrid";
            this.roomGrid.Size = new System.Drawing.Size(128, 128);
            this.roomGrid.TabIndex = 12;
            this.roomGrid.TabStop = false;
            this.roomGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.roomGrid_MouseClick);
            this.roomGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.roomGrid_MouseMove);
            // 
            // roomOptions
            // 
            this.roomOptions.Controls.Add(this.vblockCheck);
            this.roomOptions.Controls.Add(this.hblockCheck);
            this.roomOptions.Controls.Add(this.roomMusicList);
            this.roomOptions.Controls.Add(this.showObjectCheck);
            this.roomOptions.Controls.Add(this.darkRoomCheck);
            this.roomOptions.Controls.Add(this.codeButton);
            this.roomOptions.Controls.Add(this.objectButton);
            this.roomOptions.Controls.Add(this.templateButton);
            this.roomOptions.Enabled = false;
            this.roomOptions.Location = new System.Drawing.Point(424, 422);
            this.roomOptions.Name = "roomOptions";
            this.roomOptions.Size = new System.Drawing.Size(262, 153);
            this.roomOptions.TabIndex = 13;
            this.roomOptions.TabStop = false;
            this.roomOptions.Text = "Room Options";
            // 
            // vblockCheck
            // 
            this.vblockCheck.AutoSize = true;
            this.vblockCheck.Location = new System.Drawing.Point(143, 48);
            this.vblockCheck.Name = "vblockCheck";
            this.vblockCheck.Size = new System.Drawing.Size(97, 21);
            this.vblockCheck.TabIndex = 17;
            this.vblockCheck.Text = "Vert. block";
            this.vblockCheck.UseVisualStyleBackColor = true;
            this.vblockCheck.CheckedChanged += new System.EventHandler(this.vblockCheck_CheckedChanged);
            // 
            // hblockCheck
            // 
            this.hblockCheck.AutoSize = true;
            this.hblockCheck.Location = new System.Drawing.Point(143, 21);
            this.hblockCheck.Name = "hblockCheck";
            this.hblockCheck.Size = new System.Drawing.Size(101, 21);
            this.hblockCheck.TabIndex = 16;
            this.hblockCheck.Text = "Horz. block";
            this.hblockCheck.UseVisualStyleBackColor = true;
            this.hblockCheck.CheckedChanged += new System.EventHandler(this.hblockCheck_CheckedChanged);
            // 
            // roomMusicList
            // 
            this.roomMusicList.FormattingEnabled = true;
            this.roomMusicList.ItemHeight = 16;
            this.roomMusicList.Location = new System.Drawing.Point(148, 77);
            this.roomMusicList.Name = "roomMusicList";
            this.roomMusicList.Size = new System.Drawing.Size(108, 68);
            this.roomMusicList.TabIndex = 5;
            this.roomMusicList.SelectedIndexChanged += new System.EventHandler(this.roomMusicList_SelectedIndexChanged);
            // 
            // showObjectCheck
            // 
            this.showObjectCheck.AutoSize = true;
            this.showObjectCheck.Location = new System.Drawing.Point(15, 48);
            this.showObjectCheck.Name = "showObjectCheck";
            this.showObjectCheck.Size = new System.Drawing.Size(113, 21);
            this.showObjectCheck.TabIndex = 15;
            this.showObjectCheck.Text = "Show objects";
            this.showObjectCheck.UseVisualStyleBackColor = true;
            this.showObjectCheck.CheckedChanged += new System.EventHandler(this.showObjectCheck_CheckedChanged);
            // 
            // darkRoomCheck
            // 
            this.darkRoomCheck.AutoSize = true;
            this.darkRoomCheck.Location = new System.Drawing.Point(15, 21);
            this.darkRoomCheck.Name = "darkRoomCheck";
            this.darkRoomCheck.Size = new System.Drawing.Size(113, 21);
            this.darkRoomCheck.TabIndex = 14;
            this.darkRoomCheck.Text = "Room is dark";
            this.darkRoomCheck.UseVisualStyleBackColor = true;
            this.darkRoomCheck.CheckedChanged += new System.EventHandler(this.darkRoomCheck_CheckedChanged);
            // 
            // codeButton
            // 
            this.codeButton.Location = new System.Drawing.Point(15, 97);
            this.codeButton.Name = "codeButton";
            this.codeButton.Size = new System.Drawing.Size(75, 23);
            this.codeButton.TabIndex = 13;
            this.codeButton.Text = "Code";
            this.codeButton.UseVisualStyleBackColor = true;
            this.codeButton.Click += new System.EventHandler(this.codeButton_Click);
            // 
            // objectButton
            // 
            this.objectButton.Location = new System.Drawing.Point(15, 72);
            this.objectButton.Name = "objectButton";
            this.objectButton.Size = new System.Drawing.Size(107, 23);
            this.objectButton.TabIndex = 12;
            this.objectButton.Text = "Objects...";
            this.objectButton.UseVisualStyleBackColor = true;
            this.objectButton.Click += new System.EventHandler(this.objectButton_Click);
            // 
            // templateButton
            // 
            this.templateButton.Location = new System.Drawing.Point(15, 122);
            this.templateButton.Name = "templateButton";
            this.templateButton.Size = new System.Drawing.Size(125, 23);
            this.templateButton.TabIndex = 11;
            this.templateButton.Text = "Make Template";
            this.templateButton.UseVisualStyleBackColor = true;
            this.templateButton.Click += new System.EventHandler(this.templateButton_Click);
            // 
            // tileOptions
            // 
            this.tileOptions.Controls.Add(this.tileTypeList);
            this.tileOptions.Controls.Add(this.currentTileBox);
            this.tileOptions.Location = new System.Drawing.Point(692, 422);
            this.tileOptions.Name = "tileOptions";
            this.tileOptions.Size = new System.Drawing.Size(99, 151);
            this.tileOptions.TabIndex = 14;
            this.tileOptions.TabStop = false;
            this.tileOptions.Text = "Current Tile";
            // 
            // tileTypeList
            // 
            this.tileTypeList.FormattingEnabled = true;
            this.tileTypeList.ItemHeight = 16;
            this.tileTypeList.Location = new System.Drawing.Point(6, 61);
            this.tileTypeList.Name = "tileTypeList";
            this.tileTypeList.Size = new System.Drawing.Size(80, 84);
            this.tileTypeList.TabIndex = 4;
            this.tileTypeList.SelectedIndexChanged += new System.EventHandler(this.tileTypeList_SelectedIndexChanged);
            // 
            // renameButton
            // 
            this.renameButton.Location = new System.Drawing.Point(213, 419);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(71, 23);
            this.renameButton.TabIndex = 15;
            this.renameButton.Text = "Rename";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // tilesetUpDown
            // 
            this.tilesetUpDown.Enabled = false;
            this.tilesetUpDown.Location = new System.Drawing.Point(213, 445);
            this.tilesetUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.tilesetUpDown.Name = "tilesetUpDown";
            this.tilesetUpDown.Size = new System.Drawing.Size(71, 22);
            this.tilesetUpDown.TabIndex = 16;
            this.tilesetUpDown.ValueChanged += new System.EventHandler(this.tilesetUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tileset:";
            // 
            // advMusicList
            // 
            this.advMusicList.FormattingEnabled = true;
            this.advMusicList.ItemHeight = 16;
            this.advMusicList.Location = new System.Drawing.Point(163, 472);
            this.advMusicList.Name = "advMusicList";
            this.advMusicList.Size = new System.Drawing.Size(121, 68);
            this.advMusicList.TabIndex = 16;
            this.advMusicList.SelectedIndexChanged += new System.EventHandler(this.advMusicList_SelectedIndexChanged);
            // 
            // pngButton
            // 
            this.pngButton.Location = new System.Drawing.Point(163, 552);
            this.pngButton.Name = "pngButton";
            this.pngButton.Size = new System.Drawing.Size(87, 23);
            this.pngButton.TabIndex = 18;
            this.pngButton.Text = "Save .PNG";
            this.pngButton.UseVisualStyleBackColor = true;
            this.pngButton.Click += new System.EventHandler(this.pngButton_Click);
            // 
            // AdventureEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(856, 603);
            this.Controls.Add(this.pngButton);
            this.Controls.Add(this.advMusicList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tilesetUpDown);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.tileOptions);
            this.Controls.Add(this.roomOptions);
            this.Controls.Add(this.delRoomBox);
            this.Controls.Add(this.roomGrid);
            this.Controls.Add(this.delAdvBox);
            this.Controls.Add(this.addAdvBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.advList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tilesPanel);
            this.Controls.Add(this.advBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdventureEditor";
            this.Text = "AdventureEditor";
            ((System.ComponentModel.ISupportInitialize)(this.advBox)).EndInit();
            this.tilesPanel.ResumeLayout(false);
            this.tilesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tilesBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentTileBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomGrid)).EndInit();
            this.roomOptions.ResumeLayout(false);
            this.roomOptions.PerformLayout();
            this.tileOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tilesetUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox advBox;
        private System.Windows.Forms.Panel tilesPanel;
        private System.Windows.Forms.PictureBox tilesBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
        private System.Windows.Forms.PictureBox currentTileBox;
        private System.Windows.Forms.ListBox advList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addAdvBox;
        private System.Windows.Forms.Button delRoomBox;
        private System.Windows.Forms.Button delAdvBox;
        private System.Windows.Forms.PictureBox roomGrid;
        private System.Windows.Forms.GroupBox roomOptions;
        private System.Windows.Forms.Button templateButton;
        private System.Windows.Forms.GroupBox tileOptions;
        private System.Windows.Forms.ListBox tileTypeList;
        private System.Windows.Forms.Button objectButton;
        private System.Windows.Forms.Button codeButton;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.NumericUpDown tilesetUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox darkRoomCheck;
        private System.Windows.Forms.CheckBox showObjectCheck;
        private System.Windows.Forms.ListBox roomMusicList;
        private System.Windows.Forms.ListBox advMusicList;
        private System.Windows.Forms.Button pngButton;
        private System.Windows.Forms.CheckBox vblockCheck;
        private System.Windows.Forms.CheckBox hblockCheck;
    }
}