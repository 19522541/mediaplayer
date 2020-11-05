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
    public partial class SongInfoForm : Form
    {
        public SongInfoForm()
        {
            InitializeComponent();
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void MouseHover(object sender, EventArgs e)
        {
           
        }

        private void MouseLeave(object sender, EventArgs e)
        {
           
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
    }
}
