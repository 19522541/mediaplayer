using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    class _list
    {
       public List<string> _listname = new List<string>() ;
        public _list() { string temp = System.IO.File.ReadAllText(Application.StartupPath+"\\filetxt\\yourlist.txt");
            string[] arraystr = temp.Split('|');
            foreach (string t in arraystr) { _listname.Add(t); }
        
        }
        public void _addlist(string name) { 
            _listname.Add(name);
            setfile();
        }
        public void deletelist(string  name) {
            _listname.Remove(name);
            setfile();
        }
        void setfile() {
            string t = "";
            foreach (string temp in _listname) {
             t =  t+ temp+"|";  
            }
            System.IO.File.WriteAllText("filetxt//yourlist.txt", t);
        }
        public List<string> _showlist() { return _listname; }
        
        
    }
}
