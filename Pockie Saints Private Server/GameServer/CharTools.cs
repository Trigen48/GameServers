using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{        

    public class temp
    {
        const string file = "";

        public void Load(ConnectionInfo c)
        {
            ByteArray ar = new ByteArray(c.accid + file);

            ar.Close();
        }

        public void Save(ConnectionInfo c)
        {
            ByteArray ar = new ByteArray();

            System.IO.File.WriteAllBytes(c.accid + file,ar.GetByteArray());
            ar.Close();
        }

        public static void Create(ConnectionInfo c)
        {
        }
    }

    
}
