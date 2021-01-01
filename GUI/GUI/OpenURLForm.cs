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
            VideoPlayer vd = new VideoPlayer(this.parent,urlTextBox.Text);
            vd.PlayURL();
            vd.Show();
            if (vd._mp.IsPlaying)
            {

                this.Close();
            }
        }
    }
}
