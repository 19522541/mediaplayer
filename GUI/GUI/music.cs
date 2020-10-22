using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using System.Media;
using NAudio;

//using System.CodeDom.Compiler;

namespace GUI
{
    class Sound : Player
    {
        
       
        private NAudio.Wave.WaveFileReader _wav = null;
        
        public Sound(string fileName)
        {
            this._fileName = fileName;
            this._wav = new WaveFileReader(fileName);
            _time = Convert.ToInt32(_wav.TotalTime.TotalSeconds);
            _output = new DirectSoundOut();
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
        public void SettimeAudio(int t) {


            NAudio.Wave.WaveFileReader temp = _wav;
            //  temp.CurrentTime  = temp.CurrentTime.Add( TimeSpan.FromSeconds(t * time /100000));
            // if(output.PlaybackState ==NAudio.Wave.PlaybackState.Playing)
            //         output.Stop();
            double tt = t * _time / 100000;
            if (_output != null)
                _output.Stop();
            _output = new DirectSoundOut();
            _wav.Position = (long)(tt * _wav.WaveFormat.AverageBytesPerSecond);

            _output.Init(new WaveChannel32(_wav) );
            _output.Play();
            Console.WriteLine("had play");


        
        }
     public void PlaySound()
        {
            if (this._output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            { _output.Stop(); }
            else   {

                _output.Play();
                      }
            }

        public void setvolum(float a) {

         //   output.Volume = a;
        
        }

        override public void setCur(TimeSpan x)
        {
            _wav.CurrentTime = x;
        }

        
    }
}
