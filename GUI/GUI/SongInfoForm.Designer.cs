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
            this.addButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.playButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.fdeleteButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.indexLabel = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.artist = new System.Windows.Forms.Label();
            this.songName = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.Label();
            this.songInfoContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songInfoTimer = new System.Windows.Forms.Timer(this.components);
            this.addContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.songPanel.SuspendLayout();
            this.songInfoContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // songPanel
            // 
            this.songPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.songPanel.Controls.Add(this.addButton);
            this.songPanel.Controls.Add(this.playButton);
            this.songPanel.Controls.Add(this.fdeleteButton);
            this.songPanel.Controls.Add(this.indexLabel);
            this.songPanel.Controls.Add(this.title);
            this.songPanel.Controls.Add(this.artist);
            this.songPanel.Controls.Add(this.songName);
            this.songPanel.Controls.Add(this.length);
            this.songPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songPanel.Location = new System.Drawing.Point(0, 0);
            this.songPanel.Name = "songPanel";
            this.songPanel.Size = new System.Drawing.Size(713, 40);
            this.songPanel.TabIndex = 0;
            this.songPanel.Click += new System.EventHandler(this.Click1);
            this.songPanel.DoubleClick += new System.EventHandler(this.DoubleClick1);
            // 
            // addButton
            // 
            this.addButton.ActiveImage = null;
            this.addButton.AllowAnimations = true;
            this.addButton.AllowBuffering = false;
            this.addButton.AllowToggling = false;
            this.addButton.AllowZooming = true;
            this.addButton.AllowZoomingOnFocus = false;
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
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
            this.addButton.Location = new System.Drawing.Point(230, 0);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Rotation = 0;
            this.addButton.ShowActiveImage = true;
            this.addButton.ShowCursorChanges = true;
            this.addButton.ShowImageBorders = true;
            this.addButton.ShowSizeMarkers = false;
            this.addButton.Size = new System.Drawing.Size(40, 40);
            this.addButton.TabIndex = 10;
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
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
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
            this.playButton.Location = new System.Drawing.Point(166, 0);
            this.playButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playButton.Name = "playButton";
            this.playButton.Rotation = 0;
            this.playButton.ShowActiveImage = true;
            this.playButton.ShowCursorChanges = true;
            this.playButton.ShowImageBorders = true;
            this.playButton.ShowSizeMarkers = false;
            this.playButton.Size = new System.Drawing.Size(40, 40);
            this.playButton.TabIndex = 11;
            this.playButton.ToolTipText = "";
            this.playButton.WaitOnLoad = false;
            this.playButton.Zoom = 40;
            this.playButton.ZoomSpeed = 10;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // fdeleteButton
            // 
            this.fdeleteButton.ActiveImage = null;
            this.fdeleteButton.AllowAnimations = true;
            this.fdeleteButton.AllowBuffering = false;
            this.fdeleteButton.AllowToggling = false;
            this.fdeleteButton.AllowZooming = true;
            this.fdeleteButton.AllowZoomingOnFocus = false;
            this.fdeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.fdeleteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.fdeleteButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("fdeleteButton.ErrorImage")));
            this.fdeleteButton.FadeWhenInactive = false;
            this.fdeleteButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.fdeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("fdeleteButton.Image")));
            this.fdeleteButton.ImageActive = null;
            this.fdeleteButton.ImageLocation = null;
            this.fdeleteButton.ImageMargin = 40;
            this.fdeleteButton.ImageSize = new System.Drawing.Size(0, 0);
            this.fdeleteButton.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.fdeleteButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("fdeleteButton.InitialImage")));
            this.fdeleteButton.Location = new System.Drawing.Point(668, 0);
            this.fdeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fdeleteButton.Name = "fdeleteButton";
            this.fdeleteButton.Rotation = 0;
            this.fdeleteButton.ShowActiveImage = true;
            this.fdeleteButton.ShowCursorChanges = true;
            this.fdeleteButton.ShowImageBorders = true;
            this.fdeleteButton.ShowSizeMarkers = false;
            this.fdeleteButton.Size = new System.Drawing.Size(40, 40);
            this.fdeleteButton.TabIndex = 0;
            this.fdeleteButton.ToolTipText = "";
            this.fdeleteButton.WaitOnLoad = false;
            this.fdeleteButton.Zoom = 40;
            this.fdeleteButton.ZoomSpeed = 10;
            this.fdeleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // indexLabel
            // 
            this.indexLabel.AutoEllipsis = true;
            this.indexLabel.AutoSize = true;
            this.indexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.indexLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.indexLabel.Location = new System.Drawing.Point(12, 11);
            this.indexLabel.MaximumSize = new System.Drawing.Size(211, 20);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(41, 20);
            this.indexLabel.TabIndex = 12;
            this.indexLabel.Text = "num";
            this.indexLabel.Click += new System.EventHandler(this.Click1);
            this.indexLabel.DoubleClick += new System.EventHandler(this.DoubleClick1);
            // 
            // title
            // 
            this.title.AutoEllipsis = true;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.title.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.title.Location = new System.Drawing.Point(61, 11);
            this.title.MaximumSize = new System.Drawing.Size(211, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(36, 20);
            this.title.TabIndex = 12;
            this.title.Text = "title";
            this.title.Click += new System.EventHandler(this.Click1);
            this.title.DoubleClick += new System.EventHandler(this.DoubleClick1);
            // 
            // artist
            // 
            this.artist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.artist.AutoEllipsis = true;
            this.artist.AutoSize = true;
            this.artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.artist.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.artist.Location = new System.Drawing.Point(342, 9);
            this.artist.MaximumSize = new System.Drawing.Size(145, 20);
            this.artist.Name = "artist";
            this.artist.Size = new System.Drawing.Size(47, 20);
            this.artist.TabIndex = 13;
            this.artist.Text = "artist";
            this.artist.Click += new System.EventHandler(this.Click1);
            this.artist.DoubleClick += new System.EventHandler(this.DoubleClick1);
            // 
            // songName
            // 
            this.songName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.songName.AutoEllipsis = true;
            this.songName.AutoSize = true;
            this.songName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.songName.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.songName.Location = new System.Drawing.Point(448, 9);
            this.songName.MaximumSize = new System.Drawing.Size(152, 20);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(91, 20);
            this.songName.TabIndex = 14;
            this.songName.Text = "song name";
            this.songName.Click += new System.EventHandler(this.Click1);
            this.songName.DoubleClick += new System.EventHandler(this.DoubleClick1);
            // 
            // length
            // 
            this.length.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.length.AutoEllipsis = true;
            this.length.AutoSize = true;
            this.length.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.length.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.length.Location = new System.Drawing.Point(607, 9);
            this.length.MaximumSize = new System.Drawing.Size(54, 20);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(54, 20);
            this.length.TabIndex = 15;
            this.length.Text = "length";
            this.length.Click += new System.EventHandler(this.Click1);
            this.length.DoubleClick += new System.EventHandler(this.DoubleClick1);
            // 
            // songInfoContextMenu
            // 
            this.songInfoContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.songInfoContextMenu.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.songInfoContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.songInfoContextMenu.Name = "contextMenuStrip1";
            this.songInfoContextMenu.Size = new System.Drawing.Size(123, 76);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPlaylistToolStripMenuItem,
            this.toolStripSeparator1});
            this.addToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // newPlaylistToolStripMenuItem
            // 
            this.newPlaylistToolStripMenuItem.Name = "newPlaylistToolStripMenuItem";
            this.newPlaylistToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newPlaylistToolStripMenuItem.Text = "New Playlist";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // songInfoTimer
            // 
            this.songInfoTimer.Enabled = true;
            this.songInfoTimer.Interval = 50;
            this.songInfoTimer.Tick += new System.EventHandler(this.songInfoTimer_Tick);
            // 
            // addContextMenuStrip
            // 
            this.addContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.addContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.addContextMenuStrip.Name = "addContextMenuStrip";
            this.addContextMenuStrip.Size = new System.Drawing.Size(211, 32);
            this.addContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.addContextMenuStrip_ItemClicked);
            this.addContextMenuStrip.MouseLeave += new System.EventHandler(this.addContextMenuStrip_MouseLeave);
            // 
            // SongInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 40);
            this.Controls.Add(this.songPanel);
            this.Name = "SongInfoForm";
            this.Text = "NowPlayingForm";
            this.songPanel.ResumeLayout(false);
            this.songPanel.PerformLayout();
            this.songInfoContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel songPanel;
        private Bunifu.UI.WinForms.BunifuImageButton fdeleteButton;
        private System.Windows.Forms.ContextMenuStrip songInfoContextMenu;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Bunifu.UI.WinForms.BunifuImageButton addButton;
        private Bunifu.UI.WinForms.BunifuImageButton playButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.Label songName;
        private System.Windows.Forms.Label artist;
        private System.Windows.Forms.Timer songInfoTimer;
        private System.Windows.Forms.Label indexLabel;
        private System.Windows.Forms.ContextMenuStrip addContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem newPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}