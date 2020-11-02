using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    //delegate MediaFormEvt(object sender, EventArgs e);
    public partial class MediaForm : Form
    {
        private List<String> _list;
        private int _userChoice;
        private MainForm _parent;
        
        //public event EventHandler SomeEvent(object sender, EventArgs e);
        public MediaForm()
        {
            InitializeComponent();
        }

        public MediaForm(MainForm parent,List<String> list)
        {
            this._list = list;
            this._parent = parent;
            InitializeComponent();
            
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void songDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                this._userChoice = e.RowIndex;
                this._parent.playThisSong(this._userChoice);
                this._parent.playButton_Click(sender, e);
            }
        }

        public int getUserChoice()
        {
            return this._userChoice;
        }

        public void MediaForm_Load(object sender, EventArgs e)
        {
            songDataGridView.Rows.Clear();
            foreach (string path in this._list)
            {
                var fileTag = TagLib.File.Create(path);
                string title = fileTag.Tag.Title;
                string artist = fileTag.Tag.FirstPerformer;
                string album = fileTag.Tag.Album;

                TimeSpan songlegth = fileTag.Properties.Duration;
                string duration = songlegth.ToString(@"mm\:ss");
                songDataGridView.Rows.Add(title, artist, album, duration);
            }
        }
        public void addNewSong(String path)
        {
            var fileTag = TagLib.File.Create(path);
            string title = fileTag.Tag.Title;
            string artist = fileTag.Tag.FirstAlbumArtist;
            string album = fileTag.Tag.Album;
            TimeSpan songlegth = fileTag.Properties.Duration;
            string duration = songlegth.ToString(@"mm\:ss");
            songDataGridView.Rows.Add(title, artist, album, duration);
        }
    }
}
