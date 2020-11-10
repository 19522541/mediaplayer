using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AudioSwitcher.AudioApi.CoreAudio;
using Bunifu.UI.WinForms;
using Microsoft.WindowsAPICodePack.Dialogs;
namespace GUI
{
    public delegate void UserChoiceHandler(object sender, EventArgs e);
    public partial class MainForm : Form
    {
        
        private Form _activeForm = null;
        private int _bfHoverIndex = 0;
        private Player _music;
        private CoreAudioDevice _playBackDevice;
        private List<String> _list;
        private int _nowPlayIndex = 0;
        private int _check = 0;
        private int _min = 0;
        private int _sed = 0;
        private int _lastSoundValue = 0;
        private bool _random = false;
        private int _mouseX = 0;
        private MediaForm _mediaForm;
        private PictureForm _pictureForm;
        private VideoForm _videoForm;
        private PlayListForm _playListForm;
        private int _curForm = 0;
        private int _lastPlayed = -1;
        private bool _mediaCheck = false;
        private NowPlayingForm _nowPlayingForm;
        public MainForm()
        {
            
            InitializeComponent();
            
            this.Text = String.Empty;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this._playBackDevice = new CoreAudioController().DefaultPlaybackDevice;
            this._list = new List<String>();
            this.musicProcessBar.Enabled = false;
            setup();
            this.DoubleBuffered = true;
            this._mediaForm = new MediaForm(this, this._list);
            this._pictureForm = new PictureForm();
            this._videoForm = new VideoForm();
            this._playListForm = new PlayListForm();
            this._nowPlayingForm = new NowPlayingForm();
            this._mediaForm.UserChoiceChanged += playButton_Click;
            this._nowPlayingForm.FormBorderStyle = FormBorderStyle.None;
            this._nowPlayingForm.TopLevel = false;
            this.Dock = DockStyle.Left;
            this.mainBotPanel.Controls.Add(this._nowPlayingForm);
            _nowPlayingForm.BringToFront();
            this._nowPlayingForm.Visible = false;

        }


