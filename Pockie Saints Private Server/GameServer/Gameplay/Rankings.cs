using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;
using Connector;
namespace GameServer
{

    public static class Rankings
    {

        public static int Hour=5, Min=0, Sec=0;

        [ProtoContract]
        public class RankInfo
        {
            [ProtoMember(1)]
            public int Value { get; set; }

            [ProtoMember(2)]
            public byte Nobility { get; set; }

            [ProtoMember(3)]
            public int RoleID { get; set; }

            public RankInfo()
            {
            }

            public RankInfo(int role,int value,byte noble)
            {

                Value = value;
                RoleID = role;
                Nobility = noble;
            }


        }

        public static string RankFile = "";
   
        public static void Init()
        {
            if (Hour == 0) Hour = 5;
        }

        public static void PopulateNew()
        {

            Connector.MySqlConnector con = DatabaseInfo.GetConnection();

            // delete all from ranking than populate with ranks
            con.StartCommand("DELETE FROM ranking;");
            con.ExecuteNoneQuery();

            // Set Level Rank
            con.StartCommand("UpdateRankCombat();");
            con.ExecuteNoneQueryp();

            // Set Level Rank
            con.StartCommand("UpdateRankLevel();");
            con.ExecuteNoneQueryp();

            // Set Wealth Rank
            con.StartCommand("UpdateRankWealth();");
            con.ExecuteNoneQueryp();

            // Set Level Rank
            //con.StartCommand("UpdateRankHonor();");
            //con.ExecuteNoneQueryp();

            //Set Level Rank
            con.StartCommand("UpdateRankPrestige();");
            con.ExecuteNoneQueryp();


            AllocTitles(con);
            Events.Happy.UpdateHappy();

        }

        public static Connector.DataReader GetReader(Connector.MySqlConnector con,byte type)
        {
            con.StartCommand("SELECT roleid,rankno FROM ranking where rtypeid=? ORDER BY rankno LIMIT 10;");
            con.AddValue(type);
            return con.ExecuteRead();
        }


      
        public static void AllocTitles(MySqlConnector con)
        {
            
            //int no1 = 0;
            //int c = 0;
            DataReader rd;
            #region Combat Power
            rd = GetReader(con, 1);

            if (rd.CanRead && rd.Rows>0 && rd.NextRow())
            {
                AllocTitle(rd.ReadInt(), 1001, "New Combat power rank", "You ranked no 1 in the combat power ranking!");

                while (rd.NextRow())
                {
                    AllocTitle(rd.ReadInt(), 1002, "New Combat power rank", "You ranked no " + rd.ReadShort().ToString() + " in the combat power ranking!");
                }

            }
            rd.Close();
            #endregion

            #region Level
            rd = GetReader(con, 2);
            if (rd.CanRead && rd.Rows > 0 && rd.NextRow())
            {
                AllocTitle(rd.ReadInt(), 1003, "New level rank", "You ranked no 1 in the level ranking!");

                while (rd.NextRow())
                {
                    AllocTitle(rd.ReadInt(), 1004, "New level rank", "You ranked no " + rd.ReadShort().ToString() + " in the level ranking!");
                }

            }
            rd.Close();
            #endregion

            #region Wealth
            rd = GetReader(con, 3);
            if (rd.CanRead && rd.Rows > 0 && rd.NextRow())
            {
                AllocTitle(rd.ReadInt(), 1005, "New wealth rank", "You ranked no 1 in the wealth ranking!");

                while (rd.NextRow())
                {
                    AllocTitle(rd.ReadInt(), 1006, "New wealth rank", "You ranked no " + rd.ReadShort().ToString() + " in the wealth ranking!");
                }


            }
            rd.Close();
            #endregion

            #region Honor
            /*rd = GetReader(con, 4);
            if (rd.CanRead && rd.Rows>0 && rd.NextRow())
            {
                no1 = ranks.Honor[0].RoleID;
                AllocTitle(no1, 1001, "New battle honor rank", "You ranked no 1 in the battle honor ranking!");

                for (int x = 1; x < 10; x++)
                {
                     AllocTitle(rd.ReadInt(), 1002, "New battle honor rank", "You ranked no " + (x + 1).ToString() + " in the battle honor ranking!");
                }

            }
             rd.Close();
             */

            #endregion

            #region Prestige
            rd = GetReader(con, 5);
            if (rd.CanRead && rd.Rows > 0 && rd.NextRow())
            {
                AllocTitle(rd.ReadInt(), 1007, "New prestige rank", "You ranked no 1 in the pretige ranking!");

                while (rd.NextRow())
                {
                    AllocTitle(rd.ReadInt(), 1008, "New level rank", "You ranked no " + rd.ReadShort().ToString() + " in the prestige ranking!");
                }
            }
            rd.Close();
            #endregion

            rd = null;
        }

        public static void AllocTitle(int roleid, short titleid, string msgtitle,string msgbody)
        {
            int nextday=(int)DateUtil.GetTommorowIntZone(Hour , Min+10, Sec);

            RoleControl rl = Players.GetPlayer(roleid);
            if (rl != null)
            {

            
                    rl.title.Add(titleid, nextday);
                    //rl.Save(); // Save eternal mars



                    Mail.AddMail(roleid, msgtitle, msgbody);
                    //rl.mail.Save(rl.cc);
                    hidden.Codec.ShowMail(roleid);
                
                
                // Send title information
                Command.PlayerInfoController.SendTitle(rl.cc, titleid);
            }
            else
            {
                Title.OfflineAdd(roleid, 1001, nextday);
                Mail.OfflineMessage(roleid, msgtitle, msgbody);
            }
        }

        public static void BackgroundWorker()
        {

            int today = (int)DateUtil.GetTodayIntZone(Hour,Min,Sec);
            int sleep = 00;
            bool dod = false;


            if (today < DateUtil.GetDateIntZone())
            {
                sleep = (int)DateUtil.GetTommorowIntZone(Hour, Min, Sec) - (int)DateUtil.GetDateIntZone();
            }
            else
            {
                sleep = today - (int)DateUtil.GetDateIntZone();
            }


        restart: ;

            if (dod)
            {
                PopulateNew();
                sleep = (int)DateUtil.GetTommorowIntZone(Hour, Min, Sec) - (int)DateUtil.GetDateIntZone();
               // Save();

                
            }

            dod=true;
            try
            {
                System.Threading.Thread.Sleep(sleep * 1000);
            }
            catch
            {
            }
            goto restart;

        }
       
    }


}
