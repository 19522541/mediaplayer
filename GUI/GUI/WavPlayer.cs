﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using System.Media;
using NAudio;

namespace GUI
{
    class WavPlayer : Player
    {

        private NAudio.Wave.WaveFileReader _wav = null;

        public WavPlayer(string fileName)
        {
            this._fileName = fileName;
            this._wav = new WaveFileReader(fileName);
            _time = Convert.ToInt32(_wav.TotalTime.TotalSeconds);

            _output = new WaveOutEvent();

            _output.Init(new WaveChannel32(_wav));
        }

        public void DisposeWave()
        {
            if (_output != null)
            {
                if (_output.PlaybackState == NAudio.Wave.PlaybackState.Playing
                    || _output.PlaybackState == NAudio.Wave.PlaybackState.Paused)
                    _output.Stop();
                _output.Dispose();
                _output = null;
            }
            if (_wav != null)
            {
                _wav.Dispose();
                _wav = null;
            }
        }
        public void SettimeAudio(int t)
        {


            NAudio.Wave.WaveFileReader temp = _wav;
            //  temp.CurrentTime  = temp.CurrentTime.Add( TimeSpan.FromSeconds(t * time /100000));
            // if(output.PlaybackState ==NAudio.Wave.PlaybackState.Playing)
            //         output.Stop();
            double tt = t * _time / 100000;
            if (_output != null)
                _output.Stop();
            _output = new WaveOutEvent();
            _wav.Position = (long)(tt * _wav.WaveFormat.AverageBytesPerSecond);

            _output.Init(new WaveChannel32(_wav));
            _output.Play();
            Console.WriteLine("had play");



        }
        public void PlaySound()
        {
            if (this._output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            { _output.Stop(); }
            else
            {

                _output.Play();
            }
        }

        public override void setvolumn(float x)
        {
            _output.Volume = (float)x / 100;
        }

        override public void setCur(TimeSpan x)
        {
            _wav.CurrentTime = x;
        }

    }
}
