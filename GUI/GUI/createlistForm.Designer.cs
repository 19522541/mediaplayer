﻿namespace GUI
{
    partial class createlistForm
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
            this.listname = new System.Windows.Forms.TextBox();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.createbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listname
            // 
            this.listname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listname.Location = new System.Drawing.Point(205, 56);
            this.listname.Name = "listname";
            this.listname.Size = new System.Drawing.Size(254, 29);
            this.listname.TabIndex = 0;
            this.listname.TextChanged += new System.EventHandler(this.listname_TextChanged);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(501, 126);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(95, 35);
            this.cancelbutton.TabIndex = 1;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // createbutton
            // 
            this.createbutton.Location = new System.Drawing.Point(360, 126);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(91, 35);
            this.createbutton.TabIndex = 2;
            this.createbutton.Text = "OK";
            this.createbutton.UseVisualStyleBackColor = true;
            this.createbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // createlistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 246);
            this.Controls.Add(this.createbutton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.listname);
            this.Name = "createlistForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button createbutton;
        public System.Windows.Forms.TextBox listname;
    }
}