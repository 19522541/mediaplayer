namespace GUI
{
    partial class VideoPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlayer));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges13 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges14 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.videoView = new LibVLCSharp.WinForms.VideoView();
            this.hamburgerButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.playButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.backwardButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.forwardButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.stopButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.exitButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.titlePanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.maximizeButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.restoredownButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.pauseButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.videoProgressBar = new Bunifu.UI.WinForms.BunifuHSlider();
            this.videoTimer = new System.Windows.Forms.Timer(this.components);
            this.bottomPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.soundButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.videoLength = new Bunifu.UI.WinForms.BunifuLabel();
            this.videoTime = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuHSlider1 = new Bunifu.UI.WinForms.BunifuHSlider();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.hamburgerMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.addSubtitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            this.hamburgerMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoView
            // 
            this.videoView.BackColor = System.Drawing.Color.Black;
            this.videoView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView.Location = new System.Drawing.Point(0, 0);
            this.videoView.MediaPlayer = null;
            this.videoView.Name = "videoView";
            this.videoView.Size = new System.Drawing.Size(907, 371);
            this.videoView.TabIndex = 0;
            this.videoView.Text = "videoView1";
            // 
            // hamburgerButton
            // 
            this.hamburgerButton.AllowAnimations = true;
            this.hamburgerButton.AllowMouseEffects = true;
            this.hamburgerButton.AllowToggling = false;
            this.hamburgerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hamburgerButton.AnimationSpeed = 200;
            this.hamburgerButton.AutoGenerateColors = false;
            this.hamburgerButton.AutoRoundBorders = false;
            this.hamburgerButton.AutoSizeLeftIcon = true;
            this.hamburgerButton.AutoSizeRightIcon = true;
            this.hamburgerButton.BackColor = System.Drawing.Color.Transparent;
            this.hamburgerButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.hamburgerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hamburgerButton.BackgroundImage")));
            this.hamburgerButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hamburgerButton.ButtonText = "ham";
            this.hamburgerButton.ButtonTextMarginLeft = 0;
            this.hamburgerButton.ColorContrastOnClick = 45;
            this.hamburgerButton.ColorContrastOnHover = 45;
            this.hamburgerButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.hamburgerButton.CustomizableEdges = borderEdges8;
            this.hamburgerButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.hamburgerButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.hamburgerButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.hamburgerButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.hamburgerButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.hamburgerButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hamburgerButton.ForeColor = System.Drawing.Color.White;
            this.hamburgerButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hamburgerButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.hamburgerButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.hamburgerButton.IconMarginLeft = 11;
            this.hamburgerButton.IconPadding = 10;
            this.hamburgerButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hamburgerButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.hamburgerButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.hamburgerButton.IconSize = 25;
            this.hamburgerButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.hamburgerButton.IdleBorderRadius = 1;
            this.hamburgerButton.IdleBorderThickness = 1;
            this.hamburgerButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.hamburgerButton.IdleIconLeftImage = null;
            this.hamburgerButton.IdleIconRightImage = null;
            this.hamburgerButton.IndicateFocus = false;
            this.hamburgerButton.Location = new System.Drawing.Point(852, 3);
            this.hamburgerButton.Name = "hamburgerButton";
            this.hamburgerButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.hamburgerButton.OnDisabledState.BorderRadius = 1;
            this.hamburgerButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hamburgerButton.OnDisabledState.BorderThickness = 1;
            this.hamburgerButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.hamburgerButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.hamburgerButton.OnDisabledState.IconLeftImage = null;
            this.hamburgerButton.OnDisabledState.IconRightImage = null;
            this.hamburgerButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.hamburgerButton.onHoverState.BorderRadius = 1;
            this.hamburgerButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hamburgerButton.onHoverState.BorderThickness = 1;
            this.hamburgerButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.hamburgerButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.hamburgerButton.onHoverState.IconLeftImage = null;
            this.hamburgerButton.onHoverState.IconRightImage = null;
            this.hamburgerButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.hamburgerButton.OnIdleState.BorderRadius = 1;
            this.hamburgerButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hamburgerButton.OnIdleState.BorderThickness = 1;
            this.hamburgerButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.hamburgerButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.hamburgerButton.OnIdleState.IconLeftImage = null;
            this.hamburgerButton.OnIdleState.IconRightImage = null;
            this.hamburgerButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.hamburgerButton.OnPressedState.BorderRadius = 1;
            this.hamburgerButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hamburgerButton.OnPressedState.BorderThickness = 1;
            this.hamburgerButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.hamburgerButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.hamburgerButton.OnPressedState.IconLeftImage = null;
            this.hamburgerButton.OnPressedState.IconRightImage = null;
            this.hamburgerButton.Size = new System.Drawing.Size(48, 45);
            this.hamburgerButton.TabIndex = 5;
            this.hamburgerButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hamburgerButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.hamburgerButton.TextMarginLeft = 0;
            this.hamburgerButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.hamburgerButton.UseDefaultRadiusAndThickness = true;
            this.hamburgerButton.Click += new System.EventHandler(this.hamburgerButton_Click);
            // 
            // playButton
            // 
            this.playButton.AllowAnimations = true;
            this.playButton.AllowMouseEffects = true;
            this.playButton.AllowToggling = false;
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playButton.AnimationSpeed = 200;
            this.playButton.AutoGenerateColors = false;
            this.playButton.AutoRoundBorders = false;
            this.playButton.AutoSizeLeftIcon = true;
            this.playButton.AutoSizeRightIcon = true;
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.playButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playButton.BackgroundImage")));
            this.playButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.playButton.ButtonText = "bunifuButton5";
            this.playButton.ButtonTextMarginLeft = 0;
            this.playButton.ColorContrastOnClick = 45;
            this.playButton.ColorContrastOnHover = 45;
            this.playButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges9.BottomLeft = true;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = true;
            borderEdges9.TopRight = true;
            this.playButton.CustomizableEdges = borderEdges9;
            this.playButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.playButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.playButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.playButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.playButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.playButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.playButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.playButton.IconMarginLeft = 11;
            this.playButton.IconPadding = 10;
            this.playButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.playButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.playButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.playButton.IconSize = 25;
            this.playButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.playButton.IdleBorderRadius = 1;
            this.playButton.IdleBorderThickness = 1;
            this.playButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.playButton.IdleIconLeftImage = null;
            this.playButton.IdleIconRightImage = null;
            this.playButton.IndicateFocus = false;
            this.playButton.Location = new System.Drawing.Point(423, 3);
            this.playButton.Name = "playButton";
            this.playButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.playButton.OnDisabledState.BorderRadius = 1;
            this.playButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.playButton.OnDisabledState.BorderThickness = 1;
            this.playButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.playButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.playButton.OnDisabledState.IconLeftImage = null;
            this.playButton.OnDisabledState.IconRightImage = null;
            this.playButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.playButton.onHoverState.BorderRadius = 1;
            this.playButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.playButton.onHoverState.BorderThickness = 1;
            this.playButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.playButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.playButton.onHoverState.IconLeftImage = null;
            this.playButton.onHoverState.IconRightImage = null;
            this.playButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.playButton.OnIdleState.BorderRadius = 1;
            this.playButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.playButton.OnIdleState.BorderThickness = 1;
            this.playButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.playButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.playButton.OnIdleState.IconLeftImage = null;
            this.playButton.OnIdleState.IconRightImage = null;
            this.playButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.playButton.OnPressedState.BorderRadius = 1;
            this.playButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.playButton.OnPressedState.BorderThickness = 1;
            this.playButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.playButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.playButton.OnPressedState.IconLeftImage = null;
            this.playButton.OnPressedState.IconRightImage = null;
            this.playButton.Size = new System.Drawing.Size(48, 45);
            this.playButton.TabIndex = 7;
            this.playButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.playButton.TextMarginLeft = 0;
            this.playButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.playButton.UseDefaultRadiusAndThickness = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // backwardButton
            // 
            this.backwardButton.AllowAnimations = true;
            this.backwardButton.AllowMouseEffects = true;
            this.backwardButton.AllowToggling = false;
            this.backwardButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backwardButton.AnimationSpeed = 200;
            this.backwardButton.AutoGenerateColors = false;
            this.backwardButton.AutoRoundBorders = false;
            this.backwardButton.AutoSizeLeftIcon = true;
            this.backwardButton.AutoSizeRightIcon = true;
            this.backwardButton.BackColor = System.Drawing.Color.Transparent;
            this.backwardButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.backwardButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backwardButton.BackgroundImage")));
            this.backwardButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.backwardButton.ButtonText = "back";
            this.backwardButton.ButtonTextMarginLeft = 0;
            this.backwardButton.ColorContrastOnClick = 45;
            this.backwardButton.ColorContrastOnHover = 45;
            this.backwardButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            this.backwardButton.CustomizableEdges = borderEdges10;
            this.backwardButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.backwardButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.backwardButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.backwardButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.backwardButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.backwardButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backwardButton.ForeColor = System.Drawing.Color.White;
            this.backwardButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backwardButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.backwardButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.backwardButton.IconMarginLeft = 11;
            this.backwardButton.IconPadding = 10;
            this.backwardButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backwardButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.backwardButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.backwardButton.IconSize = 25;
            this.backwardButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.backwardButton.IdleBorderRadius = 1;
            this.backwardButton.IdleBorderThickness = 1;
            this.backwardButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.backwardButton.IdleIconLeftImage = null;
            this.backwardButton.IdleIconRightImage = null;
            this.backwardButton.IndicateFocus = false;
            this.backwardButton.Location = new System.Drawing.Point(369, 3);
            this.backwardButton.Name = "backwardButton";
            this.backwardButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.backwardButton.OnDisabledState.BorderRadius = 1;
            this.backwardButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.backwardButton.OnDisabledState.BorderThickness = 1;
            this.backwardButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.backwardButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.backwardButton.OnDisabledState.IconLeftImage = null;
            this.backwardButton.OnDisabledState.IconRightImage = null;
            this.backwardButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.backwardButton.onHoverState.BorderRadius = 1;
            this.backwardButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.backwardButton.onHoverState.BorderThickness = 1;
            this.backwardButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.backwardButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.backwardButton.onHoverState.IconLeftImage = null;
            this.backwardButton.onHoverState.IconRightImage = null;
            this.backwardButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.backwardButton.OnIdleState.BorderRadius = 1;
            this.backwardButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.backwardButton.OnIdleState.BorderThickness = 1;
            this.backwardButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.backwardButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.backwardButton.OnIdleState.IconLeftImage = null;
            this.backwardButton.OnIdleState.IconRightImage = null;
            this.backwardButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.backwardButton.OnPressedState.BorderRadius = 1;
            this.backwardButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.backwardButton.OnPressedState.BorderThickness = 1;
            this.backwardButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.backwardButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.backwardButton.OnPressedState.IconLeftImage = null;
            this.backwardButton.OnPressedState.IconRightImage = null;
            this.backwardButton.Size = new System.Drawing.Size(48, 45);
            this.backwardButton.TabIndex = 8;
            this.backwardButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backwardButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.backwardButton.TextMarginLeft = 0;
            this.backwardButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.backwardButton.UseDefaultRadiusAndThickness = true;
            this.backwardButton.Click += new System.EventHandler(this.backwardButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.AllowAnimations = true;
            this.forwardButton.AllowMouseEffects = true;
            this.forwardButton.AllowToggling = false;
            this.forwardButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.forwardButton.AnimationSpeed = 200;
            this.forwardButton.AutoGenerateColors = false;
            this.forwardButton.AutoRoundBorders = false;
            this.forwardButton.AutoSizeLeftIcon = true;
            this.forwardButton.AutoSizeRightIcon = true;
            this.forwardButton.BackColor = System.Drawing.Color.Transparent;
            this.forwardButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.forwardButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forwardButton.BackgroundImage")));
            this.forwardButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.forwardButton.ButtonText = "fwd";
            this.forwardButton.ButtonTextMarginLeft = 0;
            this.forwardButton.ColorContrastOnClick = 45;
            this.forwardButton.ColorContrastOnHover = 45;
            this.forwardButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges11.BottomLeft = true;
            borderEdges11.BottomRight = true;
            borderEdges11.TopLeft = true;
            borderEdges11.TopRight = true;
            this.forwardButton.CustomizableEdges = borderEdges11;
            this.forwardButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.forwardButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.forwardButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.forwardButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.forwardButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.forwardButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.forwardButton.ForeColor = System.Drawing.Color.White;
            this.forwardButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.forwardButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.forwardButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.forwardButton.IconMarginLeft = 11;
            this.forwardButton.IconPadding = 10;
            this.forwardButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.forwardButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.forwardButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.forwardButton.IconSize = 25;
            this.forwardButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.forwardButton.IdleBorderRadius = 1;
            this.forwardButton.IdleBorderThickness = 1;
            this.forwardButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.forwardButton.IdleIconLeftImage = null;
            this.forwardButton.IdleIconRightImage = null;
            this.forwardButton.IndicateFocus = false;
            this.forwardButton.Location = new System.Drawing.Point(477, 3);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.forwardButton.OnDisabledState.BorderRadius = 1;
            this.forwardButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.forwardButton.OnDisabledState.BorderThickness = 1;
            this.forwardButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.forwardButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.forwardButton.OnDisabledState.IconLeftImage = null;
            this.forwardButton.OnDisabledState.IconRightImage = null;
            this.forwardButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.forwardButton.onHoverState.BorderRadius = 1;
            this.forwardButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.forwardButton.onHoverState.BorderThickness = 1;
            this.forwardButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.forwardButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.forwardButton.onHoverState.IconLeftImage = null;
            this.forwardButton.onHoverState.IconRightImage = null;
            this.forwardButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.forwardButton.OnIdleState.BorderRadius = 1;
            this.forwardButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.forwardButton.OnIdleState.BorderThickness = 1;
            this.forwardButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.forwardButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.forwardButton.OnIdleState.IconLeftImage = null;
            this.forwardButton.OnIdleState.IconRightImage = null;
            this.forwardButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.forwardButton.OnPressedState.BorderRadius = 1;
            this.forwardButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.forwardButton.OnPressedState.BorderThickness = 1;
            this.forwardButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.forwardButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.forwardButton.OnPressedState.IconLeftImage = null;
            this.forwardButton.OnPressedState.IconRightImage = null;
            this.forwardButton.Size = new System.Drawing.Size(48, 45);
            this.forwardButton.TabIndex = 9;
            this.forwardButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.forwardButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.forwardButton.TextMarginLeft = 0;
            this.forwardButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.forwardButton.UseDefaultRadiusAndThickness = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.AllowAnimations = true;
            this.stopButton.AllowMouseEffects = true;
            this.stopButton.AllowToggling = false;
            this.stopButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stopButton.AnimationSpeed = 200;
            this.stopButton.AutoGenerateColors = false;
            this.stopButton.AutoRoundBorders = false;
            this.stopButton.AutoSizeLeftIcon = true;
            this.stopButton.AutoSizeRightIcon = true;
            this.stopButton.BackColor = System.Drawing.Color.Transparent;
            this.stopButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.stopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopButton.BackgroundImage")));
            this.stopButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.stopButton.ButtonText = "stop";
            this.stopButton.ButtonTextMarginLeft = 0;
            this.stopButton.ColorContrastOnClick = 45;
            this.stopButton.ColorContrastOnHover = 45;
            this.stopButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges12.BottomLeft = true;
            borderEdges12.BottomRight = true;
            borderEdges12.TopLeft = true;
            borderEdges12.TopRight = true;
            this.stopButton.CustomizableEdges = borderEdges12;
            this.stopButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.stopButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.stopButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.stopButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.stopButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stopButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.stopButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.stopButton.IconMarginLeft = 11;
            this.stopButton.IconPadding = 10;
            this.stopButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stopButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.stopButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.stopButton.IconSize = 25;
            this.stopButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.stopButton.IdleBorderRadius = 1;
            this.stopButton.IdleBorderThickness = 1;
            this.stopButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.stopButton.IdleIconLeftImage = null;
            this.stopButton.IdleIconRightImage = null;
            this.stopButton.IndicateFocus = false;
            this.stopButton.Location = new System.Drawing.Point(531, 3);
            this.stopButton.Name = "stopButton";
            this.stopButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.stopButton.OnDisabledState.BorderRadius = 1;
            this.stopButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.stopButton.OnDisabledState.BorderThickness = 1;
            this.stopButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.stopButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.stopButton.OnDisabledState.IconLeftImage = null;
            this.stopButton.OnDisabledState.IconRightImage = null;
            this.stopButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.stopButton.onHoverState.BorderRadius = 1;
            this.stopButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.stopButton.onHoverState.BorderThickness = 1;
            this.stopButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.stopButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.stopButton.onHoverState.IconLeftImage = null;
            this.stopButton.onHoverState.IconRightImage = null;
            this.stopButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.stopButton.OnIdleState.BorderRadius = 1;
            this.stopButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.stopButton.OnIdleState.BorderThickness = 1;
            this.stopButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.stopButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.stopButton.OnIdleState.IconLeftImage = null;
            this.stopButton.OnIdleState.IconRightImage = null;
            this.stopButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.stopButton.OnPressedState.BorderRadius = 1;
            this.stopButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.stopButton.OnPressedState.BorderThickness = 1;
            this.stopButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.stopButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.stopButton.OnPressedState.IconLeftImage = null;
            this.stopButton.OnPressedState.IconRightImage = null;
            this.stopButton.Size = new System.Drawing.Size(48, 45);
            this.stopButton.TabIndex = 10;
            this.stopButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stopButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.stopButton.TextMarginLeft = 0;
            this.stopButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.stopButton.UseDefaultRadiusAndThickness = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.SeaGreen;
            this.exitButton.color = System.Drawing.Color.SeaGreen;
            this.exitButton.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImagePosition = 20;
            this.exitButton.ImageZoom = 50;
            this.exitButton.LabelPosition = 41;
            this.exitButton.LabelText = "Tile 1";
            this.exitButton.Location = new System.Drawing.Point(860, 14);
            this.exitButton.Margin = new System.Windows.Forms.Padding(6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(40, 34);
            this.exitButton.TabIndex = 11;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.titlePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titlePanel.BackgroundImage")));
            this.titlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titlePanel.BorderColor = System.Drawing.Color.Transparent;
            this.titlePanel.BorderRadius = 3;
            this.titlePanel.BorderThickness = 1;
            this.titlePanel.Controls.Add(this.bunifuPanel2);
            this.titlePanel.Controls.Add(this.bunifuPanel1);
            this.titlePanel.Controls.Add(this.minimizeButton);
            this.titlePanel.Controls.Add(this.maximizeButton);
            this.titlePanel.Controls.Add(this.exitButton);
            this.titlePanel.Controls.Add(this.restoredownButton);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.ShowBorders = true;
            this.titlePanel.Size = new System.Drawing.Size(907, 54);
            this.titlePanel.TabIndex = 12;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Location = new System.Drawing.Point(1, 53);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(905, 390);
            this.bunifuPanel2.TabIndex = 15;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Location = new System.Drawing.Point(3, 50);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(903, 394);
            this.bunifuPanel1.TabIndex = 14;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.SeaGreen;
            this.minimizeButton.color = System.Drawing.Color.SeaGreen;
            this.minimizeButton.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.ImagePosition = 20;
            this.minimizeButton.ImageZoom = 50;
            this.minimizeButton.LabelPosition = 41;
            this.minimizeButton.LabelText = "Tile 1";
            this.minimizeButton.Location = new System.Drawing.Point(756, 14);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(6);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(40, 34);
            this.minimizeButton.TabIndex = 13;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.SeaGreen;
            this.maximizeButton.color = System.Drawing.Color.SeaGreen;
            this.maximizeButton.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.maximizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizeButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.maximizeButton.ForeColor = System.Drawing.Color.White;
            this.maximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("maximizeButton.Image")));
            this.maximizeButton.ImagePosition = 20;
            this.maximizeButton.ImageZoom = 50;
            this.maximizeButton.LabelPosition = 41;
            this.maximizeButton.LabelText = "Tile 1";
            this.maximizeButton.Location = new System.Drawing.Point(808, 14);
            this.maximizeButton.Margin = new System.Windows.Forms.Padding(6);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(40, 34);
            this.maximizeButton.TabIndex = 12;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // restoredownButton
            // 
            this.restoredownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restoredownButton.BackColor = System.Drawing.Color.SeaGreen;
            this.restoredownButton.color = System.Drawing.Color.SeaGreen;
            this.restoredownButton.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.restoredownButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restoredownButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.restoredownButton.ForeColor = System.Drawing.Color.White;
            this.restoredownButton.Image = ((System.Drawing.Image)(resources.GetObject("restoredownButton.Image")));
            this.restoredownButton.ImagePosition = 20;
            this.restoredownButton.ImageZoom = 50;
            this.restoredownButton.LabelPosition = 41;
            this.restoredownButton.LabelText = "Tile 1";
            this.restoredownButton.Location = new System.Drawing.Point(808, 14);
            this.restoredownButton.Margin = new System.Windows.Forms.Padding(6);
            this.restoredownButton.Name = "restoredownButton";
            this.restoredownButton.Size = new System.Drawing.Size(40, 34);
            this.restoredownButton.TabIndex = 16;
            this.restoredownButton.Click += new System.EventHandler(this.restoredownButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.AllowAnimations = true;
            this.pauseButton.AllowMouseEffects = true;
            this.pauseButton.AllowToggling = false;
            this.pauseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pauseButton.AnimationSpeed = 200;
            this.pauseButton.AutoGenerateColors = false;
            this.pauseButton.AutoRoundBorders = false;
            this.pauseButton.AutoSizeLeftIcon = true;
            this.pauseButton.AutoSizeRightIcon = true;
            this.pauseButton.BackColor = System.Drawing.Color.Transparent;
            this.pauseButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.pauseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pauseButton.BackgroundImage")));
            this.pauseButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.pauseButton.ButtonText = "play";
            this.pauseButton.ButtonTextMarginLeft = 0;
            this.pauseButton.ColorContrastOnClick = 45;
            this.pauseButton.ColorContrastOnHover = 45;
            this.pauseButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges13.BottomLeft = true;
            borderEdges13.BottomRight = true;
            borderEdges13.TopLeft = true;
            borderEdges13.TopRight = true;
            this.pauseButton.CustomizableEdges = borderEdges13;
            this.pauseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.pauseButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pauseButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pauseButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.pauseButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.pauseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pauseButton.ForeColor = System.Drawing.Color.White;
            this.pauseButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pauseButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.pauseButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.pauseButton.IconMarginLeft = 11;
            this.pauseButton.IconPadding = 10;
            this.pauseButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pauseButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.pauseButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.pauseButton.IconSize = 25;
            this.pauseButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.pauseButton.IdleBorderRadius = 1;
            this.pauseButton.IdleBorderThickness = 1;
            this.pauseButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.pauseButton.IdleIconLeftImage = null;
            this.pauseButton.IdleIconRightImage = null;
            this.pauseButton.IndicateFocus = false;
            this.pauseButton.Location = new System.Drawing.Point(423, 3);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pauseButton.OnDisabledState.BorderRadius = 1;
            this.pauseButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.pauseButton.OnDisabledState.BorderThickness = 1;
            this.pauseButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pauseButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.pauseButton.OnDisabledState.IconLeftImage = null;
            this.pauseButton.OnDisabledState.IconRightImage = null;
            this.pauseButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.pauseButton.onHoverState.BorderRadius = 1;
            this.pauseButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.pauseButton.onHoverState.BorderThickness = 1;
            this.pauseButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.pauseButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.pauseButton.onHoverState.IconLeftImage = null;
            this.pauseButton.onHoverState.IconRightImage = null;
            this.pauseButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.pauseButton.OnIdleState.BorderRadius = 1;
            this.pauseButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.pauseButton.OnIdleState.BorderThickness = 1;
            this.pauseButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.pauseButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.pauseButton.OnIdleState.IconLeftImage = null;
            this.pauseButton.OnIdleState.IconRightImage = null;
            this.pauseButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.pauseButton.OnPressedState.BorderRadius = 1;
            this.pauseButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.pauseButton.OnPressedState.BorderThickness = 1;
            this.pauseButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.pauseButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.pauseButton.OnPressedState.IconLeftImage = null;
            this.pauseButton.OnPressedState.IconRightImage = null;
            this.pauseButton.Size = new System.Drawing.Size(48, 45);
            this.pauseButton.TabIndex = 13;
            this.pauseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pauseButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.pauseButton.TextMarginLeft = 0;
            this.pauseButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.pauseButton.UseDefaultRadiusAndThickness = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // videoProgressBar
            // 
            this.videoProgressBar.AllowCursorChanges = true;
            this.videoProgressBar.AllowHomeEndKeysDetection = false;
            this.videoProgressBar.AllowIncrementalClickMoves = true;
            this.videoProgressBar.AllowMouseDownEffects = false;
            this.videoProgressBar.AllowMouseHoverEffects = false;
            this.videoProgressBar.AllowScrollingAnimations = true;
            this.videoProgressBar.AllowScrollKeysDetection = true;
            this.videoProgressBar.AllowScrollOptionsMenu = true;
            this.videoProgressBar.AllowShrinkingOnFocusLost = false;
            this.videoProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.videoProgressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("videoProgressBar.BackgroundImage")));
            this.videoProgressBar.BindingContainer = null;
            this.videoProgressBar.BorderRadius = 2;
            this.videoProgressBar.BorderThickness = 1;
            this.videoProgressBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.videoProgressBar.DrawThickBorder = false;
            this.videoProgressBar.DurationBeforeShrink = 2000;
            this.videoProgressBar.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.videoProgressBar.LargeChange = 10;
            this.videoProgressBar.Location = new System.Drawing.Point(81, 48);
            this.videoProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.videoProgressBar.Maximum = 1000;
            this.videoProgressBar.Minimum = 0;
            this.videoProgressBar.MinimumSize = new System.Drawing.Size(0, 31);
            this.videoProgressBar.MinimumThumbLength = 18;
            this.videoProgressBar.Name = "videoProgressBar";
            this.videoProgressBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.videoProgressBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.videoProgressBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.videoProgressBar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.videoProgressBar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.videoProgressBar.ShrinkSizeLimit = 3;
            this.videoProgressBar.Size = new System.Drawing.Size(718, 49);
            this.videoProgressBar.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.videoProgressBar.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.videoProgressBar.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.videoProgressBar.SmallChange = 1;
            this.videoProgressBar.TabIndex = 14;
            this.videoProgressBar.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.videoProgressBar.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.videoProgressBar.ThumbLength = 18;
            this.videoProgressBar.ThumbMargin = 1;
            this.videoProgressBar.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.videoProgressBar.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.videoProgressBar.Value = 0;
            this.videoProgressBar.ValueChanged += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs>(this.videoProgressBar_ValueChanged);
            this.videoProgressBar.Click += new System.EventHandler(this.videoProgressBar_Click);
            this.videoProgressBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.videoProgressBar_MouseMove);
            this.videoProgressBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.videoProgressBar_MouseUp);
            // 
            // videoTimer
            // 
            this.videoTimer.Interval = 1000;
            this.videoTimer.Tick += new System.EventHandler(this.videoTimer_Tick);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.bottomPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottomPanel.BackgroundImage")));
            this.bottomPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bottomPanel.BorderColor = System.Drawing.Color.Transparent;
            this.bottomPanel.BorderRadius = 3;
            this.bottomPanel.BorderThickness = 1;
            this.bottomPanel.Controls.Add(this.soundButton);
            this.bottomPanel.Controls.Add(this.videoLength);
            this.bottomPanel.Controls.Add(this.videoTime);
            this.bottomPanel.Controls.Add(this.bunifuHSlider1);
            this.bottomPanel.Controls.Add(this.videoProgressBar);
            this.bottomPanel.Controls.Add(this.pauseButton);
            this.bottomPanel.Controls.Add(this.hamburgerButton);
            this.bottomPanel.Controls.Add(this.stopButton);
            this.bottomPanel.Controls.Add(this.forwardButton);
            this.bottomPanel.Controls.Add(this.backwardButton);
            this.bottomPanel.Controls.Add(this.playButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 425);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.ShowBorders = true;
            this.bottomPanel.Size = new System.Drawing.Size(907, 119);
            this.bottomPanel.TabIndex = 15;
            // 
            // soundButton
            // 
            this.soundButton.AllowAnimations = true;
            this.soundButton.AllowMouseEffects = true;
            this.soundButton.AllowToggling = false;
            this.soundButton.AnimationSpeed = 200;
            this.soundButton.AutoGenerateColors = false;
            this.soundButton.AutoRoundBorders = false;
            this.soundButton.AutoSizeLeftIcon = true;
            this.soundButton.AutoSizeRightIcon = true;
            this.soundButton.BackColor = System.Drawing.Color.Transparent;
            this.soundButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.soundButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soundButton.BackgroundImage")));
            this.soundButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.soundButton.ButtonText = "sound";
            this.soundButton.ButtonTextMarginLeft = 0;
            this.soundButton.ColorContrastOnClick = 45;
            this.soundButton.ColorContrastOnHover = 45;
            this.soundButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges14.BottomLeft = true;
            borderEdges14.BottomRight = true;
            borderEdges14.TopLeft = true;
            borderEdges14.TopRight = true;
            this.soundButton.CustomizableEdges = borderEdges14;
            this.soundButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.soundButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.soundButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.soundButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.soundButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.soundButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.soundButton.ForeColor = System.Drawing.Color.White;
            this.soundButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.soundButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.soundButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.soundButton.IconMarginLeft = 11;
            this.soundButton.IconPadding = 10;
            this.soundButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.soundButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.soundButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.soundButton.IconSize = 25;
            this.soundButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.soundButton.IdleBorderRadius = 1;
            this.soundButton.IdleBorderThickness = 1;
            this.soundButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.soundButton.IdleIconLeftImage = null;
            this.soundButton.IdleIconRightImage = null;
            this.soundButton.IndicateFocus = false;
            this.soundButton.Location = new System.Drawing.Point(623, 7);
            this.soundButton.Name = "soundButton";
            this.soundButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.soundButton.OnDisabledState.BorderRadius = 1;
            this.soundButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.soundButton.OnDisabledState.BorderThickness = 1;
            this.soundButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.soundButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.soundButton.OnDisabledState.IconLeftImage = null;
            this.soundButton.OnDisabledState.IconRightImage = null;
            this.soundButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.soundButton.onHoverState.BorderRadius = 1;
            this.soundButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.soundButton.onHoverState.BorderThickness = 1;
            this.soundButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.soundButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.soundButton.onHoverState.IconLeftImage = null;
            this.soundButton.onHoverState.IconRightImage = null;
            this.soundButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.soundButton.OnIdleState.BorderRadius = 1;
            this.soundButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.soundButton.OnIdleState.BorderThickness = 1;
            this.soundButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.soundButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.soundButton.OnIdleState.IconLeftImage = null;
            this.soundButton.OnIdleState.IconRightImage = null;
            this.soundButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.soundButton.OnPressedState.BorderRadius = 1;
            this.soundButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.soundButton.OnPressedState.BorderThickness = 1;
            this.soundButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.soundButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.soundButton.OnPressedState.IconLeftImage = null;
            this.soundButton.OnPressedState.IconRightImage = null;
            this.soundButton.Size = new System.Drawing.Size(41, 41);
            this.soundButton.TabIndex = 17;
            this.soundButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.soundButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.soundButton.TextMarginLeft = 0;
            this.soundButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.soundButton.UseDefaultRadiusAndThickness = true;
            // 
            // videoLength
            // 
            this.videoLength.AllowParentOverrides = false;
            this.videoLength.AutoEllipsis = false;
            this.videoLength.CursorType = null;
            this.videoLength.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.videoLength.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.videoLength.Location = new System.Drawing.Point(808, 60);
            this.videoLength.Name = "videoLength";
            this.videoLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.videoLength.Size = new System.Drawing.Size(42, 20);
            this.videoLength.TabIndex = 16;
            this.videoLength.Text = "length";
            this.videoLength.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.videoLength.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // videoTime
            // 
            this.videoTime.AllowParentOverrides = false;
            this.videoTime.AutoEllipsis = false;
            this.videoTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.videoTime.CursorType = System.Windows.Forms.Cursors.Default;
            this.videoTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.videoTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.videoTime.Location = new System.Drawing.Point(4, 60);
            this.videoTime.Name = "videoTime";
            this.videoTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.videoTime.Size = new System.Drawing.Size(70, 20);
            this.videoTime.TabIndex = 16;
            this.videoTime.Text = "videoTime";
            this.videoTime.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.videoTime.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuHSlider1
            // 
            this.bunifuHSlider1.AllowCursorChanges = true;
            this.bunifuHSlider1.AllowHomeEndKeysDetection = false;
            this.bunifuHSlider1.AllowIncrementalClickMoves = true;
            this.bunifuHSlider1.AllowMouseDownEffects = false;
            this.bunifuHSlider1.AllowMouseHoverEffects = false;
            this.bunifuHSlider1.AllowScrollingAnimations = true;
            this.bunifuHSlider1.AllowScrollKeysDetection = true;
            this.bunifuHSlider1.AllowScrollOptionsMenu = true;
            this.bunifuHSlider1.AllowShrinkingOnFocusLost = false;
            this.bunifuHSlider1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuHSlider1.BackgroundImage")));
            this.bunifuHSlider1.BindingContainer = null;
            this.bunifuHSlider1.BorderRadius = 2;
            this.bunifuHSlider1.BorderThickness = 1;
            this.bunifuHSlider1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuHSlider1.DrawThickBorder = false;
            this.bunifuHSlider1.DurationBeforeShrink = 2000;
            this.bunifuHSlider1.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.bunifuHSlider1.LargeChange = 10;
            this.bunifuHSlider1.Location = new System.Drawing.Point(671, 10);
            this.bunifuHSlider1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuHSlider1.Maximum = 100;
            this.bunifuHSlider1.Minimum = 0;
            this.bunifuHSlider1.MinimumSize = new System.Drawing.Size(0, 31);
            this.bunifuHSlider1.MinimumThumbLength = 18;
            this.bunifuHSlider1.Name = "bunifuHSlider1";
            this.bunifuHSlider1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuHSlider1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuHSlider1.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider1.ShrinkSizeLimit = 3;
            this.bunifuHSlider1.Size = new System.Drawing.Size(152, 37);
            this.bunifuHSlider1.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider1.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.bunifuHSlider1.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.bunifuHSlider1.SmallChange = 1;
            this.bunifuHSlider1.TabIndex = 15;
            this.bunifuHSlider1.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.bunifuHSlider1.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.bunifuHSlider1.ThumbLength = 18;
            this.bunifuHSlider1.ThumbMargin = 1;
            this.bunifuHSlider1.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.bunifuHSlider1.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuHSlider1.Value = 50;
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 3;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.videoView);
            this.bunifuPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel3.Location = new System.Drawing.Point(0, 54);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(907, 371);
            this.bunifuPanel3.TabIndex = 16;
            // 
            // hamburgerMenuStrip
            // 
            this.hamburgerMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.hamburgerMenuStrip.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hamburgerMenuStrip.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.hamburgerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speedToolStripMenuItem,
            this.addSubtitleToolStripMenuItem});
            this.hamburgerMenuStrip.Name = "contextMenuStrip1";
            this.hamburgerMenuStrip.Size = new System.Drawing.Size(196, 64);
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem8,
            this.toolStripMenuItem10,
            this.normalToolStripMenuItem1,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14});
            this.speedToolStripMenuItem.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(195, 30);
            this.speedToolStripMenuItem.Text = "Speed";
            this.speedToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.toolStripMenuItem9.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(165, 30);
            this.toolStripMenuItem9.Text = "0.25";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.toolStripMenuItem8.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(165, 30);
            this.toolStripMenuItem8.Text = "0.5";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.toolStripMenuItem10.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(165, 30);
            this.toolStripMenuItem10.Text = "0.75";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // normalToolStripMenuItem1
            // 
            this.normalToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.normalToolStripMenuItem1.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.normalToolStripMenuItem1.Name = "normalToolStripMenuItem1";
            this.normalToolStripMenuItem1.Size = new System.Drawing.Size(165, 30);
            this.normalToolStripMenuItem1.Text = "Normal";
            this.normalToolStripMenuItem1.Click += new System.EventHandler(this.normalToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.toolStripMenuItem11.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(165, 30);
            this.toolStripMenuItem11.Text = "1.25";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.toolStripMenuItem12.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(165, 30);
            this.toolStripMenuItem12.Text = "1.5";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.toolStripMenuItem13.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(165, 30);
            this.toolStripMenuItem13.Text = "1.75";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.toolStripMenuItem14.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(165, 30);
            this.toolStripMenuItem14.Text = "2";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
            // 
            // addSubtitleToolStripMenuItem
            // 
            this.addSubtitleToolStripMenuItem.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSubtitleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addSubtitleToolStripMenuItem.Name = "addSubtitleToolStripMenuItem";
            this.addSubtitleToolStripMenuItem.Size = new System.Drawing.Size(195, 30);
            this.addSubtitleToolStripMenuItem.Text = "Add Subtitle";
            this.addSubtitleToolStripMenuItem.Click += new System.EventHandler(this.addSubtitleToolStripMenuItem_Click);
            // 
            // VideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(907, 544);
            this.Controls.Add(this.bunifuPanel3);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VideoPlayer";
            this.Text = "VideoPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.bunifuPanel3.ResumeLayout(false);
            this.hamburgerMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LibVLCSharp.WinForms.VideoView videoView;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton hamburgerButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton playButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton backwardButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton forwardButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton stopButton;
        private Bunifu.Framework.UI.BunifuTileButton exitButton;
        private Bunifu.UI.WinForms.BunifuPanel titlePanel;
        private Bunifu.Framework.UI.BunifuTileButton minimizeButton;
        private Bunifu.Framework.UI.BunifuTileButton maximizeButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton pauseButton;
        private Bunifu.UI.WinForms.BunifuHSlider videoProgressBar;
        private System.Windows.Forms.Timer videoTimer;
        private Bunifu.UI.WinForms.BunifuPanel bottomPanel;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.Framework.UI.BunifuTileButton restoredownButton;
        private System.Windows.Forms.ContextMenuStrip hamburgerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSubtitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private Bunifu.UI.WinForms.BunifuHSlider bunifuHSlider1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton soundButton;
        private Bunifu.UI.WinForms.BunifuLabel videoLength;
        private Bunifu.UI.WinForms.BunifuLabel videoTime;
    }
}