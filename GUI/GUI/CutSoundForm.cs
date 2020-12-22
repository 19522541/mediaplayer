using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CutSoundForm : Form
    {
        String _startDir;
        String _endDir;
        TimeSpan _songLength;
        public CutSoundForm()
        {
            InitializeComponent();
        }
        public CutSoundForm(String startDir,String endDir)
        {
            this._startDir = startDir;
            this._endDir = endDir;
            InitializeComponent();
        }
        TimeSpan convertString(String time)
        {
            int minute = 0, second = 0;
            int pos = time.IndexOf(':');
            int start = 0;
            while ( pos != -1)
            {
                minute = Int32.Parse(time.Substring(start, pos - start));
                start = pos + 1;
                pos = time.IndexOf(':',start);
            }
            second = Int32.Parse(time.Substring(start, time.Length - start));
            return new TimeSpan(0,minute,second);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _songLength = new TimeSpan(0, 3, 43);
            TrimWavFile(_startDir, _endDir, convertString(textBox1.Text),_songLength - convertString(textBox2.Text));
            this.Close();
        }

        public static void TrimWavFile(string inPath, string outPath, TimeSpan cutFromStart, TimeSpan cutFromEnd)
        {
            using (WaveFileReader reader = new WaveFileReader(inPath))
            {
                using (WaveFileWriter writer = new WaveFileWriter(outPath, reader.WaveFormat))
                {
                    int bytesPerMillisecond = reader.WaveFormat.AverageBytesPerSecond / 1000;

                    int startPos = (int)cutFromStart.TotalMilliseconds * bytesPerMillisecond;
                    startPos = startPos - startPos % reader.WaveFormat.BlockAlign;

                    int endBytes = (int)cutFromEnd.TotalMilliseconds * bytesPerMillisecond;
                    endBytes = endBytes - endBytes % reader.WaveFormat.BlockAlign;
                    int endPos = (int)reader.Length - endBytes;

                    TrimWavFile(reader, writer, startPos, endPos);
                }
            }
        }

        private static void TrimWavFile(WaveFileReader reader, WaveFileWriter writer, int startPos, int endPos)
        {
            reader.Position = startPos;
            byte[] buffer = new byte[1024];
            while (reader.Position < endPos)
            {
                int bytesRequired = (int)(endPos - reader.Position);
                if (bytesRequired > 0)
                {
                    int bytesToRead = Math.Min(bytesRequired, buffer.Length);
                    int bytesRead = reader.Read(buffer, 0, bytesToRead);
                    if (bytesRead > 0)
                    {
                        writer.WriteData(buffer, 0, bytesRead);
                    }
                }
            }
        }
    }
}
