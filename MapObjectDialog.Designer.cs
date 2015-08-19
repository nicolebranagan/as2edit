namespace as2edit
{
    partial class MapObjectDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xBox = new System.Windows.Forms.TextBox();
            this.yBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.typeBox = new System.Windows.Forms.GroupBox();
            this.lockRadio = new System.Windows.Forms.RadioButton();
            this.teleportRadio = new System.Windows.Forms.RadioButton();
            this.teleporterOptions = new System.Windows.Forms.GroupBox();
            this.roomGrid = new System.Windows.Forms.PictureBox();
            this.TeleporteryBox = new System.Windows.Forms.TextBox();
            this.TeleporterxBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TeleporterDestList = new System.Windows.Forms.ListBox();
            this.teleporterToMapCheck = new System.Windows.Forms.CheckBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.lockOptions = new System.Windows.Forms.GroupBox();
            this.lockTileUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.typeBox.SuspendLayout();
            this.teleporterOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomGrid)).BeginInit();
            this.lockOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockTileUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y:";
            // 
            // xBox
            // 
            this.xBox.Location = new System.Drawing.Point(39, 9);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(100, 22);
            this.xBox.TabIndex = 2;
            this.xBox.Text = "0";
            // 
            // yBox
            // 
            this.yBox.Location = new System.Drawing.Point(39, 37);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(100, 22);
            this.yBox.TabIndex = 3;
            this.yBox.Text = "0";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(89, 273);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(8, 273);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // typeBox
            // 
            this.typeBox.Controls.Add(this.lockRadio);
            this.typeBox.Controls.Add(this.teleportRadio);
            this.typeBox.Location = new System.Drawing.Point(12, 65);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(188, 202);
            this.typeBox.TabIndex = 6;
            this.typeBox.TabStop = false;
            this.typeBox.Text = "Object Type";
            // 
            // lockRadio
            // 
            this.lockRadio.AutoSize = true;
            this.lockRadio.Location = new System.Drawing.Point(3, 45);
            this.lockRadio.Name = "lockRadio";
            this.lockRadio.Size = new System.Drawing.Size(86, 21);
            this.lockRadio.TabIndex = 1;
            this.lockRadio.Text = "MapLock";
            this.lockRadio.UseVisualStyleBackColor = true;
            this.lockRadio.CheckedChanged += new System.EventHandler(this.lockRadio_CheckedChanged);
            // 
            // teleportRadio
            // 
            this.teleportRadio.AutoSize = true;
            this.teleportRadio.Checked = true;
            this.teleportRadio.Location = new System.Drawing.Point(3, 18);
            this.teleportRadio.Name = "teleportRadio";
            this.teleportRadio.Size = new System.Drawing.Size(122, 21);
            this.teleportRadio.TabIndex = 0;
            this.teleportRadio.TabStop = true;
            this.teleportRadio.Text = "MapTeleporter";
            this.teleportRadio.UseVisualStyleBackColor = true;
            this.teleportRadio.CheckedChanged += new System.EventHandler(this.teleportRadio_CheckedChanged);
            // 
            // teleporterOptions
            // 
            this.teleporterOptions.Controls.Add(this.roomGrid);
            this.teleporterOptions.Controls.Add(this.TeleporteryBox);
            this.teleporterOptions.Controls.Add(this.TeleporterxBox);
            this.teleporterOptions.Controls.Add(this.label4);
            this.teleporterOptions.Controls.Add(this.label3);
            this.teleporterOptions.Controls.Add(this.TeleporterDestList);
            this.teleporterOptions.Controls.Add(this.teleporterToMapCheck);
            this.teleporterOptions.Location = new System.Drawing.Point(212, 12);
            this.teleporterOptions.Name = "teleporterOptions";
            this.teleporterOptions.Size = new System.Drawing.Size(315, 183);
            this.teleporterOptions.TabIndex = 7;
            this.teleporterOptions.TabStop = false;
            this.teleporterOptions.Text = "MapTeleporter";
            // 
            // roomGrid
            // 
            this.roomGrid.Location = new System.Drawing.Point(171, 24);
            this.roomGrid.Name = "roomGrid";
            this.roomGrid.Size = new System.Drawing.Size(128, 128);
            this.roomGrid.TabIndex = 13;
            this.roomGrid.TabStop = false;
            this.roomGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.roomGrid_MouseClick);
            // 
            // TeleporteryBox
            // 
            this.TeleporteryBox.Location = new System.Drawing.Point(31, 155);
            this.TeleporteryBox.Name = "TeleporteryBox";
            this.TeleporteryBox.Size = new System.Drawing.Size(100, 22);
            this.TeleporteryBox.TabIndex = 9;
            this.TeleporteryBox.Text = "0";
            // 
            // TeleporterxBox
            // 
            this.TeleporterxBox.Location = new System.Drawing.Point(31, 126);
            this.TeleporterxBox.Name = "TeleporterxBox";
            this.TeleporterxBox.Size = new System.Drawing.Size(100, 22);
            this.TeleporterxBox.TabIndex = 8;
            this.TeleporterxBox.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "X:";
            // 
            // TeleporterDestList
            // 
            this.TeleporterDestList.Enabled = false;
            this.TeleporterDestList.FormattingEnabled = true;
            this.TeleporterDestList.ItemHeight = 16;
            this.TeleporterDestList.Location = new System.Drawing.Point(6, 24);
            this.TeleporterDestList.Name = "TeleporterDestList";
            this.TeleporterDestList.Size = new System.Drawing.Size(159, 68);
            this.TeleporterDestList.TabIndex = 1;
            this.TeleporterDestList.SelectedIndexChanged += new System.EventHandler(this.TeleporterDestList_SelectedIndexChanged);
            // 
            // teleporterToMapCheck
            // 
            this.teleporterToMapCheck.AutoSize = true;
            this.teleporterToMapCheck.Checked = true;
            this.teleporterToMapCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.teleporterToMapCheck.Location = new System.Drawing.Point(6, 99);
            this.teleporterToMapCheck.Name = "teleporterToMapCheck";
            this.teleporterToMapCheck.Size = new System.Drawing.Size(116, 21);
            this.teleporterToMapCheck.TabIndex = 0;
            this.teleporterToMapCheck.Text = "Leads to map";
            this.teleporterToMapCheck.UseVisualStyleBackColor = true;
            this.teleporterToMapCheck.CheckedChanged += new System.EventHandler(this.teleporterToMapCheck_CheckedChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(170, 273);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // lockOptions
            // 
            this.lockOptions.Controls.Add(this.label5);
            this.lockOptions.Controls.Add(this.lockTileUpDown);
            this.lockOptions.Enabled = false;
            this.lockOptions.Location = new System.Drawing.Point(212, 201);
            this.lockOptions.Name = "lockOptions";
            this.lockOptions.Size = new System.Drawing.Size(315, 66);
            this.lockOptions.TabIndex = 14;
            this.lockOptions.TabStop = false;
            this.lockOptions.Text = "MapLock";
            // 
            // lockTileUpDown
            // 
            this.lockTileUpDown.Location = new System.Drawing.Point(130, 24);
            this.lockTileUpDown.Name = "lockTileUpDown";
            this.lockTileUpDown.Size = new System.Drawing.Size(77, 22);
            this.lockTileUpDown.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tile to change to:";
            // 
            // MapObjectDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(562, 304);
            this.Controls.Add(this.lockOptions);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.teleporterOptions);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MapObjectDialog";
            this.Text = "Map Object";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MapObjectDialog_FormClosed);
            this.Load += new System.EventHandler(this.MapObjectDialog_Load);
            this.typeBox.ResumeLayout(false);
            this.typeBox.PerformLayout();
            this.teleporterOptions.ResumeLayout(false);
            this.teleporterOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomGrid)).EndInit();
            this.lockOptions.ResumeLayout(false);
            this.lockOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockTileUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.TextBox yBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox typeBox;
        private System.Windows.Forms.RadioButton teleportRadio;
        private System.Windows.Forms.GroupBox teleporterOptions;
        private System.Windows.Forms.ListBox TeleporterDestList;
        private System.Windows.Forms.CheckBox teleporterToMapCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TeleporteryBox;
        private System.Windows.Forms.TextBox TeleporterxBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.PictureBox roomGrid;
        private System.Windows.Forms.RadioButton lockRadio;
        private System.Windows.Forms.GroupBox lockOptions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown lockTileUpDown;
    }
}