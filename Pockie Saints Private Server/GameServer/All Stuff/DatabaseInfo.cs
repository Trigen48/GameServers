using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{
    internal static class DatabaseInfo
    {
        internal static string Server="127.0.0.1";
        internal static string database="saintsdb";
        internal static string User="root";
        internal static string Password="";

        internal static Connector.MySqlConnector GetConnection()
        {
            return new Connector.MySqlConnector(Server, database, User, Password);
        }
    }
}
