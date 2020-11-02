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
    public partial class createlistForm : Form
    {
        public createlistForm()
        {
            InitializeComponent();
        }
        public string name;

        private void button2_Click(object sender, EventArgs e)
        {
            name = listname.Text;
            this.Close();
        }

        private void listname_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
