namespace as2edit
{
    partial class MapEditor
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mapPanel = new System.Windows.Forms.Panel();
            this.mapBox = new System.Windows.Forms.PictureBox();
            this.tilesPanel = new System.Windows.Forms.Panel();
            this.tilesBox = new System.Windows.Forms.PictureBox();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.currentTileLabel = new System.Windows.Forms.Label();
            this.currentTileBox = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tileTypeList = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.mapPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).BeginInit();
            this.tilesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tilesBox)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentTileBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.mapPanel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tilesPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.controlPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 610);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mapPanel
            // 
            this.mapPanel.AutoScroll = true;
            this.mapPanel.Controls.Add(this.mapBox);
            this.mapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapPanel.Location = new System.Drawing.Point(272, 3);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(609, 584);
            this.mapPanel.TabIndex = 2;
            this.mapPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mapPanel_Paint);
            // 
            // mapBox
            // 
            this.mapBox.Location = new System.Drawing.Point(0, 0);
            this.mapBox.Name = "mapBox";
            this.mapBox.Size = new System.Drawing.Size(100, 50);
            this.mapBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mapBox.TabIndex = 0;
            this.mapBox.TabStop = false;
            this.mapBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mapBox_MouseMove);
            // 
            // tilesPanel
            // 
            this.tilesPanel.AutoScroll = true;
            this.tilesPanel.Controls.Add(this.tilesBox);
            this.tilesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tilesPanel.Location = new System.Drawing.Point(3, 3);
            this.tilesPanel.Name = "tilesPanel";
            this.tilesPanel.Size = new System.Drawing.Size(58, 584);
            this.tilesPanel.TabIndex = 3;
            // 
            // tilesBox
            // 
            this.tilesBox.Location = new System.Drawing.Point(0, 0);
            this.tilesBox.Name = "tilesBox";
            this.tilesBox.Size = new System.Drawing.Size(26, 50);
            this.tilesBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tilesBox.TabIndex = 0;
            this.tilesBox.TabStop = false;
            this.tilesBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tilesBox_MouseMove);
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.saveButton);
            this.controlPanel.Controls.Add(this.tileTypeList);
            this.controlPanel.Controls.Add(this.currentTileLabel);
            this.controlPanel.Controls.Add(this.currentTileBox);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(67, 3);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(199, 584);
            this.controlPanel.TabIndex = 4;
            // 
            // currentTileLabel
            // 
            this.currentTileLabel.AutoSize = true;
            this.currentTileLabel.Location = new System.Drawing.Point(55, 18);
            this.currentTileLabel.Name = "currentTileLabel";
            this.currentTileLabel.Size = new System.Drawing.Size(99, 17);
            this.currentTileLabel.TabIndex = 1;
            this.currentTileLabel.Text = "None selected";
            // 
            // currentTileBox
            // 
            this.currentTileBox.Location = new System.Drawing.Point(17, 18);
            this.currentTileBox.Name = "currentTileBox";
            this.currentTileBox.Size = new System.Drawing.Size(32, 32);
            this.currentTileBox.TabIndex = 0;
            this.currentTileBox.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 585);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusBar";
            // 
            // statusBarLabel
            // 
            this.statusBarLabel.Name = "statusBarLabel";
            this.statusBarLabel.Size = new System.Drawing.Size(74, 20);
            this.statusBarLabel.Text = "Initialized";
            // 
            // tileTypeList
            // 
            this.tileTypeList.FormattingEnabled = true;
            this.tileTypeList.ItemHeight = 16;
            this.tileTypeList.Location = new System.Drawing.Point(55, 44);
            this.tileTypeList.Name = "tileTypeList";
            this.tileTypeList.Size = new System.Drawing.Size(120, 52);
            this.tileTypeList.TabIndex = 2;
            this.tileTypeList.SelectedIndexChanged += new System.EventHandler(this.tileTypeList_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(17, 545);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // MapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 610);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MapEditor";
            this.Text = "Map Editor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.mapPanel.ResumeLayout(false);
            this.mapPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).EndInit();
            this.tilesPanel.ResumeLayout(false);
            this.tilesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tilesBox)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentTileBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel mapPanel;
        private System.Windows.Forms.PictureBox mapBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
        private System.Windows.Forms.Panel tilesPanel;
        private System.Windows.Forms.PictureBox tilesBox;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Label currentTileLabel;
        private System.Windows.Forms.PictureBox currentTileBox;
        private System.Windows.Forms.ListBox tileTypeList;
        private System.Windows.Forms.Button saveButton;
    }
}