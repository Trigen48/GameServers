using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{
    public class Escort
    {

        //const string file = "Escort";
        ConnectionInfo c;
        [ContentProto("estate")]
        public byte escortState { get; set; }

        [ContentProto("quality")]
        public byte escortQuality { get; set; }

        [ContentProto("refresh")]
        public byte freeNum { get; set; }

        [ContentProto("ecount")]
        public byte accNum {get;set;}

        [ContentProto("firsttime")]
        public byte firstTime { get; set; }

        [ContentProto("endtime")]
        public int time { get; set; }

        public Escort(ConnectionInfo cc)
        {
            c = cc;
        }

        public byte GetState()
        {
            return (byte)(escortState == 1 && time > DateUtil.GetDateIntZone() ? 1 : 0);
        }

        //public bool AddEscort(

        public bool Load()
        {
            //ByteC.LoadProto(c.accid + file, ref val);

            c.con.StartCommand("SELECT estate, quality, refresh, ecount, endtime FROM escort WHERE roleid=? LIMIT 1;");
            c.con.AddValue(c.rlid);

            return ContentResolver.DoDeserialize<Escort>(this, c.con);
        }

        public bool Save()
        {
            //ByteC.SaveProto(c.accid + file, this);
            c.con.StartCommand("UPDATE escort SET ? WHERE roleid=?;");
            c.con.AddValue(ContentResolver.DoSerializeUpdate<Escort>(this), true);
            c.con.AddValue(c.rlid);

            return c.con.ExecuteNoneQuery() > 0;
        }

        public static bool Create(int roleid)
        {
            ConnectionInfo c = new ConnectionInfo(roleid);
            c.con.StartCommand("INSERT INTO escort(roleid) VALUES(?);");
            c.con.AddValue(roleid);
            return c.con.ExecuteNoneQuery() > 0;
        }
    }
}
