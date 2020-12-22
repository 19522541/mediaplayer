namespace GUI
{
    partial class LyricForm
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
            this.lyricBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lyricBox
            // 
            this.lyricBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lyricBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lyricBox.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lyricBox.Location = new System.Drawing.Point(0, 0);
            this.lyricBox.Name = "lyricBox";
            this.lyricBox.Size = new System.Drawing.Size(800, 450);
            this.lyricBox.TabIndex = 0;
            this.lyricBox.Text = "";
            // 
            // LyricForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lyricBox);
            this.Name = "LyricForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox lyricBox;
    }
}