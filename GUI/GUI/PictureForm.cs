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
        bool hided = false;
        bool _mousecheck = false;
        int j = 0;
        int x = 10;
        int y = 80;
        ImageList imagelist = new ImageList();
        PictureBox yourpic = new PictureBox();


        // List<Panel> yourimage= new List<Panel>();
        //     List<Bitmap> yourimage = new List<Bitmap>();
        string[] imagepath;
        //  ListView imagelist = new ListView();
        //   ListViewItem lstviewItem ;
        //---------------
        public PictureForm()
        {
            this.DoubleBuffered = true;

            InitializeComponent();
            this.DoubleBuffered = true;
            var filters = new String[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp", "svg" };


            imagepath = GetFilesFrom(@"C:\Users\Admin\Pictures\", filters, false);

            listView1.ForeColor = Color.White;
            foreach (var temp in imagepath)
            {

                imagelist.Images.Add(Image.FromFile(temp));
                this.imagelist.ImageSize = new Size(100, 100);
                this.listView1.LargeImageList = this.imagelist;

            }

            foreach (var temp in imagepath)
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
            //    foreach (var temp in yourithimage) {   displayimage(temp); }
            this.listView1.BringToFront();
            this.pictureBox1.MouseWheel += new MouseEventHandler(_zoomimage);

        }
        public static String[] GetFilesFrom(String searchFolder, String[] filters, bool isRecursive)
        {
            List<String> filesFound = new List<String>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, String.Format("*.{0}", filter), searchOption));
            }
            return filesFound.ToArray();
        }
        public void _add()
        {
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

                if (filePath != null)
                {
                    imagelist.Images.Add(Image.FromFile(filePath));
                    this.imagelist.ImageSize = new Size(100, 100);
                    ListViewItem item = new ListViewItem();
                    FileInfo file = new FileInfo(filePath);
                    item.ImageIndex = j;

                    item.Text = file.FullName;
                    this.listView1.Items.Add(item);
                    j++;
                }

            }

            //this.playButton.ImageIndex = 0;












            /*    { Panel paneltemp = new Panel();
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

             yourimage.Add(paneltemp)}*/


        }
      /*  public void afterchoiceimage(string path)
        {
            //   Image tempimage = Image.FromFile(path);
            // Bitmap temp = new Bitmap(tempimage,this.pictureBox1.Width,this.pictureBox1.Height);
            //  Graphics gr = Graphics.FromImage(tempimage);
            // gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            //   this.pictureBox1.Image =(Image)temp;

            this.Controls.Add(panel1);
            this.panel1.BringToFront();
            Bitmap temp = new Bitmap(path);
            this.pictureBox1.Image = new Bitmap(path);
           
            int n = temp.Width / temp.Height;
            this.tempimage = pictureBox1.Image;
            this.pictureBox1.Image = null;
            this.pictureBox1.Width = 659;
            this.pictureBox1.Height = Convert.ToInt32(temp.Height * pictureBox1.Width / temp.Width);

            this.pictureBox1.Image = tempimage;

          



        }*/
        public void changeimage(string path)
        {
           
            
            this.pictureBox1.Image = new Bitmap(path);

            this.tempimage = pictureBox1.Image;
            this.pictureBox1.Image = null;
           
           // this.pictureBox1.Width = 697;
          //  this.pictureBox1.Height = Convert.ToInt32(tempimage.Height * pictureBox1.Width / tempimage.Width);
            this.pictureBox1.Image = tempimage;
             pictureBox1.Size = panel1.Size;
            
            this.Controls.Add(panel1);
            this.panel1.BringToFront();
        }
        private void displayimage(Panel temp)
        {

            this.Controls.Add(temp);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_mousecheck)
            {
                ListView lstview = sender as ListView;
                this.panel1.BringToFront();
                if (lstview.SelectedItems.Count > 0)
                {
                    ListViewItem temp1 = new ListViewItem();
                    temp1 = lstview.SelectedItems[0];
                    changeimage(temp1.Text);
                  
                }

            }



        }
        private void setscroll()
        {

        }
        private void sethorizontalscroll(int value) { }
        private void setverticalscroll(int value) { }
        public static Image ResizeImage(Image image, Size imagesize)
        {
            return (Image)(new Bitmap(image, imagesize));
        }
        private void _selectedimage(Object sender, EventArgs e)
        {


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
        private Image zoompic(Image pic, float t)
        {

            Bitmap bm = new Bitmap(pic, Convert.ToInt32(pic.Width * t), Convert.ToInt32(pic.Height * t));
            Graphics gr = Graphics.FromImage(pic);
            gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bm;
        }
        PictureBox tempic = new PictureBox();
        Image tempimage;
        private void _zoomimage(object sender, MouseEventArgs e)
        {

            if (e.Delta > 0)
            {
                this.tempimage = pictureBox1.Image;
                this.pictureBox1.Image = null;
                this.pictureBox1.Width = Convert.ToInt32(this.pictureBox1.Width * 1.25);
                this.pictureBox1.Height = Convert.ToInt32(this.pictureBox1.Height * 1.25);
                this.pictureBox1.Image = tempimage;
                setscroll();
                // this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;


                //  tempic.Image = pictureBox1.Image;
                // pictureBox1.Image = null;
                //   pictureBox1.Image = zoompic(tempic.Image,1.25f);

                //  this.pictureBox1.

                /// this.Controls.Add(temp);
            }
            else if (e.Delta < 0)
            {
                this.pictureBox1.Width = Convert.ToInt32(this.pictureBox1.Width * 0.75);
                this.pictureBox1.Height = Convert.ToInt32(this.pictureBox1.Height * 0.75);

                //   tempic.Image = pictureBox1.Image;
                //   pictureBox1.Image = null;
                //  pictureBox1.Image = zoompic(tempic.Image, 0.75f);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {   
            this.Controls.Remove(panel1);
            _mousecheck = false;
        }
        void afterleftclick(Point pt)
        {

        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
                // afterleftclick(e.Location);
            }
           
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {   
            var senderList = (ListView)sender;
            var clickedItem = senderList.HitTest(e.Location).Item;
            if (clickedItem != null)
            {
                changeimage(clickedItem.Text);
                _mousecheck = true;

            }
        }

        private void bunifuVScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
