namespace as2edit
{
    partial class SpecialEditor
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
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.specialBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stageSelectList = new System.Windows.Forms.ListBox();
            this.newButton = new System.Windows.Forms.Button();
            this.currentStageGroup = new System.Windows.Forms.GroupBox();
            this.currentTileBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.heightUpDown = new System.Windows.Forms.NumericUpDown();
            this.tilesPanel = new System.Windows.Forms.Panel();
            this.tilesBox = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.scrollPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.currentStageGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentTileBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).BeginInit();
            this.tilesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tilesBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 636F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Controls.Add(this.scrollPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tilesPanel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(947, 508);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.Controls.Add(this.specialBox);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(250, 3);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(630, 502);
            this.scrollPanel.TabIndex = 1;
            // 
            // specialBox
            // 
            this.specialBox.Location = new System.Drawing.Point(3, 3);
            this.specialBox.Name = "specialBox";
            this.specialBox.Size = new System.Drawing.Size(100, 50);
            this.specialBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.specialBox.TabIndex = 0;
            this.specialBox.TabStop = false;
            this.specialBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.specialBox_MouseMove);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.currentStageGroup, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(241, 502);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.stageSelectList);
            this.groupBox1.Controls.Add(this.newButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 161);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Special Stages:";
            // 
            // stageSelectList
            // 
            this.stageSelectList.FormattingEnabled = true;
            this.stageSelectList.ItemHeight = 16;
            this.stageSelectList.Location = new System.Drawing.Point(6, 21);
            this.stageSelectList.Name = "stageSelectList";
            this.stageSelectList.Size = new System.Drawing.Size(152, 132);
            this.stageSelectList.TabIndex = 0;
            this.stageSelectList.SelectedIndexChanged += new System.EventHandler(this.stageSelectList_SelectedIndexChanged);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(164, 21);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(69, 23);
            this.newButton.TabIndex = 2;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // currentStageGroup
            // 
            this.currentStageGroup.Controls.Add(this.currentTileBox);
            this.currentStageGroup.Controls.Add(this.label2);
            this.currentStageGroup.Controls.Add(this.label1);
            this.currentStageGroup.Controls.Add(this.heightUpDown);
            this.currentStageGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentStageGroup.Location = new System.Drawing.Point(3, 170);
            this.currentStageGroup.Name = "currentStageGroup";
            this.currentStageGroup.Size = new System.Drawing.Size(235, 161);
            this.currentStageGroup.TabIndex = 5;
            this.currentStageGroup.TabStop = false;
            this.currentStageGroup.Text = "Current Stage:";
            // 
            // currentTileBox
            // 
            this.currentTileBox.Location = new System.Drawing.Point(183, 123);
            this.currentTileBox.Name = "currentTileBox";
            this.currentTileBox.Size = new System.Drawing.Size(32, 32);
            this.currentTileBox.TabIndex = 7;
            this.currentTileBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Width:   19";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Height:";
            // 
            // heightUpDown
            // 
            this.heightUpDown.Location = new System.Drawing.Point(66, 23);
            this.heightUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.heightUpDown.Name = "heightUpDown";
            this.heightUpDown.Size = new System.Drawing.Size(57, 22);
            this.heightUpDown.TabIndex = 4;
            this.heightUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.heightUpDown.ValueChanged += new System.EventHandler(this.heightUpDown_ValueChanged);
            // 
            // tilesPanel
            // 
            this.tilesPanel.AutoScroll = true;
            this.tilesPanel.Controls.Add(this.tilesBox);
            this.tilesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tilesPanel.Location = new System.Drawing.Point(886, 3);
            this.tilesPanel.Name = "tilesPanel";
            this.tilesPanel.Size = new System.Drawing.Size(58, 502);
            this.tilesPanel.TabIndex = 4;
            // 
            // tilesBox
            // 
            this.tilesBox.Location = new System.Drawing.Point(0, 0);
            this.tilesBox.Name = "tilesBox";
            this.tilesBox.Size = new System.Drawing.Size(29, 50);
            this.tilesBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tilesBox.TabIndex = 0;
            this.tilesBox.TabStop = false;
            this.tilesBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tilesBox_MouseMove);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(164, 50);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(69, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // SpecialEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(947, 508);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SpecialEditor";
            this.Text = "SpecialEditor";
            this.Load += new System.EventHandler(this.SpecialEditor_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.scrollPanel.ResumeLayout(false);
            this.scrollPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.currentStageGroup.ResumeLayout(false);
            this.currentStageGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentTileBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).EndInit();
            this.tilesPanel.ResumeLayout(false);
            this.tilesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tilesBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel scrollPanel;
        private System.Windows.Forms.PictureBox specialBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox stageSelectList;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.GroupBox currentStageGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown heightUpDown;
        private System.Windows.Forms.Panel tilesPanel;
        private System.Windows.Forms.PictureBox tilesBox;
        private System.Windows.Forms.PictureBox currentTileBox;
        private System.Windows.Forms.Button saveButton;
    }
}