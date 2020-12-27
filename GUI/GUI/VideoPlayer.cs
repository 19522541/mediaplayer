﻿using System;
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
        public bool isPlaying = false;
        public Size oldVideoSize;
        public Size oldFormSize;
        public Point oldVideoLocation;

        //mouse location for progress bar
        int _mouseloc;
        string filepath;

        //a variable to check whether timer start (to ignore when assign value to media player)
        int _progressbar_value = 0;
        public VideoPlayer()
        {
            InitializeComponent();
        }

        public VideoPlayer(string filepath)
        {
            InitializeComponent();
            Core.Initialize();
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(ShortcutEvent);
            oldVideoSize = videoView.Size;
            oldFormSize = this.Size;
            oldVideoLocation = videoView.Location;

            // VLC stuff
            _libVLC = new LibVLC();
            _mp = new MediaPlayer(_libVLC);
            videoView.MediaPlayer = _mp;

            //play a video from double click
            this.filepath = filepath;
            PlayFile(this.filepath);
            //videoProcessBar.Enabled = false;

            //timer
            videoTimer.Start();

            //hamburger menu strip
            this.hamburgerMenuStrip.ShowImageMargin = false;

        }

        public void PlayFile(string file)
        {
            _mp.Play(new Media(_libVLC, file));
            isPlaying = true;
            pauseButton.BringToFront();
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
            this.Dispose();
            this.Close();
        }

        private void videoProgressBar_ValueChanged(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs e)
        {
            //time.Text = getCurTime(videoProgressBar.Value);
            if (videoProgressBar.Value == videoProgressBar.Maximum)
            {
                //videoProgressBar.Enabled = false;

                playButton.BringToFront();
            }

            //if (videoProgressBar.Focused == false)
            //{
            //    if (videoProgressBar.Value/100 - this._mp.Position != 1 && videoProgressBar.Value != 0)
            //    {
            //        TimeSpan x = TimeSpan.FromSeconds(videoProgressBar.Value);
            //        this._mp.Position = x.Milliseconds /this._mp.Length;

            //    }
            //}

            //this._mp.Position = videoProgressBar.Value/100f;
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

            _mp.Position = 0;
            this.videoProgressBar.Value = 0;
            pauseButton_Click(sender, e);
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            _mp.Position += 0.005f;
        }

        private void backwardButton_Click(object sender, EventArgs e)
        {
            _mp.Position -= 0.005f;
        }

        private void videoProgressBar_MouseUp(object sender, MouseEventArgs e)
        {
            _mp.Position = videoProgressBar.Value / 1000f;
        }

        private void videoTimer_Tick(object sender, EventArgs e)
        {
            if (this.videoProgressBar.Value < this.videoProgressBar.Maximum)
                this.videoProgressBar.Value++;
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            videoView.Size = this.Size;
            videoView.Location = this.Location;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            isFullScreen = true;
            restoredownButton.BringToFront();
        }

        private void videoProgressBar_Click(object sender, EventArgs e)
        {
            int preVal = videoProgressBar.Value;
            //int totalVal = videoProgressBar.Maximum - videoProgressBar.Minimum;
            int totalPix = videoProgressBar.Size.Width;
            float temp = (float)this._mouseloc * 1000f / (float)totalPix;
            if (temp > preVal) temp -= 9;
            else if (temp < preVal) temp += 9;
            videoProgressBar.Value = Convert.ToInt32(temp);
        }

        private void videoProgressBar_MouseMove(object sender, MouseEventArgs e)
        {
            this._mouseloc = e.X;
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
            maximizeButton.BringToFront();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {

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
            _mp.AddSlave(MediaSlaveType.Subtitle, "file:///C:\\Users\\volin\\Downloads\\[English] 05 - Future Simple Will Going to Listening Speaking Practice - Common Questions Possible Responses [DownSub.com].srt", true);
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
    }
}
