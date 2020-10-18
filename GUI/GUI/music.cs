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
    class Sound
    {
        private DirectSoundOut output = null;
        private NAudio.Wave.WaveFileReader wav = null;
        private SoundPlayer player;
        private string filename;
        public double time;
        public Sound(string filename)
        {
            this.filename = filename;
            this.wav = new WaveFileReader(filename);
            time = wav.TotalTime.TotalMilliseconds;
            output = new DirectSoundOut();
            output.Init(new WaveChannel32(wav));




        }
       
        public void DisposeWave()
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
        public void SettimeAudio(int t) {


            NAudio.Wave.WaveFileReader temp = wav;
            //  temp.CurrentTime  = temp.CurrentTime.Add( TimeSpan.FromSeconds(t * time /100000));
            // if(output.PlaybackState ==NAudio.Wave.PlaybackState.Playing)
            //         output.Stop();
            double tt = t * time / 100000;
            if (output != null)
                output.Stop();
            output = new DirectSoundOut();
            wav.Position = (long)(tt * wav.WaveFormat.AverageBytesPerSecond);

            output.Init(new WaveChannel32(wav) );
            output.Play();
            Console.WriteLine("had play");


        
        }
     public void PlaySound()
        {
            if (this.output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            { output.Stop(); }
            else   {
               
                output.Play();
                      }
            }

        public void setvolum(float a) {

         //   output.Volume = a;
        
        }

    }
}
