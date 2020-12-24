
namespace GUI
{
    partial class trimmingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trimmingForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.trimmingslider = new Bunifu.Framework.UI.BunifuRange();
            this.lengthlabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.startlabel = new System.Windows.Forms.Label();
            this.endlabel = new System.Windows.Forms.Label();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.button1 = new System.Windows.Forms.Button();
            this.namebox = new Bunifu.UI.WinForms.BunifuTextBox();
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
            this.bunifuLabel1.Location = new System.Drawing.Point(109, 109);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(98, 22);
            this.bunifuLabel1.TabIndex = 2;
            this.bunifuLabel1.Text = "bunifuLabel1";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // trimmingslider
            // 
            this.trimmingslider.BackColor = System.Drawing.Color.Transparent;
            this.trimmingslider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.trimmingslider.BorderRadius = 0;
            this.trimmingslider.IndicatorColor = System.Drawing.Color.Magenta;
            this.trimmingslider.Location = new System.Drawing.Point(120, 196);
            this.trimmingslider.MaximumRange = 100;
            this.trimmingslider.Name = "trimmingslider";
            this.trimmingslider.RangeMax = 100;
            this.trimmingslider.RangeMin = 0;
            this.trimmingslider.Size = new System.Drawing.Size(550, 30);
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
            this.lengthlabel.Location = new System.Drawing.Point(710, 196);
            this.lengthlabel.Name = "lengthlabel";
            this.lengthlabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lengthlabel.Size = new System.Drawing.Size(77, 21);
            this.lengthlabel.TabIndex = 4;
            this.lengthlabel.Text = "lengthlabel";
            this.lengthlabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lengthlabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // startlabel
            // 
            this.startlabel.AutoSize = true;
            this.startlabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startlabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.startlabel.Location = new System.Drawing.Point(105, 168);
            this.startlabel.Name = "startlabel";
            this.startlabel.Size = new System.Drawing.Size(72, 21);
            this.startlabel.TabIndex = 5;
            this.startlabel.Text = "starttime";
            // 
            // endlabel
            // 
            this.endlabel.AutoSize = true;
            this.endlabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endlabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.endlabel.Location = new System.Drawing.Point(640, 168);
            this.endlabel.Name = "endlabel";
            this.endlabel.Size = new System.Drawing.Size(67, 21);
            this.endlabel.TabIndex = 6;
            this.endlabel.Text = "endtime";
            this.endlabel.Click += new System.EventHandler(this.label2_Click);
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
            this.bunifuButton1.ButtonText = "Path";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges1;
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
            this.bunifuButton1.Location = new System.Drawing.Point(644, 268);
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
            this.bunifuButton1.Size = new System.Drawing.Size(93, 39);
            this.bunifuButton1.TabIndex = 7;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(78, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 45);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.namebox.Location = new System.Drawing.Point(335, 87);
            this.namebox.MaxLength = 32767;
            this.namebox.MinimumSize = new System.Drawing.Size(1, 1);
            this.namebox.Modified = false;
            this.namebox.Multiline = false;
            this.namebox.Name = "namebox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.namebox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.namebox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.namebox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.namebox.OnIdleState = stateProperties4;
            this.namebox.Padding = new System.Windows.Forms.Padding(3);
            this.namebox.PasswordChar = '\0';
            this.namebox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.namebox.PlaceholderText = "Enter text";
            this.namebox.ReadOnly = false;
            this.namebox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.namebox.SelectedText = "";
            this.namebox.SelectionLength = 0;
            this.namebox.SelectionStart = 0;
            this.namebox.ShortcutsEnabled = true;
            this.namebox.Size = new System.Drawing.Size(218, 34);
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
            // trimmingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(801, 344);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.endlabel);
            this.Controls.Add(this.startlabel);
            this.Controls.Add(this.lengthlabel);
            this.Controls.Add(this.trimmingslider);
            this.Controls.Add(this.bunifuLabel1);
            this.Name = "trimmingForm";
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
        private System.Windows.Forms.Button button1;
        private Bunifu.UI.WinForms.BunifuTextBox namebox;
    }
}