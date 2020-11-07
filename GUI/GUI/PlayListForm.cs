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
    { List<Panel> _listpanel = new List<Panel>();
        public PlayListForm()
        {
          
            InitializeComponent();

            foreach (string temp in _yourlist._listname) {

                displaylist(temp);
            
            
            }
            
        }
        //-------------------------------------------
        _list _yourlist = new _list();
        List<PictureBox> listbox=new List<PictureBox>();
        int x =10;
        int y =80;
        //----------------funtion-----------------------------------
      
        
        
        public void displaylist(string listname)
        {
            Panel listpanel = new Panel();
            listpanel.DoubleClick += new EventHandler(imagelist_Click);
            
            listpanel.Size = new System.Drawing.Size(139, 160);

            listpanel.Location = new System.Drawing.Point(this.x, this.y);
            PictureBox image = new PictureBox();
            image.DoubleClick += new EventHandler(imagelist_Click);
            image.Click += new EventHandler(_panelclick);
            
            image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            image.Dock = DockStyle.Top;
            Bitmap pict = new Bitmap("D:\\object\\mediaplayer-master\\GUI\\GUI\\Resources\\listbox.png");
            image.Image = (Image)pict;
            image.Size = new Size(139, 125);
            listpanel.Controls.Add(image);
            System.Windows.Forms.Label listn = new System.Windows.Forms.Label();
            listn.Text = listname;
            listn.Font = new Font("Microsoft Sans Serif", 12);
            listn.ForeColor = System.Drawing.Color.Magenta;
            listn.Location = new Point(34, 131);
            listpanel.Controls.Add(listn);
        //    listpanel.MouseClick += new MouseEventHandler(_panelclick);
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
        private void _check() {
            List<string> temp = new List<string>();
            
            foreach (var temp1 in _listpanel) {
                string strr = "";
                foreach (Control temp2 in temp1.Controls) {
                   
                    if (temp2.GetType() == typeof(PictureBox) && temp2.BackColor == System.Drawing.Color.DodgerBlue) {
                        temp.Add(strr);
                    }
                    if (temp2.GetType() == typeof(System.Windows.Forms.Label)) { strr = temp2.Text; }

                }
                 strr = "";
            }
            foreach (var t in temp) {
                _yourlist.deletelist(t);
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createlistForm formtemp = new createlistForm();
            formtemp.ShowDialog();
            if (formtemp.listname.Text != "")
            {
                _yourlist._addlist(formtemp.listname.Text);
                displaylist(formtemp.listname.Text);
            }
            //MessageBox.Show("hello");

            // using (createlistForm _createform = new createlistForm()) {
            //    _createform.ShowDialog();

            //    _yourlist._addlist(_createform.name);
            //displaylist(_createform.name);

        }


        private void redisplaylist() {
            foreach (var t in  _listpanel) { this.Controls.Remove(t); }
            foreach (string temp in _yourlist._listname)
            {

                displaylist(temp);


            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _check();
            this.x = 10;
            this.y = 80;
            redisplaylist();

           //---------delete----------------------
        }

        private void namelist_Click(object sender, EventArgs e)
        {

        }

        private void imagelist_Click(object sender, EventArgs e)
        {
           
            foreach (var temp in _listpanel) { temp.Hide(); }


        }
        private void _panelclick(object sender, EventArgs e) {
            PictureBox temp = (PictureBox)sender;
            if (temp.BackColor != System.Drawing.Color.DodgerBlue)
                temp.BackColor = System.Drawing.Color.DodgerBlue;
            else temp.BackColor=System.Drawing.Color.FromArgb(32, 30, 45);
        }

        private void PlayListForm_Load(object sender, EventArgs e)
        {

        }
    }
}
