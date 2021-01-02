﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Directory.Exists(@"\thumbnail"))
            {
                Directory.CreateDirectory(@"thumbnail");
            }
            if (!File.Exists(@"D:/bt2/data.json"))
            {
                File.Create(@"D:/bt2/data.json");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }


    }
}
