namespace as2edit
{
    partial class BestiaryEditor
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
            this.enemyList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.healthUpDown = new System.Windows.Forms.NumericUpDown();
            this.newButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.intelligentUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.decisiveUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.speedUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.intelligentRadio = new System.Windows.Forms.RadioButton();
            this.randomRadio = new System.Windows.Forms.RadioButton();
            this.stationaryRadio = new System.Windows.Forms.RadioButton();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.graphicsUpDown = new System.Windows.Forms.NumericUpDown();
            this.editButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.xOffsetUpDown = new System.Windows.Forms.NumericUpDown();
            this.yOffsetUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelligentUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decisiveUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphicsUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xOffsetUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yOffsetUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.enemyList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 452F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(422, 452);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // enemyList
            // 
            this.enemyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enemyList.FormattingEnabled = true;
            this.enemyList.ItemHeight = 16;
            this.enemyList.Location = new System.Drawing.Point(3, 3);
            this.enemyList.Name = "enemyList";
            this.enemyList.Size = new System.Drawing.Size(169, 446);
            this.enemyList.TabIndex = 0;
            this.enemyList.SelectedIndexChanged += new System.EventHandler(this.enemyList_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.healthUpDown);
            this.panel1.Controls.Add(this.newButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.intelligentUpDown);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.decisiveUpDown);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.speedUpDown);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.graphicsUpDown);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(178, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 446);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Health:";
            // 
            // healthUpDown
            // 
            this.healthUpDown.Location = new System.Drawing.Point(118, 236);
            this.healthUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.healthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.healthUpDown.Name = "healthUpDown";
            this.healthUpDown.Size = new System.Drawing.Size(60, 22);
            this.healthUpDown.TabIndex = 14;
            this.healthUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(84, 3);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 13;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(157, 414);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Intelligence:";
            // 
            // intelligentUpDown
            // 
            this.intelligentUpDown.Enabled = false;
            this.intelligentUpDown.Location = new System.Drawing.Point(118, 383);
            this.intelligentUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.intelligentUpDown.Name = "intelligentUpDown";
            this.intelligentUpDown.Size = new System.Drawing.Size(60, 22);
            this.intelligentUpDown.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Decisiveness:";
            // 
            // decisiveUpDown
            // 
            this.decisiveUpDown.Location = new System.Drawing.Point(118, 203);
            this.decisiveUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.decisiveUpDown.Name = "decisiveUpDown";
            this.decisiveUpDown.Size = new System.Drawing.Size(60, 22);
            this.decisiveUpDown.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Speed:";
            // 
            // speedUpDown
            // 
            this.speedUpDown.Location = new System.Drawing.Point(118, 169);
            this.speedUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.speedUpDown.Name = "speedUpDown";
            this.speedUpDown.Size = new System.Drawing.Size(60, 22);
            this.speedUpDown.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.intelligentRadio);
            this.groupBox1.Controls.Add(this.randomRadio);
            this.groupBox1.Controls.Add(this.stationaryRadio);
            this.groupBox1.Location = new System.Drawing.Point(15, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 106);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movement Type";
            // 
            // intelligentRadio
            // 
            this.intelligentRadio.AutoSize = true;
            this.intelligentRadio.Location = new System.Drawing.Point(6, 75);
            this.intelligentRadio.Name = "intelligentRadio";
            this.intelligentRadio.Size = new System.Drawing.Size(89, 21);
            this.intelligentRadio.TabIndex = 2;
            this.intelligentRadio.Text = "Intelligent";
            this.intelligentRadio.UseVisualStyleBackColor = true;
            this.intelligentRadio.CheckedChanged += new System.EventHandler(this.intelligentRadio_CheckedChanged);
            // 
            // randomRadio
            // 
            this.randomRadio.AutoSize = true;
            this.randomRadio.Location = new System.Drawing.Point(6, 48);
            this.randomRadio.Name = "randomRadio";
            this.randomRadio.Size = new System.Drawing.Size(125, 21);
            this.randomRadio.TabIndex = 1;
            this.randomRadio.Text = "Move randomly";
            this.randomRadio.UseVisualStyleBackColor = true;
            // 
            // stationaryRadio
            // 
            this.stationaryRadio.AutoSize = true;
            this.stationaryRadio.Checked = true;
            this.stationaryRadio.Location = new System.Drawing.Point(6, 21);
            this.stationaryRadio.Name = "stationaryRadio";
            this.stationaryRadio.Size = new System.Drawing.Size(93, 21);
            this.stationaryRadio.TabIndex = 0;
            this.stationaryRadio.TabStop = true;
            this.stationaryRadio.Text = "Stationary";
            this.stationaryRadio.UseVisualStyleBackColor = true;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(67, 36);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(111, 22);
            this.nameBox.TabIndex = 4;
            // 
            // graphicsUpDown
            // 
            this.graphicsUpDown.Location = new System.Drawing.Point(118, 69);
            this.graphicsUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.graphicsUpDown.Name = "graphicsUpDown";
            this.graphicsUpDown.Size = new System.Drawing.Size(60, 22);
            this.graphicsUpDown.TabIndex = 3;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(3, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Graphics Row:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(76, 414);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.xOffsetUpDown);
            this.groupBox2.Controls.Add(this.yOffsetUpDown);
            this.groupBox2.Location = new System.Drawing.Point(15, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 66);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Offset";
            // 
            // xOffsetUpDown
            // 
            this.xOffsetUpDown.Location = new System.Drawing.Point(38, 26);
            this.xOffsetUpDown.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.xOffsetUpDown.Name = "xOffsetUpDown";
            this.xOffsetUpDown.Size = new System.Drawing.Size(60, 22);
            this.xOffsetUpDown.TabIndex = 17;
            this.xOffsetUpDown.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // yOffsetUpDown
            // 
            this.yOffsetUpDown.Location = new System.Drawing.Point(130, 26);
            this.yOffsetUpDown.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.yOffsetUpDown.Name = "yOffsetUpDown";
            this.yOffsetUpDown.Size = new System.Drawing.Size(60, 22);
            this.yOffsetUpDown.TabIndex = 18;
            this.yOffsetUpDown.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "X:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Y:";
            // 
            // BestiaryEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 452);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BestiaryEditor";
            this.Text = "Bestiary Editor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelligentUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decisiveUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphicsUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xOffsetUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yOffsetUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox enemyList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.NumericUpDown graphicsUpDown;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown intelligentUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown decisiveUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown speedUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton intelligentRadio;
        private System.Windows.Forms.RadioButton randomRadio;
        private System.Windows.Forms.RadioButton stationaryRadio;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown healthUpDown;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown xOffsetUpDown;
        private System.Windows.Forms.NumericUpDown yOffsetUpDown;
    }
}