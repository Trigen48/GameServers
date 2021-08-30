using System;

using System.Collections;
using System.Collections.Generic;

namespace GameServer.Command
{

    internal static class RankController
    {


        internal static void GetRank(ConnectionInfo c, byte ranktype, byte faction, byte career)
        {


            c.con.StartCommand("SELECT r.rankno, r.roleid,c.charname, v.viplvl,"
                                + " c.sex,c.career,c.faction,"
                                + " (SELECT gname FROM guild, guildmember WHERE guildmember.roleid=r.roleid AND guild.guildid=guildmember.guildid) as guildname"
                                + " ,r.rankvalue,r.nobility FROM ranking r, role c,vip v WHERE r.roleid= c.roleid AND c.roleid= v.roleid ? ? AND r.rtypeid=? order by r.rankno;");


            if (faction != 0 && (faction > 0 && faction < 4))
            {
                c.con.AddValue(" AND c.faction=" + faction.ToString(), true);
            }
            else
            {
                c.con.AddValue("", true);
            }

            if (career != 0 && (career > 0 && career < 4))
            {
                c.con.AddValue(" AND c.career=" + career.ToString(), true);
            }
            else
            {
                c.con.AddValue("", true);
            }
            c.con.AddValue(ranktype);


            Connector.DataReader rd = c.con.ExecuteRead();

            if (rd.CanRead)
            {
                c.ot.WriteShort(rd.Rows);

                while (rd.NextRow())
                {
                    c.ot.WriteShort(rd.ReadShort());
                    c.ot.WriteInt(rd.ReadInt());
                    c.ot.WriteString(rd.ReadString());// c_roleName);
                    c.ot.WriteByte(rd.ReadByte());//d_vipLev);
                    c.ot.WriteByte(rd.ReadByte());
                    c.ot.WriteByte(rd.ReadByte());
                    c.ot.WriteByte(rd.ReadByte());
                    c.ot.WriteString(rd.ReadString());
                    c.ot.WriteInt(rd.ReadInt());
                    c.ot.WriteByte(rd.ReadByte());
                }
            }
            else
            {
                c.ot.WriteShort(0);
            }


        }

        internal static void c22001(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"RankController 22001");

            GetRank(c, 5, c.ar.ReadByte(), c.ar.ReadByte());
            c.ot.PackArray(22001);
        }

        internal static void c22002(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "RankController 22002");


        }

        internal static void c22003(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "RankController 22003");


        }

        internal static void c22004(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "RankController 22004");


        }

        internal static void c22005(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "RankController 22005");


        }

        internal static void c22006(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"RankController 22006");

            GetRank(c, 3, c.ar.ReadByte(), c.ar.ReadByte());
            c.ot.PackArray(22001);
        }

        internal static void c22007(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"RankController 22007");

            GetRank(c, 2, c.ar.ReadByte(), c.ar.ReadByte());
            c.ot.PackArray(22001);
        }

        internal static void c22008(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"RankController 22008");

            GetRank(c, 4, c.ar.ReadByte(), c.ar.ReadByte());
            c.ot.PackArray(22001);
        }

        internal static void c22010(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"RankController 22010");

            GetRank(c, 1, c.ar.ReadByte(), c.ar.ReadByte());
            c.ot.PackArray(22001);
        }

        internal static void c22011(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "RankController 22011");


        }

        internal static void c22012(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "RankController 22012");


        }

        internal static void c22013(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "RankController 22013");


        }

        internal static void c22014(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "RankController 22014");


        }

        internal static void c22015(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "RankController 22015");


        }

        internal static void c22016(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "RankController 22016");


        }

    }
}
