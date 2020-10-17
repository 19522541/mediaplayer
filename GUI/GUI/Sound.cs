using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;
using System.Media;
namespace GUI
{
    class Sound
    {
        private DirectSoundOut output = null;
        private NAudio.Wave.WaveFileReader wav = null;
        private SoundPlayer player;
        private string filename;
        public Sound(string filename)
        {
            this.filename = filename;
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

        public void PlaySound()
        {

        }


    }
}
