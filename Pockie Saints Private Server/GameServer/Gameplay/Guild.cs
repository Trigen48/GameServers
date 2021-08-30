using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Connector;
namespace GameServer
{

    public static class Guilds
    {
        public static short[] Population;

        public static bool DeleteGuild(int guildid)
        {

            MySqlConnector con = DatabaseInfo.GetConnection();
            con.StartCommand("DELETE FROM guild WHERE guildid = ?;");
            con.AddValue(guildid);

            int v = con.ExecuteNoneQuery();
            con = null;

            return v > 0;

        }
        
        public static void init()
        {
            Population = new short[] { 0, 10, 25, 75, 100, 120, 140, 160, 180, 190, 200 };
        }

        public static byte[] GuildBytes(byte faction, byte max, byte ord)
        {

            ByteArray ar = new ByteArray();
            MySqlConnector con = DatabaseInfo.GetConnection();


            con.StartCommand("SELECT COUNT(*) FROM guild ?");

            if (faction != 0)
            {
                con.AddValue("WHERE faction=" + faction.ToString(), true);
            }
            else
            {
                con.AddValue("", true);
            }

            int maxv = Convert.ToInt32(con.ExecuteScalar());


            if (maxv > 0)
            {

                con.StartCommand("SELECT g.guildid,g.gname, g.chiefid, (SELECT charname FROM role WHERE roleid=g.chiefid) chiefname,"
                                + " (SELECT COUNT(*) FROM guildmember m WHERE  m.guildid=g.guildid) membercount,"
                                + " g.memberlimit,g.guildlevel,g.faction,g.tenet,"
                                + " g.deputy1,(SELECT charname FROM role WHERE roleid=g.deputy1) deputy1name,"
                                + " g.deputy2,(SELECT charname FROM role WHERE roleid=g.deputy2) deputy2name, g.money"
                                + " FROM guild g ? ORDER BY g.guildlevel desc , membercount desc LIMIT ?,10;");
                if (faction != 0)
                {
                    con.AddValue("WHERE g.faction=" + faction.ToString(), true);
                }
                else
                {
                    con.AddValue("", true);
                }

                //int ord=
                int fill = (ord - 1 * 10);
                if (fill < 0) fill = 0;
                con.AddValue(fill);


                DataReader rd = con.ExecuteRead();


                if (rd.CanRead)
                {
                    int maxx = maxv / 10;
                    maxx = maxx + (((maxx) * 10) < maxv ? 1 : 0);

                    int minn;

                    minn = maxx >= ord ? ord : maxx;
                    minn = minn > 0 ? minn : minn + 1;

                    ar.WriteShort(1);// Result
                    ar.WriteShort(maxx); // Page total
                    ar.WriteShort(minn); //Page number

                    ar.WriteShort(rd.Rows);// Array Count
                    int start = (maxx * 10) + 1;
                    while (rd.NextRow())
                    {
                        // int id = Filter[start];
                        ar.WriteInt(rd.ReadInt());//guilds[id].ID);
                        ar.WriteString(rd.ReadString());//guilds[id].Name);

                        ar.WriteInt(rd.ReadInt());//guilds[id].h_ChiefID);
                        ar.WriteString(rd.ReadString());//guilds[id].i_ChiefName);

                        ar.WriteShort(rd.ReadShort());//guilds[id].GetMemberCount());
                        ar.WriteShort(rd.ReadShort());//Population[guilds[id].Guild_Level]);

                        ar.WriteShort(rd.ReadByte());//guilds[id].Guild_Level);
                        ar.WriteShort(rd.ReadByte());//guilds[id].Faction);
                        ar.WriteString(rd.ReadString());//guilds[id].d_Tenet);

                        ar.WriteInt(rd.ReadInt());//guilds[id].j_DeputyChief_1_ID);
                        ar.WriteString(rd.ReadString());//guilds[id].k_DeputyChief_1_Name);

                        ar.WriteInt(rd.ReadInt());//guilds[id].l_DeputyChief_2_ID);
                        ar.WriteString(rd.ReadString());//guilds[id].m_DeputyChief_2_Name);

                        ar.WriteInt(rd.ReadInt());//guilds[id].t_Money);
                        ar.WriteShort(start);
                        start++;
                    }
                }
                rd.Close();
            }
            else
            {
                ar.WriteShort(1);// Result
                ar.WriteShort(1); // Page total
                ar.WriteShort(1); //Page number

                ar.WriteShort(0);// Array Count
            }

            /*  lock (guilds)
              {

                  lock (saved)
                  {

                      List<int> Filter = new List<int>();


                      if (faction != 0)
                      {
                          foreach (int key in saved)
                          {
                              if (guilds[key] != null && guilds[key].Faction == faction)
                              {
                                  Filter.Add(key);
                              }
                          }
                      }
                      else
                      {
                          foreach (int key in saved)
                          {
                              if (guilds[key] != null)
                              {
                                  Filter.Add(key);
                              }
                          }
                      }


                      Filter.Sort((x, y) => CompareGuild(x, y));



                      int maxx, minn;


                      maxx = Filter.Count / 10;

                      maxx = maxx + (Filter.Count > maxx * 10 ? 1 : 0);

                      minn = maxx >= ord ? ord : maxx;

                      if (minn < 1) minn = 1;


                      int start, finish;

                      start = (minn - 1) * 10;

                      finish = start + 10;

                      finish = finish > Filter.Count ? Filter.Count : finish;

                      ar.WriteShort(1);// Result
                      ar.WriteShort(maxx); // Page total
                      ar.WriteShort(minn); //Page number

                      ar.WriteShort(finish - start);// Array Count
                      while (start < finish)
                      {
                          int id = Filter[start];
                          ar.WriteInt(guilds[id].ID);
                          ar.WriteString(guilds[id].Name);

                          ar.WriteInt(guilds[id].h_ChiefID);
                          ar.WriteString(guilds[id].i_ChiefName);

                          ar.WriteShort(guilds[id].GetMemberCount());
                          ar.WriteShort(Population[guilds[id].Guild_Level]);

                          ar.WriteShort(guilds[id].Guild_Level);
                          ar.WriteShort(guilds[id].Faction);
                          ar.WriteString(guilds[id].d_Tenet);

                          ar.WriteInt(guilds[id].j_DeputyChief_1_ID);
                          ar.WriteString(guilds[id].k_DeputyChief_1_Name);

                          ar.WriteInt(guilds[id].l_DeputyChief_2_ID);
                          ar.WriteString(guilds[id].m_DeputyChief_2_Name);

                          ar.WriteInt(guilds[id].t_Money);
                          ar.WriteShort(start + 1);
                          start++;
                      }

                  }
              }*/
            ar.PackArray(40010);
            byte[] d = ar.GetByteArray();
            ar.Close();

            return d;

        }

 
        public static bool GuildExists(string guildname)
        {

            MySqlConnector con = DatabaseInfo.GetConnection();
            con.StartCommand("SELECT COUNT(*) FROM guild WHERE gname = ?");
            con.AddValue(guildname);

            object v = con.ExecuteScalar();

            con = null;
            return v != null && Convert.ToInt32(v) > 0;
        }

