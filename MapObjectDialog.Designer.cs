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
            this.teleportRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TeleporterDestList = new System.Windows.Forms.ListBox();
            this.teleporterToMapCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TeleporterxBox = new System.Windows.Forms.TextBox();
            this.TeleporteryBox = new System.Windows.Forms.TextBox();
            this.TeleporterScreenBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.typeBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.cancelButton.Location = new System.Drawing.Point(89, 218);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(8, 218);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // typeBox
            // 
            this.typeBox.Controls.Add(this.teleportRadio);
            this.typeBox.Location = new System.Drawing.Point(12, 65);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(188, 130);
            this.typeBox.TabIndex = 6;
            this.typeBox.TabStop = false;
            this.typeBox.Text = "Object Type";
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TeleporterScreenBox);
            this.groupBox1.Controls.Add(this.TeleporteryBox);
            this.groupBox1.Controls.Add(this.TeleporterxBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TeleporterDestList);
            this.groupBox1.Controls.Add(this.teleporterToMapCheck);
            this.groupBox1.Location = new System.Drawing.Point(212, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 106);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MapTeleporter";
            // 
            // TeleporterDestList
            // 
            this.TeleporterDestList.Enabled = false;
            this.TeleporterDestList.FormattingEnabled = true;
            this.TeleporterDestList.ItemHeight = 16;
            this.TeleporterDestList.Location = new System.Drawing.Point(3, 18);
            this.TeleporterDestList.Name = "TeleporterDestList";
            this.TeleporterDestList.Size = new System.Drawing.Size(159, 52);
            this.TeleporterDestList.TabIndex = 1;
            // 
            // teleporterToMapCheck
            // 
            this.teleporterToMapCheck.AutoSize = true;
            this.teleporterToMapCheck.Checked = true;
            this.teleporterToMapCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.teleporterToMapCheck.Location = new System.Drawing.Point(6, 71);
            this.teleporterToMapCheck.Name = "teleporterToMapCheck";
            this.teleporterToMapCheck.Size = new System.Drawing.Size(116, 21);
            this.teleporterToMapCheck.TabIndex = 0;
            this.teleporterToMapCheck.Text = "Leads to map";
            this.teleporterToMapCheck.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Screen:";
            // 
            // TeleporterxBox
            // 
            this.TeleporterxBox.Location = new System.Drawing.Point(195, 15);
            this.TeleporterxBox.Name = "TeleporterxBox";
            this.TeleporterxBox.Size = new System.Drawing.Size(100, 22);
            this.TeleporterxBox.TabIndex = 8;
            this.TeleporterxBox.Text = "0";
            // 
            // TeleporteryBox
            // 
            this.TeleporteryBox.Location = new System.Drawing.Point(195, 44);
            this.TeleporteryBox.Name = "TeleporteryBox";
            this.TeleporteryBox.Size = new System.Drawing.Size(100, 22);
            this.TeleporteryBox.TabIndex = 9;
            this.TeleporteryBox.Text = "0";
            // 
            // TeleporterScreenBox
            // 
            this.TeleporterScreenBox.Location = new System.Drawing.Point(224, 72);
            this.TeleporterScreenBox.Name = "TeleporterScreenBox";
            this.TeleporterScreenBox.Size = new System.Drawing.Size(71, 22);
            this.TeleporterScreenBox.TabIndex = 10;
            this.TeleporterScreenBox.Text = "0";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(170, 218);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // MapObjectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 253);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MapObjectDialog";
            this.Text = "Map Object";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MapObjectDialog_FormClosed);
            this.Load += new System.EventHandler(this.MapObjectDialog_Load);
            this.typeBox.ResumeLayout(false);
            this.typeBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox TeleporterDestList;
        private System.Windows.Forms.CheckBox teleporterToMapCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TeleporterScreenBox;
        private System.Windows.Forms.TextBox TeleporteryBox;
        private System.Windows.Forms.TextBox TeleporterxBox;
        private System.Windows.Forms.Button deleteButton;
    }
}