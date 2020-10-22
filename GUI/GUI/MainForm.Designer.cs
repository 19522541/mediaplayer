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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sideMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.iconPanel = new System.Windows.Forms.Panel();
            this.sideMenuButton = new System.Windows.Forms.Button();
            this.menuButtonList = new System.Windows.Forms.ImageList(this.components);
            this.mediaButton = new System.Windows.Forms.Button();
            this.mediaSubMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.playlistButton = new System.Windows.Forms.Button();
            this.playlistSubMenu = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.pictureButton = new System.Windows.Forms.Button();
            this.videoButton = new System.Windows.Forms.Button();
            this.videoSubMenu = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.mainBotPanel = new System.Windows.Forms.Panel();
            this.musicProcessBar = new Bunifu.UI.WinForms.BunifuHSlider();
            this.songLength = new System.Windows.Forms.Label();
            this.soundVolumeBar = new Siticone.UI.WinForms.SiticoneSlider();
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
            this.playButton = new System.Windows.Forms.Button();
            this.playButtonList = new System.Windows.Forms.ImageList(this.components);
            this.stopButton = new System.Windows.Forms.Button();
            this.stopButtonList = new System.Windows.Forms.ImageList(this.components);
            this.controlImageList = new System.Windows.Forms.ImageList(this.components);
            this.titlePanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.exitButtonList = new System.Windows.Forms.ImageList(this.components);
            this.musicBarTimer = new System.Windows.Forms.Timer(this.components);
            this.timeSync = new System.Windows.Forms.Timer(this.components);
            this.count = new System.Windows.Forms.Timer(this.components);
            this.mainPicturebox = new System.Windows.Forms.PictureBox();
            this.songName = new System.Windows.Forms.Label();
            this.mainMidPanel = new System.Windows.Forms.Panel();
            this.sideMenuPanel.SuspendLayout();
            this.iconPanel.SuspendLayout();
            this.mediaSubMenu.SuspendLayout();
            this.playlistSubMenu.SuspendLayout();
            this.videoSubMenu.SuspendLayout();
            this.mainBotPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicturebox)).BeginInit();
            this.mainMidPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.AutoScroll = true;
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.sideMenuPanel.Controls.Add(this.iconPanel);
            this.sideMenuPanel.Controls.Add(this.mediaButton);
            this.sideMenuPanel.Controls.Add(this.mediaSubMenu);
            this.sideMenuPanel.Controls.Add(this.playlistButton);
            this.sideMenuPanel.Controls.Add(this.playlistSubMenu);
            this.sideMenuPanel.Controls.Add(this.pictureButton);
            this.sideMenuPanel.Controls.Add(this.videoButton);
            this.sideMenuPanel.Controls.Add(this.videoSubMenu);
            this.sideMenuPanel.Controls.Add(this.helpButton);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(264, 1053);
            this.sideMenuPanel.TabIndex = 0;
            // 
            // iconPanel
            // 
            this.iconPanel.Controls.Add(this.sideMenuButton);
            this.iconPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconPanel.Location = new System.Drawing.Point(3, 2);
            this.iconPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPanel.Name = "iconPanel";
            this.iconPanel.Size = new System.Drawing.Size(251, 100);
            this.iconPanel.TabIndex = 0;
            // 
            // sideMenuButton
            // 
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
            this.mediaButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mediaButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.mediaButton.FlatAppearance.BorderSize = 0;
            this.mediaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(110)))));
            this.mediaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediaButton.ForeColor = System.Drawing.SystemColors.InactiveCaption;
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
            this.mediaSubMenu.Controls.Add(this.button4);
            this.mediaSubMenu.Controls.Add(this.button3);
            this.mediaSubMenu.Controls.Add(this.button2);
            this.mediaSubMenu.Controls.Add(this.openButton);
            this.mediaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.mediaSubMenu.Location = new System.Drawing.Point(3, 156);
            this.mediaSubMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mediaSubMenu.Name = "mediaSubMenu";
            this.mediaSubMenu.Size = new System.Drawing.Size(251, 162);
            this.mediaSubMenu.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.Location = new System.Drawing.Point(0, 117);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(251, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Location = new System.Drawing.Point(0, 78);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(251, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Location = new System.Drawing.Point(0, 39);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(251, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // openButton
            // 
            this.openButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.openButton.FlatAppearance.BorderSize = 0;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.openButton.Location = new System.Drawing.Point(0, 0);
            this.openButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openButton.Name = "openButton";
            this.openButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.openButton.Size = new System.Drawing.Size(251, 39);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "&Open";
            this.openButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // playlistButton
            // 
            this.playlistButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.playlistButton.FlatAppearance.BorderSize = 0;
            this.playlistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playlistButton.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.playlistButton.Image = ((System.Drawing.Image)(resources.GetObject("playlistButton.Image")));
            this.playlistButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playlistButton.Location = new System.Drawing.Point(3, 322);
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
            this.playlistSubMenu.Controls.Add(this.button9);
            this.playlistSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.playlistSubMenu.Location = new System.Drawing.Point(3, 372);
            this.playlistSubMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playlistSubMenu.Name = "playlistSubMenu";
            this.playlistSubMenu.Size = new System.Drawing.Size(251, 43);
            this.playlistSubMenu.TabIndex = 4;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(251, 39);
            this.button9.TabIndex = 0;
            this.button9.Text = "button9";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // pictureButton
            // 
            this.pictureButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureButton.FlatAppearance.BorderSize = 0;
            this.pictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pictureButton.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureButton.Image = ((System.Drawing.Image)(resources.GetObject("pictureButton.Image")));
            this.pictureButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pictureButton.Location = new System.Drawing.Point(3, 419);
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
            // videoButton
            // 
            this.videoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.videoButton.FlatAppearance.BorderSize = 0;
            this.videoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videoButton.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.videoButton.Image = ((System.Drawing.Image)(resources.GetObject("videoButton.Image")));
            this.videoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.videoButton.Location = new System.Drawing.Point(3, 469);
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
            this.videoSubMenu.Controls.Add(this.button12);
            this.videoSubMenu.Controls.Add(this.button13);
            this.videoSubMenu.Controls.Add(this.button14);
            this.videoSubMenu.Controls.Add(this.button15);
            this.videoSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.videoSubMenu.Location = new System.Drawing.Point(3, 519);
            this.videoSubMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.videoSubMenu.Name = "videoSubMenu";
            this.videoSubMenu.Size = new System.Drawing.Size(251, 162);
            this.videoSubMenu.TabIndex = 7;
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button12.Location = new System.Drawing.Point(0, 117);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(251, 39);
            this.button12.TabIndex = 3;
            this.button12.Text = "button12";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Top;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button13.Location = new System.Drawing.Point(0, 78);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button13.Size = new System.Drawing.Size(251, 39);
            this.button13.TabIndex = 2;
            this.button13.Text = "button13";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Top;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button14.Location = new System.Drawing.Point(0, 39);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button14.Name = "button14";
            this.button14.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button14.Size = new System.Drawing.Size(251, 39);
            this.button14.TabIndex = 1;
            this.button14.Text = "button14";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
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
            this.button15.Text = "button15";
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // helpButton
            // 
            this.helpButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
            this.helpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpButton.Location = new System.Drawing.Point(3, 685);
            this.helpButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.helpButton.Name = "helpButton";
            this.helpButton.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.helpButton.Size = new System.Drawing.Size(251, 46);
            this.helpButton.TabIndex = 8;
            this.helpButton.Text = "Help";
            this.helpButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.MouseLeave += new System.EventHandler(this.helpButton_MouseLeave);
            this.helpButton.MouseHover += new System.EventHandler(this.helpButton_MouseHover);
            // 
            // mainBotPanel
            // 
            this.mainBotPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.mainBotPanel.Controls.Add(this.musicProcessBar);
            this.mainBotPanel.Controls.Add(this.songLength);
            this.mainBotPanel.Controls.Add(this.soundVolumeBar);
            this.mainBotPanel.Controls.Add(this.loopButton);
            this.mainBotPanel.Controls.Add(this.nextButton);
            this.mainBotPanel.Controls.Add(this.backButton);
            this.mainBotPanel.Controls.Add(this.randomButton);
            this.mainBotPanel.Controls.Add(this.time);
            this.mainBotPanel.Controls.Add(this.soundButton);
            this.mainBotPanel.Controls.Add(this.playButton);
            this.mainBotPanel.Controls.Add(this.stopButton);
            this.mainBotPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainBotPanel.Location = new System.Drawing.Point(264, 923);
            this.mainBotPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainBotPanel.Name = "mainBotPanel";
            this.mainBotPanel.Size = new System.Drawing.Size(1318, 130);
            this.mainBotPanel.TabIndex = 1;
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
            this.musicProcessBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.musicProcessBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("musicProcessBar.BackgroundImage")));
            this.musicProcessBar.BindingContainer = null;
            this.musicProcessBar.BorderRadius = 2;
            this.musicProcessBar.BorderThickness = 1;
            this.musicProcessBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musicProcessBar.DrawThickBorder = false;
            this.musicProcessBar.DurationBeforeShrink = 2000;
            this.musicProcessBar.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.musicProcessBar.LargeChange = 10;
            this.musicProcessBar.Location = new System.Drawing.Point(334, 86);
            this.musicProcessBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.musicProcessBar.Size = new System.Drawing.Size(751, 31);
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
            this.musicProcessBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.musicProcessBar_MouseDown);
            this.musicProcessBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.musicProcessBar_MouseUp);
            // 
            // songLength
            // 
            this.songLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.songLength.AutoSize = true;
            this.songLength.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.songLength.Location = new System.Drawing.Point(1092, 93);
            this.songLength.Name = "songLength";
            this.songLength.Size = new System.Drawing.Size(44, 17);
            this.songLength.TabIndex = 12;
            this.songLength.Text = "00:00";
            // 
            // soundVolumeBar
            // 
            this.soundVolumeBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.soundVolumeBar.Location = new System.Drawing.Point(334, 20);
            this.soundVolumeBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soundVolumeBar.Name = "soundVolumeBar";
            this.soundVolumeBar.Size = new System.Drawing.Size(162, 60);
            this.soundVolumeBar.TabIndex = 11;
            this.soundVolumeBar.Value = 50;
            this.soundVolumeBar.Scroll += new System.EventHandler(this.soundVolumeBar_Scroll);
            // 
            // loopButton
            // 
            this.loopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.loopButton.FlatAppearance.BorderSize = 0;
            this.loopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.loopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.loopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loopButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.loopButton.ImageIndex = 0;
            this.loopButton.ImageList = this.leapButtonList;
            this.loopButton.Location = new System.Drawing.Point(834, 38);
            this.loopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loopButton.Name = "loopButton";
            this.loopButton.Size = new System.Drawing.Size(32, 27);
            this.loopButton.TabIndex = 3;
            this.loopButton.UseVisualStyleBackColor = true;
            this.loopButton.Click += new System.EventHandler(this.loopButton_Click);
            // 
            // leapButtonList
            // 
            this.leapButtonList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("leapButtonList.ImageStream")));
            this.leapButtonList.TransparentColor = System.Drawing.Color.Transparent;
            this.leapButtonList.Images.SetKeyName(0, "icons8-repeat-30.png");
            this.leapButtonList.Images.SetKeyName(1, "icons8-repeat-30.png");
            this.leapButtonList.Images.SetKeyName(2, "icons8-repeat-one-30 (2).png");
            this.leapButtonList.Images.SetKeyName(3, "icons8-repeat-one-30 (1).png");
            this.leapButtonList.Images.SetKeyName(4, "icons8-repeat-one-30.png");
            this.leapButtonList.Images.SetKeyName(5, "icons8-repeat-30 (2).png");
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.nextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nextButton.ImageIndex = 0;
            this.nextButton.ImageList = this.nextButtonList;
            this.nextButton.Location = new System.Drawing.Point(777, 38);
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
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.ImageIndex = 0;
            this.backButton.ImageList = this.backButtonList;
            this.backButton.Location = new System.Drawing.Point(664, 38);
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
            this.randomButton.FlatAppearance.BorderSize = 0;
            this.randomButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.randomButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.randomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomButton.ImageIndex = 0;
            this.randomButton.ImageList = this.shuffleButtonList;
            this.randomButton.Location = new System.Drawing.Point(602, 38);
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
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.time.AutoSize = true;
            this.time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time.Location = new System.Drawing.Point(282, 93);
            this.time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(44, 17);
            this.time.TabIndex = 8;
            this.time.Text = "00:00";
            // 
            // soundButton
            // 
            this.soundButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.soundButton.FlatAppearance.BorderSize = 0;
            this.soundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soundButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.soundButton.Image = global::GUI.Properties.Resources.icons8_audio_30;
            this.soundButton.Location = new System.Drawing.Point(285, 38);
            this.soundButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soundButton.Name = "soundButton";
            this.soundButton.Size = new System.Drawing.Size(48, 22);
            this.soundButton.TabIndex = 2;
            this.soundButton.UseVisualStyleBackColor = true;
            this.soundButton.Click += new System.EventHandler(this.soundButton_Click);
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.ImageIndex = 0;
            this.playButton.ImageList = this.playButtonList;
            this.playButton.Location = new System.Drawing.Point(722, 38);
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
            this.stopButton.Enabled = false;
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.stopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.ImageIndex = 0;
            this.stopButton.ImageList = this.stopButtonList;
            this.stopButton.Location = new System.Drawing.Point(722, 38);
            this.stopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stopButton.Size = new System.Drawing.Size(32, 27);
            this.stopButton.TabIndex = 5;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Visible = false;
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
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.titlePanel.Controls.Add(this.exitButton);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(264, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(4);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1318, 62);
            this.titlePanel.TabIndex = 3;
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ImageIndex = 0;
            this.exitButton.ImageList = this.exitButtonList;
            this.exitButton.Location = new System.Drawing.Point(1267, 12);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(40, 34);
            this.exitButton.TabIndex = 4;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            this.exitButton.MouseHover += new System.EventHandler(this.exitButton_MouseHover);
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
            // mainPicturebox
            // 
            this.mainPicturebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPicturebox.Image = global::GUI.Properties.Resources.icons8_musical_notes_96;
            this.mainPicturebox.Location = new System.Drawing.Point(638, 432);
            this.mainPicturebox.Margin = new System.Windows.Forms.Padding(4);
            this.mainPicturebox.Name = "mainPicturebox";
            this.mainPicturebox.Size = new System.Drawing.Size(116, 117);
            this.mainPicturebox.TabIndex = 0;
            this.mainPicturebox.TabStop = false;
            // 
            // songName
            // 
            this.songName.AutoSize = true;
            this.songName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.songName.Location = new System.Drawing.Point(6, 66);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(46, 17);
            this.songName.TabIndex = 1;
            this.songName.Text = "label1";
            // 
            // mainMidPanel
            // 
            this.mainMidPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.mainMidPanel.Controls.Add(this.songName);
            this.mainMidPanel.Controls.Add(this.mainPicturebox);
            this.mainMidPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMidPanel.Location = new System.Drawing.Point(264, 0);
            this.mainMidPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainMidPanel.Name = "mainMidPanel";
            this.mainMidPanel.Size = new System.Drawing.Size(1318, 923);
            this.mainMidPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1582, 1053);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.mainMidPanel);
            this.Controls.Add(this.mainBotPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1500, 1000);
            this.Name = "MainForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sideMenuPanel.ResumeLayout(false);
            this.iconPanel.ResumeLayout(false);
            this.mediaSubMenu.ResumeLayout(false);
            this.playlistSubMenu.ResumeLayout(false);
            this.videoSubMenu.ResumeLayout(false);
            this.mainBotPanel.ResumeLayout(false);
            this.mainBotPanel.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPicturebox)).EndInit();
            this.mainMidPanel.ResumeLayout(false);
            this.mainMidPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sideMenuPanel;
        private System.Windows.Forms.Button mediaButton;
        private System.Windows.Forms.Panel mediaSubMenu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button playlistButton;
        private System.Windows.Forms.Panel playlistSubMenu;
        private System.Windows.Forms.Button pictureButton;
        private System.Windows.Forms.Button videoButton;
        private System.Windows.Forms.Panel videoSubMenu;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Panel mainBotPanel;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button soundButton;
        private System.Windows.Forms.Button loopButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.ImageList controlImageList;
        private System.Windows.Forms.ImageList backButtonList;
        private System.Windows.Forms.ImageList shuffleButtonList;
        private System.Windows.Forms.ImageList leapButtonList;
        private System.Windows.Forms.ImageList nextButtonList;
        private System.Windows.Forms.ImageList exitButtonList;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ImageList menuButtonList;
        private System.Windows.Forms.Panel iconPanel;
        private System.Windows.Forms.Button sideMenuButton;
        private Siticone.UI.WinForms.SiticoneSlider soundVolumeBar;
        private System.Windows.Forms.Timer musicBarTimer  ;
        private System.Windows.Forms.Timer timeSync;
        private System.Windows.Forms.Label songLength;
        private System.Windows.Forms.Timer count;
        private System.Windows.Forms.Button button9;
        private Bunifu.UI.WinForms.BunifuHSlider musicProcessBar;
        private System.Windows.Forms.PictureBox mainPicturebox;
        private System.Windows.Forms.Label songName;
        private System.Windows.Forms.Panel mainMidPanel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ImageList stopButtonList;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.ImageList playButtonList;
    }
}

