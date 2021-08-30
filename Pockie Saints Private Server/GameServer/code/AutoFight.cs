using System;
using System.Collections.Generic;
using System.Text;
namespace GameServer
{

    public class AutoFight
    {
        ConnectionInfo c;


        [ContentProto("hp")]
        public byte hp { get; set; }

        [ContentProto("mp")]
        public byte mp { get; set; }

        [ContentProto("joy")]
        public byte joy { get; set; }

        [ContentProto("config")]
        public string config { get; set; }

        public bool init = false;

        public AutoFight(ConnectionInfo con)
        {
            c = con;
        }


        public string Output()
        {
            init = true;
            return config + "," + hp.ToString() + "," + mp.ToString() + "," + joy + "," + config;
        }

        public void Input(string data)
        {
            string[] vax = data.Split(",".ToCharArray());

            config = vax[0];

            hp = byte.Parse(vax[1]);
            mp = byte.Parse(vax[2]);
            joy = byte.Parse(vax[3]);
            vax = null;

        }

        public bool Load()
        {
            //ByteC.LoadProto(c.accid + file, ref val);
            // bool set = false;
            c.con.StartCommand("SELECT hp, mp, joy, config FROM autofight WHERE roleid=? LIMIT 1;");
            c.con.AddValue(c.rlid);

            return ContentResolver.DoDeserialize<AutoFight>(this, c.con);
            /*Connector.DataReader rd = c.con.ExecuteRead();

            if (rd.CanRead && rd.NextRow())
            {
                hp = rd.ReadByte();
                mp = rd.ReadByte();
                joy = rd.ReadByte();
                config = rd.ReadString();

                set = true;
            }
            rd.Close();
            return set;*/
        }

        public bool Save()
        {
            c.con.StartCommand("UPDATE autofight SET hp=?,mp=?,joy=?,config=? WHERE roleid=?");
            c.con.AddValue(hp);
            c.con.AddValue(mp);
            c.con.AddValue(joy);
            c.con.AddValue(config);
            c.con.AddValue(c.rlid);
            return c.con.ExecuteNoneQuery() > 0;
        }

        public static bool Create(int roleid)
        {
            ConnectionInfo c = new ConnectionInfo(roleid);
            c.con.StartCommand("INSERT INTO autofight(roleid) VALUES (?);");
            c.con.AddValue(roleid);

            return c.con.ExecuteNoneQuery() > 0;
        }

    }
}
