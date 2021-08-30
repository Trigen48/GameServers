using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{

    public class Happy
    {

        ConnectionInfo c;

        [ContentProto("mclaim")]
        public byte[] MainClaimed { get; set; }

        [ContentProto("rclaim")]
        public byte[] Claimed { get; set; }

        public Happy(ConnectionInfo cc)
        {
            MainClaimed = new byte[8];
            Claimed = new byte[8];
            c = cc;
        }


        public bool Load()
        {
            c.con.StartCommand("SELECT mclaim,rclaim FROM happyclaim WHERE roleid=? LIMIT 1;");
            c.con.AddValue(c.rlid);
            return ContentResolver.DoDeserialize<Happy>(this, c.con);
        }

        public bool Save()
        {
            c.con.StartCommand("UPDATE happyclaim SET mclaim=?,rclaim=? WHERE roleid=?;");
            c.con.AddValue(MainClaimed);
            c.con.AddValue(Claimed);
            c.con.AddValue(c.rlid);
            return c.con.ExecuteNoneQuery() > 0;
        }

        public static bool Create(int roleid)
        {
            ConnectionInfo c = new ConnectionInfo(roleid);
            c.con.StartCommand("INSERT INTO happyclaim(roleid) VALUES(?);");
            c.con.AddValue(roleid);
            return c.con.ExecuteNoneQuery() > 0;
        }
    }
}
