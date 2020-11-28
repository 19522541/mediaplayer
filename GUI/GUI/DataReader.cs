using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Collections;

namespace GUI
{
    class DataReader
    {
        private String _dir;
        private List<Playlist> _data;

        public DataReader()
        {

        }

        public DataReader(String dir)
        {
            this._dir = dir;
            this._data = new List<Playlist>();
        }

        public bool loadData()
        {
            if (!File.Exists(this._dir)) return false;
            using (StreamReader r = new StreamReader(this._dir))
            {
                string json = r.ReadToEnd();
                this._data = JsonConvert.DeserializeObject<List<Playlist>>(json);
                
            }
            return true;
        }

        public List<Playlist> getData()
        {
            return this._data;
        }
    }
}
