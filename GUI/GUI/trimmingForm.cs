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
    public partial class trimmingForm : Form
    {
        
        int min;
        int sec;
        string inpath ;
        public trimmingForm(string dir, string length)
        {
            InitializeComponent();
            inpath = dir;
            this.DoubleBuffered= true;
            this.lengthlabel.Text = length;
            string[] detail = length.Split(':');
            if (Int32.TryParse(detail[1], out sec) && Int32.TryParse(detail[0], out min)) {
                trimmingslider.MaximumRange = sec + min * 60;
            
            }
        }
        void trimming()
        {
            var mp3Path = @"C:\Users\Ronnie\Desktop\podcasts\hanselminutes_0350.mp3";
            var outputPath = Path.ChangeExtension(mp3Path, ".trimmed.mp3");

            TrimMp3(mp3Path, outputPath, TimeSpan.FromMinutes(2), TimeSpan.FromMinutes(2.5));
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trimmingslider_RangeMaxChanged(object sender, EventArgs e)
        {
            this.endlabel.Location = new Point((105 + (this.trimmingslider.RangeMax * this.trimmingslider.Size.Width / this.trimmingslider.MaximumRange) ), this.endlabel.Location.Y);
            this.endlabel.Text = Convert.ToString(this.trimmingslider.RangeMax / 60) + ":" + Convert.ToString(this.trimmingslider.RangeMax % 60);
           
         
        }

        private void trimmingslider_RangeMinChanged(object sender, EventArgs e)
        {
            this.startlabel.Location = new Point((105+ (this.trimmingslider.RangeMin * this.trimmingslider.Size.Width / this.trimmingslider.MaximumRange)), this.endlabel.Location.Y);
            this.startlabel.Text = Convert.ToString(this.trimmingslider.RangeMin / 60) + ":" + Convert.ToString(this.trimmingslider.RangeMin % 60);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
           
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                if (namebox.Text != "")
                {
                    string path = dialog.SelectedPath + "/" + namebox.Text;
                    TrimMp3(inpath, path, TimeSpan.FromSeconds(this.trimmingslider.RangeMin), TimeSpan.FromSeconds(this.trimmingslider.RangeMax));
                }

            }
            
        }
    }
}
