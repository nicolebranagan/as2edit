namespace as2edit
{
    partial class Main
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
            this.advButton = new System.Windows.Forms.Button();
            this.mapButton = new System.Windows.Forms.Button();
            this.outButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // advButton
            // 
            this.advButton.Location = new System.Drawing.Point(12, 54);
            this.advButton.Name = "advButton";
            this.advButton.Size = new System.Drawing.Size(124, 40);
            this.advButton.TabIndex = 0;
            this.advButton.Text = "Adventure Editor";
            this.advButton.UseVisualStyleBackColor = true;
            this.advButton.Click += new System.EventHandler(this.advButton_Click);
            // 
            // mapButton
            // 
            this.mapButton.Location = new System.Drawing.Point(12, 12);
            this.mapButton.Name = "mapButton";
            this.mapButton.Size = new System.Drawing.Size(124, 36);
            this.mapButton.TabIndex = 1;
            this.mapButton.Text = "Map Editor";
            this.mapButton.UseVisualStyleBackColor = true;
            this.mapButton.Click += new System.EventHandler(this.mapButton_Click);
            // 
            // outButton
            // 
            this.outButton.Location = new System.Drawing.Point(12, 312);
            this.outButton.Name = "outButton";
            this.outButton.Size = new System.Drawing.Size(124, 39);
            this.outButton.TabIndex = 2;
            this.outButton.Text = "Save to XML";
            this.outButton.UseVisualStyleBackColor = true;
            this.outButton.Click += new System.EventHandler(this.outButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 267);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(124, 39);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "Open XML";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 363);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.outButton);
            this.Controls.Add(this.mapButton);
            this.Controls.Add(this.advButton);
            this.Name = "Main";
            this.Text = "Aspect Star 2 Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button advButton;
        private System.Windows.Forms.Button mapButton;
        private System.Windows.Forms.Button outButton;
        private System.Windows.Forms.Button openButton;
    }
}