        public static bool GuildExists(int guildid)
        {

            MySqlConnector con = DatabaseInfo.GetConnection();
            con.StartCommand("SELECT COUNT(*) FROM guild WHERE guildid = ?");
            con.AddValue(guildid);

            object v = con.ExecuteScalar();

            con = null;
            return v != null && Convert.ToInt32(v) > 0;
        }


        public static int GetOffer(byte level, byte rank)
        {

            int price = 0;

            price = level * 432523;


            decimal reduce = ((decimal)price * GetRate(rank));
            price = (int)(reduce);


            return price;
        }

        public static decimal GetRate(byte rank)
        {
            switch (rank)
            {
                case 1:
                    return 1.0m;
                case 2:
                    return 0.8m;
                case 3:
                    return 0.60m;
                default:
                    return 0.5m;
            }
        }

        public static int CreateGuild(string guildname, int roleid, string announce, byte faction, byte level, byte shoplvl)
        {
            int guildid = 0;

            MySqlConnector con = DatabaseInfo.GetConnection();
            con.StartCommand("INSERT INTO guild(gname,announce,initiatorid,chiefid,faction,guildlevel,shoplevel,memberlimit) VALUES(?,?,?,?,?,?,?,?);");
            con.AddValue(guildname);
            con.AddValue(announce);
            con.AddValue(roleid);
            con.AddValue(roleid);
            con.AddValue(faction);
            con.AddValue(level);
            con.AddValue(shoplvl);
            con.AddValue(Population[level]);

            if (con.ExecuteNoneQuery() > 0)
            {
                guildid = (int)con.LastID;
                con.StartCommand("INSERT INTO guildmember(guildid,roleid,memberrank) VALUES(?,?,1);");
                con.AddValue(guildid);
                con.AddValue(roleid);

                if (con.ExecuteNoneQuery() < 1)
                {
                    con.StartCommand("DELETE FROM guild WHERE guildid=?;");
                    con.AddValue(guildid);
                    con.ExecuteNoneQuery();

                    guildid = -1;
                }
            }

            con = null;

            return guildid;

        }

    }

}
