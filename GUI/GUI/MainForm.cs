using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Windows.Forms;
//using AudioSwitcher.AudioApi.CoreAudio;
using Bunifu.UI.WinForms;
using Microsoft.WindowsAPICodePack.Dialogs;
namespace GUI
{
    public delegate void UserChoiceHandler(object sender, EventArgs e);
    public partial class MainForm : Form
    {
        private int _bfHoverIndex = 0;
        private Player _music;
        //private CoreAudioDevice _playBackDevice;
        public List<String> _playedList;
        public int _nowPlayIndex = 0;
        private int _check = 0;
        private int _min = 0;
        private int _sed = 0;
        private int _lastSoundValue = 0;
        private bool _random = false;
        private bool _loop = false;
        private bool _loopAll = false;
        private int _mouseX = 0;
        public MediaForm _mediaForm;
        private PictureForm _pictureForm;
        private VideoForm _videoForm;
        public PlayListForm _playListForm;
        public MediaForm _backupMediaForm;
        private int _curForm = 0;
        public int _lastPlayed = -1;
        public int _backMode = -1;
        private NowPlayingForm _nowPlayingForm;
        public List<String> _allSong;
        public List<String> _ablum;
        public List<String> _title;
        public List<String> _firstPerformer;
        public List<String> _length;
        public List<Image> _songImg;
        public LyricForm _lyricBox;
        public SongInfoForm _nowSongInfo = null;
        private bool _playlistCheck = false;
        public MainForm()
        {
            
            InitializeComponent();
            
            this.Text = String.Empty;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            //this._playBackDevice = new CoreAudioController().DefaultPlaybackDevice;
            this._allSong = new List<string>();
            
            this.musicProcessBar.Enabled = false;
            setup();
            this.DoubleBuffered = true;
            this._mediaForm = new MediaForm(this, this._playedList);
            this._pictureForm = new PictureForm(this);
         
            this._videoForm = new VideoForm();
            this._playListForm = new PlayListForm(this);
            this._nowPlayingForm = new NowPlayingForm();
            this._mediaForm.UserChoiceChanged += playButton_Click;
            this._nowPlayingForm.FormBorderStyle = FormBorderStyle.None;
            this._nowPlayingForm.TopLevel = false;
            this.Dock = DockStyle.Left;
            this.mainBotPanel.Controls.Add(this._nowPlayingForm);
            _nowPlayingForm.BringToFront();
            this._nowPlayingForm.Visible = false;
            this.backwardButton.Visible = false;

        }


        //-------------------function------------------//
        private void setup()
        { 
            mediaSubMenu.Visible = false;
            imageSubMenu.Visible = false;
            playlistSubMenu.Visible = false;
            videoSubMenu.Visible = false;
            //this.soundVolumeBar.Value = Convert.ToInt32(this._playBackDevice.Volume);
            this.soundVolumeBar.Value = 50;
            this._lastSoundValue = this.soundVolumeBar.Value;
        }


