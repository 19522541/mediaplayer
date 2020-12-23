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
            this.label1 = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.listpanel = new System.Windows.Forms.Panel();
            this.namelist = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.imagelist = new System.Windows.Forms.PictureBox();
            this.listpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagelist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "PlayList";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(118, 29);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(105, 34);
            this.addbutton.TabIndex = 3;
            this.addbutton.Text = "Create ";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // listpanel
            // 
            this.listpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listpanel.Controls.Add(this.namelist);
            this.listpanel.Controls.Add(this.imagelist);
            this.listpanel.Location = new System.Drawing.Point(67, 99);
            this.listpanel.Name = "listpanel";
            this.listpanel.Size = new System.Drawing.Size(139, 160);
            this.listpanel.TabIndex = 4;
            // 
            // namelist
            // 
            this.namelist.AutoSize = true;
            this.namelist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelist.ForeColor = System.Drawing.Color.Magenta;
            this.namelist.Location = new System.Drawing.Point(34, 131);
            this.namelist.Name = "namelist";
            this.namelist.Size = new System.Drawing.Size(68, 20);
            this.namelist.TabIndex = 1;
            this.namelist.Text = "namelist";
            this.namelist.Click += new System.EventHandler(this.namelist_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // imagelist
            // 
            this.imagelist.Dock = System.Windows.Forms.DockStyle.Top;
            this.imagelist.Location = new System.Drawing.Point(0, 0);
            this.imagelist.Name = "imagelist";
            this.imagelist.Size = new System.Drawing.Size(139, 125);
            this.imagelist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagelist.TabIndex = 0;
            this.imagelist.TabStop = false;
            this.imagelist.Click += new System.EventHandler(this.imagelist_Click);
            // 
            // PlayListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(975, 609);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listpanel);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlayListForm";
            this.Text = "PlayListForm";
            this.listpanel.ResumeLayout(false);
            this.listpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagelist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Panel listpanel;
        private System.Windows.Forms.Label namelist;
        private System.Windows.Forms.PictureBox imagelist;
        private System.Windows.Forms.Button button1;
    }
}