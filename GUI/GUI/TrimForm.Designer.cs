
namespace GUI
{
    partial class TrimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrimForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.trimmingslider = new Bunifu.Framework.UI.BunifuRange();
            this.lengthlabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.startlabel = new System.Windows.Forms.Label();
            this.endlabel = new System.Windows.Forms.Label();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.namebox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.cancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.trimFormDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bunifuLabel1.Location = new System.Drawing.Point(145, 134);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(93, 27);
            this.bunifuLabel1.TabIndex = 2;
            this.bunifuLabel1.Text = "File Name";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // trimmingslider
            // 
            this.trimmingslider.BackColor = System.Drawing.Color.Transparent;
            this.trimmingslider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.trimmingslider.BorderRadius = 0;
            this.trimmingslider.IndicatorColor = System.Drawing.Color.Magenta;
            this.trimmingslider.Location = new System.Drawing.Point(160, 241);
            this.trimmingslider.Margin = new System.Windows.Forms.Padding(5);
            this.trimmingslider.MaximumRange = 100;
            this.trimmingslider.Name = "trimmingslider";
            this.trimmingslider.RangeMax = 100;
            this.trimmingslider.RangeMin = 0;
            this.trimmingslider.Size = new System.Drawing.Size(733, 35);
            this.trimmingslider.TabIndex = 3;
            this.trimmingslider.RangeMaxChanged += new System.EventHandler(this.trimmingslider_RangeMaxChanged);
            this.trimmingslider.RangeMinChanged += new System.EventHandler(this.trimmingslider_RangeMinChanged);
            // 
            // lengthlabel
            // 
            this.lengthlabel.AllowParentOverrides = false;
            this.lengthlabel.AutoEllipsis = false;
            this.lengthlabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.lengthlabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.lengthlabel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthlabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lengthlabel.Location = new System.Drawing.Point(947, 241);
            this.lengthlabel.Margin = new System.Windows.Forms.Padding(4);
            this.lengthlabel.Name = "lengthlabel";
            this.lengthlabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lengthlabel.Size = new System.Drawing.Size(111, 26);
            this.lengthlabel.TabIndex = 4;
            this.lengthlabel.Text = "Song Length";
            this.lengthlabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lengthlabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // startlabel
            // 
            this.startlabel.AutoSize = true;
            this.startlabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startlabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.startlabel.Location = new System.Drawing.Point(140, 207);
            this.startlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startlabel.Name = "startlabel";
            this.startlabel.Size = new System.Drawing.Size(90, 25);
            this.startlabel.TabIndex = 5;
            this.startlabel.Text = "starttime";
            // 
            // endlabel
            // 
            this.endlabel.AutoSize = true;
            this.endlabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endlabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.endlabel.Location = new System.Drawing.Point(853, 207);
            this.endlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endlabel.Name = "endlabel";
            this.endlabel.Size = new System.Drawing.Size(84, 25);
            this.endlabel.TabIndex = 6;
            this.endlabel.Text = "endtime";
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Save";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges3;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Purple;
            this.bunifuButton1.IdleBorderRadius = 1;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(901, 353);
            this.bunifuButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 1;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.BorderRadius = 1;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.Purple;
            this.bunifuButton1.OnIdleState.BorderRadius = 1;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 1;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(124, 29);
            this.bunifuButton1.TabIndex = 7;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // namebox
            // 
            this.namebox.AcceptsReturn = false;
            this.namebox.AcceptsTab = false;
            this.namebox.AnimationSpeed = 200;
            this.namebox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.namebox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.namebox.BackColor = System.Drawing.Color.Transparent;
            this.namebox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("namebox.BackgroundImage")));
            this.namebox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.namebox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.namebox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.namebox.BorderColorIdle = System.Drawing.Color.Silver;
            this.namebox.BorderRadius = 1;
            this.namebox.BorderThickness = 1;
            this.namebox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.namebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.namebox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.namebox.DefaultText = "";
            this.namebox.FillColor = System.Drawing.Color.White;
            this.namebox.HideSelection = true;
            this.namebox.IconLeft = null;
            this.namebox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.namebox.IconPadding = 10;
            this.namebox.IconRight = null;
            this.namebox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.namebox.Lines = new string[0];
            this.namebox.Location = new System.Drawing.Point(382, 128);
            this.namebox.Margin = new System.Windows.Forms.Padding(4);
            this.namebox.MaxLength = 32767;
            this.namebox.MinimumSize = new System.Drawing.Size(1, 1);
            this.namebox.Modified = false;
            this.namebox.Multiline = false;
            this.namebox.Name = "namebox";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.namebox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.namebox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.namebox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.namebox.OnIdleState = stateProperties8;
            this.namebox.Padding = new System.Windows.Forms.Padding(4);
            this.namebox.PasswordChar = '\0';
            this.namebox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.namebox.PlaceholderText = "Enter text";
            this.namebox.ReadOnly = false;
            this.namebox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.namebox.SelectedText = "";
            this.namebox.SelectionLength = 0;
            this.namebox.SelectionStart = 0;
            this.namebox.ShortcutsEnabled = true;
            this.namebox.Size = new System.Drawing.Size(291, 33);
            this.namebox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.namebox.TabIndex = 9;
            this.namebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.namebox.TextMarginBottom = 0;
            this.namebox.TextMarginLeft = 3;
            this.namebox.TextMarginTop = 0;
            this.namebox.TextPlaceholder = "Enter text";
            this.namebox.UseSystemPasswordChar = false;
            this.namebox.WordWrap = true;
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
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.cancelButton.CustomizableEdges = borderEdges4;
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
            this.cancelButton.Location = new System.Drawing.Point(751, 353);
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
            this.cancelButton.TabIndex = 7;
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.cancelButton.TextMarginLeft = 0;
            this.cancelButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.cancelButton.UseDefaultRadiusAndThickness = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // dragPanel
            // 
            this.dragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(1068, 78);
            this.dragPanel.TabIndex = 10;
            // 
            // trimFormDragControl
            // 
            this.trimFormDragControl.Fixed = true;
            this.trimFormDragControl.Horizontal = true;
            this.trimFormDragControl.TargetControl = this.dragPanel;
            this.trimFormDragControl.Vertical = true;
            // 
            // TrimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1068, 423);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.endlabel);
            this.Controls.Add(this.startlabel);
            this.Controls.Add(this.lengthlabel);
            this.Controls.Add(this.trimmingslider);
            this.Controls.Add(this.bunifuLabel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TrimForm";
            this.Text = "trimmingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.Framework.UI.BunifuRange trimmingslider;
        private Bunifu.UI.WinForms.BunifuLabel lengthlabel;
        private System.Windows.Forms.Label startlabel;
        private System.Windows.Forms.Label endlabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuTextBox namebox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton cancelButton;
        private System.Windows.Forms.Panel dragPanel;
        private Bunifu.Framework.UI.BunifuDragControl trimFormDragControl;
    }
}