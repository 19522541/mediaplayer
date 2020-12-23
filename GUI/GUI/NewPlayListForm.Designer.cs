namespace GUI
{
    partial class NewPlayListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPlayListForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.getPlaylistName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.playlistPic = new System.Windows.Forms.PictureBox();
            this.movingPanel = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.playlistPic)).BeginInit();
            this.movingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.createButton.FlatAppearance.BorderSize = 0;
            this.createButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.createButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.createButton.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.createButton.Location = new System.Drawing.Point(156, 317);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(144, 36);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create playlist";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            this.createButton.MouseEnter += new System.EventHandler(this.createButton_MouseEnter);
            this.createButton.MouseLeave += new System.EventHandler(this.createButton_MouseLeave);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cancelButton.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cancelButton.Location = new System.Drawing.Point(189, 373);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(78, 33);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            this.cancelButton.MouseEnter += new System.EventHandler(this.cancelButton_MouseEnter);
            this.cancelButton.MouseLeave += new System.EventHandler(this.cancelButton_MouseLeave);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label.Location = new System.Drawing.Point(151, 268);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(159, 26);
            this.label.TabIndex = 2;
            this.label.Text = "Created by you";
            // 
            // getPlaylistName
            // 
            this.getPlaylistName.AcceptsReturn = false;
            this.getPlaylistName.AcceptsTab = false;
            this.getPlaylistName.AnimationSpeed = 200;
            this.getPlaylistName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.getPlaylistName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.getPlaylistName.BackColor = System.Drawing.Color.Transparent;
            this.getPlaylistName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("getPlaylistName.BackgroundImage")));
            this.getPlaylistName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.getPlaylistName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.getPlaylistName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.getPlaylistName.BorderColorIdle = System.Drawing.Color.Silver;
            this.getPlaylistName.BorderRadius = 1;
            this.getPlaylistName.BorderThickness = 1;
            this.getPlaylistName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.getPlaylistName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.getPlaylistName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.getPlaylistName.DefaultText = "";
            this.getPlaylistName.FillColor = System.Drawing.Color.White;
            this.getPlaylistName.HideSelection = true;
            this.getPlaylistName.IconLeft = null;
            this.getPlaylistName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.getPlaylistName.IconPadding = 10;
            this.getPlaylistName.IconRight = null;
            this.getPlaylistName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.getPlaylistName.Lines = new string[0];
            this.getPlaylistName.Location = new System.Drawing.Point(94, 208);
            this.getPlaylistName.MaxLength = 32767;
            this.getPlaylistName.MinimumSize = new System.Drawing.Size(1, 1);
            this.getPlaylistName.Modified = false;
            this.getPlaylistName.Multiline = false;
            this.getPlaylistName.Name = "getPlaylistName";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.getPlaylistName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.getPlaylistName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.getPlaylistName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.getPlaylistName.OnIdleState = stateProperties4;
            this.getPlaylistName.Padding = new System.Windows.Forms.Padding(3);
            this.getPlaylistName.PasswordChar = '\0';
            this.getPlaylistName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.getPlaylistName.PlaceholderText = "Enter playlist name";
            this.getPlaylistName.ReadOnly = false;
            this.getPlaylistName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.getPlaylistName.SelectedText = "";
            this.getPlaylistName.SelectionLength = 0;
            this.getPlaylistName.SelectionStart = 0;
            this.getPlaylistName.ShortcutsEnabled = true;
            this.getPlaylistName.Size = new System.Drawing.Size(269, 41);
            this.getPlaylistName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.getPlaylistName.TabIndex = 3;
            this.getPlaylistName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.getPlaylistName.TextMarginBottom = 0;
            this.getPlaylistName.TextMarginLeft = 3;
            this.getPlaylistName.TextMarginTop = 0;
            this.getPlaylistName.TextPlaceholder = "Enter playlist name";
            this.getPlaylistName.UseSystemPasswordChar = false;
            this.getPlaylistName.WordWrap = true;
            // 
            // playlistPic
            // 
            this.playlistPic.Image = global::GUI.Properties.Resources.icons8_video_playlist_100;
            this.playlistPic.Location = new System.Drawing.Point(179, 57);
            this.playlistPic.Name = "playlistPic";
            this.playlistPic.Size = new System.Drawing.Size(98, 100);
            this.playlistPic.TabIndex = 0;
            this.playlistPic.TabStop = false;
            this.playlistPic.Click += new System.EventHandler(this.playlistPic_Click);
            // 
            // movingPanel
            // 
            this.movingPanel.BackColor = System.Drawing.Color.Transparent;
            this.movingPanel.Controls.Add(this.playlistPic);
            this.movingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.movingPanel.Location = new System.Drawing.Point(0, 0);
            this.movingPanel.Name = "movingPanel";
            this.movingPanel.Size = new System.Drawing.Size(447, 180);
            this.movingPanel.TabIndex = 4;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.movingPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // NewPlayListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(49)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(447, 469);
            this.Controls.Add(this.getPlaylistName);
            this.Controls.Add(this.label);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.movingPanel);
            this.Name = "NewPlayListForm";
            this.Text = "NewPlayListForm";
            ((System.ComponentModel.ISupportInitialize)(this.playlistPic)).EndInit();
            this.movingPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playlistPic;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label;
        private Bunifu.UI.WinForms.BunifuTextBox getPlaylistName;
        private System.Windows.Forms.Panel movingPanel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}