namespace GUI
{
    partial class LyricsForm
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
            this.lyricsText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lyricsText
            // 
            this.lyricsText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lyricsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lyricsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lyricsText.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lyricsText.Location = new System.Drawing.Point(0, 0);
            this.lyricsText.Name = "lyricsText";
            this.lyricsText.ReadOnly = true;
            this.lyricsText.Size = new System.Drawing.Size(1089, 471);
            this.lyricsText.TabIndex = 0;
            this.lyricsText.Text = "";
            // 
            // LyricsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1089, 471);
            this.Controls.Add(this.lyricsText);
            this.Name = "LyricsForm";
            this.Text = "LyricsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox lyricsText;
    }
}