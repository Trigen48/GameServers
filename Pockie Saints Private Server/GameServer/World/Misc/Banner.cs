using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer.World
{
    internal static class Banner
    {
        internal static string Msg = "Welcome to maximus";
        internal static int Sec = 30;
        internal static int Time = 0;
        internal static int Number = 0;
        internal static byte[] Broadcast;
        internal const string sep = "#&";

        public static void SysSend(ConnectionInfo c, string data, byte type)
        {
            ByteArray ar = new ByteArray();
            ar.WriteByte(1);
            ar.WriteByte(type);
            string mm = c.rlid.ToString() + sep + c.Player.role.name + " " + sep +
                c.Player.role.faction.ToString() + sep +
                data;
            ar.WriteString(mm);

            byte[] d = ar.GetByteArray();
            lock (World.MessageQ) World.MessageQ.Add(d);
            ar.Close();

        }

        public static void SysSendRose(int give, int gets, byte anon, int count)
        {

            RoleControl rl = Players.GetPlayer(give);
            RoleControl rl2 = Players.GetPlayer(gets);
            ByteArray ot = new ByteArray();
            ot.WriteInt(give);
            ot.WriteString(rl.role.name);
            ot.WriteByte(rl.role.faction);

            ot.WriteShort(count);
            ot.WriteByte(anon);

            ot.WriteInt(gets);
            ot.WriteString(rl2.role.name);
            ot.WriteByte(rl2.role.faction);

            /*ot.WriteInt(f_receiveId);
            ot.WriteString(g_receiveName);
            ot.WriteByte(h_receiveCamp);*/
            ot.PackArray(43000);

            byte[] d = ot.GetByteArray();
            lock (World.MessageQ2) World.MessageQ2.Add(d);
            ot.Close();
        }

        public static void BroadCastEvent(byte[] data)
        {
            lock (World.MessageQ2) World.MessageQ2.Add(data);
        }
        public static void SetBroadCast(string msg)
        {
            SetBroadCast(msg, Sec, 5);
        }

        public static void SetBroadCast(string msg, int RunTime)
        {
            SetBroadCast(msg, RunTime, 5);
        }

        public static void SetBroadCast(string msg, int RunTime, int Count)
        {
            Msg = msg;
            Sec = RunTime;
            Number = Count;
        }

        public static void broadcast(string msg, byte type)
        {
            ByteArray ar = new ByteArray();
            ar.WriteByte(type);
            ar.WriteInt(DateUtil.GetDateIntZone());
            ar.WriteString(msg);
            ar.PackArray(11004);

            byte[] d = ar.GetByteArray();
            chat.SendWorldMsg(ref d, 0);
            ar.Close();


        }

        public static void Build()
        {
            ByteArray ar = new ByteArray();
            ar.WriteByte(2);
            ar.WriteInt(Time - Sec);
            ar.WriteString(Msg);
            ar.PackArray(11004);

            Broadcast = ar.GetByteArray();
            ar.Close();
        }
        public static void Broad()
        {
            Number = 3;
            Time = (int)DateUtil.GetDateIntZone() + Sec;
        }
        public static void Render()
        {
            if (!CanBroadcast()) return;

            if (Time > DateUtil.GetDateIntZone()) return;

            Number--;

            Time = (int)DateUtil.GetDateIntZone() + Sec;
            Build();
            chat.SendWorldMsg(ref Broadcast, 0);

        }

        public static bool CanBroadcast()
        {
            return Number > 0;
        }



        public static void AnnounceLogin(ConnectionInfo c,byte type)
        {

            ByteArray a = new ByteArray();


            a.WriteInt(c.rlid);
            a.WriteShort(type);
            a.WriteString(c.Player.role.name);
            a.PackArray(14030);

            byte[] f = a.GetByteArray();

            a.Clear();

            a.WriteInt(c.rlid);
            a.WriteShort(type);
            a.WriteString(c.Player.role.name);
            a.PackArray(14031);

            byte[] e = a.GetByteArray();
            a.Close();
            a = null;



            c.con.StartCommand("SELECT r.roleid,f.ftypeid FROM role r INNER JOIN friend f ON r.roleid=f.friendid WHERE f.roleid=? AND r.isonline=1 AND (f.ftypeid=1 OR f.ftypeid=3);");
            c.con.AddValue(c.rlid);

            Connector.DataReader rd = c.con.ExecuteRead();


            if (rd.CanRead)
            {
                while (rd.NextRow())
                {
                    int id = rd.ReadInt();
                    byte type1 = rd.ReadByte();


                    RoleControl rl = Players.GetPlayer(id);

                    if (rl != null)
                    {
                        if (type1 == 1)
                            rl.Send(f);
                        else
                            rl.Send(e);

                    }
                }
            }
            rd.Close();
            e = null;
            f = null;
        }

    }
}
