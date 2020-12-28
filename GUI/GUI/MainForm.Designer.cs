namespace GUI
{
    partial class MainForm
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
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation4 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.sideMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.iconPanel = new System.Windows.Forms.Panel();
            this.sideMenuButton = new System.Windows.Forms.Button();
            this.menuButtonList = new System.Windows.Forms.ImageList(this.components);
            this.mediaButton = new System.Windows.Forms.Button();
            this.mediaSubMenu = new System.Windows.Forms.Panel();
            this.openMusicFolderButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.playlistButton = new System.Windows.Forms.Button();
            this.playlistSubMenu = new System.Windows.Forms.Panel();
            this.createPlaylist = new System.Windows.Forms.Button();
            this.pictureButton = new System.Windows.Forms.Button();
            this.imageSubMenu = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.videoButton = new System.Windows.Forms.Button();
            this.videoSubMenu = new System.Windows.Forms.Panel();
            this.playURLButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.mainBotPanel = new System.Windows.Forms.Panel();
            this.soundVolumeBar = new Bunifu.UI.WinForms.BunifuHSlider();
            this.musicProcessBar = new Bunifu.UI.WinForms.BunifuHSlider();
            this.songLength = new System.Windows.Forms.Label();
            this.loopButton = new System.Windows.Forms.Button();
            this.leapButtonList = new System.Windows.Forms.ImageList(this.components);
            this.nextButton = new System.Windows.Forms.Button();
            this.nextButtonList = new System.Windows.Forms.ImageList(this.components);
            this.backButton = new System.Windows.Forms.Button();
            this.backButtonList = new System.Windows.Forms.ImageList(this.components);
            this.randomButton = new System.Windows.Forms.Button();
            this.shuffleButtonList = new System.Windows.Forms.ImageList(this.components);
            this.time = new System.Windows.Forms.Label();
            this.soundButton = new System.Windows.Forms.Button();
            this.soundButtonList = new System.Windows.Forms.ImageList(this.components);
            this.muteButton = new System.Windows.Forms.Button();
            this.muteButtonList = new System.Windows.Forms.ImageList(this.components);
            this.playButton = new System.Windows.Forms.Button();
            this.playButtonList = new System.Windows.Forms.ImageList(this.components);
            this.stopButton = new System.Windows.Forms.Button();
            this.stopButtonList = new System.Windows.Forms.ImageList(this.components);
            this.controlImageList = new System.Windows.Forms.ImageList(this.components);
            this.exitButtonList = new System.Windows.Forms.ImageList(this.components);
            this.musicBarTimer = new System.Windows.Forms.Timer(this.components);
            this.timeSync = new System.Windows.Forms.Timer(this.components);
            this.count = new System.Windows.Forms.Timer(this.components);
            this.sideMenuAni = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.titlePanel = new System.Windows.Forms.Panel();
            this.cancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.saveButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.backwardButton = new System.Windows.Forms.Button();
            this.backwardButtonList = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.mainMidPanel = new System.Windows.Forms.Panel();
            this.mainPicturebox = new System.Windows.Forms.PictureBox();
            this.dragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.sideMenuPanel.SuspendLayout();
            this.iconPanel.SuspendLayout();
            this.mediaSubMenu.SuspendLayout();
            this.playlistSubMenu.SuspendLayout();
            this.imageSubMenu.SuspendLayout();
            this.videoSubMenu.SuspendLayout();
            this.mainBotPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.mainMidPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.sideMenuPanel.Controls.Add(this.iconPanel);
            this.sideMenuPanel.Controls.Add(this.mediaButton);
            this.sideMenuPanel.Controls.Add(this.mediaSubMenu);
            this.sideMenuPanel.Controls.Add(this.playlistButton);
            this.sideMenuPanel.Controls.Add(this.playlistSubMenu);
            this.sideMenuPanel.Controls.Add(this.pictureButton);
            this.sideMenuPanel.Controls.Add(this.imageSubMenu);
            this.sideMenuPanel.Controls.Add(this.videoButton);
            this.sideMenuPanel.Controls.Add(this.videoSubMenu);
            this.sideMenuPanel.Controls.Add(this.helpButton);
            this.sideMenuAni.SetDecoration(this.sideMenuPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(264, 685);
            this.sideMenuPanel.TabIndex = 0;
            // 
            // iconPanel
            // 
            this.iconPanel.Controls.Add(this.sideMenuButton);
            this.sideMenuAni.SetDecoration(this.iconPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.iconPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconPanel.Location = new System.Drawing.Point(3, 2);
            this.iconPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPanel.Name = "iconPanel";
            this.iconPanel.Size = new System.Drawing.Size(251, 100);
            this.iconPanel.TabIndex = 0;
            // 
            // sideMenuButton
            // 
            this.sideMenuAni.SetDecoration(this.sideMenuButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.sideMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.sideMenuButton.FlatAppearance.BorderSize = 0;
            this.sideMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.sideMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.sideMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideMenuButton.ImageIndex = 0;
            this.sideMenuButton.ImageList = this.menuButtonList;
            this.sideMenuButton.Location = new System.Drawing.Point(3, 27);
            this.sideMenuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sideMenuButton.Name = "sideMenuButton";
            this.sideMenuButton.Size = new System.Drawing.Size(44, 46);
            this.sideMenuButton.TabIndex = 3;
            this.sideMenuButton.UseVisualStyleBackColor = true;
            this.sideMenuButton.Click += new System.EventHandler(this.sideMenuButton_Click);
            this.sideMenuButton.MouseLeave += new System.EventHandler(this.sideMenuButton_MouseLeave);
            this.sideMenuButton.MouseHover += new System.EventHandler(this.sideMenuButton_MouseHover);
            // 
            // menuButtonList
            // 
            this.menuButtonList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuButtonList.ImageStream")));
            this.menuButtonList.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.menuButtonList.Images.SetKeyName(0, "icons8-menu-40.png");
            this.menuButtonList.Images.SetKeyName(1, "icons8-menu-40 (1).png");
            // 
            // mediaButton
            // 
            this.sideMenuAni.SetDecoration(this.mediaButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.mediaButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mediaButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.mediaButton.FlatAppearance.BorderSize = 0;
            this.mediaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(110)))));
            this.mediaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediaButton.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mediaButton.Image = global::GUI.Properties.Resources.icons8_music_30;
            this.mediaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mediaButton.Location = new System.Drawing.Point(3, 106);
            this.mediaButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mediaButton.Name = "mediaButton";
            this.mediaButton.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.mediaButton.Size = new System.Drawing.Size(251, 46);
            this.mediaButton.TabIndex = 1;
            this.mediaButton.Text = "Media";
            this.mediaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mediaButton.UseVisualStyleBackColor = true;
            this.mediaButton.Click += new System.EventHandler(this.mediaButton_Click);
            this.mediaButton.MouseLeave += new System.EventHandler(this.mediaButton_MouseLeave);
            this.mediaButton.MouseHover += new System.EventHandler(this.mediaButton_MouseHover);
            // 
            // mediaSubMenu
            // 
            this.mediaSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.mediaSubMenu.Controls.Add(this.openMusicFolderButton);
            this.mediaSubMenu.Controls.Add(this.openButton);
            this.sideMenuAni.SetDecoration(this.mediaSubMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.mediaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.mediaSubMenu.Location = new System.Drawing.Point(3, 156);
            this.mediaSubMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mediaSubMenu.Name = "mediaSubMenu";
            this.mediaSubMenu.Size = new System.Drawing.Size(251, 95);
            this.mediaSubMenu.TabIndex = 2;
            // 
            // openMusicFolderButton
            // 
            this.sideMenuAni.SetDecoration(this.openMusicFolderButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.openMusicFolderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.openMusicFolderButton.FlatAppearance.BorderSize = 0;
            this.openMusicFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openMusicFolderButton.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.openMusicFolderButton.Location = new System.Drawing.Point(0, 43);
            this.openMusicFolderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openMusicFolderButton.Name = "openMusicFolderButton";
            this.openMusicFolderButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.openMusicFolderButton.Size = new System.Drawing.Size(251, 43);
            this.openMusicFolderButton.TabIndex = 1;
            this.openMusicFolderButton.Text = "&Open folder";
            this.openMusicFolderButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openMusicFolderButton.UseVisualStyleBackColor = true;
            this.openMusicFolderButton.Click += new System.EventHandler(this.openMusicFolderButton_Click);
            // 
            // openButton
            // 
            this.sideMenuAni.SetDecoration(this.openButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.openButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.openButton.FlatAppearance.BorderSize = 0;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.openButton.Location = new System.Drawing.Point(0, 0);
            this.openButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openButton.Name = "openButton";
            this.openButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.openButton.Size = new System.Drawing.Size(251, 43);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "&Open file";
            this.openButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // playlistButton
            // 
            this.sideMenuAni.SetDecoration(this.playlistButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.playlistButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.playlistButton.FlatAppearance.BorderSize = 0;
            this.playlistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playlistButton.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.playlistButton.Image = ((System.Drawing.Image)(resources.GetObject("playlistButton.Image")));
            this.playlistButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playlistButton.Location = new System.Drawing.Point(3, 255);
            this.playlistButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playlistButton.Name = "playlistButton";
            this.playlistButton.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.playlistButton.Size = new System.Drawing.Size(251, 46);
            this.playlistButton.TabIndex = 3;
            this.playlistButton.Text = "Playlist Management";
            this.playlistButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.playlistButton.UseVisualStyleBackColor = true;
            this.playlistButton.Click += new System.EventHandler(this.playlistButton_Click);
            this.playlistButton.MouseLeave += new System.EventHandler(this.playlistButton_MouseLeave);
            this.playlistButton.MouseHover += new System.EventHandler(this.playlistButton_MouseHover);
            // 
            // playlistSubMenu
            // 
            this.playlistSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.playlistSubMenu.Controls.Add(this.createPlaylist);
            this.sideMenuAni.SetDecoration(this.playlistSubMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.playlistSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.playlistSubMenu.Location = new System.Drawing.Point(3, 305);
            this.playlistSubMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playlistSubMenu.Name = "playlistSubMenu";
            this.playlistSubMenu.Size = new System.Drawing.Size(251, 43);
            this.playlistSubMenu.TabIndex = 4;
            // 
            // createPlaylist
            // 
            this.sideMenuAni.SetDecoration(this.createPlaylist, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.createPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.createPlaylist.FlatAppearance.BorderSize = 0;
            this.createPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPlaylist.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.createPlaylist.Location = new System.Drawing.Point(0, 0);
            this.createPlaylist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createPlaylist.Name = "createPlaylist";
            this.createPlaylist.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.createPlaylist.Size = new System.Drawing.Size(251, 43);
            this.createPlaylist.TabIndex = 0;
            this.createPlaylist.Text = "New Playlist";
            this.createPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createPlaylist.UseVisualStyleBackColor = true;
            this.createPlaylist.Click += new System.EventHandler(this.createPlaylist_Click);
            // 
            // pictureButton
            // 
            this.sideMenuAni.SetDecoration(this.pictureButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pictureButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureButton.FlatAppearance.BorderSize = 0;
            this.pictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pictureButton.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureButton.Image = ((System.Drawing.Image)(resources.GetObject("pictureButton.Image")));
            this.pictureButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pictureButton.Location = new System.Drawing.Point(3, 352);
            this.pictureButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureButton.Name = "pictureButton";
            this.pictureButton.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.pictureButton.Size = new System.Drawing.Size(251, 46);
            this.pictureButton.TabIndex = 5;
            this.pictureButton.Text = "Picture";
            this.pictureButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pictureButton.UseVisualStyleBackColor = true;
            this.pictureButton.Click += new System.EventHandler(this.pictureButton_Click);
            this.pictureButton.MouseLeave += new System.EventHandler(this.pictureButton_MouseLeave);
            this.pictureButton.MouseHover += new System.EventHandler(this.pictureButton_MouseHover);
            // 
            // imageSubMenu
            // 
            this.imageSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.imageSubMenu.Controls.Add(this.button15);
            this.sideMenuAni.SetDecoration(this.imageSubMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.imageSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageSubMenu.Location = new System.Drawing.Point(3, 402);
            this.imageSubMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageSubMenu.Name = "imageSubMenu";
            this.imageSubMenu.Size = new System.Drawing.Size(251, 40);
            this.imageSubMenu.TabIndex = 7;
            // 
            // button15
            // 
            this.sideMenuAni.SetDecoration(this.button15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button15.Dock = System.Windows.Forms.DockStyle.Top;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button15.Location = new System.Drawing.Point(0, 0);
            this.button15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button15.Name = "button15";
            this.button15.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button15.Size = new System.Drawing.Size(251, 39);
            this.button15.TabIndex = 0;
            this.button15.Text = "&Open";
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // videoButton
            // 
            this.sideMenuAni.SetDecoration(this.videoButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.videoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.videoButton.FlatAppearance.BorderSize = 0;
            this.videoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videoButton.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.videoButton.Image = ((System.Drawing.Image)(resources.GetObject("videoButton.Image")));
            this.videoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.videoButton.Location = new System.Drawing.Point(3, 446);
            this.videoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.videoButton.Name = "videoButton";
            this.videoButton.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.videoButton.Size = new System.Drawing.Size(251, 46);
            this.videoButton.TabIndex = 6;
            this.videoButton.Text = "Video";
            this.videoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.videoButton.UseVisualStyleBackColor = true;
            this.videoButton.Click += new System.EventHandler(this.videoButton_Click);
            this.videoButton.MouseLeave += new System.EventHandler(this.videoButton_MouseLeave);
            this.videoButton.MouseHover += new System.EventHandler(this.videoButton_MouseHover);
            // 
            // videoSubMenu
            // 
            this.videoSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.videoSubMenu.Controls.Add(this.playURLButton);
            this.videoSubMenu.Controls.Add(this.button3);
            this.sideMenuAni.SetDecoration(this.videoSubMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.videoSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.videoSubMenu.Location = new System.Drawing.Point(3, 496);
            this.videoSubMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.videoSubMenu.Name = "videoSubMenu";
            this.videoSubMenu.Size = new System.Drawing.Size(251, 84);
            this.videoSubMenu.TabIndex = 9;
            // 
            // playURLButton
            // 
            this.sideMenuAni.SetDecoration(this.playURLButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.playURLButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.playURLButton.FlatAppearance.BorderSize = 0;
            this.playURLButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playURLButton.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.playURLButton.Location = new System.Drawing.Point(0, 39);
            this.playURLButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playURLButton.Name = "playURLButton";
            this.playURLButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.playURLButton.Size = new System.Drawing.Size(251, 43);
            this.playURLButton.TabIndex = 2;
            this.playURLButton.Text = "Open URL";
            this.playURLButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playURLButton.UseVisualStyleBackColor = true;
            this.playURLButton.Click += new System.EventHandler(this.playURLButton_Click);
            // 
            // button3
            // 
            this.sideMenuAni.SetDecoration(this.button3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(251, 39);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // helpButton
            // 
            this.sideMenuAni.SetDecoration(this.helpButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.helpButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
            this.helpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpButton.Location = new System.Drawing.Point(3, 584);
            this.helpButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.helpButton.Name = "helpButton";
            this.helpButton.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.helpButton.Size = new System.Drawing.Size(251, 46);
            this.helpButton.TabIndex = 8;
            this.helpButton.Text = "Help";
            this.helpButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            this.helpButton.MouseLeave += new System.EventHandler(this.helpButton_MouseLeave);
            this.helpButton.MouseHover += new System.EventHandler(this.helpButton_MouseHover);
            // 
            // mainBotPanel
            // 
            this.mainBotPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.mainBotPanel.Controls.Add(this.soundVolumeBar);
            this.mainBotPanel.Controls.Add(this.musicProcessBar);
            this.mainBotPanel.Controls.Add(this.songLength);
            this.mainBotPanel.Controls.Add(this.loopButton);
            this.mainBotPanel.Controls.Add(this.nextButton);
            this.mainBotPanel.Controls.Add(this.backButton);
            this.mainBotPanel.Controls.Add(this.randomButton);
            this.mainBotPanel.Controls.Add(this.time);
            this.mainBotPanel.Controls.Add(this.soundButton);
            this.mainBotPanel.Controls.Add(this.muteButton);
            this.mainBotPanel.Controls.Add(this.playButton);
            this.mainBotPanel.Controls.Add(this.stopButton);
            this.sideMenuAni.SetDecoration(this.mainBotPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.mainBotPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainBotPanel.Location = new System.Drawing.Point(264, 563);
            this.mainBotPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainBotPanel.Name = "mainBotPanel";
            this.mainBotPanel.Size = new System.Drawing.Size(1083, 122);
            this.mainBotPanel.TabIndex = 1;
            // 
            // soundVolumeBar
            // 
            this.soundVolumeBar.AllowCursorChanges = true;
            this.soundVolumeBar.AllowHomeEndKeysDetection = false;
            this.soundVolumeBar.AllowIncrementalClickMoves = true;
            this.soundVolumeBar.AllowMouseDownEffects = false;
            this.soundVolumeBar.AllowMouseHoverEffects = false;
            this.soundVolumeBar.AllowScrollingAnimations = true;
            this.soundVolumeBar.AllowScrollKeysDetection = true;
            this.soundVolumeBar.AllowScrollOptionsMenu = true;
            this.soundVolumeBar.AllowShrinkingOnFocusLost = false;
            this.soundVolumeBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soundVolumeBar.BackgroundImage")));
            this.soundVolumeBar.BindingContainer = null;
            this.soundVolumeBar.BorderRadius = 2;
            this.soundVolumeBar.BorderThickness = 1;
            this.soundVolumeBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideMenuAni.SetDecoration(this.soundVolumeBar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.soundVolumeBar.DrawThickBorder = false;
            this.soundVolumeBar.DurationBeforeShrink = 2000;
            this.soundVolumeBar.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.soundVolumeBar.LargeChange = 10;
            this.soundVolumeBar.Location = new System.Drawing.Point(892, 41);
            this.soundVolumeBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.soundVolumeBar.Maximum = 100;
            this.soundVolumeBar.Minimum = 0;
            this.soundVolumeBar.MinimumSize = new System.Drawing.Size(0, 31);
            this.soundVolumeBar.MinimumThumbLength = 18;
            this.soundVolumeBar.Name = "soundVolumeBar";
            this.soundVolumeBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.soundVolumeBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.soundVolumeBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.soundVolumeBar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.soundVolumeBar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.soundVolumeBar.ShrinkSizeLimit = 3;
            this.soundVolumeBar.Size = new System.Drawing.Size(124, 31);
            this.soundVolumeBar.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.soundVolumeBar.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.soundVolumeBar.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.soundVolumeBar.SmallChange = 1;
            this.soundVolumeBar.TabIndex = 14;
            this.soundVolumeBar.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.soundVolumeBar.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.soundVolumeBar.ThumbLength = 18;
            this.soundVolumeBar.ThumbMargin = 1;
            this.soundVolumeBar.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.soundVolumeBar.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.soundVolumeBar.Value = 50;
            this.soundVolumeBar.ValueChanged += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs>(this.soundVolumeBar_ValueChanged);
            this.soundVolumeBar.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.soundVolumeBar_Scroll);
            // 
            // musicProcessBar
            // 
            this.musicProcessBar.AllowCursorChanges = true;
            this.musicProcessBar.AllowHomeEndKeysDetection = false;
            this.musicProcessBar.AllowIncrementalClickMoves = true;
            this.musicProcessBar.AllowMouseDownEffects = false;
            this.musicProcessBar.AllowMouseHoverEffects = false;
            this.musicProcessBar.AllowScrollingAnimations = true;
            this.musicProcessBar.AllowScrollKeysDetection = true;
            this.musicProcessBar.AllowScrollOptionsMenu = true;
            this.musicProcessBar.AllowShrinkingOnFocusLost = false;
            this.musicProcessBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.musicProcessBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("musicProcessBar.BackgroundImage")));
            this.musicProcessBar.BindingContainer = null;
            this.musicProcessBar.BorderRadius = 2;
            this.musicProcessBar.BorderThickness = 1;
            this.musicProcessBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideMenuAni.SetDecoration(this.musicProcessBar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.musicProcessBar.DrawThickBorder = false;
            this.musicProcessBar.DurationBeforeShrink = 2000;
            this.musicProcessBar.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.musicProcessBar.LargeChange = 10;
            this.musicProcessBar.Location = new System.Drawing.Point(380, 83);
            this.musicProcessBar.Margin = new System.Windows.Forms.Padding(5);
            this.musicProcessBar.Maximum = 1000;
            this.musicProcessBar.Minimum = 0;
            this.musicProcessBar.MinimumSize = new System.Drawing.Size(0, 31);
            this.musicProcessBar.MinimumThumbLength = 18;
            this.musicProcessBar.Name = "musicProcessBar";
            this.musicProcessBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.musicProcessBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.musicProcessBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.musicProcessBar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.musicProcessBar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.musicProcessBar.ShrinkSizeLimit = 3;
            this.musicProcessBar.Size = new System.Drawing.Size(374, 31);
            this.musicProcessBar.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.musicProcessBar.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.musicProcessBar.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.musicProcessBar.SmallChange = 1;
            this.musicProcessBar.TabIndex = 13;
            this.musicProcessBar.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.musicProcessBar.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.musicProcessBar.ThumbLength = 18;
            this.musicProcessBar.ThumbMargin = 1;
            this.musicProcessBar.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.musicProcessBar.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.musicProcessBar.Value = 0;
            this.musicProcessBar.ValueChanged += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs>(this.musicProcessBar_ValueChanged);
            this.musicProcessBar.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.musicProcessBar_Scroll);
            this.musicProcessBar.Click += new System.EventHandler(this.musicProcessBar_Click);
            this.musicProcessBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.musicProcessBar_MouseDown);
            this.musicProcessBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.musicProcessBar_MouseMove);
            this.musicProcessBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.musicProcessBar_MouseUp);
            // 
            // songLength
            // 
            this.songLength.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.songLength.AutoSize = true;
            this.sideMenuAni.SetDecoration(this.songLength, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.songLength.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.songLength.Location = new System.Drawing.Point(762, 90);
            this.songLength.Name = "songLength";
            this.songLength.Size = new System.Drawing.Size(44, 17);
            this.songLength.TabIndex = 12;
            this.songLength.Text = "00:00";
            this.songLength.Click += new System.EventHandler(this.songLength_Click);
            // 
            // loopButton
            // 
            this.loopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sideMenuAni.SetDecoration(this.loopButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.loopButton.FlatAppearance.BorderSize = 0;
            this.loopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.loopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.loopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loopButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.loopButton.ImageIndex = 0;
            this.loopButton.ImageList = this.leapButtonList;
            this.loopButton.Location = new System.Drawing.Point(661, 41);
            this.loopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loopButton.Name = "loopButton";
            this.loopButton.Size = new System.Drawing.Size(32, 27);
            this.loopButton.TabIndex = 3;
            this.loopButton.UseVisualStyleBackColor = true;
            this.loopButton.Click += new System.EventHandler(this.loopButton_Click);
            this.loopButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loopButton_MouseDown);
            this.loopButton.MouseLeave += new System.EventHandler(this.loopButton_MouseLeave);
            this.loopButton.MouseHover += new System.EventHandler(this.loopButton_MouseHover);
            this.loopButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loopButton_MouseUp);
            // 
            // leapButtonList
            // 
            this.leapButtonList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("leapButtonList.ImageStream")));
            this.leapButtonList.TransparentColor = System.Drawing.Color.Transparent;
            this.leapButtonList.Images.SetKeyName(0, "icons8-repeat-30.png");
            this.leapButtonList.Images.SetKeyName(1, "icons8-repeat-30 (2).png");
            this.leapButtonList.Images.SetKeyName(2, "icons8-repeat-30.png");
            this.leapButtonList.Images.SetKeyName(3, "icons8-repeat-one-30 (2).png");
            this.leapButtonList.Images.SetKeyName(4, "icons8-repeat-30.png");
            this.leapButtonList.Images.SetKeyName(5, "icons8-repeat-one-30.png");
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sideMenuAni.SetDecoration(this.nextButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.nextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nextButton.ImageIndex = 0;
            this.nextButton.ImageList = this.nextButtonList;
            this.nextButton.Location = new System.Drawing.Point(614, 41);
            this.nextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(32, 27);
            this.nextButton.TabIndex = 4;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            this.nextButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nextButton_MouseDown);
            this.nextButton.MouseLeave += new System.EventHandler(this.nextButton_MouseLeave);
            this.nextButton.MouseHover += new System.EventHandler(this.nextButton_MouseHover);
            this.nextButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nextButton_MouseUp);
            // 
            // nextButtonList
            // 
            this.nextButtonList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("nextButtonList.ImageStream")));
            this.nextButtonList.TransparentColor = System.Drawing.Color.Transparent;
            this.nextButtonList.Images.SetKeyName(0, "icons8-end-30.png");
            this.nextButtonList.Images.SetKeyName(1, "icons8-end-30.png");
            this.nextButtonList.Images.SetKeyName(2, "icons8-end-30 (1).png");
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sideMenuAni.SetDecoration(this.backButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.ImageIndex = 0;
            this.backButton.ImageList = this.backButtonList;
            this.backButton.Location = new System.Drawing.Point(507, 41);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(32, 27);
            this.backButton.TabIndex = 6;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.backButton_MouseDown);
            this.backButton.MouseLeave += new System.EventHandler(this.backButton_MouseLeave);
            this.backButton.MouseHover += new System.EventHandler(this.backButton_MouseHover);
            this.backButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.backButton_MouseUp);
            // 
            // backButtonList
            // 
            this.backButtonList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("backButtonList.ImageStream")));
            this.backButtonList.TransparentColor = System.Drawing.Color.Transparent;
            this.backButtonList.Images.SetKeyName(0, "icons8-skip-to-start-30.png");
            this.backButtonList.Images.SetKeyName(1, "icons8-skip-to-start-30.png");
            this.backButtonList.Images.SetKeyName(2, "icons8-skip-to-start-30 (1).png");
            // 
            // randomButton
            // 
            this.randomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sideMenuAni.SetDecoration(this.randomButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.randomButton.FlatAppearance.BorderSize = 0;
            this.randomButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.randomButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.randomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomButton.ImageIndex = 0;
            this.randomButton.ImageList = this.shuffleButtonList;
            this.randomButton.Location = new System.Drawing.Point(456, 41);
            this.randomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(32, 27);
            this.randomButton.TabIndex = 7;
            this.randomButton.UseMnemonic = false;
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            this.randomButton.MouseLeave += new System.EventHandler(this.randomButton_MouseLeave);
            this.randomButton.MouseHover += new System.EventHandler(this.randomButton_MouseHover);
            // 
            // shuffleButtonList
            // 
            this.shuffleButtonList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("shuffleButtonList.ImageStream")));
            this.shuffleButtonList.TransparentColor = System.Drawing.Color.Transparent;
            this.shuffleButtonList.Images.SetKeyName(0, "icons8-shuffle-30.png");
            this.shuffleButtonList.Images.SetKeyName(1, "icons8-shuffle-30.png");
            this.shuffleButtonList.Images.SetKeyName(2, "icons8-shuffle-30 (1).png");
            this.shuffleButtonList.Images.SetKeyName(3, "icons8-shuffle-30 (2).png");
            // 
            // time
            // 
            this.time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time.AutoSize = true;
            this.sideMenuAni.SetDecoration(this.time, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.time.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.time.Location = new System.Drawing.Point(327, 90);
            this.time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(44, 17);
            this.time.TabIndex = 8;
            this.time.Text = "00:00";
            this.time.Click += new System.EventHandler(this.time_Click);
            // 
            // soundButton
            // 
            this.soundButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sideMenuAni.SetDecoration(this.soundButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.soundButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.soundButton.FlatAppearance.BorderSize = 0;
            this.soundButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.soundButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.soundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soundButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.soundButton.ImageIndex = 0;
            this.soundButton.ImageList = this.soundButtonList;
            this.soundButton.Location = new System.Drawing.Point(837, 40);
            this.soundButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soundButton.Name = "soundButton";
            this.soundButton.Size = new System.Drawing.Size(48, 34);
            this.soundButton.TabIndex = 2;
            this.soundButton.UseVisualStyleBackColor = true;
            this.soundButton.Click += new System.EventHandler(this.soundButton_Click);
            this.soundButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.soundButton_MouseDown);
            this.soundButton.MouseLeave += new System.EventHandler(this.soundButton_MouseLeave);
            this.soundButton.MouseHover += new System.EventHandler(this.soundButton_MouseHover);
            this.soundButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.soundButton_MouseUp);
            // 
            // soundButtonList
            // 
            this.soundButtonList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("soundButtonList.ImageStream")));
            this.soundButtonList.TransparentColor = System.Drawing.Color.Transparent;
            this.soundButtonList.Images.SetKeyName(0, "icons8-audio-30.png");
            this.soundButtonList.Images.SetKeyName(1, "icons8-low-volume-30.png");
            this.soundButtonList.Images.SetKeyName(2, "icons8-audio-30 (2).png");
            this.soundButtonList.Images.SetKeyName(3, "icons8-low-volume-30 (2).png");
            this.soundButtonList.Images.SetKeyName(4, "icons8-audio-30 (1).png");
            this.soundButtonList.Images.SetKeyName(5, "icons8-low-volume-30 (1).png");
            // 
            // muteButton
            // 
            this.muteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sideMenuAni.SetDecoration(this.muteButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.muteButton.Enabled = false;
            this.muteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.muteButton.FlatAppearance.BorderSize = 0;
            this.muteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.muteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.muteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.muteButton.ImageIndex = 0;
            this.muteButton.ImageList = this.muteButtonList;
            this.muteButton.Location = new System.Drawing.Point(837, 39);
            this.muteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(48, 34);
            this.muteButton.TabIndex = 2;
            this.muteButton.UseVisualStyleBackColor = true;
            this.muteButton.Visible = false;
            this.muteButton.Click += new System.EventHandler(this.muteButton_Click);
            this.muteButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.muteButton_MouseDown);
            this.muteButton.MouseLeave += new System.EventHandler(this.muteButton_MouseLeave);
            this.muteButton.MouseHover += new System.EventHandler(this.muteButton_MouseHover);
            this.muteButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.muteButton_MouseUp);
            // 
            // muteButtonList
            // 
            this.muteButtonList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("muteButtonList.ImageStream")));
            this.muteButtonList.TransparentColor = System.Drawing.Color.Transparent;
            this.muteButtonList.Images.SetKeyName(0, "icons8-no-audio-30.png");
            this.muteButtonList.Images.SetKeyName(1, "icons8-mute-30 (3).png");
            this.muteButtonList.Images.SetKeyName(2, "icons8-no-audio-30 (2).png");
            this.muteButtonList.Images.SetKeyName(3, "icons8-mute-30 (5).png");
            this.muteButtonList.Images.SetKeyName(4, "icons8-no-audio-30 (1).png");
            this.muteButtonList.Images.SetKeyName(5, "icons8-mute-30 (4).png");
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sideMenuAni.SetDecoration(this.playButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.ImageIndex = 0;
            this.playButton.ImageList = this.playButtonList;
            this.playButton.Location = new System.Drawing.Point(562, 41);
            this.playButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playButton.Name = "playButton";
            this.playButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playButton.Size = new System.Drawing.Size(32, 27);
            this.playButton.TabIndex = 5;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playButton_MouseDown);
            this.playButton.MouseLeave += new System.EventHandler(this.playButton_MouseLeave);
            this.playButton.MouseHover += new System.EventHandler(this.playButton_MouseHover);
            this.playButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.playButton_MouseUp);
            // 
            // playButtonList
            // 
            this.playButtonList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("playButtonList.ImageStream")));
            this.playButtonList.TransparentColor = System.Drawing.Color.Transparent;
            this.playButtonList.Images.SetKeyName(0, "icons8-play-30.png");
            this.playButtonList.Images.SetKeyName(1, "icons8-play-30 (1).png");
            this.playButtonList.Images.SetKeyName(2, "icons8-play-30.png");
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sideMenuAni.SetDecoration(this.stopButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.stopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.ImageIndex = 0;
            this.stopButton.ImageList = this.stopButtonList;
            this.stopButton.Location = new System.Drawing.Point(562, 43);
            this.stopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stopButton.Size = new System.Drawing.Size(32, 27);
            this.stopButton.TabIndex = 5;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            this.stopButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stopButton_MouseDown);
            this.stopButton.MouseLeave += new System.EventHandler(this.stopButton_MouseLeave);
            this.stopButton.MouseHover += new System.EventHandler(this.stopButton_MouseHover);
            this.stopButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.stopButton_MouseUp);
            // 
            // stopButtonList
            // 
            this.stopButtonList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("stopButtonList.ImageStream")));
            this.stopButtonList.TransparentColor = System.Drawing.Color.Transparent;
            this.stopButtonList.Images.SetKeyName(0, "icons8-pause-30 (1).png");
            this.stopButtonList.Images.SetKeyName(1, "icons8-pause-30 (2).png");
            this.stopButtonList.Images.SetKeyName(2, "icons8-pause-30.png");
            // 
            // controlImageList
            // 
            this.controlImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("controlImageList.ImageStream")));
            this.controlImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.controlImageList.Images.SetKeyName(0, "icons8-pause-30 (1).png");
            this.controlImageList.Images.SetKeyName(1, "icons8-play-30.png");
            this.controlImageList.Images.SetKeyName(2, "icons8-pause-30.png");
            this.controlImageList.Images.SetKeyName(3, "icons8-play-30.png");
            this.controlImageList.Images.SetKeyName(4, "icons8-pause-30 (2).png");
            this.controlImageList.Images.SetKeyName(5, "icons8-play-30 (1).png");
            // 
            // exitButtonList
            // 
            this.exitButtonList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("exitButtonList.ImageStream")));
            this.exitButtonList.TransparentColor = System.Drawing.Color.Transparent;
            this.exitButtonList.Images.SetKeyName(0, "icons8-delete-30 (1).png");
            this.exitButtonList.Images.SetKeyName(1, "icons8-delete-30 (2).png");
            // 
            // musicBarTimer
            // 
            this.musicBarTimer.Interval = 1000;
            this.musicBarTimer.Tick += new System.EventHandler(this.musicBarTimer_Tick);
            // 
            // timeSync
            // 
            this.timeSync.Interval = 1000;
            this.timeSync.Tick += new System.EventHandler(this.timeSync_Tick);
            // 
            // count
            // 
            this.count.Interval = 1000;
            this.count.Tick += new System.EventHandler(this.count_Tick);
            // 
            // sideMenuAni
            // 
            this.sideMenuAni.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide;
            this.sideMenuAni.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.sideMenuAni.DefaultAnimation = animation4;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.titlePanel.Controls.Add(this.cancelButton);
            this.titlePanel.Controls.Add(this.saveButton);
            this.titlePanel.Controls.Add(this.backwardButton);
            this.titlePanel.Controls.Add(this.label1);
            this.titlePanel.Controls.Add(this.exitButton);
            this.sideMenuAni.SetDecoration(this.titlePanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlePanel.Location = new System.Drawing.Point(264, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(4);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1083, 102);
            this.titlePanel.TabIndex = 5;
            // 
            // cancelButton
            // 
            this.cancelButton.AllowAnimations = true;
            this.cancelButton.AllowMouseEffects = true;
            this.cancelButton.AllowToggling = false;
            this.cancelButton.AnimationSpeed = 200;
            this.cancelButton.AutoGenerateColors = false;
            this.cancelButton.AutoRoundBorders = false;
            this.cancelButton.AutoSizeLeftIcon = true;
            this.cancelButton.AutoSizeRightIcon = true;
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.cancelButton.ButtonText = "Cancel";
            this.cancelButton.ButtonTextMarginLeft = 0;
            this.cancelButton.ColorContrastOnClick = 45;
            this.cancelButton.ColorContrastOnHover = 45;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.cancelButton.CustomizableEdges = borderEdges7;
            this.sideMenuAni.SetDecoration(this.cancelButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cancelButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.cancelButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cancelButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.cancelButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.cancelButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.cancelButton.IconMarginLeft = 11;
            this.cancelButton.IconPadding = 10;
            this.cancelButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.cancelButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.cancelButton.IconSize = 25;
            this.cancelButton.IdleBorderColor = System.Drawing.Color.Purple;
            this.cancelButton.IdleBorderRadius = 1;
            this.cancelButton.IdleBorderThickness = 1;
            this.cancelButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cancelButton.IdleIconLeftImage = null;
            this.cancelButton.IdleIconRightImage = null;
            this.cancelButton.IndicateFocus = false;
            this.cancelButton.Location = new System.Drawing.Point(736, 56);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.cancelButton.OnDisabledState.BorderRadius = 1;
            this.cancelButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.cancelButton.OnDisabledState.BorderThickness = 1;
            this.cancelButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cancelButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.cancelButton.OnDisabledState.IconLeftImage = null;
            this.cancelButton.OnDisabledState.IconRightImage = null;
            this.cancelButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.cancelButton.onHoverState.BorderRadius = 1;
            this.cancelButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.cancelButton.onHoverState.BorderThickness = 1;
            this.cancelButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.cancelButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.cancelButton.onHoverState.IconLeftImage = null;
            this.cancelButton.onHoverState.IconRightImage = null;
            this.cancelButton.OnIdleState.BorderColor = System.Drawing.Color.Purple;
            this.cancelButton.OnIdleState.BorderRadius = 1;
            this.cancelButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.cancelButton.OnIdleState.BorderThickness = 1;
            this.cancelButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cancelButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.cancelButton.OnIdleState.IconLeftImage = null;
            this.cancelButton.OnIdleState.IconRightImage = null;
            this.cancelButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.cancelButton.OnPressedState.BorderRadius = 1;
            this.cancelButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.cancelButton.OnPressedState.BorderThickness = 1;
            this.cancelButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.cancelButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.cancelButton.OnPressedState.IconLeftImage = null;
            this.cancelButton.OnPressedState.IconRightImage = null;
            this.cancelButton.Size = new System.Drawing.Size(124, 29);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.cancelButton.TextMarginLeft = 0;
            this.cancelButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.cancelButton.UseDefaultRadiusAndThickness = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.AllowAnimations = true;
            this.saveButton.AllowMouseEffects = true;
            this.saveButton.AllowToggling = false;
            this.saveButton.AnimationSpeed = 200;
            this.saveButton.AutoGenerateColors = false;
            this.saveButton.AutoRoundBorders = false;
            this.saveButton.AutoSizeLeftIcon = true;
            this.saveButton.AutoSizeRightIcon = true;
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.saveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveButton.BackgroundImage")));
            this.saveButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveButton.ButtonText = "Save";
            this.saveButton.ButtonTextMarginLeft = 0;
            this.saveButton.ColorContrastOnClick = 45;
            this.saveButton.ColorContrastOnHover = 45;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.saveButton.CustomizableEdges = borderEdges8;
            this.sideMenuAni.SetDecoration(this.saveButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.saveButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.saveButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.saveButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.saveButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.saveButton.IconMarginLeft = 11;
            this.saveButton.IconPadding = 10;
            this.saveButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.saveButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.saveButton.IconSize = 25;
            this.saveButton.IdleBorderColor = System.Drawing.Color.Purple;
            this.saveButton.IdleBorderRadius = 1;
            this.saveButton.IdleBorderThickness = 1;
            this.saveButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.saveButton.IdleIconLeftImage = null;
            this.saveButton.IdleIconRightImage = null;
            this.saveButton.IndicateFocus = false;
            this.saveButton.Location = new System.Drawing.Point(886, 56);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.saveButton.OnDisabledState.BorderRadius = 1;
            this.saveButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveButton.OnDisabledState.BorderThickness = 1;
            this.saveButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.saveButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.saveButton.OnDisabledState.IconLeftImage = null;
            this.saveButton.OnDisabledState.IconRightImage = null;
            this.saveButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.saveButton.onHoverState.BorderRadius = 1;
            this.saveButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveButton.onHoverState.BorderThickness = 1;
            this.saveButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.saveButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.saveButton.onHoverState.IconLeftImage = null;
            this.saveButton.onHoverState.IconRightImage = null;
            this.saveButton.OnIdleState.BorderColor = System.Drawing.Color.Purple;
            this.saveButton.OnIdleState.BorderRadius = 1;
            this.saveButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveButton.OnIdleState.BorderThickness = 1;
            this.saveButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.saveButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.saveButton.OnIdleState.IconLeftImage = null;
            this.saveButton.OnIdleState.IconRightImage = null;
            this.saveButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.saveButton.OnPressedState.BorderRadius = 1;
            this.saveButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveButton.OnPressedState.BorderThickness = 1;
            this.saveButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.saveButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.saveButton.OnPressedState.IconLeftImage = null;
            this.saveButton.OnPressedState.IconRightImage = null;
            this.saveButton.Size = new System.Drawing.Size(124, 29);
            this.saveButton.TabIndex = 14;
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.saveButton.TextMarginLeft = 0;
            this.saveButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.saveButton.UseDefaultRadiusAndThickness = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // backwardButton
            // 
            this.backwardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sideMenuAni.SetDecoration(this.backwardButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.backwardButton.FlatAppearance.BorderSize = 0;
            this.backwardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.backwardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.backwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backwardButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backwardButton.ImageIndex = 0;
            this.backwardButton.ImageList = this.backwardButtonList;
            this.backwardButton.Location = new System.Drawing.Point(49, 36);
            this.backwardButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backwardButton.Name = "backwardButton";
            this.backwardButton.Size = new System.Drawing.Size(54, 27);
            this.backwardButton.TabIndex = 8;
            this.backwardButton.UseVisualStyleBackColor = true;
            this.backwardButton.Click += new System.EventHandler(this.backwardButton_Click);
            this.backwardButton.MouseEnter += new System.EventHandler(this.backwardButton_MouseEnter);
            this.backwardButton.MouseLeave += new System.EventHandler(this.backwardButton_MouseLeave);
            // 
            // backwardButtonList
            // 
            this.backwardButtonList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("backwardButtonList.ImageStream")));
            this.backwardButtonList.TransparentColor = System.Drawing.Color.Transparent;
            this.backwardButtonList.Images.SetKeyName(0, "icons8-arrow-pointing-left-60 (2).png");
            this.backwardButtonList.Images.SetKeyName(1, "icons8-arrow-pointing-left-60 (1).png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.sideMenuAni.SetDecoration(this.label1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(-4, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 7;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sideMenuAni.SetDecoration(this.exitButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ImageIndex = 0;
            this.exitButton.ImageList = this.exitButtonList;
            this.exitButton.Location = new System.Drawing.Point(1032, 12);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(40, 34);
            this.exitButton.TabIndex = 4;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            this.exitButton.MouseHover += new System.EventHandler(this.exitButton_MouseHover);
            // 
            // mainMidPanel
            // 
            this.mainMidPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.mainMidPanel.Controls.Add(this.mainPicturebox);
            this.sideMenuAni.SetDecoration(this.mainMidPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.mainMidPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMidPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMidPanel.Location = new System.Drawing.Point(264, 102);
            this.mainMidPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainMidPanel.Name = "mainMidPanel";
            this.mainMidPanel.Size = new System.Drawing.Size(1083, 461);
            this.mainMidPanel.TabIndex = 6;
            // 
            // mainPicturebox
            // 
            this.mainPicturebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sideMenuAni.SetDecoration(this.mainPicturebox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.mainPicturebox.Image = global::GUI.Properties.Resources.icons8_musical_notes_96;
            this.mainPicturebox.Location = new System.Drawing.Point(520, 189);
            this.mainPicturebox.Margin = new System.Windows.Forms.Padding(4);
            this.mainPicturebox.Name = "mainPicturebox";
            this.mainPicturebox.Size = new System.Drawing.Size(116, 117);
            this.mainPicturebox.TabIndex = 0;
            this.mainPicturebox.TabStop = false;
            this.mainPicturebox.Click += new System.EventHandler(this.mainPicturebox_Click);
            // 
            // dragControl
            // 
            this.dragControl.Fixed = true;
            this.dragControl.Horizontal = true;
            this.dragControl.TargetControl = this.titlePanel;
            this.dragControl.Vertical = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1347, 685);
            this.Controls.Add(this.mainMidPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.mainBotPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.sideMenuAni.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.BottomMirror);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1363, 724);
            this.Name = "MainForm";
            this.Text = " Media Player";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sideMenuPanel.ResumeLayout(false);
            this.iconPanel.ResumeLayout(false);
            this.mediaSubMenu.ResumeLayout(false);
            this.playlistSubMenu.ResumeLayout(false);
            this.imageSubMenu.ResumeLayout(false);
            this.videoSubMenu.ResumeLayout(false);
            this.mainBotPanel.ResumeLayout(false);
            this.mainBotPanel.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.mainMidPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sideMenuPanel;
        private System.Windows.Forms.Button mediaButton;
        private System.Windows.Forms.Panel mediaSubMenu;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button playlistButton;
        private System.Windows.Forms.Panel playlistSubMenu;
        private System.Windows.Forms.Button pictureButton;
        private System.Windows.Forms.Button videoButton;
        private System.Windows.Forms.Panel imageSubMenu;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Panel mainBotPanel;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button soundButton;
        private System.Windows.Forms.Button loopButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.ImageList controlImageList;
        private System.Windows.Forms.ImageList backButtonList;
        private System.Windows.Forms.ImageList shuffleButtonList;
        private System.Windows.Forms.ImageList leapButtonList;
        private System.Windows.Forms.ImageList nextButtonList;
        private System.Windows.Forms.ImageList exitButtonList;
        private System.Windows.Forms.ImageList menuButtonList;
        private System.Windows.Forms.Panel iconPanel;
        private System.Windows.Forms.Button sideMenuButton;
        private System.Windows.Forms.Timer musicBarTimer  ;
        private System.Windows.Forms.Timer timeSync;
        private System.Windows.Forms.Label songLength;
        private System.Windows.Forms.Timer count;
        private System.Windows.Forms.Button createPlaylist;
        private Bunifu.UI.WinForms.BunifuHSlider musicProcessBar;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ImageList stopButtonList;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.ImageList playButtonList;
        private System.Windows.Forms.Button muteButton;
        private System.Windows.Forms.ImageList muteButtonList;
        private System.Windows.Forms.ImageList soundButtonList;
        private Bunifu.UI.WinForms.BunifuTransition sideMenuAni;
        private Bunifu.Framework.UI.BunifuDragControl dragControl;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel mainMidPanel;
        private System.Windows.Forms.PictureBox mainPicturebox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button backwardButton;
        private System.Windows.Forms.ImageList backwardButtonList;
        private System.Windows.Forms.Panel videoSubMenu;
        private System.Windows.Forms.Button playURLButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button openMusicFolderButton;
        private Bunifu.UI.WinForms.BunifuHSlider soundVolumeBar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton cancelButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton saveButton;
    }
}

