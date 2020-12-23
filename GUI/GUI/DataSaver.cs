using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
namespace GUI
{
    class DataSaver
    {
        private String _dir;
        private List<Playlist> _data;
        public DataSaver()
        {

        }

        public DataSaver(String dir,List<Playlist> data)
        {
            this._dir = dir;
            this._data = data;
        }

        public bool saveData()
        {
            if (!File.Exists(this._dir)) return false;
            string temp = JsonConvert.SerializeObject(_data);
            File.WriteAllText(_dir, temp);
            return true;
                
        }

        public bool update()
        {
            if (!File.Exists(this._dir)) return false;
            List<String> formatData = new List<String>();
            foreach (var x in this._data)
            {
                string temp = JsonConvert.SerializeObject(x);
                File.WriteAllText(_dir, temp);
            }
            return true;
        }

    }
}
