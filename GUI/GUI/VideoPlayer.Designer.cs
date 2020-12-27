﻿namespace GUI
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.videoView = new LibVLCSharp.WinForms.VideoView();
            this.bunifuButton4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
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
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.videoView)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
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
            // bunifuButton4
            // 
            this.bunifuButton4.AllowAnimations = true;
            this.bunifuButton4.AllowMouseEffects = true;
            this.bunifuButton4.AllowToggling = false;
            this.bunifuButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuButton4.AnimationSpeed = 200;
            this.bunifuButton4.AutoGenerateColors = false;
            this.bunifuButton4.AutoRoundBorders = false;
            this.bunifuButton4.AutoSizeLeftIcon = true;
            this.bunifuButton4.AutoSizeRightIcon = true;
            this.bunifuButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton4.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton4.BackgroundImage")));
            this.bunifuButton4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.ButtonText = "bunifuButton4";
            this.bunifuButton4.ButtonTextMarginLeft = 0;
            this.bunifuButton4.ColorContrastOnClick = 45;
            this.bunifuButton4.ColorContrastOnHover = 45;
            this.bunifuButton4.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton4.CustomizableEdges = borderEdges1;
            this.bunifuButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton4.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton4.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton4.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton4.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton4.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton4.IconMarginLeft = 11;
            this.bunifuButton4.IconPadding = 10;
            this.bunifuButton4.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton4.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton4.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton4.IconSize = 25;
            this.bunifuButton4.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton4.IdleBorderRadius = 1;
            this.bunifuButton4.IdleBorderThickness = 1;
            this.bunifuButton4.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton4.IdleIconLeftImage = null;
            this.bunifuButton4.IdleIconRightImage = null;
            this.bunifuButton4.IndicateFocus = false;
            this.bunifuButton4.Location = new System.Drawing.Point(838, 3);
            this.bunifuButton4.Name = "bunifuButton4";
            this.bunifuButton4.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton4.OnDisabledState.BorderRadius = 1;
            this.bunifuButton4.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.OnDisabledState.BorderThickness = 1;
            this.bunifuButton4.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton4.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton4.OnDisabledState.IconLeftImage = null;
            this.bunifuButton4.OnDisabledState.IconRightImage = null;
            this.bunifuButton4.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton4.onHoverState.BorderRadius = 1;
            this.bunifuButton4.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.onHoverState.BorderThickness = 1;
            this.bunifuButton4.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton4.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.onHoverState.IconLeftImage = null;
            this.bunifuButton4.onHoverState.IconRightImage = null;
            this.bunifuButton4.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton4.OnIdleState.BorderRadius = 1;
            this.bunifuButton4.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.OnIdleState.BorderThickness = 1;
            this.bunifuButton4.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton4.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.OnIdleState.IconLeftImage = null;
            this.bunifuButton4.OnIdleState.IconRightImage = null;
            this.bunifuButton4.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton4.OnPressedState.BorderRadius = 1;
            this.bunifuButton4.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.OnPressedState.BorderThickness = 1;
            this.bunifuButton4.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton4.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.OnPressedState.IconLeftImage = null;
            this.bunifuButton4.OnPressedState.IconRightImage = null;
            this.bunifuButton4.Size = new System.Drawing.Size(48, 45);
            this.bunifuButton4.TabIndex = 5;
            this.bunifuButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton4.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton4.TextMarginLeft = 0;
            this.bunifuButton4.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton4.UseDefaultRadiusAndThickness = true;
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.playButton.CustomizableEdges = borderEdges2;
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
            this.playButton.Location = new System.Drawing.Point(334, 5);
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
            this.backwardButton.ButtonText = "bunifuButton6";
            this.backwardButton.ButtonTextMarginLeft = 0;
            this.backwardButton.ColorContrastOnClick = 45;
            this.backwardButton.ColorContrastOnHover = 45;
            this.backwardButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.backwardButton.CustomizableEdges = borderEdges3;
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
            this.backwardButton.Location = new System.Drawing.Point(271, 5);
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
            this.forwardButton.ButtonText = "bunifuButton7";
            this.forwardButton.ButtonTextMarginLeft = 0;
            this.forwardButton.ColorContrastOnClick = 45;
            this.forwardButton.ColorContrastOnHover = 45;
            this.forwardButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.forwardButton.CustomizableEdges = borderEdges4;
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
            this.forwardButton.Location = new System.Drawing.Point(397, 5);
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
            this.stopButton.ButtonText = "bunifuButton8";
            this.stopButton.ButtonTextMarginLeft = 0;
            this.stopButton.ColorContrastOnClick = 45;
            this.stopButton.ColorContrastOnHover = 45;
            this.stopButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.stopButton.CustomizableEdges = borderEdges5;
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
            this.stopButton.Location = new System.Drawing.Point(458, 5);
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
            this.pauseButton.ButtonText = "bunifuButton1";
            this.pauseButton.ButtonTextMarginLeft = 0;
            this.pauseButton.ColorContrastOnClick = 45;
            this.pauseButton.ColorContrastOnHover = 45;
            this.pauseButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.pauseButton.CustomizableEdges = borderEdges6;
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
            this.pauseButton.Location = new System.Drawing.Point(334, 5);
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
            this.videoProgressBar.Location = new System.Drawing.Point(3, 48);
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
            this.videoProgressBar.Size = new System.Drawing.Size(680, 49);
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
            this.bottomPanel.Controls.Add(this.videoProgressBar);
            this.bottomPanel.Controls.Add(this.pauseButton);
            this.bottomPanel.Controls.Add(this.bunifuButton4);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.normalToolStripMenuItem,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.xToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 196);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(128, 24);
            this.toolStripMenuItem2.Text = "0.25";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(128, 24);
            this.toolStripMenuItem3.Text = "0.5";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(128, 24);
            this.toolStripMenuItem4.Text = "0.75";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.normalToolStripMenuItem.Text = "Normal";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(128, 24);
            this.toolStripMenuItem5.Text = "1.25";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(128, 24);
            this.toolStripMenuItem6.Text = "1.5";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(128, 24);
            this.toolStripMenuItem7.Text = "1.75";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.xToolStripMenuItem.Text = "2X";
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
            this.bunifuPanel3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LibVLCSharp.WinForms.VideoView videoView;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton4;
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
    }
}