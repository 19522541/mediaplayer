namespace GUI
{
    partial class PlayListForm
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
            this.playListView = new System.Windows.Forms.ListView();
            this.playlistName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // playListView
            // 
            this.playListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.playListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.playlistName});
            this.playListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playListView.HideSelection = false;
            this.playListView.Location = new System.Drawing.Point(0, 0);
            this.playListView.Name = "playListView";
            this.playListView.Size = new System.Drawing.Size(1089, 471);
            this.playListView.TabIndex = 0;
            this.playListView.UseCompatibleStateImageBehavior = false;
            this.playListView.DoubleClick += new System.EventHandler(this.playListView_DoubleClick);
            // 
            // PlayListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1089, 471);
            this.Controls.Add(this.playListView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PlayListForm";
            this.Text = "PlayListForm";
            this.Load += new System.EventHandler(this.PlayListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView playListView;
        private System.Windows.Forms.ColumnHeader playlistName;
    }
}