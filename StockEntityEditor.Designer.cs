namespace as2edit
{
    partial class StockEntityEditor
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
            this.entityList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.graphicsLabel = new System.Windows.Forms.Label();
            this.codeButton = new System.Windows.Forms.Button();
            this.entityGfxList = new System.Windows.Forms.ListBox();
            this.newButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.graphicsUpDown = new System.Windows.Forms.NumericUpDown();
            this.editButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphicsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.entityList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 452F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(369, 313);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // entityList
            // 
            this.entityList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entityList.FormattingEnabled = true;
            this.entityList.ItemHeight = 16;
            this.entityList.Location = new System.Drawing.Point(3, 3);
            this.entityList.Name = "entityList";
            this.entityList.Size = new System.Drawing.Size(169, 307);
            this.entityList.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.graphicsLabel);
            this.panel1.Controls.Add(this.codeButton);
            this.panel1.Controls.Add(this.entityGfxList);
            this.panel1.Controls.Add(this.newButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.graphicsUpDown);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(178, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 307);
            this.panel1.TabIndex = 1;
            // 
            // graphicsLabel
            // 
            this.graphicsLabel.AutoSize = true;
            this.graphicsLabel.Location = new System.Drawing.Point(12, 192);
            this.graphicsLabel.Name = "graphicsLabel";
            this.graphicsLabel.Size = new System.Drawing.Size(35, 17);
            this.graphicsLabel.TabIndex = 28;
            this.graphicsLabel.Text = "Tile:";
            // 
            // codeButton
            // 
            this.codeButton.Location = new System.Drawing.Point(15, 222);
            this.codeButton.Name = "codeButton";
            this.codeButton.Size = new System.Drawing.Size(103, 26);
            this.codeButton.TabIndex = 26;
            this.codeButton.Text = "Edit Code";
            this.codeButton.UseVisualStyleBackColor = true;
            this.codeButton.Click += new System.EventHandler(this.codeButton_Click);
            // 
            // entityGfxList
            // 
            this.entityGfxList.FormattingEnabled = true;
            this.entityGfxList.ItemHeight = 16;
            this.entityGfxList.Location = new System.Drawing.Point(15, 97);
            this.entityGfxList.Name = "entityGfxList";
            this.entityGfxList.Size = new System.Drawing.Size(163, 84);
            this.entityGfxList.TabIndex = 27;
            this.entityGfxList.SelectedIndexChanged += new System.EventHandler(this.entityGfxList_SelectedIndexChanged);
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
            this.closeButton.Location = new System.Drawing.Point(84, 278);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
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
            this.graphicsUpDown.Location = new System.Drawing.Point(118, 187);
            this.graphicsUpDown.Maximum = new decimal(new int[] {
            255,
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
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Graphics:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(3, 278);
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
            // StockEntityEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 313);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StockEntityEditor";
            this.Text = "StockEntityEditor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphicsUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox entityList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.NumericUpDown graphicsUpDown;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label graphicsLabel;
        private System.Windows.Forms.Button codeButton;
        private System.Windows.Forms.ListBox entityGfxList;
    }
}