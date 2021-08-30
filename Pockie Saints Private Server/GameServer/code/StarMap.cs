using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{

    public class StarMap
    {

        ConnectionInfo c;


        [ContentProto("curindex")]
        public byte curindex { get; set; }

        [ContentProto("curpos")]
        public byte curpos { get; set; }

        [ContentProto("nextpos")]
        public byte nextpos { get; set; }

        [ContentProto("timeleft")]
        public int timeleft { get; set; }

        [ContentProto("interact")]
        public int interact { get; set; }

        [ContentProto("passive")]
        public int passive { get; set; }

        //hp,mp,atk,hit,dod,crit,def,fort
        public int[] combat;

        public StarMap(ConnectionInfo cc)
        {
            c = cc;
        }

        public void SetCombat()
        {
            if (combat == null)
                combat = new int[8];

            if (curpos == 0 && curindex == 1)
                return;

            byte car = c.Player.role.career;
            byte ind = curindex;
            byte pos = curpos;

            if (curpos == 0)
            {

                if (curindex <= 1)
                    return;

                pos = 15;
                ind -= 1;

            }


            combat = StarMapCfg.maps[car][ind][pos].comabt;
        }



        public void Increment()
        {
            curpos++;
            nextpos=0;
            timeleft = 0;

            if (nextpos == 16 && curindex != 12)
            {
                curpos = 0;
                nextpos = 0;
                curindex++;
            }

            SetCombat();
        }

        public bool Load()
        {
            c.con.StartCommand("SELECT curindex,curpos,nextpos,timeleft,interact,passive FROM starmap WHERE roleid=?;");
            c.con.AddValue(c.rlid);


            /*bool ret = 

           if(ret) SetCombat();
            */
            return ContentResolver.DoDeserialize<StarMap>(this, c.con);;
      
        }

        public bool Save()
        {
            c.con.StartCommand("UPDATE starmap SET ? WHERE roleid=?;");
            c.con.AddValue(ContentResolver.DoSerializeUpdate<StarMap>(this), true);
            c.con.AddValue(c.rlid);

            return c.con.ExecuteNoneQuery() > 0;;
           // return
        }

        public static bool Create( int roleid)
        {
            ConnectionInfo c = new ConnectionInfo(roleid);
            c.con.StartCommand("INSERT INTO starmap(roleid) VALUES(?);");
            c.con.AddValue(roleid);
            return c.con.ExecuteNoneQuery() > 0;
        }
    }
}
