namespace as2edit
{
    partial class CodeExplanation
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
            this.explanation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // explanation
            // 
            this.explanation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explanation.Location = new System.Drawing.Point(0, 0);
            this.explanation.Multiline = true;
            this.explanation.Name = "explanation";
            this.explanation.ReadOnly = true;
            this.explanation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.explanation.Size = new System.Drawing.Size(475, 483);
            this.explanation.TabIndex = 0;
            // 
            // CodeExplanation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 483);
            this.Controls.Add(this.explanation);
            this.Name = "CodeExplanation";
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox explanation;
    }
}