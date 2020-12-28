namespace GUI
{
    partial class VideoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.videolistView = new System.Windows.Forms.ListView();
            this.emptyListLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.topPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.openFolderButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // videolistView
            // 
            this.videolistView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.videolistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videolistView.HideSelection = false;
            this.videolistView.Location = new System.Drawing.Point(0, 0);
            this.videolistView.Name = "videolistView";
            this.videolistView.Size = new System.Drawing.Size(1300, 876);
            this.videolistView.TabIndex = 0;
            this.videolistView.UseCompatibleStateImageBehavior = false;
            this.videolistView.SelectedIndexChanged += new System.EventHandler(this.videolistView_SelectedIndexChanged);
            this.videolistView.DoubleClick += new System.EventHandler(this.videolistView_DoubleClick);
            this.videolistView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.videolistView_MouseDoubleClick);
            // 
            // emptyListLabel
            // 
            this.emptyListLabel.AllowParentOverrides = false;
            this.emptyListLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emptyListLabel.AutoEllipsis = false;
            this.emptyListLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.emptyListLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.emptyListLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.emptyListLabel.Font = new System.Drawing.Font("Malgun Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyListLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emptyListLabel.Location = new System.Drawing.Point(524, 27);
            this.emptyListLabel.Name = "emptyListLabel";
            this.emptyListLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.emptyListLabel.Size = new System.Drawing.Size(388, 62);
            this.emptyListLabel.TabIndex = 1;
            this.emptyListLabel.Text = "Video Not Found";
            this.emptyListLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.emptyListLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // topPanel
            // 
            this.topPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.topPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topPanel.BackgroundImage")));
            this.topPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topPanel.BorderColor = System.Drawing.Color.Transparent;
            this.topPanel.BorderRadius = 3;
            this.topPanel.BorderThickness = 1;
            this.topPanel.Controls.Add(this.openFolderButton);
            this.topPanel.Controls.Add(this.emptyListLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.ShowBorders = true;
            this.topPanel.Size = new System.Drawing.Size(1300, 101);
            this.topPanel.TabIndex = 2;
            // 
            // openFolderButton
            // 
            this.openFolderButton.AllowAnimations = true;
            this.openFolderButton.AllowMouseEffects = true;
            this.openFolderButton.AllowToggling = false;
            this.openFolderButton.AnimationSpeed = 200;
            this.openFolderButton.AutoGenerateColors = false;
            this.openFolderButton.AutoRoundBorders = false;
            this.openFolderButton.AutoSizeLeftIcon = true;
            this.openFolderButton.AutoSizeRightIcon = true;
            this.openFolderButton.BackColor = System.Drawing.Color.Transparent;
            this.openFolderButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.openFolderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openFolderButton.BackgroundImage")));
            this.openFolderButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.openFolderButton.ButtonText = "Browse";
            this.openFolderButton.ButtonTextMarginLeft = 0;
            this.openFolderButton.ColorContrastOnClick = 45;
            this.openFolderButton.ColorContrastOnHover = 45;
            this.openFolderButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.openFolderButton.CustomizableEdges = borderEdges1;
            this.openFolderButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.openFolderButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.openFolderButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.openFolderButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.openFolderButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.openFolderButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.openFolderButton.ForeColor = System.Drawing.Color.White;
            this.openFolderButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openFolderButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.openFolderButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.openFolderButton.IconMarginLeft = 11;
            this.openFolderButton.IconPadding = 10;
            this.openFolderButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openFolderButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.openFolderButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.openFolderButton.IconSize = 25;
            this.openFolderButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.openFolderButton.IdleBorderRadius = 1;
            this.openFolderButton.IdleBorderThickness = 1;
            this.openFolderButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.openFolderButton.IdleIconLeftImage = null;
            this.openFolderButton.IdleIconRightImage = null;
            this.openFolderButton.IndicateFocus = false;
            this.openFolderButton.Location = new System.Drawing.Point(1037, 27);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.openFolderButton.OnDisabledState.BorderRadius = 1;
            this.openFolderButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.openFolderButton.OnDisabledState.BorderThickness = 1;
            this.openFolderButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.openFolderButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.openFolderButton.OnDisabledState.IconLeftImage = null;
            this.openFolderButton.OnDisabledState.IconRightImage = null;
            this.openFolderButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.openFolderButton.onHoverState.BorderRadius = 1;
            this.openFolderButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.openFolderButton.onHoverState.BorderThickness = 1;
            this.openFolderButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.openFolderButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.openFolderButton.onHoverState.IconLeftImage = null;
            this.openFolderButton.onHoverState.IconRightImage = null;
            this.openFolderButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.openFolderButton.OnIdleState.BorderRadius = 1;
            this.openFolderButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.openFolderButton.OnIdleState.BorderThickness = 1;
            this.openFolderButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.openFolderButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.openFolderButton.OnIdleState.IconLeftImage = null;
            this.openFolderButton.OnIdleState.IconRightImage = null;
            this.openFolderButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.openFolderButton.OnPressedState.BorderRadius = 1;
            this.openFolderButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.openFolderButton.OnPressedState.BorderThickness = 1;
            this.openFolderButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.openFolderButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.openFolderButton.OnPressedState.IconLeftImage = null;
            this.openFolderButton.OnPressedState.IconRightImage = null;
            this.openFolderButton.Size = new System.Drawing.Size(104, 48);
            this.openFolderButton.TabIndex = 2;
            this.openFolderButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.openFolderButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.openFolderButton.TextMarginLeft = 0;
            this.openFolderButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.openFolderButton.UseDefaultRadiusAndThickness = true;
            this.openFolderButton.Click += new System.EventHandler(this.openFolderButton_Click);
            // 
            // VideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1300, 876);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.videolistView);
            this.Name = "VideoForm";
            this.Text = "VideoForm";
            this.Load += new System.EventHandler(this.VideoForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView videolistView;
        private Bunifu.UI.WinForms.BunifuLabel emptyListLabel;
        private Bunifu.UI.WinForms.BunifuPanel topPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton openFolderButton;
    }
}