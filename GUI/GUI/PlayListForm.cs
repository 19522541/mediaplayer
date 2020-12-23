using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class PlayListForm : Form
    {
        private MainForm _parent;
        private List<Playlist> _playlists;
        private ImageList _imgList = new ImageList();
        public MediaForm _mediaForm;
        private DataReader _dataReader;
        public PlayListForm()
        {
            this._playlists = new List<Playlist>();
            _imgList.ImageSize = new Size(200, 200);
            _imgList.ColorDepth = ColorDepth.Depth32Bit;

            InitializeComponent();
            this.playListView.LargeImageList = _imgList;
            //this.playListView.SmallImageList = _imgList;
        }
        
        public PlayListForm(MainForm parent)
        {
            this._playlists = new List<Playlist>();
            _imgList.ImageSize = new Size(200, 200);
            _imgList.ColorDepth = ColorDepth.Depth32Bit;
            this._parent = parent;
            InitializeComponent();
            this.playListView.LargeImageList = _imgList;
            this._dataReader = new DataReader(@"D:/bt2/data.json");
            
        }

        public void addNewPlayList(string Name,string imgDir,string songDir)
        {
            Playlist x;
            if (songDir == String.Empty)
            {
                 x = new Playlist(Name, imgDir);
            }
            else
            {
                List<String> list = new List<String>();
                list.Add(songDir);
                 x = new Playlist(Name,imgDir,list);
            }
            this._playlists.Add(x);
            ListViewItem temp;
            if (x._imgDir != string.Empty)
            {
                _imgList.Images.Add(x._imgDir, Image.FromFile(x._imgDir));
                 temp = new ListViewItem(x._name, x._imgDir);
            }
            else
            {
                var bmp = new Bitmap(GUI.Properties.Resources.pic);
                _imgList.Images.Add("default", bmp);
                temp = new ListViewItem(x._name, "default");
            }
            temp.ForeColor = SystemColors.GradientActiveCaption;
            this.playListView.Items.Add(temp);
        }

        private void playListView_DoubleClick(object sender, EventArgs e)
        {
            var selectedPlayList = playListView.SelectedItems;
            if (selectedPlayList.Count == 0)
            {
                return;
            }
            var playlist = selectedPlayList[0];
            int index = 0;
            foreach(Playlist x in this._playlists)
            {
                if (x.getName() == playlist.SubItems[0].Text)
                {
                    break;
                }
                else
                {
                    index++;
                }
            }
            List<String> songDir = this._playlists[index]._songDir;
            this._parent._mediaForm._nowPlayIndex = this._parent._nowPlayIndex;
            this._parent.setInfo(0, -1);
            
            this._parent._backupMediaForm = new MediaForm(this._parent, songDir); 
            this._parent._playedList = this._parent._backupMediaForm._list;
            this._parent._backupMediaForm._mediaCheck = true;
            this._parent._backupMediaForm.UserChoiceChanged += this._parent.playButton_Click;
            this._parent._backupMediaForm.FormBorderStyle = FormBorderStyle.None;
            this._parent._backupMediaForm.Dock = DockStyle.Fill;
            this._parent._backupMediaForm.TopLevel = false;
            this.playListView.Hide();
            this.Controls.Add(this._parent._backupMediaForm);
            this._parent._backupMediaForm.Show();
            this._parent.setPlayedList(_parent._backupMediaForm._list, _parent._backupMediaForm._ablum, _parent._backupMediaForm._title, _parent._backupMediaForm._firstPerformer, _parent._backupMediaForm._length, _parent._backupMediaForm._songImg);

        }

        public void PlayListForm_Load(object sender, EventArgs e)
        {
            this.playListView.Items.Clear();
            this._playlists.Clear();
            _dataReader.loadData();
            var list = _dataReader.getData();
            if (list.Count == 0)
            {
                return;
            }
            else
            {
                foreach (Playlist x in list)
                {
                    this._playlists.Add(x);
                    ListViewItem temp;
                    if (x._imgDir != string.Empty)
                    {
                        _imgList.Images.Add(x._imgDir, Image.FromFile(x._imgDir));
                        temp = new ListViewItem(x._name, x._imgDir);
                    }
                    else
                    {
                        var bmp = new Bitmap(GUI.Properties.Resources.pic);
                        _imgList.Images.Add("default", bmp);
                        temp = new ListViewItem(x._name, "default");
                    }
                    temp.ForeColor = SystemColors.GradientActiveCaption;
                    this.playListView.Items.Add(temp);
                }
            }
        }

        public List<Playlist> GetPlaylist()
        {
            return this._playlists;
        }

        public List<String> getPlaylistsName()
        {
            List<String> rs = new List<String>();
            foreach (Playlist x in this._playlists)
            {
                rs.Add(x._name);
            }
            return rs;
        }

        public void showInfo()
        {
            this.playListView.Show();
        }
    }
}