        private void hideSubMenu()
        {
            if (mediaSubMenu.Visible == true)
                mediaSubMenu.Visible = false;
            if (playlistSubMenu.Visible == true)
                playlistSubMenu.Visible = false;
            if (imageSubMenu.Visible == true)
                imageSubMenu.Visible = false;
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

        public void openNewForm(Form newForm, int index)
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

        void getNextSong(int z) // 1 for next and 2 for back
        {
            if (_nowPlayIndex > this._playedList.Count)
            {
                _nowPlayIndex = 0;
            }
            if (this._random)
            {
                int temp = this._nowPlayIndex;
                while (temp == this._nowPlayIndex)
                {
                    Random x = new Random();
                    this._nowPlayIndex = x.Next(0, this._playedList.Count - 1);
                }

            }
            else if (this._loop)
            {

            }
            else if (z == 1)
            {
                if (this._nowPlayIndex < this._playedList.Count - 1) this._nowPlayIndex++;
                else if (this._loopAll) this._nowPlayIndex = 0;
                else this._nowPlayIndex = -1;
            }
            else if (z == 2)
            {
                if (this._nowPlayIndex > 0) this._nowPlayIndex--;
                else  this._nowPlayIndex = this._nowPlayIndex = this._playedList.Count - 1;
                
            }
        }
        //---------------------event-----------------//

        
        //
        // Play button
        //
        public void playButton_Click(object sender, EventArgs e)
        {
            if (this._nowPlayIndex == -1)
            {
                playButton.BringToFront();
                if (this._mediaForm._mediaCheck) this._mediaForm.restart(this._playedList.Count - 1);
                this._nowPlayingForm.Visible = false;
                this._nowPlayIndex = 0;
                return;
            }
            if (this.musicProcessBar.Value == 0)
            {
                if (this._mediaForm._mediaCheck)
                {
                    if (this._lastPlayed != this._nowPlayIndex)
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
                    else
                    {
                        this._lastPlayed = this._nowPlayIndex;
                    }
                }
                if (this._backupMediaForm != null && this._backupMediaForm._mediaCheck)
                {
                    if (this._backupMediaForm._firstPlay)
                    {
                        //this.setInfo(0, -1);
                        this._backupMediaForm._firstPlay = false;
                        //this._playedList = this._backupMediaForm._list;
                    }
                    if (this._lastPlayed != this._nowPlayIndex)
                    {
                        if (_lastPlayed == -1)
                        {
                            this._backupMediaForm.setup(_nowPlayIndex);
                            this._backupMediaForm.setLastPlayed(this._nowPlayIndex);
                        }
                        else
                        {
                            this._backupMediaForm.restart(_lastPlayed);
                            this._backupMediaForm.setup(_nowPlayIndex);
                            this._backupMediaForm.setLastPlayed(this._nowPlayIndex);
                        }
                    }
                    else
                    {
                        this._lastPlayed = this._nowPlayIndex;
                    }
                }
                this._nowPlayingForm.Visible = true;
                if (this._songImg != null)
                {
                    this._nowPlayingForm.setNewInfo(this._songImg[this._nowPlayIndex], _title[_nowPlayIndex], _firstPerformer[_nowPlayIndex]);
                    songLength.Text = this._length[_nowPlayIndex];
                }
                else
                {
                    var fileTag = TagLib.File.Create(this._playedList[_nowPlayIndex]);
                    string title = fileTag.Tag.Title;
                    string artist = fileTag.Tag.FirstPerformer;
                    string album = fileTag.Tag.Album;
                    TimeSpan songlegth = fileTag.Properties.Duration;
                    string duration = songlegth.ToString(@"mm\:ss");
                    if (album == null) album = "Unknown";
                    if (artist == null) artist = "Unknown";
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
                    this._nowPlayingForm.setNewInfo(temp, title, artist);
                    songLength.Text = duration;
                }
                this._nowPlayingForm.Visible = true;
                if (this._playedList[this._nowPlayIndex].Contains(".wav"))
                {
                    _music = new WavPlayer(this._playedList[this._nowPlayIndex]);
                }
                else if (this._playedList[this._nowPlayIndex].Contains(".mp3"))
                {
                    _music = new Mp3Player(this._playedList[this._nowPlayIndex]);
                }
                
                
            }
            this.musicProcessBar.Enabled = true;
            stopButton.BringToFront();
            musicProcessBar.Minimum = 0;
            musicProcessBar.Maximum = this._music.getTime();
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
            //stopButton.Enabled = false;
            //stopButton.Visible = false;
            //playButton.Enabled = true;
            //playButton.Visible = true;
            playButton.BringToFront();
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
            //this._music = null;
            this._lastPlayed = this._nowPlayIndex;
            getNextSong(2);
            
            playButton_Click(sender, e);
            
        }

        private void backButton_MouseDown(object sender, MouseEventArgs e)
        {
            count.Stop();
            musicBarTimer.Stop();
            this._music.stop();
            backButton.ImageIndex = 1;
            
            
        }


        private void backButton_MouseUp(object sender, MouseEventArgs e)
        {
            backButton.ImageIndex = 2;
            
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
            getNextSong(1);
            playButton_Click(sender, e);
        }

        private void nextButton_MouseDown(object sender, MouseEventArgs e)
        {
            count.Stop();
            musicBarTimer.Stop();
            this._music.stop();
            nextButton.ImageIndex = 1;
            
            
        }

        private void nextButton_MouseUp(object sender, MouseEventArgs e)
        {
            nextButton.ImageIndex = 2;
            
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
            if (!(_loop || _loopAll)) this._loopAll = true;
            else if (_loopAll)
            {
                this._loop = true;
                this._loopAll = false;
            }
            else if (_loop)
            {
                this._loop = this._loopAll;
            }
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
            this._playlistCheck = false;
            this.setPlayedList(this._mediaForm._list, this._mediaForm._ablum, this._mediaForm._title, this._mediaForm._firstPerformer, this._mediaForm._length, this._mediaForm._songImg);
            this.setInfo(0, -1);
            if (this._mediaForm._nowPlayIndex != -1) this._mediaForm.restart(this._mediaForm._nowPlayIndex);
            this._mediaForm._firstPlay = true;
            this.backwardButton.Visible = false;
            this._mediaForm._mediaCheck = true;
            if (this._backupMediaForm != null) this._backupMediaForm._mediaCheck = false;
            if (sideMenuPanel.Width < 70)
            {
                sideMenuButton_Click(sender, e);
                this._nowPlayIndex = 0;
                this._lastPlayed = -1;
            }
            openNewForm(this._mediaForm, 1);

            showSubMenu(mediaSubMenu);

        }

        private void playlistButton_Click(object sender, EventArgs e)
        {
            this._playlistCheck = true;
            this._backMode = 2;
            this.backwardButton.Visible = true;
            this._mediaForm._mediaCheck = false;
            if (sideMenuPanel.Width < 70)
            {
                sideMenuButton_Click(sender, e);
            }
            showSubMenu(playlistSubMenu);
            openNewForm(this._playListForm, 2);
        }

        private void pictureButton_Click(object sender, EventArgs e)
        {
            this._playlistCheck = false;
            this._backMode = 3;
            this.backwardButton.Visible = true;
            if (sideMenuPanel.Width < 70)
            {
                sideMenuButton_Click(sender, e);
            }
            openNewForm(this._pictureForm, 3);
            showSubMenu(imageSubMenu);
        }

        private void videoButton_Click(object sender, EventArgs e)
        {
            this._playlistCheck = false;
            this.backwardButton.Visible = false;
            if (sideMenuPanel.Width < 70)
            {
                sideMenuButton_Click(sender, e);
            }
            showSubMenu(videoSubMenu);

            openNewForm(this._videoForm, 4);
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
                this._allSong.Add(dir);
            }
            musicFiles = musicFolder.GetFiles("*.wav");
            this._playedList = _allSong;
            foreach (var x in musicFiles)
            {
                string dir = x.FullName;
                this._allSong.Add(dir);
            }
            if (this._playedList.Count > 0)
            {
                if (this._playedList[this._nowPlayIndex].Contains(".wav"))
                {
                    _music = new WavPlayer(this._playedList[this._nowPlayIndex]);
                }
                else if (this._playedList[this._nowPlayIndex].Contains(".mp3"))
                {
                    _music = new Mp3Player(this._playedList[this._nowPlayIndex]);
                }
            }
            else
            {
                MessageBox.Show("Hien tai khong co nhac");
            }
            this._playListForm.PlayListForm_Load(sender, e);
            
            this._mediaForm.setList(this._allSong);
            //this._mediaForm.MediaForm_Load(sender, e);
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
            List<String> temp = new List<String>();
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Chose your music file";
            open.InitialDirectory = "C:\\Users";
            open.Filter = "Mp3 file(*.mp3)| *.mp3| Wav file(*.wav)|*wav";
            if (open.ShowDialog() == DialogResult.OK)
            {
                this._playedList.Add(open.FileName);
                this.playButton.ImageIndex = 0;
                DialogResult check = MessageBox.Show("Bạn có muốn giữ lại những bài hát cũ", "", MessageBoxButtons.YesNo);
                if (check == DialogResult.No)
                {
                    this._mediaForm.clear();
                    this._nowPlayIndex = 0;
                    this._lastPlayed = -1;
                    this._playedList = temp;
                }
                temp.Add(open.FileName);
                this._mediaForm.addNewSong(temp);
            }

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
            //_playBackDevice.Volume = soundVolumeBar.Value;

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

        private void loopButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (loopButton.ImageIndex == 1)
            {
                loopButton.ImageIndex = 0;
            }
            else if (loopButton.ImageIndex == 4)
            {
                loopButton.ImageIndex = 2;
            }
            else if (loopButton.ImageIndex == 5)
            {
                loopButton.ImageIndex = 3;
            }
        }

