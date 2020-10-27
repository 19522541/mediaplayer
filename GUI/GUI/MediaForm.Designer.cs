namespace GUI
{
    partial class MediaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaForm));
            this.songDataGridView = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.songInforPanel = new System.Windows.Forms.Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.songPicture = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.songDataGridView.SuspendLayout();
            this.songInforPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // songDataGridView
            // 
            this.songDataGridView.Controls.Add(this.label3);
            this.songDataGridView.Controls.Add(this.label1);
            this.songDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songDataGridView.Location = new System.Drawing.Point(0, 0);
            this.songDataGridView.Name = "songDataGridView";
            this.songDataGridView.Size = new System.Drawing.Size(1300, 876);
            this.songDataGridView.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(406, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 76);
            this.label1.TabIndex = 2;
            this.label1.Text = "Music Data Grid";
            // 
            // songInforPanel
            // 
            this.songInforPanel.Controls.Add(this.bunifuLabel1);
            this.songInforPanel.Controls.Add(this.songPicture);
            this.songInforPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.songInforPanel.Location = new System.Drawing.Point(0, 746);
            this.songInforPanel.Name = "songInforPanel";
            this.songInforPanel.Size = new System.Drawing.Size(1300, 130);
            this.songInforPanel.TabIndex = 1;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuLabel1.Location = new System.Drawing.Point(129, 37);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(158, 45);
            this.bunifuLabel1.TabIndex = 2;
            this.bunifuLabel1.Text = "songName";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // songPicture
            // 
            this.songPicture.AllowFocused = false;
            this.songPicture.AutoSizeHeight = true;
            this.songPicture.BorderRadius = 61;
            this.songPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.songPicture.Image = ((System.Drawing.Image)(resources.GetObject("songPicture.Image")));
            this.songPicture.IsCircle = true;
            this.songPicture.Location = new System.Drawing.Point(0, 0);
            this.songPicture.Name = "songPicture";
            this.songPicture.Size = new System.Drawing.Size(123, 123);
            this.songPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.songPicture.TabIndex = 0;
            this.songPicture.TabStop = false;
            this.songPicture.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 3;
            // 
            // MediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1300, 876);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.songInforPanel);
            this.Controls.Add(this.songDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MediaForm";
            this.Text = "MediaForm";
            this.songDataGridView.ResumeLayout(false);
            this.songDataGridView.PerformLayout();
            this.songInforPanel.ResumeLayout(false);
            this.songInforPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel songDataGridView;
        private System.Windows.Forms.Panel songInforPanel;
        private Bunifu.UI.WinForms.BunifuPictureBox songPicture;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}