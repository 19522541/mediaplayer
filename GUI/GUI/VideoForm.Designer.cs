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
            this.videolistView = new System.Windows.Forms.ListView();
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
            // 
            // VideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1300, 876);
            this.Controls.Add(this.videolistView);
            this.Name = "VideoForm";
            this.Text = "VideoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView videolistView;
    }
}