namespace GUI
{
    partial class SongInfoForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongInfoForm));
            this.songPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.addButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.playButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.songNamePanel = new System.Windows.Forms.Panel();
            this.songName = new System.Windows.Forms.Label();
            this.lengthPanel = new System.Windows.Forms.Panel();
            this.length = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.artistPanel = new System.Windows.Forms.Panel();
            this.artist = new System.Windows.Forms.Label();
            this.songInfoContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.songNamePanel.SuspendLayout();
            this.lengthPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.artistPanel.SuspendLayout();
            this.songInfoContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // songPanel
            // 
            this.songPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.songPanel.Controls.Add(this.deleteButton);
            this.songPanel.Controls.Add(this.buttonPanel);
            this.songPanel.Controls.Add(this.songNamePanel);
            this.songPanel.Controls.Add(this.lengthPanel);
            this.songPanel.Controls.Add(this.titlePanel);
            this.songPanel.Controls.Add(this.artistPanel);
            this.songPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songPanel.Location = new System.Drawing.Point(0, 0);
            this.songPanel.Name = "songPanel";
            this.songPanel.Size = new System.Drawing.Size(884, 40);
            this.songPanel.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.ActiveImage = null;
            this.deleteButton.AllowAnimations = true;
            this.deleteButton.AllowBuffering = false;
            this.deleteButton.AllowToggling = false;
            this.deleteButton.AllowZooming = true;
            this.deleteButton.AllowZoomingOnFocus = false;
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.ErrorImage")));
            this.deleteButton.FadeWhenInactive = false;
            this.deleteButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageActive = null;
            this.deleteButton.ImageLocation = null;
            this.deleteButton.ImageMargin = 40;
            this.deleteButton.ImageSize = new System.Drawing.Size(0, 0);
            this.deleteButton.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.deleteButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.InitialImage")));
            this.deleteButton.Location = new System.Drawing.Point(844, 0);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Rotation = 0;
            this.deleteButton.ShowActiveImage = true;
            this.deleteButton.ShowCursorChanges = true;
            this.deleteButton.ShowImageBorders = true;
            this.deleteButton.ShowSizeMarkers = false;
            this.deleteButton.Size = new System.Drawing.Size(40, 40);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.ToolTipText = "";
            this.deleteButton.WaitOnLoad = false;
            this.deleteButton.Zoom = 40;
            this.deleteButton.ZoomSpeed = 10;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.buttonPanel.Controls.Add(this.addButton);
            this.buttonPanel.Controls.Add(this.playButton);
            this.buttonPanel.Location = new System.Drawing.Point(219, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(154, 40);
            this.buttonPanel.TabIndex = 7;
            this.buttonPanel.Click += new System.EventHandler(this.SongInfo_Click);
            // 
            // addButton
            // 
            this.addButton.ActiveImage = null;
            this.addButton.AllowAnimations = true;
            this.addButton.AllowBuffering = false;
            this.addButton.AllowToggling = false;
            this.addButton.AllowZooming = true;
            this.addButton.AllowZoomingOnFocus = false;
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("addButton.ErrorImage")));
            this.addButton.FadeWhenInactive = false;
            this.addButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageActive = null;
            this.addButton.ImageLocation = null;
            this.addButton.ImageMargin = 40;
            this.addButton.ImageSize = new System.Drawing.Size(0, 0);
            this.addButton.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.addButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("addButton.InitialImage")));
            this.addButton.Location = new System.Drawing.Point(94, 0);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Rotation = 0;
            this.addButton.ShowActiveImage = true;
            this.addButton.ShowCursorChanges = true;
            this.addButton.ShowImageBorders = true;
            this.addButton.ShowSizeMarkers = false;
            this.addButton.Size = new System.Drawing.Size(40, 40);
            this.addButton.TabIndex = 0;
            this.addButton.ToolTipText = "";
            this.addButton.WaitOnLoad = false;
            this.addButton.Zoom = 40;
            this.addButton.ZoomSpeed = 10;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // playButton
            // 
            this.playButton.ActiveImage = null;
            this.playButton.AllowAnimations = true;
            this.playButton.AllowBuffering = false;
            this.playButton.AllowToggling = false;
            this.playButton.AllowZooming = true;
            this.playButton.AllowZoomingOnFocus = false;
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.playButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("playButton.ErrorImage")));
            this.playButton.FadeWhenInactive = false;
            this.playButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.ImageActive = null;
            this.playButton.ImageLocation = null;
            this.playButton.ImageMargin = 40;
            this.playButton.ImageSize = new System.Drawing.Size(0, 0);
            this.playButton.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.playButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("playButton.InitialImage")));
            this.playButton.Location = new System.Drawing.Point(33, 0);
            this.playButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playButton.Name = "playButton";
            this.playButton.Rotation = 0;
            this.playButton.ShowActiveImage = true;
            this.playButton.ShowCursorChanges = true;
            this.playButton.ShowImageBorders = true;
            this.playButton.ShowSizeMarkers = false;
            this.playButton.Size = new System.Drawing.Size(40, 40);
            this.playButton.TabIndex = 0;
            this.playButton.ToolTipText = "";
            this.playButton.WaitOnLoad = false;
            this.playButton.Zoom = 40;
            this.playButton.ZoomSpeed = 10;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // songNamePanel
            // 
            this.songNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.songNamePanel.Controls.Add(this.songName);
            this.songNamePanel.Location = new System.Drawing.Point(3, 0);
            this.songNamePanel.Name = "songNamePanel";
            this.songNamePanel.Size = new System.Drawing.Size(217, 40);
            this.songNamePanel.TabIndex = 6;
            this.songNamePanel.Click += new System.EventHandler(this.SongInfo_Click);
            // 
            // songName
            // 
            this.songName.AutoSize = true;
            this.songName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.songName.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.songName.Location = new System.Drawing.Point(76, 9);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(91, 20);
            this.songName.TabIndex = 0;
            this.songName.Text = "song name";
            // 
            // lengthPanel
            // 
            this.lengthPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lengthPanel.Controls.Add(this.length);
            this.lengthPanel.Location = new System.Drawing.Point(767, 0);
            this.lengthPanel.Name = "lengthPanel";
            this.lengthPanel.Size = new System.Drawing.Size(74, 40);
            this.lengthPanel.TabIndex = 5;
            this.lengthPanel.Click += new System.EventHandler(this.SongInfo_Click);
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.length.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.length.Location = new System.Drawing.Point(7, 9);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(44, 20);
            this.length.TabIndex = 0;
            this.length.Text = "label";
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.titlePanel.Controls.Add(this.title);
            this.titlePanel.Location = new System.Drawing.Point(565, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(203, 40);
            this.titlePanel.TabIndex = 4;
            this.titlePanel.Click += new System.EventHandler(this.SongInfo_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.title.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.title.Location = new System.Drawing.Point(74, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(36, 20);
            this.title.TabIndex = 0;
            this.title.Text = "title";
            // 
            // artistPanel
            // 
            this.artistPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.artistPanel.Controls.Add(this.artist);
            this.artistPanel.Location = new System.Drawing.Point(372, 0);
            this.artistPanel.Name = "artistPanel";
            this.artistPanel.Size = new System.Drawing.Size(197, 40);
            this.artistPanel.TabIndex = 3;
            this.artistPanel.Click += new System.EventHandler(this.SongInfo_Click);
            // 
            // artist
            // 
            this.artist.AutoSize = true;
            this.artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.artist.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.artist.Location = new System.Drawing.Point(77, 9);
            this.artist.Name = "artist";
            this.artist.Size = new System.Drawing.Size(47, 20);
            this.artist.TabIndex = 0;
            this.artist.Text = "artist";
            // 
            // songInfoContextMenu
            // 
            this.songInfoContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.songInfoContextMenu.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.songInfoContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.songInfoContextMenu.Name = "contextMenuStrip1";
            this.songInfoContextMenu.Size = new System.Drawing.Size(211, 104);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.playToolStripMenuItem.Text = "Play";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // SongInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 40);
            this.Controls.Add(this.songPanel);
            this.Name = "SongInfoForm";
            this.Text = "NowPlayingForm";
            this.songPanel.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            this.songNamePanel.ResumeLayout(false);
            this.songNamePanel.PerformLayout();
            this.lengthPanel.ResumeLayout(false);
            this.lengthPanel.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.artistPanel.ResumeLayout(false);
            this.artistPanel.PerformLayout();
            this.songInfoContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel songPanel;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Panel songNamePanel;
        private System.Windows.Forms.Panel lengthPanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel artistPanel;
        private System.Windows.Forms.Label songName;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label artist;
        private Bunifu.UI.WinForms.BunifuImageButton deleteButton;
        private Bunifu.UI.WinForms.BunifuImageButton addButton;
        private Bunifu.UI.WinForms.BunifuImageButton playButton;
        private System.Windows.Forms.ContextMenuStrip songInfoContextMenu;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}