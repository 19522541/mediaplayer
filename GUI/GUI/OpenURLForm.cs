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
    public partial class OpenURLForm : Form
    {
        MainForm parent;
        public OpenURLForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            var videoPlayer = new VideoPlayer(this.parent,urlTextBox.Text,true);
            
            if(!videoPlayer.IsDisposed)
            {
                if (this.parent._player != null)
                {
                    if (!this.parent._player.IsDisposed)
                    {
                        //videoPlayer._mp.Stop();
                        if (this.parent._player._mp.WillPlay)
                            this.parent._player._mp.Dispose();
                        this.parent._player.Dispose();
                        this.parent._player.Close();
                    }
                }
                
                //modify video player
                videoPlayer.TopLevel = false;
                videoPlayer.FormBorderStyle = FormBorderStyle.None;
                videoPlayer.Dock = DockStyle.Fill;

                //assign video player to MainForm's player
                this.parent._player = videoPlayer;
                this.parent.PlayVideo(sender, e);
            }
            
        }
    }
}
