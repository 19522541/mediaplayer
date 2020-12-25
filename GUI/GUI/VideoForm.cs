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

        ImageList thumbnail_list = new ImageList();
        List<string> vid_path;
        int vid_index = 0;
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
            videoframe.Save(name + ".bmp");

            //dispose video frame
            videoframe.Dispose();
            reader.Close();
        }

        private ImageList GetVideoThumbnail(string[] vid_path)
        {
            ImageList thumbnails = new ImageList();
            foreach (var video in vid_path)
            {
                // create a thumbnail [video's name].bmp
                getFirstFrame(video);
                var temp = Path.GetFileNameWithoutExtension(video);
                var thumbnail = Directory.GetFiles(temp, ".bmp")[0];

                thumbnails.Images.Add(Image.FromFile(thumbnail));



            }


            return thumbnails;
        }

        private string GetVideoThumbnail(string vid_path)
        {
            getFirstFrame(vid_path);
            var temp = Path.GetFileNameWithoutExtension(vid_path);
            temp += ".bmp";
            DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());
            temp = Path.Combine(dir.FullName, temp);


            return temp;
        }

    }
}