        //-------------------function------------------//
        private void setup()
        { 
            mediaSubMenu.Visible = false;
            videoSubMenu.Visible = false;
            playlistSubMenu.Visible = false;
            //   this.soundVolumeBar.Value = Convert.ToInt32(this._playBackDevice.Volume);
            this.soundVolumeBar.Value = 50;
          this._lastSoundValue = this.soundVolumeBar.Value;
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

        private void openNewForm(Form newForm, int index)
        {
            if (this._curForm == 1) this._mediaForm.Hide();
            else if (this._curForm == 2) this._playListForm.Hide();
            else if (this._curForm == 3) this._pictureForm.Hide();
            else if (this._curForm == 4) this._videoForm.Hide();
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            newForm.TopLevel = false;
            mainMidPanel.Controls.Add(newForm);
            mainMidPanel.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
            this._curForm = index;
        }

        void setSoundButtonImg()
        {
            if (soundVolumeBar.Value > 50)
            {
                soundButton.ImageIndex = 0; 
            }
            else if (soundVolumeBar.Value <= 50)
            {
                soundButton.ImageIndex = 1;
            }
        }

        void setMuteButtonImg()
        {
            if (soundVolumeBar.Value > 0)
            {
                muteButton.ImageIndex = 0;
            }
            else 
            {
                muteButton.ImageIndex = 1;
            }
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
            
        }

        //---------------------event-----------------//

        
        //
        // Play button
        //
        public void playButton_Click(object sender, EventArgs e)
        {
            
            if (this.musicProcessBar.Value == 0)
            {
                var fileTag = TagLib.File.Create(this._list[this._nowPlayIndex]);
                TimeSpan songlegth = fileTag.Properties.Duration;
                Image temp = null;
                if (fileTag.Tag.Pictures.Length >= 1)
                {
                    var bin = (byte[])(fileTag.Tag.Pictures[0].Data.Data);
                    temp = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(100, 100, null, IntPtr.Zero);
                }
                else
                {
                    temp = new Bitmap(GUI.Properties.Resources.songImg);
                }
                string songName = fileTag.Tag.Album;
                if (songName == null) songName = "Unknown";
                string artist = fileTag.Tag.FirstPerformer;
                if (artist == null) artist = "Unknown";
                this._nowPlayingForm.setNewInfo(temp,songName, artist);
                this._nowPlayingForm.Visible = true;
                //code de dung nhac//
                if (this._list[this._nowPlayIndex].Contains(".wav"))
                {
                    _music = new WavPlayer(this._list[this._nowPlayIndex]);
                }
                else if (this._list[this._nowPlayIndex].Contains(".mp3"))
                {
                    _music = new Mp3Player(this._list[this._nowPlayIndex]);
                }
                songLength.Text = songlegth.ToString(@"mm\:ss");
                if (this._lastPlayed != this._nowPlayIndex && this._mediaCheck)
                {
                    if (_lastPlayed == -1)
                    {
                        this._mediaForm.setup(_nowPlayIndex);
                        this._mediaForm.setLastPlayed(this._nowPlayIndex);
                    }
                    else
                    {
                        this._mediaForm.restart(_lastPlayed);
                        this._mediaForm.setup(_nowPlayIndex);
                        this._mediaForm.setLastPlayed(this._nowPlayIndex);
                    }
                }
            }
            this.musicProcessBar.Enabled = true;
            stopButton.Enabled = true;
            stopButton.Visible = true;
            playButton.Enabled = false;
            playButton.Visible = false;
            
            //music.SettimeAudio(musicProcessBar.Value);
            //music.DisposeWave();
           
            musicProcessBar.Minimum = 0;
            musicProcessBar.Maximum = this._music.getTime();//tao gia tri cho musicProcessBar moi khi chon file
            _min = 0;
            _sed = 0;
            musicBarTimer.Start();
            count.Start();
            
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
            stopButton.ImageIndex = 1;
        }

        private void stopButton_MouseHover(object sender, EventArgs e)
        {
            stopButton.ImageIndex = 2;
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
            this._lastPlayed = this._nowPlayIndex;
           
            if (!this._random)
            {
                if (this._nowPlayIndex > 0) this._nowPlayIndex--;
                else this._nowPlayIndex = this._nowPlayIndex = this._list.Count - 1;
            }
            else
            {
                int temp = this._nowPlayIndex;
                while (temp == this._nowPlayIndex)
                {
                    Random x = new Random();
                    this._nowPlayIndex = x.Next(0, this._list.Count - 1);
                }
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
            if (this._random)
            {
                this._random = false;
            }
            else
            {
                this._random = true;
            }

        }

        private void randomButton_MouseHover(object sender, EventArgs e)
        {
            this._bfHoverIndex = randomButton.ImageIndex;
            if (this._bfHoverIndex == 0)
            {
                randomButton.ImageIndex = 2;
            }
            else if (this._bfHoverIndex == 1)
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
            if (!musicProcessBar.Enabled) musicProcessBar.Enabled = true;
            this._music.stop();
            musicProcessBar.Value = 0;
            this._check = 0;
            this._lastPlayed = this._nowPlayIndex;
            if (!this._random)
            {
                if (this._nowPlayIndex < this._list.Count - 1) this._nowPlayIndex++;
                else this._nowPlayIndex = 0;
            }
            else
            {
                int temp = this._nowPlayIndex;
                while (temp == this._nowPlayIndex)
                {
                    Random x = new Random();
                    this._nowPlayIndex = x.Next(0, this._list.Count - 1);
                }
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
        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();
        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        //{
        //    ReleaseCapture();
        //    SendMessage(this.Handle, 0x112, 0xf012, 0);
        //}
        //
        // Side Menu Button
        //
        private void sideMenuButton_Click(object sender, EventArgs e)
        {
            
            if (this.sideMenuPanel.Width > 150)
            {
                sideMenuPanel.Visible = false;
                this.sideMenuPanel.Width -= this.sideMenuPanel.Width/4 *3;
                sideMenuAni.ShowSync(sideMenuPanel);
            }
            else
            {
                sideMenuPanel.Visible = false;
                this.sideMenuPanel.Width += this.sideMenuPanel.Width* 3;
                sideMenuAni.ShowSync(sideMenuPanel); 
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
            this._mediaCheck = true;
            if (sideMenuPanel.Width < 70)
            {
                sideMenuButton_Click(sender, e);
            }
            openNewForm(this._mediaForm,1);
            
            showSubMenu(mediaSubMenu);
            
        }

        private void playlistButton_Click(object sender, EventArgs e)
        {
            
            if (sideMenuPanel.Width < 70)
            {
                sideMenuButton_Click(sender, e);
            }
            showSubMenu(playlistSubMenu);
            
            openNewForm(this._playListForm,2);
        }

        private void pictureButton_Click(object sender, EventArgs e)
        {
            if (sideMenuPanel.Width < 70)
            {
                sideMenuButton_Click(sender, e);
            }
            openNewForm(this._pictureForm,3);
        }

        private void videoButton_Click(object sender, EventArgs e)
        {
            if (sideMenuPanel.Width < 70)
            {
                sideMenuButton_Click(sender, e);
            }
            showSubMenu(videoSubMenu);
            
            openNewForm(this._videoForm,4);
        }
        //
        // music bar
        //
        private void musicProcessBar_Click(object sender, EventArgs e)
        {
            int preVal = musicProcessBar.Value;
            int totalVal = musicProcessBar.Maximum - musicProcessBar.Minimum;
            int totalPix = musicProcessBar.Size.Width;
            float temp = (float)this._mouseX * totalVal / (float)totalPix;
            if (temp > preVal) temp-=2;
            else if (temp < preVal) temp+=2;
            musicProcessBar.Value = Convert.ToInt32(temp);
            

        }
        private void musicProcessBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (stopButton.Enabled == true)
            {
                //this._music.pause();
                //playButton.Visible = true;
                //playButton.Enabled = true;
                //stopButton.Visible = false;
                //stopButton.Enabled = false;
                stopButton_Click(sender, e);
            }
        }

        private void musicProcessBar_MouseUp(object sender, MouseEventArgs e)
        {
           
           if (musicProcessBar.Value - this._check != 1 && musicProcessBar.Value != 0)
           {
                TimeSpan x = TimeSpan.FromSeconds(musicProcessBar.Value);
                this._music.setCur(x);

           }
           //if (this.musicProcessBar.Value < this.musicProcessBar.Maximum) this._music.start();
           if (playButton.Enabled && this.musicProcessBar.Value < this.musicProcessBar.Maximum)
           {
                playButton_Click(sender, e);
           }
        }

        private void musicProcessBar_ValueChanged(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs e)
        {
            
            time.Text = getCurTime(musicProcessBar.Value);
            if (musicProcessBar.Value == musicProcessBar.Maximum)
            {
                musicProcessBar.Enabled = false;
                nextButton_Click(sender, e);
            }
            
            if (musicProcessBar.Focused == false)
            {
                if (musicProcessBar.Value - this._check != 1 && musicProcessBar.Value != 0)
                {
                    TimeSpan x = TimeSpan.FromSeconds(musicProcessBar.Value);
                    this._music.setCur(x);

               }
            }
            this._check = musicProcessBar.Value;
        }

        private void musicProcessBar_MouseMove(object sender, MouseEventArgs e)
        {
            this._mouseX = e.X;
        }
        private void musicProcessBar_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {

        }
        //
        // sound volume
        //
        private void soundVolumeBar_Scroll(object sender, EventArgs e)
        {
            //   this._playBackDevice.Volume = soundVolumeBar.Value;
            this._music.setvolumn(soundVolumeBar.Value);
            this._lastSoundValue = soundVolumeBar.Value; 
        }
        
        //
        // music bar timer
        //
        private void musicBarTimer_Tick(object sender, EventArgs e)
        {
           if (this.musicProcessBar.Value < this.musicProcessBar.Maximum)
            this.musicProcessBar.Value++;
            

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            int index = userName.IndexOf(@"\");
            string temp = userName.Substring(index + 1, userName.Length - index -1);
            string path = @"C:\Users\" + temp + @"\Music";
            DirectoryInfo musicFolder = new DirectoryInfo(path);
            FileInfo[] musicFiles = musicFolder.GetFiles("*.mp3");
            foreach (var x in musicFiles)
            {
                string dir = x.FullName;
                this._list.Add(x.FullName);
            }
            musicFiles = musicFolder.GetFiles("*.wav");
            foreach (var x in musicFiles)
            {
                string dir = x.FullName;
                this._list.Add(x.FullName);
            }
            if (this._list.Count > 0)
            {
                if (this._list[this._nowPlayIndex].Contains(".wav"))
                {
                    _music = new WavPlayer(this._list[this._nowPlayIndex]);
                }
                else if (this._list[this._nowPlayIndex].Contains(".mp3"))
                {
                    _music = new Mp3Player(this._list[this._nowPlayIndex]);
                }
            }
            else
            {
                MessageBox.Show("Hien tai khong co nhac");
            }
            

        }
        
        private void timeSync_Tick(object sender, EventArgs e)
        {

        }


        //
        // Open button
        //
        //Shrink problem
        private void openButton_Click(object sender, EventArgs e)
        {
            int temp = this._list.Count;
            CommonOpenFileDialog open = new CommonOpenFileDialog();
            open.InitialDirectory = "C:\\Users";
            open.IsFolderPicker = true;
            open.ShowDialog();
            var files = Directory.EnumerateFiles(open.FileName,"*.*", SearchOption.AllDirectories)
                .Where(s => s.EndsWith(".mp3") || s.EndsWith(".wav"));
            foreach( string filepath in files)
                this._list.Add(filepath);
            this.playButton.ImageIndex = 0;
            this._mediaForm.addNewSong(temp);

            
        }
        //
        // Song Time Label
        //
        private void count_Tick(object sender, EventArgs e)
        {
            if (_sed < 60)
            {
                _sed++;

            }
            else
            {
                _min++;
                _sed = 0;
            }

            String strSed, strMin;
            if (_sed < 10) strSed = "0" + _sed.ToString();
            else strSed = _sed.ToString();
            if (_min < 1) strMin = "0" + _min.ToString();
            else strMin = _min.ToString();
            time.Text = (strMin + ":" + strSed);
        }

        
        //
        //Sound Button
        //
        private void soundButton_Click(object sender, EventArgs e)
        {
            soundButton.Enabled = false;
            soundButton.Visible = false;
            muteButton.Enabled = true;
            muteButton.Visible = true;
            int temp = soundVolumeBar.Value;
            soundVolumeBar.Value = 0;
            this._lastSoundValue = temp;
            setMuteButtonImg();
        }
        private void soundButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (soundButton.ImageIndex == 4)
            {
                soundButton.ImageIndex = 2;
            }
            else if (soundButton.ImageIndex == 5)
            {
                soundButton.ImageIndex = 3;
            }
        }

        private void soundButton_MouseHover(object sender, EventArgs e)
        {
            if (soundButton.ImageIndex == 0)
            {
                soundButton.ImageIndex = 4;
            }
            else if (soundButton.ImageIndex == 1)
            {
                soundButton.ImageIndex = 5;
            }
        }

        private void soundButton_MouseLeave(object sender, EventArgs e)
        {
            if (soundButton.ImageIndex == 4)
            {
                soundButton.ImageIndex = 0;
            }
            else if (soundButton.ImageIndex == 5)
            {
                soundButton.ImageIndex = 1;
            }
        }

        private void soundButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (soundButton.ImageIndex == 2)
            {
                soundButton.ImageIndex = 4;
            }
            else if (soundButton.ImageIndex == 3)
            {
                soundButton.ImageIndex = 5;
            }

        }


        //
        //Mute Button
        //

        private void muteButton_Click(object sender, EventArgs e)
        {
            soundButton.Enabled = true;
            soundButton.Visible = true;
            muteButton.Enabled = false;
            muteButton.Visible = false;
            if (this._lastSoundValue != 0)
                soundVolumeBar.Value = this._lastSoundValue;
            else
                soundVolumeBar.Value = 30;
           setSoundButtonImg();
        }

        private void soundVolumeBar_ValueChanged(object sender, EventArgs e)
        {
            if (soundVolumeBar.Value == 0 && soundButton.Enabled == true)
            {
                soundButton_Click(sender, e);
            }
            else if (soundVolumeBar.Value > 0 && soundButton.Enabled == false)
            {
                muteButton_Click(sender, e);
            }
            else
            {
                setMuteButtonImg();
                setSoundButtonImg();
            }
        }

        private void muteButton_MouseHover(object sender, EventArgs e)
        {
            if (muteButton.ImageIndex == 0)
            {
                muteButton.ImageIndex = 4;
            }
            else if (muteButton.ImageIndex == 1)
            {
                muteButton.ImageIndex = 5;
            }
        }

        private void muteButton_MouseLeave(object sender, EventArgs e)
        {
            if (muteButton.ImageIndex == 4)
            {
                muteButton.ImageIndex = 0;
            }
            else if (muteButton.ImageIndex == 5)
            {
                muteButton.ImageIndex = 1;
            }
        }

        private void muteButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (muteButton.ImageIndex == 4)
            {
                muteButton.ImageIndex = 2;
            }
            else if (muteButton.ImageIndex == 5)
            {
                muteButton.ImageIndex = 3;
            }
        }

        private void muteButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (muteButton.ImageIndex == 2)
            {
                muteButton.ImageIndex = 4;
            }
            else if (muteButton.ImageIndex == 3)
            {
                muteButton.ImageIndex = 5;
            }
        }

        

        public void playThisSong(int index)
        {
            this._nowPlayIndex = index;
            this._music.stop();
            musicProcessBar.Value = 0;
        }

        public void setLastPlayed(int index)
        {
            this._lastPlayed = index;
        }

        public int getNowPlayIndex()
        {
            return this._nowPlayIndex;
        }

        public bool havePlayed()
        {
            return musicProcessBar.Enabled;
        }
        
    }
}
