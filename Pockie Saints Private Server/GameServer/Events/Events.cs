using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer.Events
{
    public static class Events
    {
        public struct EventItem
        {
           public String a_name;
           public int b_startTime;
           public int c_endTime;

           public String d_desc;
           public byte e_type;

           public int fa_value;
           public int fb_value;
           public int fc_value;

           public String g_url;
           public byte h_layoutType;

           public String i_conent;

           public int j_id;

           public int k_creatTime;
           public byte l_limitTimes;
        }

        public static string[] props = new string[] { "-name", "-starttime", "-endtime", "-description", "-type", "-value1", "-value2", "-value3", "-url", "-layouttype", "-content", "-id", "-createtime", "-limit" };
        public static List<EventItem> GameEvents = new List<EventItem>();

        public static void Init()
        {

            ByteArray r = new ByteArray("50014.bin");
            r.ReadByte();

            int count = r.ReadShort();

            for (int x = 0; x < count; x++)
            {
                EventItem evi = new EventItem();
                evi.a_name = r.ReadString();
                evi.b_startTime = r.ReadInt();
                evi.c_endTime = r.ReadInt();
                evi.d_desc = r.ReadString();
                evi.e_type = r.ReadByte();
                evi.fa_value = r.ReadInt();
                evi.fb_value = r.ReadInt();
                evi.fc_value = r.ReadInt();
                evi.g_url = r.ReadString();
                evi.h_layoutType = r.ReadByte();
                evi.i_conent = r.ReadString();
                evi.j_id = r.ReadInt();
                evi.k_creatTime = r.ReadInt();
                evi.l_limitTimes = r.ReadByte();

                evi.c_endTime = (int)DateUtil.GetDaysIntZone(5);

                GameEvents.Add(evi);
            }

           /* config.ConfigLoader loader = new config.ConfigLoader("config/Events.cfg");

            string eventlist = "";


            loader.GetString(ref eventlist, "Event-Names");
            eventlist=eventlist.Replace(" ","");

            if (eventlist != "")
            {

                string[] eventCode = eventlist.ToLower().Split(new char[] { ',' });

                foreach (string ev in eventCode)
                {


                    bool skip = false;

                    foreach (string k in props)
                    {
                        string key = ev + k;


                        if (!loader.PropertyExists(k))
                        {
                            skip = true;
                            break;
                        }
                    }

                    if (skip)
                        continue;

                    EventItem evit = new EventItem();







                    loader.GetString(ref evit.a_name, ev + props[0]);//public String a_name;

                    DateTime date = new DateTime();


                    loader.GetDateTime(ref date, ev + props[1]);
                    evit.b_startTime = (int)DateUtil.GetDateInt(date);//public int b_startTime;

                    loader.GetDateTime(ref date, ev + props[2]);
                    evit.c_endTime = (int)DateUtil.GetDateInt(date);// public int c_endtime;

                    loader.GetString(ref evit.d_desc, ev + props[3]); // public String d_desc;
                    loader.GetByte(ref evit.e_type, ev + props[4]);// public byte e_type;

                    loader.GetInt(ref evit.fa_value, ev + props[5]);//public int fa_value;
                    loader.GetInt(ref evit.fb_value, ev + props[6]);// public int fb_value;
                    loader.GetInt(ref evit.fc_value, ev + props[7]);//public int fc_value;

                    loader.GetString(ref evit.g_url, ev + props[8]);//public String g_url;
                    loader.GetByte(ref evit.h_layoutType, ev + props[9]);//public byte h_layoutType;

                    loader.GetString(ref evit.i_conent, ev + props[10]);// public String i_conent;

                    loader.GetInt(ref evit.j_id, ev + props[11]); // public int j_id;

                    loader.GetDateTime(ref date, ev + props[12]);
                    evit.k_creatTime = (int)DateUtil.GetDateInt(date);//  public int k_creatTime;
                    loader.GetByte(ref evit.l_limitTimes, ev + props[13]);//  public byte l_limitTimes;


                    GameEvents.Add(evit);
                }

            }
            */

        }

        public static void Notify(EventItem ev)
        {
        }

        public static EventItem GetEvent(ConnectionInfo c,EventItem ev)
        {

            return ev;
        }

    }
}
