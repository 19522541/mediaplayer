using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    

    
    public partial class SongInfoForm : Form
    {
        int _index;
        MediaForm _parent = null;
        String _dir = null;
        bool _isPlaying = false;
        public SongInfoForm()
        {
            InitializeComponent();
            
        }

        public SongInfoForm(MediaForm parent,int index ,string dir,string songName,string title,string artist,string length)
        {
            InitializeComponent();
            this._parent = parent;
            this._dir = dir;
            this._index = index;
            this.indexLabel.Text = (_index + 1).ToString();
            this.artist.Text = artist;
            this.length.Text = length;
            this.songName.Text = songName;
            this.title.Text = title;
            this.DoubleBuffered = true;
            this._index = index;
            this.songInfoContextMenu.Renderer = new MyRenderer();

        }

        

        
        private void SongInfo_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {
                
                songInfoContextMenu.Show(Cursor.Position);
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {

                songInfoContextMenu.Show(Cursor.Position);
                return;
            }

            else if(me.Button == MouseButtons.Left)
            {
                if (this._parent.getLastPlayed() == -1)
                {
                    this._parent.setUserChoice(_dir);
                    this.setup();
                    this._parent.setLastPlayed(this._index);
                }
                else
                {
                    this._parent.setUserChoice(_dir);
                    this._parent.restart(this._parent.getLastPlayed());
                    this.setup();
                    this._parent.setLastPlayed(this._index);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {

                songInfoContextMenu.Show(Cursor.Position);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {

                songInfoContextMenu.Show(Cursor.Position);
            }
        }

        private void songName_Click(object sender, EventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            songInfoTimer_Tick(this, e);
        }

        private void songInfoTimer_Tick(object sender, EventArgs e)
        {
            if (ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                songPanel.BackColor = Color.FromArgb(21, 23, 26);
                
            }
            else
            {
                songPanel.BackColor = Color.FromArgb(33, 37, 41);
                
            }
        }


        private void Click1(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button == MouseButtons.Right)
            {

                this.songInfoContextMenu.Show(Cursor.Position);
            }
        }

        private void DoubleClick1(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button == MouseButtons.Left)
            {
                if (this._parent.getLastPlayed() == -1)
                {
                    this._parent.setUserChoice(_dir);
                    this.setup();
                    this._parent.setLastPlayed(this._index);
                }
                else
                {
                    this._parent.setUserChoice(_dir);
                    this._parent.restart(this._parent.getLastPlayed());
                    this.setup();
                    this._parent.setLastPlayed(this._index);
                }
            }
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                if (this._parent.getLastPlayed() == -1)
                {
                    this._parent.setUserChoice(_dir);
                    this.setup();
                    this._parent.setLastPlayed(this._index);
                }
                else
                {
                    this._parent.setUserChoice(_dir);
                    this._parent.restart(this._parent.getLastPlayed());
                    this.setup();
                    this._parent.setLastPlayed(this._index);
                }
            

        }

        // set color
        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuBorder
            {
                get { return Color.FromArgb(33, 37, 41); }
            }
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(21, 23, 26); }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.Orange; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(21, 23, 26); }
            }
        }
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        public void restart()
        {
            songPanel.BackColor = Color.FromArgb(33, 37, 41);
            songName.ForeColor = title.ForeColor = artist.ForeColor = length.ForeColor = SystemColors.GradientActiveCaption;
            this.songInfoTimer.Start();
        }
        
        public void setup()
        {
            songPanel.BackColor = Color.FromArgb(21, 23, 26);
            songName.ForeColor = title.ForeColor = artist.ForeColor = length.ForeColor = Color.FromArgb(250, 58, 95);
            this.songInfoTimer.Stop();
        }
        
    }
}
