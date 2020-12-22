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
    public partial class LyricForm : Form
    {
        public LyricForm()
        {
            InitializeComponent();
        }

        public LyricForm(string lyric)
        {
            InitializeComponent();
            this.lyricBox.Text = lyric;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
            this.lyricBox.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}
