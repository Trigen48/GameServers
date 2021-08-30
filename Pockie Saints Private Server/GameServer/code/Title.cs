using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{

    public static class TitleHelper
    {


        public static Dictionary<int, int[]> TitleList;

        public static void Init()
        {
            TitleList = new Dictionary<int, int[]>();
            TitleList.Add(0, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            TitleList.Add(1001, new int[] { 300, 400, 150, 3000, 150, 150, 150, 500, 50 });
            TitleList.Add(1002, new int[] { 150, 180, 45, 1500, 45, 45, 45, 250, 0 });
            TitleList.Add(1003, new int[] { 360, 480, 0, 3600, 0, 0, 0, 600, 40 });
            TitleList.Add(1004, new int[] { 180, 216, 0, 1800, 0, 0, 0, 300, 0 });
            TitleList.Add(1005, new int[] { 0, 0, 120, 0, 120, 120, 120, 0, 10 });
            TitleList.Add(1006, new int[] { 0, 0, 36, 0, 36, 36, 36, 0, 0 });
            TitleList.Add(1007, new int[] { 330, 440, 0, 3300, 0, 0, 0, 550, 30 });
            TitleList.Add(1008, new int[] { 165, 198, 0, 1650, 0, 0, 0, 275, 0 });
            TitleList.Add(1009, new int[] { 330, 440, 0, 3300, 0, 0, 0, 550, 30 });
            TitleList.Add(1010, new int[] { 165, 198, 0, 1650, 0, 0, 0, 275, 0 });
            TitleList.Add(1011, new int[] { 330, 440, 0, 3300, 0, 0, 0, 550, 30 });
            TitleList.Add(1012, new int[] { 165, 198, 0, 1650, 0, 0, 0, 275, 0 });
            TitleList.Add(1013, new int[] { 330, 440, 0, 3300, 0, 0, 0, 550, 30 });
            TitleList.Add(1014, new int[] { 165, 198, 0, 1650, 0, 0, 0, 275, 0 });
            TitleList.Add(1015, new int[] { 330, 440, 0, 3300, 0, 0, 0, 550, 30 });
            TitleList.Add(1016, new int[] { 165, 198, 0, 1650, 0, 0, 0, 275, 0 });
            TitleList.Add(1017, new int[] { 360, 480, 0, 3600, 0, 0, 0, 600, 40 });
            TitleList.Add(1018, new int[] { 180, 216, 0, 1800, 0, 0, 0, 300, 0 });
            TitleList.Add(1019, new int[] { 330, 440, 0, 3300, 0, 0, 0, 550, 30 });
            TitleList.Add(1020, new int[] { 165, 198, 0, 1650, 0, 0, 0, 275, 0 });
            TitleList.Add(1021, new int[] { 360, 480, 0, 3600, 0, 0, 0, 600, 40 });
            TitleList.Add(1022, new int[] { 180, 216, 0, 1800, 0, 0, 0, 300, 0 });
            TitleList.Add(1023, new int[] { 330, 440, 0, 3300, 0, 0, 0, 550, 30 });
            TitleList.Add(1024, new int[] { 165, 198, 0, 1650, 0, 0, 0, 275, 0 });
            TitleList.Add(1025, new int[] { 0, 0, 120, 0, 120, 120, 120, 0, 10 });
            TitleList.Add(1026, new int[] { 0, 0, 36, 0, 36, 36, 36, 0, 0 });
            TitleList.Add(1027, new int[] { 0, 0, 0, 5000, 0, 0, 0, 0, 20 });
            TitleList.Add(1028, new int[] { 0, 0, 0, 5000, 0, 0, 0, 0, 20 });
            TitleList.Add(1029, new int[] { 200, 0, 0, 0, 0, 0, 0, 0, 0 });
            TitleList.Add(1030, new int[] { 300, 0, 0, 0, 0, 0, 0, 0, 0 });
            TitleList.Add(1031, new int[] { 100, 0, 0, 0, 0, 0, 0, 0, 0 });
            TitleList.Add(1032, new int[] { 200, 300, 0, 1000, 0, 0, 0, 0, 0 });
            TitleList.Add(1033, new int[] { 250, 350, 0, 1500, 0, 0, 0, 0, 0 });
            TitleList.Add(1034, new int[] { 300, 400, 0, 2000, 0, 0, 0, 0, 0 });
            TitleList.Add(1035, new int[] { 350, 450, 0, 2500, 0, 0, 0, 0, 0 });
            TitleList.Add(1036, new int[] { 400, 500, 0, 3000, 0, 0, 0, 0, 0 });
            TitleList.Add(1037, new int[] { 300, 400, 150, 3000, 150, 150, 150, 500, 0 });
            TitleList.Add(1038, new int[] { 100, 120, 30, 1000, 30, 30, 30, 150, 0 });
            TitleList.Add(1039, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            TitleList.Add(1040, new int[] { 450, 550, 0, 3500, 0, 0, 0, 0, 0 });
            TitleList.Add(1041, new int[] { 500, 600, 0, 4000, 0, 0, 0, 0, 0 });
            TitleList.Add(1042, new int[] { 550, 650, 0, 4500, 0, 0, 0, 0, 0 });
            TitleList.Add(1043, new int[] { 90, 120, 0, 900, 0, 0, 0, 150, 10 });
            TitleList.Add(1044, new int[] { 45, 54, 0, 450, 0, 0, 0, 75, 0 });
            TitleList.Add(1045, new int[] { 90, 120, 0, 900, 0, 0, 0, 150, 10 });
            TitleList.Add(1046, new int[] { 45, 54, 0, 450, 0, 0, 0, 75, 0 });
            TitleList.Add(1047, new int[] { 360, 480, 0, 3600, 0, 0, 0, 600, 40 });
            TitleList.Add(1048, new int[] { 45, 54, 0, 450, 0, 0, 0, 75, 0 });
            TitleList.Add(1049, new int[] { 360, 480, 0, 3600, 0, 0, 0, 600, 40 });
            TitleList.Add(1050, new int[] { 45, 54, 0, 450, 0, 0, 0, 75, 0 });
            TitleList.Add(1051, new int[] { 30, 36, 9, 300, 9, 9, 9, 50, 10 });
            TitleList.Add(1052, new int[] { 120, 144, 36, 1200, 36, 36, 36, 200, 20 });
            TitleList.Add(1053, new int[] { 240, 288, 72, 2400, 72, 72, 72, 400, 30 });
            TitleList.Add(1054, new int[] { 390, 520, 195, 3900, 195, 195, 195, 650, 50 });
            TitleList.Add(1055, new int[] { 360, 480, 180, 3600, 180, 180, 180, 600, 50 });
            TitleList.Add(1056, new int[] { 330, 440, 165, 3300, 165, 165, 165, 550, 50 });
            TitleList.Add(1057, new int[] { 300, 400, 150, 3000, 150, 150, 150, 500, 50 });
            TitleList.Add(1058, new int[] { 360, 480, 50, 3600, 50, 50, 50, 600, 40 });
            TitleList.Add(1059, new int[] { 360, 480, 50, 3600, 50, 50, 50, 600, 40 });
            TitleList.Add(1060, new int[] { 360, 480, 50, 3600, 50, 50, 50, 600, 40 });

        }
    }

   
    public class Title
    {
       // const string file = "titles";
        ConnectionInfo c;
        int nextcheck = 0;
        bool Checked = false;
      
        public class TitleItem
        {
           [ContentProto("titleid")]
            public short title_id{ get; set; }

            [ContentProto("expire")]
            public int title_time{ get; set; }

           // public byte Selected { get; set; }

            public TitleItem()
            {
            }

            public TitleItem(short titleID, int TitleTime)
            {
                title_id = titleID;
                title_time = TitleTime;
            }
        }

        
        public List<TitleItem> titles { get; set; }

        

        public Title(ConnectionInfo cc)
        {
            c = cc;
            titles = new List<TitleItem>();
        }

        public bool Load()
        {

            c.con.StartCommand("SELECT titleid, expire FROM title WHERE roleid=?");
            c.con.AddValue(c.rlid);

            Connector.DataReader rd = c.con.ExecuteRead();
            bool can = rd.CanRead;

            if (rd.CanRead)
            {
                while (rd.NextRow())
                {
                    titles.Add(new TitleItem(rd.ReadShort(),rd.ReadInt()));
                }
               
            }
            rd.Close();
            return can;//ConnectorResolver.DoDeserializeCollection<TitleItem>(titles, c.con);
            //ByteC.LoadProto(c.accid + file, ref val);

          /*  if (val.CheckTitles())
            {
                val.Save(c);
            }*/
        }

        public bool Add(short id, int expire)
        {
            int idd = titles.FindIndex(delegate(TitleItem tl) { return tl.title_id == id; });

            if (idd != -1)
            {

                c.con.StartCommand("UPDATE title SET expire=? WHERE roleid=? AND titleid=?;");
                c.con.AddValue(expire);
                c.con.AddValue(c.rlid);
                c.con.AddValue(id);

                if (c.con.ExecuteNoneQuery() > 0)
                {
                    titles[idd].title_time = expire;
                    return true;
                }
            }
            else
            {

                c.con.StartCommand("INSERT INTO title(roleid,titleid,expire) VALUES(?,?,?);");
                c.con.AddValue(c.rlid);
                c.con.AddValue(id);
                c.con.AddValue(expire);

                if (c.con.ExecuteNoneQuery() > 0)
                {
                    titles.Add(new TitleItem(id, expire));
                    return true;
                }
            }

            if (nextcheck > expire && expire!=0)
                nextcheck = expire;

            Checked = false;

            return false;
        }

        public bool Remove(short id)
        {
            int tid = titles.FindIndex(delegate(TitleItem t) { return t.title_id == id; });

            if (tid != 0)
            {
                c.con.StartCommand("DELETE FROM title WHERE roleid=? AND titleid=?;");
                c.con.AddValue(c.rlid);
                c.con.AddValue(id);

                if (c.con.ExecuteNoneQuery() > 0)
                {
                    titles.RemoveAt(tid);
                    return true;
                }
            }

            return false;
        }

        public bool Expired(short id)
        {
            int tid = titles.FindIndex(delegate(TitleItem t) { return t.title_id == id; });

            if (tid != 0)
            {
                return titles[tid].title_time < DateUtil.GetDateIntZone();
            }

            return false;
        }

        public void RemoveAll()
        {

            c.con.StartCommand("DELETE FROM title WHERE roleid=?");
            c.con.AddValue(c.rlid);

            if (c.con.ExecuteNoneQuery() > 0)
            {
                titles.Clear();
                c.Player.role.UpdateTitle(0);
               
                SetupTitles();
            }
        }

        private void SetupTitles()
        {
            c.currentScene.UpdateTitle(c);
            c.Player.combat.Compute(true);
            c.currentScene.UpdatePlayerHp(c);
            Command.PlayerInfoController.SendTitles(c);
        }

        public void CheckTitle()
        {
            if (c.Player.role.title_id != 0)
            {
                if (CheckTitles())
                {
                   // Save(c);
                    SetupTitles();
                }
            }

        }

        public bool CheckTitles()
        {

            if ((Checked == true && nextcheck == 0)) return false;

            Checked=true;

            if (nextcheck > DateUtil.GetDateIntZone()) return false;

            List<short> removes = new List<short>();
            bool dos = false;
            for (int x = 0; x < titles.Count; x++)
            {
                if (titles[x].title_time != 0 && titles[x].title_time < DateUtil.GetDateIntZone())
                {
                    removes.Add(titles[x].title_id);
                }
                if (nextcheck < titles[x].title_time)
                    nextcheck = titles[x].title_time;
            }

            if (removes.Count != 0)
            {
                dos = true;
                foreach (short id in removes)
                {
                    if (id == c.Player.role.title_id)
                    {
                        c.Player.role.UpdateTitle(0);
                    }
                    Remove(id);
                }

            }
            removes.Clear();
            removes = null;

            return dos;
        }

        public static bool OfflineAdd(int roleid, int idd, int expire)
        {
            Connector.MySqlConnector con = DatabaseInfo.GetConnection();

            con.StartCommand("SELECT COUNT(*) FROM title WHERE roleid=? AND titleid=?;");
            con.AddValue(roleid);
            con.AddValue(idd);

            object o=con.ExecuteScalar();
            if (o!=null && Convert.ToInt32(o) == 1)
            {
                con.StartCommand("UPDATE title SET expire=? WHERE roleid=? AND titleid=?;");
                con.AddValue(expire);
                con.AddValue(roleid);
                con.AddValue(idd);
            }
            else
            {
                con.StartCommand("INSERT INTO title(roleid,titleid,expire) VALUES(?,?,?);");
                con.AddValue(roleid);
                con.AddValue(idd);
                con.AddValue(expire);
            }

            bool resul = con.ExecuteNoneQuery() > 0;

            con = null;

            return resul;

        }

    }

}
