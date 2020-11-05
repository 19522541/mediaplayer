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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.songDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.titleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.songDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // songDataGridView
            // 
            this.songDataGridView.AllowCustomTheming = true;
            this.songDataGridView.AllowUserToAddRows = false;
            this.songDataGridView.AllowUserToResizeColumns = false;
            this.songDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.songDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.songDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.songDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.songDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.songDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.songDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.songDataGridView.ColumnHeadersHeight = 40;
            this.songDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleCol,
            this.artistCol,
            this.albumCol,
            this.lengthCol});
            this.songDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.songDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.songDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.songDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.songDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.songDataGridView.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.songDataGridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.songDataGridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.songDataGridView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.songDataGridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.songDataGridView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.songDataGridView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.songDataGridView.CurrentTheme.Name = null;
            this.songDataGridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.songDataGridView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.songDataGridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.songDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.songDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.songDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.songDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songDataGridView.EnableHeadersVisualStyles = false;
            this.songDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.songDataGridView.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.songDataGridView.HeaderBgColor = System.Drawing.Color.Empty;
            this.songDataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.songDataGridView.Location = new System.Drawing.Point(0, 0);
            this.songDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.songDataGridView.Name = "songDataGridView";
            this.songDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.songDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.songDataGridView.RowHeadersVisible = false;
            this.songDataGridView.RowHeadersWidth = 51;
            this.songDataGridView.RowTemplate.Height = 40;
            this.songDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.songDataGridView.Size = new System.Drawing.Size(1089, 471);
            this.songDataGridView.TabIndex = 7;
            this.songDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.songDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.songDataGridView_CellContentDoubleClick);
            // 
            // titleCol
            // 
            this.titleCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleCol.FillWeight = 15F;
            this.titleCol.HeaderText = "Title";
            this.titleCol.MinimumWidth = 6;
            this.titleCol.Name = "titleCol";
            this.titleCol.ReadOnly = true;
            // 
            // artistCol
            // 
            this.artistCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.artistCol.FillWeight = 30F;
            this.artistCol.HeaderText = "Artist";
            this.artistCol.MinimumWidth = 6;
            this.artistCol.Name = "artistCol";
            this.artistCol.ReadOnly = true;
            // 
            // albumCol
            // 
            this.albumCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.albumCol.FillWeight = 25F;
            this.albumCol.HeaderText = "Album";
            this.albumCol.MinimumWidth = 6;
            this.albumCol.Name = "albumCol";
            this.albumCol.ReadOnly = true;
            // 
            // lengthCol
            // 
            this.lengthCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lengthCol.FillWeight = 15F;
            this.lengthCol.HeaderText = "Length";
            this.lengthCol.MinimumWidth = 6;
            this.lengthCol.Name = "lengthCol";
            this.lengthCol.ReadOnly = true;
            // 
            // MediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1089, 471);
            this.Controls.Add(this.songDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MediaForm";
            this.Text = "MediaForm";
            this.Load += new System.EventHandler(this.MediaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.songDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView songDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthCol;
    }
}