using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class Mp3Player : Player
    {
        private NAudio.Wave.WaveStream _pcm; 
        private NAudio.Wave.BlockAlignReductionStream _stream;


        public Mp3Player(string fileName)
        {
            this._fileName = fileName;
            this._pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(this._fileName));
            this._stream = new NAudio.Wave.BlockAlignReductionStream(_pcm);
            this._output = new NAudio.Wave.WaveOutEvent();
            this._output.Init(this._stream);
            this._time = Convert.ToInt32(this._stream.TotalTime.TotalSeconds);
        }
        public override void setvolumn(float x)
        {
            _output.Volume = (float)x / 100;
        }
        public override void setCur(TimeSpan x)
        {
            _stream.CurrentTime = x;
        }
       
        
    }
}
