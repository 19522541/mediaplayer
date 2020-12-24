using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public delegate void MediaFormEventHandler(object sender, EventArgs e);

    public partial class MediaForm : Form
    {
        public event UserChoiceHandler UserChoiceChanged;
        public List<String> _list;
        private string _userChoice;
        public MainForm _parent;
        private List<SongInfoForm> _songInfo = null;
        public int _lastPlayed = -1;
        public PlayListForm _playListParent = null;
        public List<String> _ablum;
        public List<String> _title;
        public List<String> _firstPerformer;
        public List<String> _length;
        public List<Image> _songImg;
        public bool _firstPlay = true;
        public bool _mediaCheck = false;
        public int _nowPlayIndex = -1;
        public int _lastPlayedIndex;

        //
        //event
        //
        protected virtual void OnUserChoiceChanged()
        {
            if (UserChoiceChanged != null)
                UserChoiceChanged(this, EventArgs.Empty);
        }
        //public event EventHandler SomeEvent(object sender, EventArgs e);
        public MediaForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            //this.IsMdiContainer = true;
        }

        public MediaForm(MainForm parent, List<String> list)
        {
            this._list = list;
            this._parent = parent;
            InitializeComponent();
            this._songInfo = new List<SongInfoForm>();
            this._ablum = new List<String>();
            this._title = new List<String>();
            this._length = new List<String>();
            this._firstPerformer = new List<String>();
            this._songImg = new List<Image>();

        }

        public MediaForm(MainForm parent, PlayListForm playListParent, List<String> list)
        {
            this._list = list;
            this._parent = parent;
            this._playListParent = playListParent;
            InitializeComponent();
            this._songInfo = new List<SongInfoForm>();
            this._ablum = new List<String>();
            this._title = new List<String>();
            this._length = new List<String>();
            this._firstPerformer = new List<String>();
            this._songImg = new List<Image>();

        }

        void takeData(String dir)
        {
            var fileTag = TagLib.File.Create(dir);
            string title = fileTag.Tag.Title;
            string artist = fileTag.Tag.FirstPerformer;
            string album = fileTag.Tag.Album;
            TimeSpan songlegth = fileTag.Properties.Duration;
            string duration = songlegth.ToString(@"mm\:ss");
            if (album == null) album = "Unknown";
            if (artist == null) artist = "Unknown";
            Image temp = null;
            if (fileTag.Tag.Pictures.Length >= 1)
            {
                var bin = (byte[])(fileTag.Tag.Pictures[0].Data.Data);
                temp = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(100, 100, null, IntPtr.Zero);
            }
            else
            {
                temp = new Bitmap(GUI.Properties.Resources.songImg);
            }
            this._ablum.Add(album);
            this._firstPerformer.Add(artist);
            this._title.Add(title);
            this._length.Add(duration);
            this._songImg.Add(temp);
        }

        private void addSongInfo(SongInfoForm temp)
        {
            temp.TopLevel = false;
            temp.FormBorderStyle = FormBorderStyle.None;
            temp.Dock = DockStyle.Top;
            mediaPanel.Controls.Add(temp);
            //mediaPanel.Tag = temp;
            temp.BringToFront();
            temp.Show();
        }

        public string getUserChoice()
        {
            return this._userChoice;
        }

        public void MediaForm_Load(object sender, EventArgs e)
        {
            foreach (string x in this._list)
            {
                takeData(x);
            }
            for (int i = 0; i < this._list.Count; i++)
            {

                string title = this._title[i];
                string artist = this._firstPerformer[i];
                string album = this._ablum[i];
                string duration = this._length[i];
                SongInfoForm temp = new SongInfoForm(this, i, _list[i], album, title, artist, duration);
                this._songInfo.Add(temp);
                addSongInfo(temp);


            }
            if (this._parent.havePlayed() && !this._firstPlay)
            {
                this.setup(this._parent.getNowPlayIndex());
                if (this._parent.getNowPlayIndex() == 0) this._lastPlayed = this._parent.getNowPlayIndex();
            }


        }


        public void addNewSong(List<String> newSongs)
        {
            //check
            if (this._list.Count == 0) this._list = newSongs;
            foreach (String x in newSongs)
            {
                takeData(x);
            }
            for (int i = this._list.Count - newSongs.Count; i < this._list.Count; i++)
            {
                string title = this._title[i];
                string artist = this._firstPerformer[i];
                string album = this._ablum[i];
                string duration = this._length[i];
                SongInfoForm temp = new SongInfoForm(this, i, _list[i], album, title, artist, duration);
                this._songInfo.Add(temp);
                addSongInfo(temp);
            }
        }

        public void setUserChoice(string userChoice)
        {
            this._parent.playThisSong(this._list.IndexOf(userChoice));
            if (UserChoiceChanged != null)
            {
                UserChoiceChanged(this, EventArgs.Empty);
            }
        }

        public void setList(List<String> newList)
        {
            this._list = newList;
        }

        public void setup(int index)
        {
            this._songInfo[index].setup();
        }

        public void restart(int index)
        {
            this._songInfo[index].restart();

        }

        public int getLastPlayed()
        {
            return this._lastPlayed;
        }

        public void setLastPlayed(int index)
        {
            this._lastPlayed = index;
            this._parent.setLastPlayed(index);
        }

        public void clear()
        {

            this.mediaPanel.Controls.Clear();
            this._list.Clear();
            _ablum.Clear();
            _title.Clear();
            _firstPerformer.Clear();
            _length.Clear();
            _songImg.Clear();
            this._songInfo.Clear();
        }
    }
}