        private void loopButton_MouseHover(object sender, EventArgs e)
        {
           if (loopButton.ImageIndex == 0)
           {
                loopButton.ImageIndex = 1;
           }
           else if (loopButton.ImageIndex == 2)
           {
                loopButton.ImageIndex = 4;
           }
            else if (loopButton.ImageIndex == 3)
           {
                loopButton.ImageIndex = 5;
           }
        }

        private void loopButton_MouseLeave(object sender, EventArgs e)
        {
            if (loopButton.ImageIndex == 1)
            {
                loopButton.ImageIndex = 0;
            }
            else if (loopButton.ImageIndex == 4)
            {
                loopButton.ImageIndex = 2;
            }
            else if (loopButton.ImageIndex == 5)
            {
                loopButton.ImageIndex = 3;
            }
        }

        private void loopButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (loopButton.ImageIndex == 0)
            {
                loopButton.ImageIndex = 4;
            }
            else if (loopButton.ImageIndex == 2)
            {
                loopButton.ImageIndex = 5;
            }
            else if (loopButton.ImageIndex == 3)
            {
                loopButton.ImageIndex = 1;
            }
        }

        private void mainPicturebox_Click(object sender, EventArgs e)
        {

        }

        public List<String> getListSong()
        {
            return this._playedList;
        }

