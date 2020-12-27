using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        public VideoPlayer()
        {
            InitializeComponent();
        }

        public VideoPlayer(string filepath)
        {
            InitializeComponent();
            Core.Initialize();

            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(ShortcutEvent);
            oldVideoSize = videoView.Size;
            oldVideoLocation = videoView.Location;

            // VLC stuff
            _libVLC = new LibVLC();
            _mp = new MediaPlayer(_libVLC);
            videoView.MediaPlayer = _mp;

            //play a video from double click
            PlayFile(filepath);
            //videoProcessBar.Enabled = false;
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
                pauseButton.BringToFront();
            }   
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (_mp.IsPlaying)
            {
                _mp.Pause();
                playButton.BringToFront();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            _mp.Stop();
            this.Dispose();
            this.Close();
        }
    }
}
