namespace GUI
{
    partial class NowPlayingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NowPlayingForm));
            this.nowPlayingPanel = new System.Windows.Forms.Panel();
            this.artistLabel = new System.Windows.Forms.Label();
            this.songNameLabel = new System.Windows.Forms.Label();
            this.songImg = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.nowPlayingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songImg)).BeginInit();
            this.SuspendLayout();
            // 
            // nowPlayingPanel
            // 
            this.nowPlayingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.nowPlayingPanel.Controls.Add(this.artistLabel);
            this.nowPlayingPanel.Controls.Add(this.songNameLabel);
            this.nowPlayingPanel.Controls.Add(this.songImg);
            this.nowPlayingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nowPlayingPanel.Location = new System.Drawing.Point(0, 0);
            this.nowPlayingPanel.Name = "nowPlayingPanel";
            this.nowPlayingPanel.Size = new System.Drawing.Size(319, 123);
            this.nowPlayingPanel.TabIndex = 1;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.artistLabel.Location = new System.Drawing.Point(149, 66);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(39, 17);
            this.artistLabel.TabIndex = 1;
            this.artistLabel.Text = "artist";
            // 
            // songNameLabel
            // 
            this.songNameLabel.AutoSize = true;
            this.songNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.songNameLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.songNameLabel.Location = new System.Drawing.Point(148, 37);
            this.songNameLabel.Name = "songNameLabel";
            this.songNameLabel.Size = new System.Drawing.Size(89, 20);
            this.songNameLabel.TabIndex = 1;
            this.songNameLabel.Text = "songName";
            this.songNameLabel.Click += new System.EventHandler(this.songNameLabel_Click);
            // 
            // songImg
            // 
            this.songImg.AllowFocused = false;
            this.songImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.songImg.AutoSizeHeight = true;
            this.songImg.BorderRadius = 42;
            this.songImg.Image = ((System.Drawing.Image)(resources.GetObject("songImg.Image")));
            this.songImg.IsCircle = true;
            this.songImg.Location = new System.Drawing.Point(26, 12);
            this.songImg.Name = "songImg";
            this.songImg.Size = new System.Drawing.Size(85, 85);
            this.songImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.songImg.TabIndex = 0;
            this.songImg.TabStop = false;
            this.songImg.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // NowPlayingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 123);
            this.Controls.Add(this.nowPlayingPanel);
            this.Name = "NowPlayingForm";
            this.Text = "NowPlayingForm";
            this.nowPlayingPanel.ResumeLayout(false);
            this.nowPlayingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel nowPlayingPanel;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label songNameLabel;
        private Bunifu.UI.WinForms.BunifuPictureBox songImg;
    }
}