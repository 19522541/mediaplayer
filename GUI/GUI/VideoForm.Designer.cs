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
            this.videolistView = new System.Windows.Forms.ListView();
            this.emptyListLabel = new Bunifu.UI.WinForms.BunifuLabel();
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
            this.videolistView.DoubleClick += new System.EventHandler(this.videolistView_DoubleClick);
            this.videolistView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.videolistView_MouseDoubleClick);
            // 
            // emptyListLabel
            // 
            this.emptyListLabel.AllowParentOverrides = false;
            this.emptyListLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emptyListLabel.AutoEllipsis = false;
            this.emptyListLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.emptyListLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.emptyListLabel.Font = new System.Drawing.Font("Malgun Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyListLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emptyListLabel.Location = new System.Drawing.Point(525, 33);
            this.emptyListLabel.Name = "emptyListLabel";
            this.emptyListLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.emptyListLabel.Size = new System.Drawing.Size(388, 62);
            this.emptyListLabel.TabIndex = 1;
            this.emptyListLabel.Text = "Video Not Found";
            this.emptyListLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.emptyListLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // VideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1300, 876);
            this.Controls.Add(this.emptyListLabel);
            this.Controls.Add(this.videolistView);
            this.Name = "VideoForm";
            this.Text = "VideoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView videolistView;
        private Bunifu.UI.WinForms.BunifuLabel emptyListLabel;
    }
}