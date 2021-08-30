using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public class Log
    {
        public bool enlog = true;
        System.IO.StreamWriter rw;

        public Log()
        {
            CheckDir();
            rw = new System.IO.StreamWriter("log/" + DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss") + ".log");
            rw.AutoFlush = true;
        }

        public void Save(string msg)
        {
            if (!enlog) return;

            lock (rw)
            {
                rw.WriteLine(msg);
                rw.WriteLine();
                rw.Flush();
            }

        }

        public void Save(Exception ex)
        {
            Save(ex.ToString());
        }

        public void CheckDir()
        {
            if (!System.IO.Directory.Exists("log"))
                System.IO.Directory.CreateDirectory("log");

        }

        public void Close()
        {
            rw.Close();
        }
    }
}
