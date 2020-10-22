using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AudioSwitcher.AudioApi.CoreAudio;
using NAudio.Dmo;
using Utilities.BunifuButton.Transitions;

namespace GUI
{
    public partial class MainForm : Form
    {
        private Form _activeForm = null;
        private int _bfHoverIndex = 1;
        Player _music;
        private CoreAudioDevice _playBackDevice;
        private List<String> _list;
        private int _nowPlayIndex = 0;
        private int _check = 0;
        int min = 0;
        int sed = 0;
        public MainForm()
        { 
            InitializeComponent();
            setup();
            this.Text = String.Empty;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this._playBackDevice = new CoreAudioController().DefaultPlaybackDevice;
            this._list = new List<String>();
            this._list.Add("D:\\bt2\\test5.mp3");
            this._list.Add("D:\\bt2\\test1.wav");
            this._list.Add("D:\\bt2\\test2.wav");
            this._list.Add("D:\\bt2\\test3.wav");
            this._list.Add("D:\\bt2\\test4.wav");
            
            this.soundVolumeBar.Value = Convert.ToInt32(this._playBackDevice.Volume);
            if (this._list[this._nowPlayIndex].Contains(".wav"))
            {
                _music = new Sound(this._list[this._nowPlayIndex]);
            }
            else if (this._list[this._nowPlayIndex].Contains(".mp3"))
            {
                _music = new Mp3Player(this._list[this._nowPlayIndex]);
            }
            //  music = new Sound("");//dung tam 1 file .wav hay mp3 vi ko thay phan chuyen file 



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

        public String getCurTime(int time)
        {
            String rs = "";
            int mins = Convert.ToInt32(time) / 60;
            int second = Convert.ToInt32(time) % 60;
            string minStr, sedStr;
            if (mins < 10)
            {
                minStr = "0" + mins.ToString();
            }
            else
            {
                minStr = mins.ToString();
            }

            if (second < 10)
            {
                sedStr = "0" + second.ToString();
            }
            else
            {
                sedStr = second.ToString();
            }
            rs = minStr + ":" + sedStr;
            return rs;
            return rs;
        }

        //---------------------event-----------------//


        //
        // Play button
        //
        private void playButton_Click(object sender, EventArgs e)
        {
            //code de dung nhac//
            stopButton.Enabled = true;
            stopButton.Visible = true;
            playButton.Enabled = false;
            playButton.Visible = false;
            songLength.Text = this._music.getSongLength();
            //music.SettimeAudio(musicProcessBar.Value);
            //music.DisposeWave();
           
            musicProcessBar.Minimum = 0;
            musicProcessBar.Maximum = this._music.getTime();//tao gia tri cho musicProcessBar moi khi chon file
            min = 0;
            sed = 0;
            musicBarTimer.Start();
            count.Start();
            songLength.Text = _music.getSongLength();
            _music.start();
            
            
            

        }

        private void playButton_MouseDown(object sender, MouseEventArgs e)
        {
            playButton.ImageIndex = 1;
        }

        private void playButton_MouseUp(object sender, MouseEventArgs e)
        {
            playButton.ImageIndex = 2;
        }

        private void playButton_MouseHover(object sender, EventArgs e)
        {
            playButton.ImageIndex = 2;
        }

        private void playButton_MouseLeave(object sender, EventArgs e)
        {
            playButton.ImageIndex = 0;
        }
        //
        // Stop button
        //
        private void stopButton_Click(object sender, EventArgs e)
        {
            stopButton.Enabled = false;
            stopButton.Visible = false;
            playButton.Enabled = true;
            playButton.Visible = true;
            musicBarTimer.Stop();
            count.Stop();
            this._music.pause();
        }
        private void stopButton_MouseDown(object sender, MouseEventArgs e)
        {
            stopButton.ImageIndex = 2;
        }

        private void stopButton_MouseHover(object sender, EventArgs e)
        {
            stopButton.ImageIndex = 1;
        }

        private void stopButton_MouseLeave(object sender, EventArgs e)
        {
            stopButton.ImageIndex = 0;
        }

        private void stopButton_MouseUp(object sender, MouseEventArgs e)
        {
            stopButton.ImageIndex = 1;
        }
        //
        // Back button
        //
        private void backButton_Click(object sender, EventArgs e)
        {
            this._music.stop();
            this.musicProcessBar.Value = 0;
            this._check = 0;
            this._music = null;
            if (this._nowPlayIndex == 0) this._nowPlayIndex = this._list.Count - 1;
            else if (this._nowPlayIndex < this._list.Count - 1) this._nowPlayIndex--;
            if (this._list[this._nowPlayIndex].Contains(".wav"))
            {
                _music = new Sound(this._list[this._nowPlayIndex]);
            }
            else if (this._list[this._nowPlayIndex].Contains(".mp3"))
            {
                _music = new Mp3Player(this._list[this._nowPlayIndex]);
            }
            playButton_Click(sender, e);
            
        }

        private void backButton_MouseDown(object sender, MouseEventArgs e)
        {
            count.Stop();
            musicBarTimer.Stop();
            this._music.stop();
            backButton.ImageIndex = 1;
            playButton.Visible = true;
            stopButton.Visible = false;
        }


        private void backButton_MouseUp(object sender, MouseEventArgs e)
        {
            backButton.ImageIndex = 2;
            playButton.Visible = false;
            stopButton.Visible = true;
        }

        private void backButton_MouseHover(object sender, EventArgs e)
        {
            backButton.ImageIndex = 2;

        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {

            backButton.ImageIndex = 0;
        }
        //
        // Random button
        //
        private void randomButton_Click(object sender, EventArgs e)
        {
            if (randomButton.ImageIndex != 0 && randomButton.ImageIndex != 2)
                randomButton.ImageIndex = 0;
            else
                randomButton.ImageIndex = 1;
            this._bfHoverIndex = randomButton.ImageIndex;
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

        //
        // Next button
        //
        private void nextButton_Click(object sender, EventArgs e)
        {
            this._music.stop();
            musicProcessBar.Value = 0;
            this._check = 0;
            this._music = null;
            if (this._nowPlayIndex < this._list.Count - 1) this._nowPlayIndex++;
            else this._nowPlayIndex = 0;
            if (this._list[this._nowPlayIndex].Contains(".wav"))
            {
                _music = new Sound(this._list[this._nowPlayIndex]);
            }
            else if (this._list[this._nowPlayIndex].Contains(".mp3"))
            {
                _music = new Mp3Player(this._list[this._nowPlayIndex]);
            }
            playButton_Click(sender, e);
        }

        private void nextButton_MouseDown(object sender, MouseEventArgs e)
        {
            count.Stop();
            musicBarTimer.Stop();
            this._music.stop();
            nextButton.ImageIndex = 1;
            playButton.Visible = true;
            stopButton.Visible = false;
        }

        private void nextButton_MouseUp(object sender, MouseEventArgs e)
        {
            nextButton.ImageIndex = 2;
            playButton.Visible = false;
            stopButton.Visible = true;
        }

        private void nextButton_MouseHover(object sender, EventArgs e)
        {
            nextButton.ImageIndex = 2;
        }

        private void nextButton_MouseLeave(object sender, EventArgs e)
        {
            nextButton.ImageIndex = 0;
        }
        //
        // Loop button
        //
        private void loopButton_Click(object sender, EventArgs e)
        {
            
        }
        //
        // Exit button
        //
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
        //
        // Drag app
        //
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //
        // Side Menu Button
        //
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
        //
        // Side menu button
        //
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
        //
        // music bar
        //
        private void musicProcessBar_Click(object sender, EventArgs e)
        {
          //_music.SettimeAudio(musicProcessBar.Value);
        }
        private void musicProcessBar_MouseDown(object sender, MouseEventArgs e)
        {
            this._music.stop();
            playButton.Visible = true;
            playButton.Enabled = true;
            stopButton.Visible = false;
            stopButton.Enabled = false;
        }

        private void musicProcessBar_MouseUp(object sender, MouseEventArgs e)
        {
            playButton.Visible = false;
            playButton.Enabled = false;
            stopButton.Visible = true;
            stopButton.Enabled = true;
            this._music.start();
        }

        private void musicProcessBar_ValueChanged(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs e)
        {
            if (musicProcessBar.Value == musicProcessBar.Maximum)
            {
                nextButton_Click(sender, e);
            }
            if (musicProcessBar.Value - this._check != 1)
            {
                TimeSpan x = TimeSpan.FromSeconds(musicProcessBar.Value);
                this._music.setCur(x); 
                
            }
            time.Text = getCurTime(musicProcessBar.Value);
            this._check = musicProcessBar.Value;


        }
        //
        // sound volume
        //
        private void soundVolumeBar_Scroll(object sender, EventArgs e)
        {
          this._playBackDevice.Volume = soundVolumeBar.Value;
            //float x = this.soundVolumeBar.Value;
            //x = x / 100;
         //this.music.setvolum(x);
        }
        
        //
        // music bar timer
        //
        private void musicBarTimer_Tick(object sender, EventArgs e)
        {
           this.musicProcessBar.Value++;
            

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        
        private void timeSync_Tick(object sender, EventArgs e)
        {

        }


        //
        // Open button
        //
        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "WAV file (*.wav)| *.wav";
            if (open.ShowDialog() != DialogResult.OK) return;
            this._list.Insert(0, open.FileName);
            //this.playButton.ImageIndex = 0;
            playButton_Click(sender, e);
        }
        //
        // Song Time Label
        //
        private void count_Tick(object sender, EventArgs e)
        {
            if (sed < 60)
            {
                sed++;

            }
            else
            {
                min++;
                sed = 0;
            }

            String strSed, strMin;
            if (sed < 10) strSed = "0" + sed.ToString();
            else strSed = sed.ToString();
            if (min < 1) strMin = "0" + min.ToString();
            else strMin = min.ToString();
            time.Text = (strMin + ":" + strSed);
        }

        private void volumeSlider1_Load(object sender, EventArgs e)
        {

        }

        private void soundButton_Click(object sender, EventArgs e)
        {

        }

      
    }
}
