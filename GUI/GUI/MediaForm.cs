using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public delegate void MediaFormEventHandler(object sender, EventArgs e);

    public partial class MediaForm : Form
    {
        public event UserChoiceHandler UserChoiceChanged;
        private List<String> _list;
        private string _userChoice;
        private MainForm _parent;
        private List<SongInfoForm> _songInfo = null;
        private int _lastPlayed = -1;
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
        }

        public MediaForm(MainForm parent,List<String> list)
        {
            this._list = list;
            this._parent = parent;
            InitializeComponent();
            this._songInfo = new List<SongInfoForm>();
            
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
            //songDataGridView.Rows.Clear();
            for (int i = 0; i < this._list.Count;i++)
            {
                var fileTag = TagLib.File.Create(_list[i]);
                string title = fileTag.Tag.Title;
                string artist = fileTag.Tag.FirstPerformer;
                string album = fileTag.Tag.Album;
                TimeSpan songlegth = fileTag.Properties.Duration;
                string duration = songlegth.ToString(@"mm\:ss");
                SongInfoForm temp = new SongInfoForm(this,i, _list[i], album, title, artist, duration);
                this._songInfo.Add(temp);
                addSongInfo(temp);
                
            }
            if (this._parent.havePlayed())
            {
                this.setup(this._parent.getNowPlayIndex());
                if (this._parent.getNowPlayIndex() == 0) this._lastPlayed = this._parent.getNowPlayIndex();
            }


        }
        public void addNewSong(int index)
        {
            for (int i = index; i < this._list.Count;i++ )
            {
                var fileTag = TagLib.File.Create(_list[i]);
                string title = fileTag.Tag.Title;
                string artist = fileTag.Tag.FirstPerformer;
                string album = fileTag.Tag.Album;
                TimeSpan songlegth = fileTag.Properties.Duration;
                string duration = songlegth.ToString(@"mm\:ss");
                SongInfoForm temp = new SongInfoForm(this,i, _list[i], album, title, artist, duration);
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
    }
}