        private void createPlaylist_Click(object sender, EventArgs e)
        {
            NewPlayListForm newForm = new NewPlayListForm(this,String.Empty);
            newForm.Location = PointToClient(Cursor.Position);
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.ShowDialog();

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataSaver dataSaver = new DataSaver(@"D:/bt2/data.json", this._playListForm.GetPlaylist());
            if (!dataSaver.saveData())
            {
                MessageBox.Show("Failed");
            }
        }

        private void backwardButton_Click(object sender, EventArgs e)
        {
            switch (_backMode)
            {
                case 1:
                    {
                        if (this._lyricBox != null)
                            this._lyricBox.Close();
                        this.openNewForm(this._nowSongInfo._parent, -1);
                        if (_playlistCheck)
                        {
                            this._backMode = 2;
                        }
                        else
                        {
                            this.backwardButton.Visible = false;
                        }
                        break;
                    }
                case 2:
                    {
                        if (this._backupMediaForm != null) this._backupMediaForm.Close();
                        this._playListForm.showInfo();
                        this.openNewForm(this._playListForm, 2);
                        break;
                    }
                case 3:
                    {
                        _pictureForm.escapse();
                        break;
                    }
            }
        }

        private void backwardButton_MouseEnter(object sender, EventArgs e)
        {
            backwardButton.ImageIndex = 1;
        }

        private void backwardButton_MouseLeave(object sender, EventArgs e)
        {
            backwardButton.ImageIndex = 0;
        }

        public void setPlayedList(List<String> playedList, List<String> ablum, List<String> title, List<String> firstPer, List<String> leng,List<Image> imgDir)
        {
            this._playedList = playedList;
            this._ablum = ablum;
            this._title = title;
            this._firstPerformer = firstPer;
            this._length = leng;
            this._songImg = imgDir;

        }

        public void setInfo(int nowPlayindex,int lastPlayIndex)
        {
            this._nowPlayIndex = nowPlayindex;
            this._lastPlayed = lastPlayIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            _pictureForm._add();
        }

        private void openMusicFolderButton_Click(object sender, EventArgs e)
        {
            List<String> temp = new List<String>();
            CommonOpenFileDialog open = new CommonOpenFileDialog();
            open.InitialDirectory = "C:\\Users";
            open.IsFolderPicker = true;

            if (open.ShowDialog() == CommonFileDialogResult.Ok)
            {
                var files = Directory.EnumerateFiles(open.FileName, "*.*", SearchOption.AllDirectories)
                    .Where(s => s.EndsWith(".mp3") || s.EndsWith(".wav"));
                foreach (string filepath in files)
                {
                    this._playedList.Add(filepath);
                    temp.Add(filepath);
                }
                DialogResult check = MessageBox.Show("Bạn có muốn giữ lại những bài hát cũ", "", MessageBoxButtons.YesNo);
                if (check == DialogResult.No)
                {
                    this._mediaForm.clear();
                    this._nowPlayIndex = 0;
                    this._lastPlayed = -1;
                    this._playedList = temp;
                }
                this.playButton.ImageIndex = 0;
                this._mediaForm.addNewSong(temp);
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            InformationForm x = new InformationForm();
            openNewForm(x, -1);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this._pictureForm.cancel();
            pictureFormCtrlHide();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this._pictureForm.save();
            pictureFormCtrlHide();
        }

        public void pictureFormCtrlAppear()
        {
            this.cancelButton.Visible = true;
            this.saveButton.Visible = true;
        }
        public void pictureFormCtrlHide()
        {
            this.cancelButton.Visible = false;
            this.saveButton.Visible = false;
        }
    }
}
