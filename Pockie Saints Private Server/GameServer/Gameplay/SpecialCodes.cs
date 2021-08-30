using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer.Gameplay
{
    public static class SpecialCodes
    {

        //static char[] alph = new char[] {'','','','','','','','','','','','','','','','' };
        const string SpecialCode = "config/specialcode.cfg";


        public static Dictionary<string, int> codes = new Dictionary<string, int>();

        public static int GetCodeCore(string code)
        {

            

            if (code.Length == 16)
            {
                
            }

            return 0;
        }

        public static string GenerateSerial(int roleid,int serverid,int codeid)
        {

            ByteArray ar = new ByteArray();

            ar.WriteBytes(codeid);

            return "";
        }

        public static void Load()
        {
            if (System.IO.File.Exists(SpecialCode))
            {
                config.ConfigLoader ld = new config.ConfigLoader(SpecialCode);
                codes = ld.ToIntDictionary();
                ld.Close();
            }
        }

        public static void Save()
        {
            System.IO.StreamWriter rw = new System.IO.StreamWriter(SpecialCode);

            lock (codes)
            {
                foreach (string key in codes.Keys)
                {
                    rw.WriteLine(key.ToUpper() + ":" + codes[key].ToString());
                }

                rw.Flush();
                rw.Close();
            }
        }
    }
}
