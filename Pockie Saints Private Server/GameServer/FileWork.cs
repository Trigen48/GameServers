using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{
    public static class UserWork
    {
        const string userdir = "accounts\\";
        public static int UserCanLogin(string name, string pass, ByteArray ar)
        {
            string fl=main.maindir + userdir+name;
            if (System.IO.File.Exists(fl))
            {
                ar = new ByteArray(fl);

                if (pass != ar.ReadString())
                {
                    
                    ar.Close();
                    return -1;
                }

                return ar.ReadInt();

            }

            return -1;
        }

        public static bool CreateUser(string name, string pass)
        {

            return true; ;
        }
    }
}
