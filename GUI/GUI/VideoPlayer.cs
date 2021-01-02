using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibVLCSharp.Shared;
using MediaToolkit;
using MediaToolkit.Model;
using NReco.VideoInfo;
namespace GUI
{
    public partial class VideoPlayer : Form
    {

        // VLC stuff
        public LibVLC _libVLC;
        public MediaPlayer _mp;
        public Media media;

        //utils
        public bool isFullScreen = false;
        //public bool isPlaying = false;
        public Size oldVideoSize;
        public Size oldFormSize;
        public Point oldVideoLocation;
        
        //mouse location for progress bar
        int _mouseloc;
        string filepath;

        //a variable to check whether timer start (to ignore when assign value to media player)
        int _progressbar_value = 0;

        //Media Info
        public TimeSpan duration;

        //Volume
        int volume = 0;

        //parent MainForm
        MainForm parent;
        

        public VideoPlayer()
        {
            InitializeComponent();
        }

        public VideoPlayer(MainForm parent, string filepath, bool isURL=false)
        {
            InitializeComponent();
            Core.Initialize();
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(ShortcutEvent);
            oldVideoSize = videoView.Size;
            oldFormSize = this.Size;
            oldVideoLocation = videoView.Location;

            //assign parent
            this.parent = parent;

            // VLC stuff
            _libVLC = new LibVLC();
            _mp = new MediaPlayer(_libVLC);
            
            videoView.MediaPlayer = _mp;


            

            //play a video from double click
            this.filepath = filepath;
            if(isURL)
            {
                if(!PlayURL(this.filepath)) //if play unsuccessfully (invalid link)
                {
                    this.Dispose();
                    return;
                }
            }    
            else
                PlayFile(this.filepath);

            // Media Info
            var ffProbe = new FFProbe();
            var videoInfo = ffProbe.GetMediaInfo(filepath);
            
            duration = videoInfo.Duration;

            //set maximum for progress bar
            
            this.videoProgressBar.Minimum = 0;
            this.videoProgressBar.Maximum = (int)duration.TotalSeconds;

            //display duration
            this.videoTime.Text = getCurrentTime();
            this.videoLength.Text = duration.ToString(@"hh\:mm\:ss");


            //timer
            videoTimer.Start();

            //hamburger menu strip
            this.hamburgerMenuStrip.ShowImageMargin = false;

        }

        public void PlayFile(string file)
        {
            media = new Media(_libVLC, file);
            _mp.Play(media);
            //isPlaying = true;
            button6.BringToFront();
            //double vidlength = media.Duration;
            //TimeSpan length = TimeSpan.FromMilliseconds(vidlength);

            //string duration = length.ToString(@"hh\:mm\:ss");
            //this.videoLength.Text = getVideoDuration();
            //this.label1.Text = getVideoDuration();
        }

