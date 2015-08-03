namespace as2edit
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
            this.objectButton = new System.Windows.Forms.Button();
            this.templateButton = new System.Windows.Forms.Button();
            this.tileOptions = new System.Windows.Forms.GroupBox();
            this.tileTypeList = new System.Windows.Forms.ListBox();
            this.codeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.advBox)).BeginInit();
            this.tilesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tilesBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentTileBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomGrid)).BeginInit();
            this.roomOptions.SuspendLayout();
            this.tileOptions.SuspendLayout();
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
            this.advList.Location = new System.Drawing.Point(12, 442);
            this.advList.Name = "advList";
            this.advList.Size = new System.Drawing.Size(120, 100);
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
            this.label2.Location = new System.Drawing.Point(135, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rooms:";
            // 
            // addAdvBox
            // 
            this.addAdvBox.Location = new System.Drawing.Point(12, 547);
            this.addAdvBox.Name = "addAdvBox";
            this.addAdvBox.Size = new System.Drawing.Size(57, 23);
            this.addAdvBox.TabIndex = 8;
            this.addAdvBox.Text = "Add";
            this.addAdvBox.UseVisualStyleBackColor = true;
            this.addAdvBox.Click += new System.EventHandler(this.addAdvBox_Click);
            // 
            // delRoomBox
            // 
            this.delRoomBox.Location = new System.Drawing.Point(137, 122);
            this.delRoomBox.Name = "delRoomBox";
            this.delRoomBox.Size = new System.Drawing.Size(57, 23);
            this.delRoomBox.TabIndex = 10;
            this.delRoomBox.Text = "Delete";
            this.delRoomBox.UseVisualStyleBackColor = true;
            this.delRoomBox.Click += new System.EventHandler(this.delRoomBox_Click);
            // 
            // delAdvBox
            // 
            this.delAdvBox.Location = new System.Drawing.Point(75, 547);
            this.delAdvBox.Name = "delAdvBox";
            this.delAdvBox.Size = new System.Drawing.Size(57, 23);
            this.delAdvBox.TabIndex = 11;
            this.delAdvBox.Text = "Delete";
            this.delAdvBox.UseVisualStyleBackColor = true;
            this.delAdvBox.Click += new System.EventHandler(this.delAdvBox_Click);
            // 
            // roomGrid
            // 
            this.roomGrid.Location = new System.Drawing.Point(138, 442);
            this.roomGrid.Name = "roomGrid";
            this.roomGrid.Size = new System.Drawing.Size(128, 128);
            this.roomGrid.TabIndex = 12;
            this.roomGrid.TabStop = false;
            this.roomGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.roomGrid_MouseClick);
            // 
            // roomOptions
            // 
            this.roomOptions.Controls.Add(this.codeButton);
            this.roomOptions.Controls.Add(this.objectButton);
            this.roomOptions.Controls.Add(this.templateButton);
            this.roomOptions.Controls.Add(this.delRoomBox);
            this.roomOptions.Enabled = false;
            this.roomOptions.Location = new System.Drawing.Point(272, 422);
            this.roomOptions.Name = "roomOptions";
            this.roomOptions.Size = new System.Drawing.Size(200, 151);
            this.roomOptions.TabIndex = 13;
            this.roomOptions.TabStop = false;
            this.roomOptions.Text = "Room Options";
            // 
            // objectButton
            // 
            this.objectButton.Location = new System.Drawing.Point(6, 21);
            this.objectButton.Name = "objectButton";
            this.objectButton.Size = new System.Drawing.Size(90, 23);
            this.objectButton.TabIndex = 12;
            this.objectButton.Text = "Objects...";
            this.objectButton.UseVisualStyleBackColor = true;
            this.objectButton.Click += new System.EventHandler(this.objectButton_Click);
            // 
            // templateButton
            // 
            this.templateButton.Location = new System.Drawing.Point(6, 122);
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
            this.tileOptions.Location = new System.Drawing.Point(591, 422);
            this.tileOptions.Name = "tileOptions";
            this.tileOptions.Size = new System.Drawing.Size(200, 151);
            this.tileOptions.TabIndex = 14;
            this.tileOptions.TabStop = false;
            this.tileOptions.Text = "Current Tile";
            // 
            // tileTypeList
            // 
            this.tileTypeList.FormattingEnabled = true;
            this.tileTypeList.ItemHeight = 16;
            this.tileTypeList.Location = new System.Drawing.Point(6, 59);
            this.tileTypeList.Name = "tileTypeList";
            this.tileTypeList.Size = new System.Drawing.Size(120, 84);
            this.tileTypeList.TabIndex = 4;
            this.tileTypeList.SelectedIndexChanged += new System.EventHandler(this.tileTypeList_SelectedIndexChanged);
            // 
            // codeButton
            // 
            this.codeButton.Location = new System.Drawing.Point(6, 50);
            this.codeButton.Name = "codeButton";
            this.codeButton.Size = new System.Drawing.Size(75, 23);
            this.codeButton.TabIndex = 13;
            this.codeButton.Text = "Code";
            this.codeButton.UseVisualStyleBackColor = true;
            this.codeButton.Click += new System.EventHandler(this.codeButton_Click);
            // 
            // AdventureEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 603);
            this.Controls.Add(this.tileOptions);
            this.Controls.Add(this.roomOptions);
            this.Controls.Add(this.roomGrid);
            this.Controls.Add(this.delAdvBox);
            this.Controls.Add(this.addAdvBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.advList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tilesPanel);
            this.Controls.Add(this.advBox);
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
            this.tileOptions.ResumeLayout(false);
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
    }
}