using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainbowServer
{
    internal static class Folders
    {

        internal static string CharDir;
        internal static string UserDir;
        internal static string MainDir;
        internal static string IDBASE;

        internal static void Init()
        {
            MainDir = "c:\\rainbow\\";
            CharDir = MainDir + "Chars\\";
            UserDir = MainDir + "Users\\";
            IDBASE = MainDir + "ID_DATA.srt";

            CreateDir(UserDir);
            CreateDir(CharDir);

        }

        public static void CreateDir(String dir)
        {
            if (!System.IO.Directory.Exists(dir))
            {
                try
                {
                    System.IO.Directory.CreateDirectory(dir);
                }
                catch
                {
                }
            }
        }
    }
}
