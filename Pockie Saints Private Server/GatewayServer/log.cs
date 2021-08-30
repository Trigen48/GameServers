using System;
using System.Collections.Generic;
using System.Text;

namespace gateway
{
    internal static class log
    {
        // internal static Log trace = new Log();

        internal static bool enlog = true;

        static log()
        {
            CheckDir();
        }

        internal static void Save(Exception ex)
        {
            Save(ex.ToString());
        }

        internal static void Save(string msg)
        {
            if (!enlog) return;
            CheckDir();

            string f = DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + new Random().Next(10003).ToString();
            System.IO.File.WriteAllText("log/gateway-" + f + ".log", msg);
        }

        internal static void CheckDir()
        {
            if (!System.IO.Directory.Exists("log"))
                System.IO.Directory.CreateDirectory("log");

        }
    }
}

