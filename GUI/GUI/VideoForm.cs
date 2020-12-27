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
        public string user = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        //public string videoPath;
        public List<string> videos;
        //var picture_path = user + @"\Pictures\";
        //imagepath = GetFilesFrom(picture_path, filters, false);

        public ImageList thumbnail_list = new ImageList();
        List<string> vid_path;
        int vid_index = 0;

        VideoPlayer videoPlayer;
        public VideoForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            //thumbnail_list = new ImageList();
            vid_path = new List<string>();
            string root_path = user + @"\Downloads\";
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
            videolistView.LargeImageList.ColorDepth = ColorDepth.Depth32Bit;
            this.videolistView.BringToFront();
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
            videoframe.Save(save_path);

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
                if(videoPlayer!=null)
                {
                    if(videoPlayer.isPlaying)
                        videoPlayer._mp.Stop();
                    videoPlayer.Dispose();
                }
                var filepath = hit.Item.Tag.ToString();
                videoPlayer = new VideoPlayer(filepath);
                videoPlayer.Show();
                //MessageBox.Show(this, hit.Item.Tag.ToString());

            };
        }
    }
}
