using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public delegate void NewPlayListFormEventHandler(object sender, EventArgs e);
    public partial class NewPlayListForm : Form
    {
        private Form _parent;
        private string _imgDir = string.Empty;
        public event NewPlayListFormEventHandler Created;
        public string _songDir { get; set; }
        protected virtual void OnCreated()
        {
            if (Created != null)
                Created(this, EventArgs.Empty);
        }

        public NewPlayListForm()
        {
            InitializeComponent();
            
        }

        public NewPlayListForm(MainForm parent,String songDir)
        {
            InitializeComponent();
            this._parent = parent;
            this._songDir = songDir;

        }

        private void createButton_MouseLeave(object sender, EventArgs e)
        {
            this.createButton.ForeColor = SystemColors.GradientActiveCaption;
        }

    
        private void cancelButton_MouseLeave(object sender, EventArgs e)
        {
            this.cancelButton.ForeColor = SystemColors.GradientActiveCaption;
        }

        private void createButton_MouseEnter(object sender, EventArgs e)
        {
            this.createButton.ForeColor = Color.FromArgb(250, 58, 95);
        }

        private void cancelButton_MouseEnter(object sender, EventArgs e)
        {
            this.cancelButton.ForeColor = Color.FromArgb(250, 58, 95);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //this.Close

            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            String playlistName;
            if (getPlaylistName.Text == "")
            {
                playlistName = "New Playlist";
            }
            else
            {
                playlistName = getPlaylistName.Text;
            }
            ((MainForm)this._parent)._playListForm.addNewPlayList(playlistName, this._imgDir, _songDir);
            this.Close();
        }

        private void playlistPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                _imgDir = openFileDialog.FileName;
                this.playlistPic.SizeMode = PictureBoxSizeMode.StretchImage;
                this.playlistPic.Image = Image.FromFile(_imgDir);
            }
        }

        
    }
}
