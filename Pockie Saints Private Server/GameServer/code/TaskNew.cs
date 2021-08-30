using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Connector;

namespace GameServer
{
    public class TaskNew
    {
        ConnectionInfo c;
        public TaskNew(ConnectionInfo cc)
        {
            c = cc;
        }

        public bool Load()
        {

            return true;
        }

        public bool Save()
        {

            return true;
        }

        public bool Create(ConnectionInfo c, int roleid)
        {

            c.con.StartCommand("");

            return c.con.ExecuteNoneQuery() > 0;
        }
    }
}
