using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{
    public class StarTarget
    {

        const string file = "StarTarget";


        public void Load(ConnectionInfo c)
        {

            ByteArray ar = new ByteArray(c.accid + file);


            ar.Close();

        }

        public void Save(ConnectionInfo c)
        {

            ByteArray ar = new ByteArray();


            ar.SaveFile(c.accid + file);
            ar.Close();
        }

        public static void Create(ConnectionInfo c)
        {

            System.IO.File.WriteAllBytes(c.accid + file, new byte[16]);

        }
    }
}
