using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{
    internal static class log
    {
        // internal static Log trace = new Log();

        internal static bool enlog = true;
        internal static void Save(string msg)
        {
            if (!enlog) return;
            CheckDir();
            string a = (DateUtil.GetZoneDate().ToString().Replace("/", "-")).Replace(":", "_") + new Random().Next(10003).ToString();

            CheckDir();
            System.IO.File.WriteAllText("log/Game Server " + a + ".log", msg);
        }

        internal static void Save(Exception ex)
        {
            Save(ex.ToString());

        }

        internal static void Save(Exception ex, ConnectionInfo c)
        {

            string e = "";
            if (c != null)
                e = "Player Exception: " + c.rlid.ToString();
            else
                e = "Player Exception: Null";


            e += "\n" + ex.ToString();


            Save(e);

        }

        internal static void CheckDir()
        {
            if (!System.IO.Directory.Exists("log"))
                System.IO.Directory.CreateDirectory("log");

        }
    }
}

