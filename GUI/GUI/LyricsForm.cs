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
    public partial class LyricsForm : Form
    {
        private MediaForm _parent;
        public LyricsForm()
        {
            InitializeComponent();
        }

        public LyricsForm(MediaForm parent,string lyrics)
        {
            this._parent = parent;
            InitializeComponent();
            this.lyricsText.SelectionAlignment = HorizontalAlignment.Center;
            if (lyrics != null) this.lyricsText.Text = lyrics;
            else
            {
                string temp = "Bài hát hiện tại chưa có lời!!!";
                this.lyricsText.Text = temp;
            }
        }
    }
}