        public bool PlayURL(string file)
        {

            try
            {
                if(!_mp.Play(new Media(this._libVLC, new Uri(file))))
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open the link.");
                return false;
            }
            finally
            {
                button6.BringToFront();
                
            }
            //this.isPlaying = true;
            return true;
            //TimeSpan length = TimeSpan.FromMilliseconds(_mp.Length);
            //this.videoLength.Text = length.ToString(@"mm\:ss");

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //this.videoProcessBar.Enabled = true;
            //stopButton.BringToFront();
            //videoProcessBar.Minimum = 0;
            //videoProcessBar.Maximum = (int)this._mp.Time;

            if (!_mp.IsPlaying)
            {
                _mp.Play();
                videoTimer.Start();
                pauseButton.BringToFront();

            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (_mp.IsPlaying)
            {

                _mp.Pause();
                videoTimer.Stop();
                playButton.BringToFront();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            _mp.Stop();
            _mp.Dispose();
            this.parent.videoClose(sender, e);
            this.Dispose();
            this.Close();
        }

        private void videoProgressBar_ValueChanged(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs e)
        {
            videoTime.Text = getCurrentTime();
            if (videoProgressBar.Value == videoProgressBar.Maximum)
            {
                //videoProgressBar.Enabled = false;
                //StopVideo();
                
                stopButton_Click(sender, e);

            }

            //if (videoProgressBar.Focused == false)
            //{
            //    if (videoProgressBar.Value/100 - this._mp.Position != 1 && videoProgressBar.Value != 0)
            //    {
            //        TimeSpan x = TimeSpan.FromSeconds(videoProgressBar.Value);
            //        this._mp.Position = x.Milliseconds /this._mp.Length;

            //    }
            //}

            //this._mp.Position = (float)videoProgressBar.Value / (float)videoProgressBar.Maximum;
            //uneccessary to change Position or Time (cause lagging)
            //_mp.Time = videoProgressBar.Value * 10;

            if (videoProgressBar.Focused == false)
            {
                // ignore when timer just start
                if (this.videoProgressBar.Value - this._progressbar_value != 1)
                {
                    this._mp.Time = (long)TimeSpan.FromSeconds(this.videoProgressBar.Value).TotalMilliseconds;
                }
            }
            this._progressbar_value = this.videoProgressBar.Value;

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            _mp.Stop();
            videoTimer.Stop();
            this.videoProgressBar.Value = 0;
            button2.BringToFront();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            //_mp.Position += 0.005f;

            // skip 10 seconds
            if(this.videoProgressBar.Value + 10 >= videoProgressBar.Maximum)
            {
                this.videoProgressBar.Value = videoProgressBar.Maximum;
                _mp.Position = 1f;
                return;
            }    
            _mp.Position += 10f / videoProgressBar.Maximum;
            this.videoProgressBar.Value += 10;
            
            //this.videoProgressBar.Value += 1000;
            //_mp.Position = (float)videoProgressBar.Value / (float)videoProgressBar.Maximum;
            //videoTime.Text = getCurrentTime();
        }

        private void backwardButton_Click(object sender, EventArgs e)
        {
            _mp.Position -= 5f / videoProgressBar.Maximum;
            this.videoProgressBar.Value -= 5;
        }

        private void videoProgressBar_MouseUp(object sender, MouseEventArgs e)
        {
            
            _mp.Position = (float)videoProgressBar.Value / (float)videoProgressBar.Maximum;
            //this.playButton_Click(sender, e);
        }

        private void videoTimer_Tick(object sender, EventArgs e)
        {
            if (this.videoProgressBar.Value < this.videoProgressBar.Maximum)
            {
                this.videoProgressBar.Value++;
            }
             
                
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            videoView.Size = this.Size;
            videoView.Location = this.Location;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            isFullScreen = true;
            button9.BringToFront();
        }

        private void videoProgressBar_Click(object sender, EventArgs e)
        {
            int preVal = videoProgressBar.Value;
            //int totalVal = videoProgressBar.Maximum - videoProgressBar.Minimum;
            int barWidth = videoProgressBar.Size.Width;
            float percentage = (float)this._mouseloc / (float)barWidth;
            float temp = percentage * this.videoProgressBar.Maximum;
            int offset =0;
            if(this.duration.TotalSeconds>=30)
            {
                offset = 10;
            }    
            else if(this.duration.TotalSeconds<30)
            {
                offset = 0;
            }
            //if (temp > preVal) temp -= offset;
            //else if (temp < preVal) temp += offset;
            videoProgressBar.Value = Convert.ToInt32(temp);
            _mp.Position = (float)videoProgressBar.Value / (float)videoProgressBar.Maximum;
            videoProgressBar.Value = Convert.ToInt32(_mp.Position * videoProgressBar.Maximum);
        }

        private void videoProgressBar_MouseMove(object sender, MouseEventArgs e)
        {
            
            this._mouseloc = e.X;
            //if(e.Button==MouseButtons.Left)
            //{
                
            //    int barWidth = videoProgressBar.Size.Width;
            //    float percentage = (float)this._mouseloc / (float)barWidth;
            //    float temp = percentage * this.videoProgressBar.Maximum;

            //    videoProgressBar.Value = Convert.ToInt32(temp);
            //    _mp.Position = (float)videoProgressBar.Value / (float)videoProgressBar.Maximum;
            //    pauseButton_Click(sender, e);
            //}
            
        }

        private void MediaEndReached(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(_ => this._mp.Play(new Media(_libVLC, this.filepath)));
        }

        private void restoredownButton_Click(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None; // change form style
            this.WindowState = FormWindowState.Normal; // back to normal size
            this.Size = oldFormSize;
            videoView.Size = oldVideoSize; // make video the same size as form
            videoView.Location = oldVideoLocation; // remove offset
            button10.BringToFront();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {

        }

        private void hamburgerButton_Click(object sender, EventArgs e)
        {
            
            MouseEventArgs me = (MouseEventArgs)e;
            this.hamburgerMenuStrip.Show(Cursor.Position);
            
        }

        

        private void addSubtitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string formats = "Subtitle Text Files |*.srt; *.txt";
            ofd.Filter = formats;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var filename = @"file:///" + ofd.FileName;
                var boo = _mp.AddSlave(MediaSlaveType.Subtitle, filename, true);
            }
            //test
            //var sub = @"file:///C:\Users\volin\Downloads\[English]05-Future Simple Will Going to Listening Speaking Practice
            //    - Common Questions Possible Responses [DownSub.com].srt";
            //_mp.AddSlave(MediaSlaveType.Subtitle, sub, true);

            
        }

        private void xToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            _mp.SetRate(0.25f);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            _mp.SetRate(0.5f);
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            _mp.SetRate(0.75f);
        }

