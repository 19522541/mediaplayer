using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    { List<Panel> _listpanel = new List<Panel>();
        public PlayListForm()
        {
          
            InitializeComponent();

            foreach (string temp in _yourlist._listname) {

                displaylist(temp);
            
            
            }
            
        }
        _list _yourlist = new _list();
        List<PictureBox> listbox=new List<PictureBox>();
        int x =10;
        int y =80;
        //----------------funtion-----------------------------------
        void displayyourlist()
        {

            foreach (string temp in _yourlist._listname)
            {
                PictureBox templist = new PictureBox();
                listbox.Add(templist);
                templist.Location = new System.Drawing.Point(this.x, this.y);
                templist.Size = new System.Drawing.Size(120, 120);
                Bitmap _image = new Bitmap("D:\\Toi_t0I\\eto.jpg");
                templist.Image = (Image)_image;
                templist.SizeMode = PictureBoxSizeMode.Zoom;
                Controls.Add(templist);
                this.x += 160;
                if (this.x >= 700) { this.x = 10; this.y += 180; }
            }
        }
        void displaythislist(string name) {
                PictureBox templist = new PictureBox();
                listbox.Add(templist);
                templist.Location = new System.Drawing.Point(this.x, this.y);
                templist.Size = new System.Drawing.Size(120, 120);
                Bitmap _image = new Bitmap("D:\\Toi_t0I\\eto.jpg");
                templist.Image = (Image)_image;
                templist.SizeMode = PictureBoxSizeMode.Zoom;
                Controls.Add(templist);
                this.x += 160;
                if (this.x >= 700)
                {
                    this.x = 10; this.y += 180;

                }
        
        }
        public void displaylist(string listname)
        {
            Panel listpanel = new Panel();
            listpanel.Click += new EventHandler(imagelist_Click);
            listpanel.Size = new System.Drawing.Size(139, 160);

            listpanel.Location = new System.Drawing.Point(this.x, this.y);
            PictureBox image = new PictureBox();
            image.Click += new EventHandler(imagelist_Click);
            image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            image.Dock = DockStyle.Top;
            Bitmap pict = new Bitmap("D:\\Toi_t0I\\eto.jpg");
            image.Image = (Image)pict;
            image.Size = new Size(139, 125);
            listpanel.Controls.Add(image);
            System.Windows.Forms.Label listn = new System.Windows.Forms.Label();
            listn.Text = listname;
            listn.Font = new Font("Microsoft Sans Serif", 12);
            listn.ForeColor = System.Drawing.Color.Magenta;
            listn.Location = new Point(34, 131);
            listpanel.Controls.Add(listn);
            listpanel.MouseClick += new MouseEventHandler(_panelclick);
            _listpanel.Add(listpanel);
            this.Controls.Add(listpanel);

            this.x += 200;
            if (this.x >= 700)
            {
                this.x = 10; this.y += 200;

            }
          //  addclickeven();

        

        }
      private  void addclickeven() {
            foreach (var temp in _listpanel) {
                temp.Click += new EventHandler(imagelist_Click);
            }
        
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("wewee");
           
           // using (createlistForm _createform = new createlistForm()) {
            //    _createform.ShowDialog();

            //    _yourlist._addlist(_createform.name);
//displaylist(_createform.name);
            
            }
            

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // temp = listpanel;
            displaylist("name");
        }

        private void namelist_Click(object sender, EventArgs e)
        {

        }

        private void imagelist_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }
        private void _panelclick(object sender, EventArgs e) {
            MessageBox.Show("helo");
            
        }
    }
}
