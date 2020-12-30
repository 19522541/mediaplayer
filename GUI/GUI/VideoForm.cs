using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Video.FFMPEG;
namespace GUI
{
    public partial class VideoForm : Form
    {
        //MainForm as parent to assign video player to mainform's player
        MainForm _parent;
        public string root_path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)+@"\Downloads\";
        
        
        //public string videoPath;
        public List<string> videos;
        //var picture_path = user + @"\Pictures\";
        //imagepath = GetFilesFrom(picture_path, filters, false);

        public ImageList thumbnail_list = new ImageList();
        List<string> vid_path;
        int vid_index = 0;

        public VideoPlayer videoPlayer;

        //check if folder not have media files
        public bool isMediaNotFound;
        public VideoForm(MainForm parent, string folder)
        {
            InitializeComponent();

            this._parent = parent;

            this.DoubleBuffered = true;
            //thumbnail_list = new ImageList();
            vid_path = new List<string>();

            if (folder != "") root_path = folder;

            var filters = new string[]
            {
                "*.dat", "*.wmv", "*.amv", "*.asf", "*.avi",
                "*.flv",
                "*.mkv", "*.mov", "*.mp4", "*.mp4v",
                "*.mpeg", "*.mpeg1", "*.mpeg2", "*.mpeg4","*.mpg",
                "*.rec", "*.rm", "*.webm"


            };
            //vid_path = GetFilesFrom(root_path, filters, false);
            foreach (var filter in filters)
            {
                var temp = Directory.GetFiles(root_path, filter, SearchOption.TopDirectoryOnly);
                vid_path.AddRange(temp);
            }

            videolistView.ForeColor = Color.White;
            //thumbnail_list = GetVideoThumbnail(vid_path);
            foreach (var vid in vid_path)
            {
                var temp = GetVideoThumbnail(vid);
                this.thumbnail_list.Images.Add(Image.FromFile(temp));
                this.thumbnail_list.ImageSize = new Size(100, 100);
                this.videolistView.LargeImageList = thumbnail_list;
            }
            foreach (var vid in vid_path)
            {
                ListViewItem item = new ListViewItem();
                FileInfo file = new FileInfo(vid);
                item.ImageIndex = vid_index;

                item.Text = file.Name;
                item.Tag = vid;
                this.videolistView.Items.Add(item);

                vid_index++;
            }
            if (videolistView.LargeImageList != null)
            {
                videolistView.LargeImageList.ColorDepth = ColorDepth.Depth32Bit;
                
                //this.videolistView.Show();
                //this.videolistView.BringToFront();
                //this.topPanel.Hide();
                //this.emptyListLabel.Hide();

                //add videoListView to mainPanel
                mainPanel.Controls.Add(videolistView);
                mainPanel.Tag = videolistView;
                this.videolistView.BringToFront();
                this.topPanel.Hide();
                this.emptyListLabel.Hide();

                //assign player to MainForm's video player
                
            }
            else
            {
                isMediaNotFound = true;
                this.emptyListLabel.Show();
                this.emptyListLabel.BringToFront();
                this.videolistView.Hide();
                
            }    
                
            
            
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

        private void getFirstFrame(string path)
        {
            VideoFileReader reader = new VideoFileReader();
            // open video file
            reader.Open(path);
            //read the first frame 
            Bitmap videoframe = reader.ReadVideoFrame();
            string name = Path.GetFileNameWithoutExtension(path);
            name += ".bmp";
            DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());
            string temp = @"thumbnail";
            string save_path = Path.Combine(dir.FullName,temp,name);
            if (!File.Exists(save_path))
            {
                videoframe.Save(save_path);
            }    
            
            
            //dispose video frame
            videoframe.Dispose();
            reader.Close();
        }

        //private ImageList GetVideoThumbnail(string[] vid_path)
        //{
        //    ImageList thumbnails = new ImageList();
        //    foreach (var video in vid_path)
        //    {
        //        // create a thumbnail [video's name].bmp
        //        getFirstFrame(video);
        //        var temp = Path.GetFileNameWithoutExtension(video);
        //        var thumbnail = Directory.GetFiles(temp, ".bmp")[0];

        //        thumbnails.Images.Add(Image.FromFile(thumbnail));



        //    }


        //    return thumbnails;
        //}

        private string GetVideoThumbnail(string vid_path) //get the bitmap thumbnail path of video
        {
            getFirstFrame(vid_path);
            var file = Path.GetFileNameWithoutExtension(vid_path);
            file += ".bmp";
            string thumbnail_path = @"thumbnail";
            DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());
            // combine current directory + thumbnail + filename (./Debug/thumbnail/filename.bmp)
            var temp = Path.Combine(dir.FullName,thumbnail_path, file);


            return temp;
        }

        public void DeleteThumbnail()
        {
            foreach(Image image in this.thumbnail_list.Images)
            {
                image.Dispose();
            }
            DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());
            string temp = @"thumbnail";
            string thumbnail_path = Path.Combine(dir.FullName, temp);
            DirectoryInfo del_folder = new DirectoryInfo(thumbnail_path);
            foreach(FileInfo fi in del_folder.EnumerateFiles())
            {
                fi.Delete();
            }
        }

        private void videolistView_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void videolistView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hit = videolistView.HitTest(e.Location);

            if (hit.Item != null)

            {
                // open in a seperate window

                if (videoPlayer != null)
                {
                    if (!videoPlayer.IsDisposed)
                    {
                        //videoPlayer._mp.Stop();
                        if(videoPlayer._mp.WillPlay)
                            videoPlayer._mp.Dispose();
                        videoPlayer.Dispose();
                        videoPlayer.Close();
                    }                      
                    
                }
                var filepath = hit.Item.Tag.ToString();
                videoPlayer = new VideoPlayer(filepath);

                //modify video player
                videoPlayer.TopLevel = false;
                videoPlayer.FormBorderStyle = FormBorderStyle.None;
                videoPlayer.Dock = DockStyle.Fill;
                
                //assign video player to MainForm's player
                this._parent._player = this.videoPlayer;
                this._parent.PlayVideo(sender, e);

                //add video player to main Panel
                    //this.mainPanel.Controls.Add(videoPlayer);
                    //this.mainPanel.Tag = videoPlayer;
                    //this.videoPlayer.BringToFront();
                    //this.videoPlayer.Show();
                //this.videolistView.Hide();

                //MessageBox.Show(this, hit.Item.Tag.ToString());

                //open inside the main panel
                
            };
        }

        private void openFolderButton_Click(object sender, EventArgs e)
        {

        }

        private void VideoForm_Load(object sender, EventArgs e)
        {

        }

        private void videolistView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void videoPlayerView_Click(object sender, EventArgs e)
        {

        }
    }
}
