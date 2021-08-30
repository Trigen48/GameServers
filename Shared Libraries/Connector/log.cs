using System;
using System.Collections.Generic;
using System.Text;

namespace Connector
{
    public static class clog
    {
        public  static bool enlog = true;

        internal static void Save(string msg)
        {
            if (!enlog) return;
            CheckDir();

            string a = DateTime.Now.ToString("yyyyMMdd_hh_mm_ss - ") + new Random().Next(10003).ToString();
            System.IO.File.WriteAllText("log/Connector Log " + a + ".log", msg);
        }

        internal static void Save(Exception ex)
        {
            Save(ex.ToString());
        }


        internal static void CheckDir()
        {
            if (!System.IO.Directory.Exists("log"))
                System.IO.Directory.CreateDirectory("log");
        }
    }
}