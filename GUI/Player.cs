using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    abstract class Player
    {

        protected IWavePlayer _output;
        protected string _fileName;
        protected int _time;

        public int getTime()
        {
            return this._time;
        }

        public void pause()
        {
            this._output.Pause();
        }

        public void stop()
        {
            
            _output.Stop();
            _output.Dispose();
        }

        public void start()
        {

            _output.Play();

        }

        public String getSongLength()
        {
            String rs = "";
            int mins = Convert.ToInt32(_time) / 60;
            int second = Convert.ToInt32(_time) % 60;
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
        virtual public void setvolumn(float x) { }
        virtual public void setCur(TimeSpan x) { }
    }
}
