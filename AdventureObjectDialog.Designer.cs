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
            this.keyRadio = new System.Windows.Forms.RadioButton();
            this.okButton = new System.Windows.Forms.Button();
            this.yBox = new System.Windows.Forms.TextBox();
            this.xBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.objectListBox = new System.Windows.Forms.ListBox();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.typeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(84, 218);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // typeBox
            // 
            this.typeBox.Controls.Add(this.keyRadio);
            this.typeBox.Location = new System.Drawing.Point(165, 65);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(188, 147);
            this.typeBox.TabIndex = 15;
            this.typeBox.TabStop = false;
            this.typeBox.Text = "Object Type";
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
            this.okButton.Location = new System.Drawing.Point(297, 218);
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
            this.objectListBox.Size = new System.Drawing.Size(156, 196);
            this.objectListBox.TabIndex = 18;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(3, 218);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 19;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(165, 218);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 20;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AdventureObjectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 246);
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
            this.Name = "AdventureObjectDialog";
            this.Text = "AdventureObjectDialog";
            this.typeBox.ResumeLayout(false);
            this.typeBox.PerformLayout();
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
    }
}