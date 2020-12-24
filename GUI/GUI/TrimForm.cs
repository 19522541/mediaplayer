using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
namespace GUI
{
    public partial class TrimForm : Form
    {
        TimeSpan _startTime, _endTime,_leng;
        int _min;
        int _sec;
        string _path ;
        public TrimForm(string dir, string length)
        {
            InitializeComponent();
            _path = dir;
            this.DoubleBuffered= true;
            this.lengthlabel.Text = length;
            string[] detail = length.Split(':');
            if (Int32.TryParse(detail[1], out _sec) && Int32.TryParse(detail[0], out _min)) {
                trimmingslider.MaximumRange = _sec + _min * 60 + 5;
                _leng = new TimeSpan(0, _min, _sec);
            }
            this.FormBorderStyle = FormBorderStyle.None;
            this._startTime = new TimeSpan(0);
            this._endTime = new TimeSpan(0);
        }
        void trimming(string startDir,string endPath)
        {
            
            if (this._path.Contains(".mp3")){
                TrimMp3(startDir, endPath + ".mp3", _startTime, _endTime);
            }
            else
            {
                TrimWav(startDir, endPath + ".wav", _startTime, _leng-_endTime);
            }
        }

        void TrimMp3(string inputPath, string outputPath, TimeSpan? begin, TimeSpan? end)
        {
            if (begin.HasValue && end.HasValue && begin > end)
                throw new ArgumentOutOfRangeException("end", "end should be greater than begin");

            using (var reader = new Mp3FileReader(inputPath))
            using (var writer = File.Create(outputPath))
            {
                Mp3Frame frame;
                while ((frame = reader.ReadNextFrame()) != null)
                    if (reader.CurrentTime >= begin || !begin.HasValue)
                    {
                        if (reader.CurrentTime <= end || !end.HasValue)
                            writer.Write(frame.RawData, 0, frame.RawData.Length);
                        else break;
                    }
            }
        }

        void TrimWav(string inPath, string outPath, TimeSpan cutFromStart, TimeSpan cutFromEnd)
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

        void TrimWavFile(WaveFileReader reader, WaveFileWriter writer, int startPos, int endPos)
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

        private void trimmingslider_RangeMaxChanged(object sender, EventArgs e)
        {
            this.endlabel.Location = new Point((105 + (this.trimmingslider.RangeMax * this.trimmingslider.Size.Width / this.trimmingslider.MaximumRange) ), this.endlabel.Location.Y);
            this.endlabel.Text = Convert.ToString(this.trimmingslider.RangeMax / 60) + ":" + Convert.ToString(this.trimmingslider.RangeMax % 60);
            this._endTime = new TimeSpan(0, this.trimmingslider.RangeMax / 60, this.trimmingslider.RangeMax % 60);
        }

        private void trimmingslider_RangeMinChanged(object sender, EventArgs e)
        {
            this.startlabel.Location = new Point((105+ (this.trimmingslider.RangeMin * this.trimmingslider.Size.Width / this.trimmingslider.MaximumRange)), this.endlabel.Location.Y);
            this.startlabel.Text = Convert.ToString(this.trimmingslider.RangeMin / 60) + ":" + Convert.ToString(this.trimmingslider.RangeMin % 60);
            this._startTime = new TimeSpan(0, this.trimmingslider.RangeMin / 60, this.trimmingslider.RangeMin % 60);
        }


        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (_startTime == _endTime)
            {
                MessageBox.Show("Error");
                return;
            }
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                if (namebox.Text != "")
                {
                    string path = dialog.SelectedPath + "/" + namebox.Text;
                    trimming(_path, path);
                }

            }
            this.Close();
            
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
