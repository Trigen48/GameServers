using System;
using System.Collections.Generic;
using System.Text;

namespace RainbowServer
{
    internal static class log
    {
        internal static bool enlog = true;
        internal static void Save(string msg)
        {
            if (!enlog) return;
            string a = (DateTime.UtcNow.AddHours(DateUtil.Zone).ToString().Replace("/", "-")).Replace(":", "_");

            CheckDir();
            System.IO.File.WriteAllText("log\\" + a + ".log", msg);
        }

        internal static void Save(Exception ex)
        {
            if (!enlog) return;
            string a = (DateTime.UtcNow.AddHours(DateUtil.Zone).ToString().Replace("/", "-")).Replace(":", "_");
            string[] lines = new string[5];

            lines[0] = ex.ToString();

            if (ex.InnerException != null)
                lines[2] = ex.InnerException.ToString();

            lines[4] = ex.StackTrace;


            CheckDir();
            System.IO.File.WriteAllLines("log\\" + a + ".log", lines);
            lines = null;

        }

        internal static void Save(Exception ex, ConnectionInfo c)
        {
            if (!enlog) return;
            string a = (DateTime.UtcNow.AddHours(DateUtil.Zone).ToString().Replace("/", "-")).Replace(":", "_");
            string[] lines = new string[7];


            if (c != null)
                lines[0] = "Player Exception: " + c.SessionID.ToString();
            else
                lines[0] = "Player Exception: Null";


            lines[2] = ex.ToString();

            if (ex.InnerException != null)
                lines[4] = ex.InnerException.ToString();

            lines[6] = ex.StackTrace;

            CheckDir();
            System.IO.File.WriteAllLines("log\\" + a + ".log", lines);
            lines = null;

        }
        internal static void CheckDir()
        {
            if (!System.IO.Directory.Exists("log"))
                System.IO.Directory.CreateDirectory("log");

        }
    }
}

