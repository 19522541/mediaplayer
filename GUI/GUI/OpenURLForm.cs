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
        public OpenURLForm()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            VideoPlayer vd = new VideoPlayer(urlTextBox.Text);
            vd.PlayURL();
            vd.Show();
            if (vd.isPlaying)
            {

                this.Close();
            }
        }
    }
}
