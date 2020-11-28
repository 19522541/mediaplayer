using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Playlist
    {
        public String _name { get; set; }
        public String _imgDir { get; set; }
        public List<String> _songDir{ get; set; }
        
        public Playlist()
        {

        }
        
        public Playlist(String name, String imgDir, List<String> songDir)
        {

            this._name = name;
            this._songDir = songDir;
            this._imgDir = imgDir;
            
        }

        public Playlist(String name,String imgDir)
        {
            this._name = name;
            this._imgDir = imgDir;
            this._songDir = new List<String>();
        }

        public List<String> getSongDirs()
        {
            return this._songDir;
        }

        public String getName()
        {
            return this._name;
        }
    }
}
