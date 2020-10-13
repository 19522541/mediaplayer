﻿using System;
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
using NAudio;
using NAudio.Wave;
using System.Media;
//using Windows.UI.Xaml.Controls;
namespace GUI
{
    public partial class MainForm : Form
    {
        private WaveOut output = null;
        private NAudio.Wave.WaveFileReader wav = null;
        private SoundPlayer player;

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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Wave file (*wav;*.mp3;*.aac)|*.wav;*.mp3;*.aac";
            //   open.Filter = ".MP3 file (*.mp3) |*.mp3";
            if (open.ShowDialog() != DialogResult.OK) return;

            DisposeWave();
            // Console.WriteLine(open.FileName.en);
            if (open.FileName.EndsWith(".mp3"))
            {
                Console.WriteLine("mp3");
                var reader = new Mp3FileReader(open.FileName);
                output = new WaveOut(); // or WaveOutEvent()
                output.Init(reader);
                output.Play();
                playButton.Enabled = true;
            }
            else if (open.FileName.EndsWith(".wav"))
            {
                Console.WriteLine("wav");
                var wav = new NAudio.Wave.WaveFileReader(open.FileName);
                output = new WaveOut();
                output.Init(new NAudio.Wave.WaveChannel32(wav));
                output.Play();
                playButton.Enabled = true;
            }
            else if (open.FileName.EndsWith(".aac")) {
                using (MediaFoundationReader reader = new MediaFoundationReader(open.FileName))
                // resample the file to PCM with same sample rate, channels and bits per sample
                using (ResamplerDmoStream resampledReader = new ResamplerDmoStream(reader,
                    new WaveFormat(reader.WaveFormat.SampleRate, reader.WaveFormat.BitsPerSample, reader.WaveFormat.Channels)))
                // create WAVe file
                using (WaveFileWriter waveWriter = new WaveFileWriter("temp.wav", resampledReader.WaveFormat))
                {
                    Console.WriteLine("###");
                    // copy samples
                    resampledReader.CopyTo(waveWriter);


                }
                NAudio.Wave.WaveFileReader wavef = new WaveFileReader("temp.wav");
                var sound = new NAudio.Wave.DirectSoundOut();
                sound.Init(new WaveChannel32(wavef));
                sound.Play();

            }      
            // renderWaveForm(open.FileName);


          
        }

        private void DisposeWave()
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing
                    || output.PlaybackState == NAudio.Wave.PlaybackState.Paused)
                    output.Stop();
                output.Dispose();
                output = null;
            }
            if (wav != null)
            {
                wav.Dispose();
                wav = null;
            }
        }


        private void playButton_Click(object sender, EventArgs e)
        {
            if (output != null)
            {
                output.Play();
                playButton.Visible = false;
                pauseButton.Visible = true;
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (output != null)
            {
                output.Pause();
                playButton.Visible = true;
                pauseButton.Visible = false;
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            player = new SoundPlayer();
            //player.Stream = Properties.Resources.

        }
    }
}
