using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {
        private Form _activeForm = null;
        public MainForm()
        {
            InitializeComponent();
            setup();
        }

        private void setup()
        { 
            mediaSubMenu.Visible = false;
            videoSubMenu.Visible = false;
            playlistSubMenu.Visible = false;
        }

        private void mediaButton_Click(object sender, EventArgs e)
        {
            showSubMenu(mediaSubMenu);
            
            //openNewForm(newForm);
        }

        private void playlistButton_Click(object sender, EventArgs e)
        {
            showSubMenu(playlistSubMenu);
            PlayListForm newForm = new PlayListForm();
            openNewForm(newForm);
        }

        private void pictureButton_Click(object sender, EventArgs e)
        {

        }

        private void videoButton_Click(object sender, EventArgs e)
        {
            showSubMenu(videoSubMenu);
            VideoForm newForm = new VideoForm();
            openNewForm(newForm);
        }

        private void hideSubMenu()
        {
            if (mediaSubMenu.Visible == true)
                mediaSubMenu.Visible = false;
            if (playlistSubMenu.Visible == true)
                playlistSubMenu.Visible = false;
            if (videoSubMenu.Visible == true)
                videoSubMenu.Visible = false;
        }

        private void showSubMenu(Panel temp)
        {
            if (temp.Visible == false)
            {
                hideSubMenu();
                temp.Visible = true;
            }
            else
            {
                temp.Visible = false;
            }
        }

        private void openNewForm(Form newForm)
        {
            if (this._activeForm != null)
            {
                this._activeForm.Close();
            }
            this._activeForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            mainMidPanel.Controls.Add(newForm);
            mainMidPanel.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();

        }
        //-------------------function------------------//
        private void changeImg(Button temp)
        {
            if (temp.ImageIndex != 0)
                temp.ImageIndex = 0;
            else
                temp.ImageIndex = 1;
        }
        //---------------------event-----------------//

        private void playButton_Click(object sender, EventArgs e)
        {
            //code de dung nhac//
            changeImg(playButton);
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            changeImg(randomButton);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            
        }

        private void loopButton_Click(object sender, EventArgs e)
        {
            changeImg(loopButton);
        }

        private void nextButton_MouseDown(object sender, MouseEventArgs e)
        {
            changeImg(nextButton);
        }

        private void nextButton_MouseUp(object sender, MouseEventArgs e)
        {
            changeImg(nextButton);
        }

        private void backButton_MouseDown(object sender, MouseEventArgs e)
        {
            changeImg(backButton);
        }


        private void backButton_MouseUp(object sender, MouseEventArgs e)
        {
            changeImg(backButton);
        }
    }
}
