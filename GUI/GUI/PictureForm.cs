using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace GUI
{
    public partial class PictureForm : Form
    {
        int j = 0;
        int x= 10;
        int y= 80;
        ImageList imagelist= new ImageList();
     
       // List<Panel> yourimage= new List<Panel>();
       //     List<Bitmap> yourimage = new List<Bitmap>();
        string[] imagepath;
      //  ListView imagelist = new ListView();
     //   ListViewItem lstviewItem ;
        //---------------
        public PictureForm()
        {

            InitializeComponent();
            
            imagepath = System.IO.Directory.GetFiles(@"C:\Users\Admin\Pictures\", "*.jpg");

            listView1.ForeColor = Color.White;
            foreach (var temp in imagepath) {

                imagelist.Images.Add(Image.FromFile(temp));
                this.imagelist.ImageSize = new Size(100, 100);
                this.listView1.LargeImageList = this.imagelist;
                
            }
           
            foreach(var temp in imagepath)
        {   
               ListViewItem item = new ListViewItem();
                FileInfo file = new FileInfo(temp);
             item.ImageIndex = j;
              
                item.Text = file.FullName;
              this.listView1.Items.Add(item);
                
                j++;
                
           }
            listView1.LargeImageList.ColorDepth = ColorDepth.Depth32Bit;
            //     foreach (var temp in imagepath) {   creatteimage(temp); }
            //    foreach (var temp in yourimage) {   displayimage(temp); }


        }
        
        private void _add() {
            OpenFileDialog res = new OpenFileDialog();

            //Filter
            res.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";

            //When the user select the file
            if (res.ShowDialog() == DialogResult.OK)
            {
                //Get the file's path
                var filePath = res.FileName;
                //open.Filter = "WAV file (*.wav)| *.wav";
                //if (open.ShowDialog() != DialogResult.OK) return;
               

                imagelist.Images.Add(Image.FromFile(filePath));
                this.imagelist.ImageSize = new Size(100, 100);
                ListViewItem item = new ListViewItem();
                FileInfo file = new FileInfo(filePath);
                item.ImageIndex = j;
               
                item.Text = file.FullName;
                this.listView1.Items.Add(item);
                j++;

            }
           
            //this.playButton.ImageIndex = 0;













            /*     Panel paneltemp = new Panel();
                 paneltemp.Size = new Size(150, 170);
                 PictureBox tempimage = new PictureBox();
                 tempimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                 tempimage.Image = Image.FromFile(path);
                 Label templabel = new Label();
             templabel.Font = new Font("Microsoft Sans Serif", 13);
                 templabel.Text = Path.GetFileName(path);
                 tempimage.Dock = DockStyle.Top;
                 paneltemp.Controls.Add(tempimage);
                 paneltemp.Controls.Add(templabel);
                 templabel.Location = new  Point(34, 131);
                 paneltemp.Location = new Point(x,y);
             this.x += 220;
             if (this.x >= 700)
             {
                 this.x = 10; this.y += 250;

             }

             yourimage.Add(paneltemp)*/


        }
        private void displayimage(Panel temp) {

            this.Controls.Add(temp);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lstview = sender as ListView;
           
            if (lstview.SelectedItems.Count > 0) {
                ListViewItem temp1= new ListViewItem();
                temp1 = lstview.SelectedItems[0];
                PictureBox choiceimage = new PictureBox();
                choiceimage.Size = new Size(250, 250);
                choiceimage.SizeMode = PictureBoxSizeMode.Zoom;
                choiceimage.Dock = DockStyle.Fill;
                
                choiceimage.Image = Image.FromFile(temp1.Text) ;//temp1.Text;
                choiceimage.Location = new  Point(80,80);
                this.Controls.Add(choiceimage);
                choiceimage.Click += new EventHandler(_selectedimage);
                choiceimage.BringToFront();
                MessageBox.Show(temp1.Text);
                //  MessageBox.Show(temp1.Text);
              
            }
           
           
            
         }
        private void _selectedimage(Object sender, EventArgs e) {

            PictureBox temp = (PictureBox)sender;
            temp.Hide();
        
        
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _add();
        }
    }
}
