using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{

    public class Temp
    {

        ConnectionInfo c;
        public Temp(ConnectionInfo cc)
        {
            c = cc;
        }

        public bool Load()
        {

            return true;
        }

        public bool Save()
        {
            //ByteC.SaveProto(c.accid + file, this);

            return true;
        }

        public bool Create(ConnectionInfo c,int roleid)
        {

            c.con.StartCommand("");

            return c.con.ExecuteNoneQuery() > 0;
        }
    }
}
