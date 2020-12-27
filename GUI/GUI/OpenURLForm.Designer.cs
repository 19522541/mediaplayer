namespace GUI
{
    partial class OpenURLForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenURLForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.urlTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.openButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuTileButton1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(629, 48);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTileButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "Tile 1";
            this.bunifuTileButton1.Location = new System.Drawing.Point(590, 6);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(33, 30);
            this.bunifuTileButton1.TabIndex = 0;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuLabel1.Location = new System.Drawing.Point(51, 92);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(218, 31);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Paste the URL here:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // urlTextBox
            // 
            this.urlTextBox.AcceptsReturn = false;
            this.urlTextBox.AcceptsTab = false;
            this.urlTextBox.AnimationSpeed = 200;
            this.urlTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.urlTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.urlTextBox.BackColor = System.Drawing.Color.Transparent;
            this.urlTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("urlTextBox.BackgroundImage")));
            this.urlTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.urlTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.urlTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.urlTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.urlTextBox.BorderRadius = 1;
            this.urlTextBox.BorderThickness = 1;
            this.urlTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.urlTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.urlTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.urlTextBox.DefaultText = "";
            this.urlTextBox.FillColor = System.Drawing.Color.White;
            this.urlTextBox.HideSelection = true;
            this.urlTextBox.IconLeft = null;
            this.urlTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.urlTextBox.IconPadding = 10;
            this.urlTextBox.IconRight = null;
            this.urlTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.urlTextBox.Lines = new string[0];
            this.urlTextBox.Location = new System.Drawing.Point(49, 136);
            this.urlTextBox.MaxLength = 32767;
            this.urlTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.urlTextBox.Modified = false;
            this.urlTextBox.Multiline = false;
            this.urlTextBox.Name = "urlTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.urlTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.urlTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.urlTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.urlTextBox.OnIdleState = stateProperties4;
            this.urlTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.urlTextBox.PasswordChar = '\0';
            this.urlTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.urlTextBox.PlaceholderText = "Enter text";
            this.urlTextBox.ReadOnly = false;
            this.urlTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.urlTextBox.SelectedText = "";
            this.urlTextBox.SelectionLength = 0;
            this.urlTextBox.SelectionStart = 0;
            this.urlTextBox.ShortcutsEnabled = true;
            this.urlTextBox.Size = new System.Drawing.Size(481, 69);
            this.urlTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.urlTextBox.TabIndex = 2;
            this.urlTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.urlTextBox.TextMarginBottom = 0;
            this.urlTextBox.TextMarginLeft = 3;
            this.urlTextBox.TextMarginTop = 0;
            this.urlTextBox.TextPlaceholder = "Enter text";
            this.urlTextBox.UseSystemPasswordChar = false;
            this.urlTextBox.WordWrap = true;
            // 
            // openButton
            // 
            this.openButton.AllowAnimations = true;
            this.openButton.AllowMouseEffects = true;
            this.openButton.AllowToggling = false;
            this.openButton.AnimationSpeed = 200;
            this.openButton.AutoGenerateColors = false;
            this.openButton.AutoRoundBorders = false;
            this.openButton.AutoSizeLeftIcon = true;
            this.openButton.AutoSizeRightIcon = true;
            this.openButton.BackColor = System.Drawing.Color.Transparent;
            this.openButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.openButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openButton.BackgroundImage")));
            this.openButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.openButton.ButtonText = "Open";
            this.openButton.ButtonTextMarginLeft = 0;
            this.openButton.ColorContrastOnClick = 45;
            this.openButton.ColorContrastOnHover = 45;
            this.openButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.openButton.CustomizableEdges = borderEdges1;
            this.openButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.openButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.openButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.openButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.openButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.openButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.openButton.ForeColor = System.Drawing.Color.White;
            this.openButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.openButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.openButton.IconMarginLeft = 11;
            this.openButton.IconPadding = 10;
            this.openButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.openButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.openButton.IconSize = 25;
            this.openButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.openButton.IdleBorderRadius = 1;
            this.openButton.IdleBorderThickness = 1;
            this.openButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.openButton.IdleIconLeftImage = null;
            this.openButton.IdleIconRightImage = null;
            this.openButton.IndicateFocus = false;
            this.openButton.Location = new System.Drawing.Point(49, 231);
            this.openButton.Name = "openButton";
            this.openButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.openButton.OnDisabledState.BorderRadius = 1;
            this.openButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.openButton.OnDisabledState.BorderThickness = 1;
            this.openButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.openButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.openButton.OnDisabledState.IconLeftImage = null;
            this.openButton.OnDisabledState.IconRightImage = null;
            this.openButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.openButton.onHoverState.BorderRadius = 1;
            this.openButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.openButton.onHoverState.BorderThickness = 1;
            this.openButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.openButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.openButton.onHoverState.IconLeftImage = null;
            this.openButton.onHoverState.IconRightImage = null;
            this.openButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.openButton.OnIdleState.BorderRadius = 1;
            this.openButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.openButton.OnIdleState.BorderThickness = 1;
            this.openButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.openButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.openButton.OnIdleState.IconLeftImage = null;
            this.openButton.OnIdleState.IconRightImage = null;
            this.openButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.openButton.OnPressedState.BorderRadius = 1;
            this.openButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.openButton.OnPressedState.BorderThickness = 1;
            this.openButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.openButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.openButton.OnPressedState.IconLeftImage = null;
            this.openButton.OnPressedState.IconRightImage = null;
            this.openButton.Size = new System.Drawing.Size(108, 55);
            this.openButton.TabIndex = 3;
            this.openButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.openButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.openButton.TextMarginLeft = 0;
            this.openButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.openButton.UseDefaultRadiusAndThickness = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // OpenURLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(629, 340);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpenURLForm";
            this.Text = "OpenURLForm";
            this.bunifuPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuTextBox urlTextBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton openButton;
    }
}