        private void normalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _mp.SetRate(1.0f);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            _mp.SetRate(1.25f);
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            _mp.SetRate(1.5f);
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            _mp.SetRate(1.75f);
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            _mp.SetRate(2f);
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

        public string getCurrentTime()
        {
            //string rs = "";
            //var curent_time = this.videoProgressBar.Value;
            //int mins = Convert.ToInt32(curent_time) / 60;
            //int second = Convert.ToInt32(curent_time) % 60;
            //string minStr, sedStr;
            //if (mins < 10)
            //{
            //    minStr = "0" + mins.ToString();
            //}
            //else
            //{
            //    minStr = mins.ToString();
            //}

            //if (second < 10)
            //{
            //    sedStr = "0" + second.ToString();
            //}
            //else
            //{
            //    sedStr = second.ToString();
            //}
            //rs = minStr + ":" + sedStr;
            //return rs;
            TimeSpan current = TimeSpan.FromSeconds(this.videoProgressBar.Value);
            return current.ToString(@"hh\:mm\:ss");
        }

        public string getVideoDuration()
        {
            string rs = "";
            TimeSpan cur = TimeSpan.FromMilliseconds(_mp.Length);
            int seconds = cur.Seconds;
            int mins = Convert.ToInt32(seconds) / 60;
            int second = Convert.ToInt32(seconds) % 60;
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
        private void videoProgressBar_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {

        }

        private void videoProgressBar_MouseDown(object sender, MouseEventArgs e)
        {
            
            
        }

        private void StopVideo()
        {
            _mp.Stop();
            videoTimer.Stop();
            this.videoProgressBar.Value = 0;
            playButton.BringToFront();
        }

        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            this._mp.Volume = bunifuHSlider1.Value;
        }

        void setSoundButtonImg()
        {
            if (bunifuHSlider1.Value > 50)
            {
                button1.ImageIndex = 0;
            }
            else if (bunifuHSlider1.Value <= 50)
            {
                button1.ImageIndex = 1;
            }
        }

        void setMuteButtonImg()
        {
            if (bunifuHSlider1.Value > 0)
            {
                muteButton.ImageIndex = 0;
            }
            else
            {
                muteButton.ImageIndex = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Visible = false;
            muteButton.Enabled = true;
            muteButton.Visible = true;
            int temp = bunifuHSlider1.Value;
            bunifuHSlider1.Value = 0;
            this.volume = temp;
            muteButton.BringToFront();
            //setMuteButtonImg();
        }

        private void muteButton_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.Visible = true;
            muteButton.Enabled = false;
            muteButton.Visible = false;
            if (this.volume != 0)
                bunifuHSlider1.Value = this.volume;
            else
                bunifuHSlider1.Value = 50;
            button1.BringToFront();
            //setSoundButtonImg();
        }

        private void bunifuHSlider1_ValueChanged(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs e)
        {
            this._mp.Volume = bunifuHSlider1.Value;
            if (bunifuHSlider1.Value == 0 && button1.Enabled == true)
            {
                button1_Click(sender, e);
            }
            else if (bunifuHSlider1.Value > 0 && bunifuHSlider1.Enabled == false)
            {
                muteButton_Click(sender, e);
            }
            else
            {
                //setMuteButtonImg();
                //setSoundButtonImg();
            }
            //_playBackDevice.Volume = soundVolumeBar.Value;
        }

        private void bottomPanel_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            backwardButton_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (!_mp.IsPlaying)
            {
                _mp.Play();
                videoTimer.Start();
                button6.BringToFront();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            forwardButton_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            stopButton_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_mp.IsPlaying)
            {

                _mp.Pause();
                videoTimer.Stop();
                button2.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hamburgerButton_Click(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            restoredownButton_Click(sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            maximizeButton_Click(sender, e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            exitButton_Click(sender, e);
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            media.AddOption(":freetype-color=16711680");
        }
    }
}
