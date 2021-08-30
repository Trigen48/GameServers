using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{

 
    public class LuckyWheel
    {

        ConnectionInfo c;

        [ContentProto("claim")]
        public byte claim { get; set; }

        [ContentProto("prize")]
        public int prize { get; set; }

        [ContentProto("bind")]
        public byte bind { get; set; }

        public LuckyWheel(ConnectionInfo cc)
        {
            c = cc;
        }

        public bool Load()
        {
            c.con.StartCommand("SELECT Claim, Prize, bind FROM luckywheel WHERE roleid=? LIMIT 1;");
            c.con.AddValue(c.rlid);

            return ContentResolver.DoDeserialize<LuckyWheel>(this, c.con);
        }


        public void Reset()
        {
            prize = 0;
            claim = 0;
            bind = 0;
        }
        public bool Save()
        {
            //ByteC.SaveProto(c.accid + file, this);

            /* c.con.StartCommand("UPDATE luckywheel SET Claim=?, Prize=?, bind=? WHERE roleid=?;");
             c.con.AddValue(claim);
             c.con.AddValue(prize);
             c.con.AddValue(bind);
             c.con.AddValue(c.rlid);*/

            c.con.StartCommand("UPDATE luckywheel SET ? WHERE roleid=?;");
            c.con.AddValue(ContentResolver.DoSerializeUpdate<LuckyWheel>(this), true);
            c.con.AddValue(c.rlid);


            return c.con.ExecuteNoneQuery() > 0;
        }

        public static bool Create(int roleid)
        {
            ConnectionInfo c = new ConnectionInfo(roleid);
            c.con.StartCommand("INSERT INTO luckywheel(roleid) VALUES(?);");
            c.con.AddValue(roleid);
            return c.con.ExecuteNoneQuery() > 0;
        }
    }
}
