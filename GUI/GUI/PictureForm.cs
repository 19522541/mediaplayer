﻿using System;
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
using System.Threading.Tasks;
namespace GUI
{
    public partial class PictureForm : Form
    { 
        Point fpt1 = new Point();
        Point secpt2 = new Point();
        bool mouse = false;
        bool _mousecheck = false;
        bool _cutPicture = false;
        int j = 0;
        int x = 10;
        int y = 80;
        MainForm _parent;
        ImageList imagelist = new ImageList();
        PictureBox yourpic = new PictureBox();
        bool selected = false;
        Rectangle[] point = new Rectangle[2];
        Rectangle rec;
        
        // List<Panel> yourimage= new List<Panel>();
        //     List<Bitmap> yourimage = new List<Bitmap>();
        string[] imagepath;
        //  ListView imagelist = new ListView();
        //   ListViewItem lstviewItem ;
        //---------------
        public PictureForm(MainForm parent)
        {
            this.DoubleBuffered = true;
            this._parent = parent;
            InitializeComponent();
            this.DoubleBuffered = true;
            var filters = new String[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp", "svg" };
            this.point[0].Size = new Size(10, 10);
            this.point[1].Size = new Size(10, 10);

            imagepath = GetFilesFrom(@"C:\Users\DELL\Pictures", filters, false);

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
        public void save_image() {
            if (pictureBox1.Image != null) {

                SaveFileDialog savefil = new SaveFileDialog();
                savefil.Filter = "image file(*.bmg,*.gif,*.jpg) |*.bmp;*.gif;*.jpg";
                if (savefil.ShowDialog() == DialogResult.OK) {
                    if (savefil.FileName.EndsWith(".bmp")){
                        pictureBox1.Image.Save(savefil.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                    
                    }
                 
                  else  if (savefil.FileName.EndsWith(".gif"))
                    {
                        pictureBox1.Image.Save(savefil.FileName, System.Drawing.Imaging.ImageFormat.Gif);

                    }
                   else if (savefil.FileName.EndsWith(".jpg"))
                    {
                        pictureBox1.Image.Save(savefil.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                    }
                    else if (savefil.FileName.EndsWith(".png"))
                    {
                        pictureBox1.Image.Save(savefil.FileName, System.Drawing.Imaging.ImageFormat.Png);

                    }
                }
            }
        
        
        }
        private void rightRotate() {

            tempimage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = tempimage;
            pictureBox1.Size = panel1.Size;

        }
        private void leftRotate()
        {

            tempimage.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Image = tempimage;
            pictureBox1.Size = panel1.Size;

        }

        public void setrec() {
            rec = new Rectangle();
            rec.X = Math.Min(fpt1.X, secpt2.X);
            rec.Y = Math.Min(secpt2.Y, fpt1.Y);
            rec.Size = new Size(Math.Abs(fpt1.X - secpt2.X), Math.Abs(fpt1.Y- secpt2.Y));
            
          
            
        }
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
                this.selected = true;
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

      
        private void sethorizontalscroll(int value) { }
        private void setverticalscroll(int value) { }
        public void redraw() {
            Graphics g = this.pictureBox1.CreateGraphics();
            g.FillRectangle(Brushes.Aqua, point[0]);
            g.FillRectangle(Brushes.Aqua, point[1]);

        }
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
            foreach (ListViewItem temp in listView1.Items) {
                if (temp.Focused)
                {

                    changeimage(temp.Text);
                    _mousecheck = true;
                    break;
                   

                }
            
            }
        }

      

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right) contextMenuStrip2.Show(Cursor.Position); 
           // else
         //   {
         //      
           //     this.Controls.Remove(panel1);
          //      _mousecheck = false;
          //  }
        }

        private void rotateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rightRotate();
        }

        private void leftRotateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leftRotate();
        }
        public void next() {
            if(selected)
            {
                int selectedIndex = listView1.SelectedIndices[0];
                listView1.Items[selectedIndex].Selected = false;

                // Prevents exception on the last element:      
                if (selectedIndex < listView1.Items.Count - 1)
                {
                    selectedIndex++;
                }
                else { selectedIndex = 0; }
                listView1.Items[selectedIndex].Selected = true;
                listView1.Items[selectedIndex].Focused = true;
            }

        }
        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
             _mousecheck = true;
            //int selectedIndex = listView1.SelectedIndices[0];
            //listView1.Items[selectedIndex].Selected = false;

            //// Prevents exception on the last element:      
            //if (selectedIndex < listView1.Items.Count-1)
            //{
            //    selectedIndex++;
            //}
            //else{ selectedIndex = 0;   }
            //listView1.Items[selectedIndex].Selected = true;
            //listView1.Items[selectedIndex].Focused = true;
            next();
        }
        public void back() {
            if (selected)
            {
                int selectedIndex = listView1.SelectedIndices[0];
                listView1.Items[selectedIndex].Selected = false;

                // Prevents exception on the last element:      
                if (selectedIndex > 0)
                {
                    selectedIndex--;

                }
                else { selectedIndex = listView1.Items.Count - 1; }
                listView1.Items[selectedIndex].Selected = true;
                listView1.Items[selectedIndex].Focused = true;
            }
        }
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mousecheck = true;
            back();
        }

        private void contextMenuStrip1_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _cutPicture = true;
            this._parent.pictureFormCtrlAppear();
            
        }
        public void cancel()
        {
            _cutPicture = false;
            rec = new Rectangle();
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {   if (_cutPicture == true)
            {
                mouse = true;
                fpt1 = e.Location;
                this.pictureBox1.Refresh();
                setrec();
            }
            // || point[0].Contains(e.Location)
            
          //  if (point[0].Contains(e.Location)) {
      //          this.point[0].Location = e.Location;
           //}
        //    else if(point[1].Contains(e.Location)) this.point[0].Location = e.Location;
         //   redraw();
      }

        private void eSCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            escapse();
        }

        public void escapse()
        {
            this.Controls.Remove(panel1);
            _mousecheck = false;
        }

        private void pictureBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) contextMenuStrip2.Show(Cursor.Position);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse == true) {

                secpt2 = e.Location;
                this.pictureBox1.Invalidate();
                setrec();


                drawa();

            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouse == true) {

                secpt2 = e.Location;
               
                setrec();
               
                
                drawa();
                this.mouse = false;
            }
        }
        void drawa()
        {


            if (rec != null)
            {


               var g1= this.pictureBox1.CreateGraphics();
                Pen p = new Pen(Color.DarkOrange, 4);
                g1.DrawRectangle(p, rec);
            }
         //   if (rec != null&& rec.Height>20 && rec.Width>20) {
         //       draw_picture();
            
         //   }
        }
        public void draw_picture() {
            var rect = this.pictureBox1.ClientRectangle;
            using (var output = new Bitmap(rect.Width, rect.Height, pictureBox1.Image.PixelFormat)) {
                this.pictureBox1.DrawToBitmap(output,rect);
                this.pictureBox1.Image = output.Clone(rec, output.PixelFormat);
            
            }
        
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        public void save()
        {
            if (rec != null && rec.Height > 20 && rec.Width > 20)
            {
                    draw_picture();

                 }
                save_image();
            _cutPicture = false;
        }
    }
}
