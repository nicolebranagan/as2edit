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
            this.saveButton = new System.Windows.Forms.Button();
            this.stageSelectList = new System.Windows.Forms.ListBox();
            this.newButton = new System.Windows.Forms.Button();
            this.currentStageGroup = new System.Windows.Forms.GroupBox();
            this.currentTileBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.heightUpDown = new System.Windows.Forms.NumericUpDown();
            this.stageObjectsBox = new System.Windows.Forms.GroupBox();
            this.showCheck = new System.Windows.Forms.CheckBox();
            this.enemyOptionsGroup = new System.Windows.Forms.GroupBox();
            this.saveEnemyButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.amplitudeUpDown = new System.Windows.Forms.NumericUpDown();
            this.speedUpDown = new System.Windows.Forms.NumericUpDown();
            this.timeUpDown = new System.Windows.Forms.NumericUpDown();
            this.behaviorUpDown = new System.Windows.Forms.NumericUpDown();
            this.shootingRateUpDown = new System.Windows.Forms.NumericUpDown();
            this.rowUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yUpDown = new System.Windows.Forms.NumericUpDown();
            this.xUpDown = new System.Windows.Forms.NumericUpDown();
            this.deleteObjectButton = new System.Windows.Forms.Button();
            this.objectListBox = new System.Windows.Forms.ListBox();
            this.newObjectButton = new System.Windows.Forms.Button();
            this.tilesPanel = new System.Windows.Forms.Panel();
            this.tilesBox = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.scrollPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.currentStageGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentTileBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).BeginInit();
            this.stageObjectsBox.SuspendLayout();
            this.enemyOptionsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shootingRateUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xUpDown)).BeginInit();
            this.tilesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tilesBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(947, 531);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.Controls.Add(this.specialBox);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(250, 3);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(630, 500);
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
            this.tableLayoutPanel2.Controls.Add(this.stageObjectsBox, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(241, 500);
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
            this.groupBox1.Size = new System.Drawing.Size(235, 159);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Special Stages:";
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
            this.currentStageGroup.Enabled = false;
            this.currentStageGroup.Location = new System.Drawing.Point(3, 168);
            this.currentStageGroup.Name = "currentStageGroup";
            this.currentStageGroup.Size = new System.Drawing.Size(235, 69);
            this.currentStageGroup.TabIndex = 5;
            this.currentStageGroup.TabStop = false;
            this.currentStageGroup.Text = "Current Stage:";
            // 
            // currentTileBox
            // 
            this.currentTileBox.Location = new System.Drawing.Point(197, 13);
            this.currentTileBox.Name = "currentTileBox";
            this.currentTileBox.Size = new System.Drawing.Size(32, 32);
            this.currentTileBox.TabIndex = 7;
            this.currentTileBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Width:    19";
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
            // stageObjectsBox
            // 
            this.stageObjectsBox.Controls.Add(this.showCheck);
            this.stageObjectsBox.Controls.Add(this.enemyOptionsGroup);
            this.stageObjectsBox.Controls.Add(this.deleteObjectButton);
            this.stageObjectsBox.Controls.Add(this.objectListBox);
            this.stageObjectsBox.Controls.Add(this.newObjectButton);
            this.stageObjectsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stageObjectsBox.Location = new System.Drawing.Point(3, 243);
            this.stageObjectsBox.Name = "stageObjectsBox";
            this.stageObjectsBox.Size = new System.Drawing.Size(235, 254);
            this.stageObjectsBox.TabIndex = 6;
            this.stageObjectsBox.TabStop = false;
            this.stageObjectsBox.Text = "Stage Objects";
            // 
            // showCheck
            // 
            this.showCheck.AutoSize = true;
            this.showCheck.Enabled = false;
            this.showCheck.Location = new System.Drawing.Point(164, 79);
            this.showCheck.Name = "showCheck";
            this.showCheck.Size = new System.Drawing.Size(64, 21);
            this.showCheck.TabIndex = 8;
            this.showCheck.Text = "Show";
            this.showCheck.UseVisualStyleBackColor = true;
            // 
            // enemyOptionsGroup
            // 
            this.enemyOptionsGroup.Controls.Add(this.saveEnemyButton);
            this.enemyOptionsGroup.Controls.Add(this.label10);
            this.enemyOptionsGroup.Controls.Add(this.label9);
            this.enemyOptionsGroup.Controls.Add(this.label8);
            this.enemyOptionsGroup.Controls.Add(this.label7);
            this.enemyOptionsGroup.Controls.Add(this.label6);
            this.enemyOptionsGroup.Controls.Add(this.label5);
            this.enemyOptionsGroup.Controls.Add(this.amplitudeUpDown);
            this.enemyOptionsGroup.Controls.Add(this.speedUpDown);
            this.enemyOptionsGroup.Controls.Add(this.timeUpDown);
            this.enemyOptionsGroup.Controls.Add(this.behaviorUpDown);
            this.enemyOptionsGroup.Controls.Add(this.shootingRateUpDown);
            this.enemyOptionsGroup.Controls.Add(this.rowUpDown);
            this.enemyOptionsGroup.Controls.Add(this.label4);
            this.enemyOptionsGroup.Controls.Add(this.label3);
            this.enemyOptionsGroup.Controls.Add(this.yUpDown);
            this.enemyOptionsGroup.Controls.Add(this.xUpDown);
            this.enemyOptionsGroup.Enabled = false;
            this.enemyOptionsGroup.Location = new System.Drawing.Point(5, 97);
            this.enemyOptionsGroup.Name = "enemyOptionsGroup";
            this.enemyOptionsGroup.Size = new System.Drawing.Size(230, 155);
            this.enemyOptionsGroup.TabIndex = 7;
            this.enemyOptionsGroup.TabStop = false;
            this.enemyOptionsGroup.Text = "Enemy Options";
            // 
            // saveEnemyButton
            // 
            this.saveEnemyButton.Location = new System.Drawing.Point(155, 129);
            this.saveEnemyButton.Name = "saveEnemyButton";
            this.saveEnemyButton.Size = new System.Drawing.Size(69, 23);
            this.saveEnemyButton.TabIndex = 9;
            this.saveEnemyButton.Text = "Save";
            this.saveEnemyButton.UseVisualStyleBackColor = true;
            this.saveEnemyButton.Click += new System.EventHandler(this.saveEnemyButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(120, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Amp:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Spd:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Behav.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Row:";
            // 
            // amplitudeUpDown
            // 
            this.amplitudeUpDown.Location = new System.Drawing.Point(162, 73);
            this.amplitudeUpDown.Maximum = new decimal(new int[] {
            608,
            0,
            0,
            0});
            this.amplitudeUpDown.Name = "amplitudeUpDown";
            this.amplitudeUpDown.Size = new System.Drawing.Size(57, 22);
            this.amplitudeUpDown.TabIndex = 16;
            // 
            // speedUpDown
            // 
            this.speedUpDown.Location = new System.Drawing.Point(162, 45);
            this.speedUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.speedUpDown.Name = "speedUpDown";
            this.speedUpDown.Size = new System.Drawing.Size(57, 22);
            this.speedUpDown.TabIndex = 15;
            // 
            // timeUpDown
            // 
            this.timeUpDown.Location = new System.Drawing.Point(162, 101);
            this.timeUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.timeUpDown.Name = "timeUpDown";
            this.timeUpDown.Size = new System.Drawing.Size(57, 22);
            this.timeUpDown.TabIndex = 14;
            // 
            // behaviorUpDown
            // 
            this.behaviorUpDown.Location = new System.Drawing.Point(61, 101);
            this.behaviorUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.behaviorUpDown.Name = "behaviorUpDown";
            this.behaviorUpDown.Size = new System.Drawing.Size(57, 22);
            this.behaviorUpDown.TabIndex = 13;
            // 
            // shootingRateUpDown
            // 
            this.shootingRateUpDown.Location = new System.Drawing.Point(61, 73);
            this.shootingRateUpDown.Name = "shootingRateUpDown";
            this.shootingRateUpDown.Size = new System.Drawing.Size(57, 22);
            this.shootingRateUpDown.TabIndex = 12;
            // 
            // rowUpDown
            // 
            this.rowUpDown.Location = new System.Drawing.Point(61, 45);
            this.rowUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rowUpDown.Name = "rowUpDown";
            this.rowUpDown.Size = new System.Drawing.Size(57, 22);
            this.rowUpDown.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "X:";
            // 
            // yUpDown
            // 
            this.yUpDown.Location = new System.Drawing.Point(123, 20);
            this.yUpDown.Maximum = new decimal(new int[] {
            6400,
            0,
            0,
            0});
            this.yUpDown.Name = "yUpDown";
            this.yUpDown.Size = new System.Drawing.Size(57, 22);
            this.yUpDown.TabIndex = 9;
            // 
            // xUpDown
            // 
            this.xUpDown.Location = new System.Drawing.Point(33, 20);
            this.xUpDown.Maximum = new decimal(new int[] {
            608,
            0,
            0,
            0});
            this.xUpDown.Name = "xUpDown";
            this.xUpDown.Size = new System.Drawing.Size(57, 22);
            this.xUpDown.TabIndex = 8;
            // 
            // deleteObjectButton
            // 
            this.deleteObjectButton.Location = new System.Drawing.Point(166, 50);
            this.deleteObjectButton.Name = "deleteObjectButton";
            this.deleteObjectButton.Size = new System.Drawing.Size(69, 23);
            this.deleteObjectButton.TabIndex = 6;
            this.deleteObjectButton.Text = "Delete";
            this.deleteObjectButton.UseVisualStyleBackColor = true;
            this.deleteObjectButton.Click += new System.EventHandler(this.deleteObjectButton_Click);
            // 
            // objectListBox
            // 
            this.objectListBox.FormattingEnabled = true;
            this.objectListBox.ItemHeight = 16;
            this.objectListBox.Location = new System.Drawing.Point(6, 21);
            this.objectListBox.Name = "objectListBox";
            this.objectListBox.Size = new System.Drawing.Size(152, 68);
            this.objectListBox.TabIndex = 4;
            this.objectListBox.SelectedIndexChanged += new System.EventHandler(this.objectListBox_SelectedIndexChanged);
            // 
            // newObjectButton
            // 
            this.newObjectButton.Location = new System.Drawing.Point(164, 21);
            this.newObjectButton.Name = "newObjectButton";
            this.newObjectButton.Size = new System.Drawing.Size(69, 23);
            this.newObjectButton.TabIndex = 5;
            this.newObjectButton.Text = "New";
            this.newObjectButton.UseVisualStyleBackColor = true;
            this.newObjectButton.Click += new System.EventHandler(this.newObjectButton_Click);
            // 
            // tilesPanel
            // 
            this.tilesPanel.AutoScroll = true;
            this.tilesPanel.Controls.Add(this.tilesBox);
            this.tilesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tilesPanel.Location = new System.Drawing.Point(886, 3);
            this.tilesPanel.Name = "tilesPanel";
            this.tilesPanel.Size = new System.Drawing.Size(58, 500);
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
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 506);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(947, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBarLabel
            // 
            this.statusBarLabel.Name = "statusBarLabel";
            this.statusBarLabel.Size = new System.Drawing.Size(200, 20);
            this.statusBarLabel.Text = "Special Stage Editor Loaded.";
            // 
            // SpecialEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(947, 531);
            this.Controls.Add(this.statusStrip1);
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
            this.stageObjectsBox.ResumeLayout(false);
            this.stageObjectsBox.PerformLayout();
            this.enemyOptionsGroup.ResumeLayout(false);
            this.enemyOptionsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shootingRateUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xUpDown)).EndInit();
            this.tilesPanel.ResumeLayout(false);
            this.tilesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tilesBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox stageObjectsBox;
        private System.Windows.Forms.GroupBox enemyOptionsGroup;
        private System.Windows.Forms.Button deleteObjectButton;
        private System.Windows.Forms.ListBox objectListBox;
        private System.Windows.Forms.Button newObjectButton;
        private System.Windows.Forms.CheckBox showCheck;
        private System.Windows.Forms.Button saveEnemyButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown amplitudeUpDown;
        private System.Windows.Forms.NumericUpDown speedUpDown;
        private System.Windows.Forms.NumericUpDown timeUpDown;
        private System.Windows.Forms.NumericUpDown behaviorUpDown;
        private System.Windows.Forms.NumericUpDown shootingRateUpDown;
        private System.Windows.Forms.NumericUpDown rowUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown yUpDown;
        private System.Windows.Forms.NumericUpDown xUpDown;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
    }
}