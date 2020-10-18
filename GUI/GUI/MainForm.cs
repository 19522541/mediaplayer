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
        private int _bfHoverIndex = 0;
        
        public MainForm()
        {
            InitializeComponent();
            setup();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

        }


        //-------------------function------------------//
        private void setup()
        { 
            mediaSubMenu.Visible = false;
            videoSubMenu.Visible = false;
            playlistSubMenu.Visible = false;
            
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
        
       
        
        //---------------------event-----------------//

        private void playButton_Click(object sender, EventArgs e)
        {
            //code de dung nhac//
            
            processBar.Minimum = 0;
            processBar.Maximum = 100;
            
            int i;
           
            {
                //status = false;
                for (i = 0; i <= 100; i++)
                {
                    processBar.Value = i;
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color;
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            if (randomButton.ImageIndex != 0 && randomButton.ImageIndex != 2)
                randomButton.ImageIndex = 0;
            else
                randomButton.ImageIndex = 1;
            this._bfHoverIndex = randomButton.ImageIndex;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            
        }

        private void loopButton_Click(object sender, EventArgs e)
        {
            
        }

        private void nextButton_MouseDown(object sender, MouseEventArgs e)
        {
            nextButton.ImageIndex = 1;
        }

        private void nextButton_MouseUp(object sender, MouseEventArgs e)
        {
            nextButton.ImageIndex = 2;
        }

        private void backButton_MouseDown(object sender, MouseEventArgs e)
        {
           backButton.ImageIndex = 1;
        }


        private void backButton_MouseUp(object sender, MouseEventArgs e)
        {
            backButton.ImageIndex = 2;
        }

        private void randomButton_MouseHover(object sender, EventArgs e)
        {
            this._bfHoverIndex = randomButton.ImageIndex;
            if (this._bfHoverIndex == 0)
            {
                randomButton.ImageIndex = 2;
            }
            else
            {
                randomButton.ImageIndex = 3;
            }
        }

        private void randomButton_MouseLeave(object sender, EventArgs e)
        {
            randomButton.ImageIndex = this._bfHoverIndex;
        }

        private void backButton_MouseHover(object sender, EventArgs e)
        {
            backButton.ImageIndex = 2;
            
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {

            backButton.ImageIndex = 0;
        }

        private void nextButton_MouseHover(object sender, EventArgs e)
        {
            nextButton.ImageIndex = 2;
        }

        private void nextButton_MouseLeave(object sender, EventArgs e)
        {
            nextButton.ImageIndex = 0;
        }

        private void playButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (playButton.ImageIndex == 2)
            {
                playButton.ImageIndex = 4;
            }
            else
            {
                playButton.ImageIndex = 5;
            }
        }

        private void playButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (playButton.ImageIndex == 4)
            {
                playButton.ImageIndex = 3;
            }
            else
            {
                playButton.ImageIndex = 2;
            }

            if (playButton.ImageIndex == 3)
            {
                this._bfHoverIndex = 1;
            }
            else
            {
                this._bfHoverIndex = 0;
            }
        }

        private void playButton_MouseHover(object sender, EventArgs e)
        {
            this._bfHoverIndex = playButton.ImageIndex;
            if (playButton.ImageIndex == 0)
            {
                playButton.ImageIndex = 2;
            }
            else
            {
                playButton.ImageIndex = 3;
            }
        }

        private void playButton_MouseLeave(object sender, EventArgs e)
        {
            playButton.ImageIndex = this._bfHoverIndex;
        }

        private void exitButton_MouseHover(object sender, EventArgs e)
        {
            exitButton.ImageIndex = 1;
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.ImageIndex = 0;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void sideMenuButton_Click(object sender, EventArgs e)
        {
            if (this.sideMenuPanel.Width > 150)
            {
                this.sideMenuPanel.Width /= 4;
            }
            else
            {
                this.sideMenuPanel.Width *= 4;
            }
        }

        private void sideMenuButton_MouseHover(object sender, EventArgs e)
        {
            sideMenuButton.ImageIndex = 1;
        }

        private void sideMenuButton_MouseLeave(object sender, EventArgs e)
        {
            sideMenuButton.ImageIndex = 0;
        }

        private void mediaButton_MouseHover(object sender, EventArgs e)
        {
            mediaButton.BackColor = Color.FromArgb(37, 37, 38);
        }

        private void mediaButton_MouseLeave(object sender, EventArgs e)
        {
            mediaButton.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void playlistButton_MouseHover(object sender, EventArgs e)
        {
            playlistButton.BackColor = Color.FromArgb(37, 37, 38);
        }

        private void playlistButton_MouseLeave(object sender, EventArgs e)
        {
            playlistButton.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void pictureButton_MouseHover(object sender, EventArgs e)
        {
            pictureButton.BackColor = Color.FromArgb(37, 37, 38);
        }

        private void pictureButton_MouseLeave(object sender, EventArgs e)
        {
            pictureButton.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void videoButton_MouseHover(object sender, EventArgs e)
        {
            videoButton.BackColor = Color.FromArgb(37, 37, 38);

        }

        private void videoButton_MouseLeave(object sender, EventArgs e)
        {
            videoButton.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void helpButton_MouseHover(object sender, EventArgs e)
        {
            helpButton.BackColor = Color.FromArgb(37, 37, 38);
        }

        private void helpButton_MouseLeave(object sender, EventArgs e)
        {
            helpButton.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void mediaButton_Click(object sender, EventArgs e)
        {
            if (sideMenuPanel.Width < 70)
            {
                sideMenuButton_Click(sender, e);
            }
            showSubMenu(mediaSubMenu);

            //openNewForm(newForm);
        }

        private void playlistButton_Click(object sender, EventArgs e)
        {
            
            if (sideMenuPanel.Width < 70)
            {
                sideMenuButton_Click(sender, e);
            }
            showSubMenu(playlistSubMenu);
            PlayListForm newForm = new PlayListForm();
            openNewForm(newForm);
        }

        private void pictureButton_Click(object sender, EventArgs e)
        {
            PictureForm newForm = new PictureForm();
            openNewForm(newForm);
        }

        private void videoButton_Click(object sender, EventArgs e)
        {
            if (sideMenuPanel.Width < 70)
            {
                sideMenuButton_Click(sender, e);
            }
            showSubMenu(videoSubMenu);
            VideoForm newForm = new VideoForm();
            openNewForm(newForm);
        }
    }
}
