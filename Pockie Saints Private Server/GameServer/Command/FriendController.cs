using System;

using System.Collections;

namespace GameServer.Command
{

    internal static class FriendController
    {

        internal static void c14000(ConnectionInfo c)
        {


            c.con.StartCommand("SELECT fgroupdesc FROM friendgroup WHERE roleid=? ORDER BY fgroupid;");
            c.con.AddValue(c.rlid);
            Connector.DataReader rd = c.con.ExecuteRead();



            if (rd.CanRead)
            {
                c.ot.WriteShort(rd.Rows);

                while (rd.NextRow())
                {
                    c.ot.WriteString(rd.ReadString());
                }
            }
            else
            {
                c.ot.WriteShort(0);
            }

            rd.Close();

            c.con.StartCommand("SELECT r.isonline,f.friendid,f.intimacy,f.fgroupid,r.lvl,r.sex,r.career,r.faction,v.viplvl,r.constellation,r.charname FROM friend f INNER JOIN role r ON f.friendid=r.roleid INNER JOIN vip v ON v.roleid= r.roleid WHERE f.roleid=? AND f.ftypeid=1;");
            c.con.AddValue(c.rlid);
            rd = c.con.ExecuteRead();

            if (rd.CanRead)
            {
                c.ot.WriteShort(rd.Rows);

                while (rd.NextRow())
                {


                    c.ot.WriteShort(rd.ReadByte());//isonline
                    c.ot.WriteInt(rd.ReadInt());//roleid

                    c.ot.WriteInt(rd.ReadInt());//c.Player.friends.Friends[0].friends[ids[i]].intimacy);
                    c.ot.WriteShort(rd.ReadShort());//c.Player.friends.Friends[0].friends[ids[i]].chatgroup);
                    c.ot.WriteShort(rd.ReadShort());//c.Player.friends.Friends[0].friends[ids[i]].level);
                    c.ot.WriteShort(rd.ReadShort());//c.Player.friends.Friends[0].friends[ids[i]].sex);
                    c.ot.WriteShort(rd.ReadShort());//c.Player.friends.Friends[0].friends[ids[i]].carear);
                    c.ot.WriteByte(rd.ReadByte());//c.Player.friends.Friends[0].friends[ids[i]].faction);
                    c.ot.WriteByte(rd.ReadByte());//c.Player.friends.Friends[0].friends[ids[i]].vip);
                    c.ot.WriteByte(rd.ReadByte());//c.Player.friends.Friends[0].friends[ids[i]].constelation);
                    c.ot.WriteString(rd.ReadString());//c.Player.friends.Friends[0].friends[ids[i]].name);
                }
            }
            else
            {
                c.ot.WriteShort(0);
            }

            rd.Close();


            c.ot.PackArray(14000);
        }

        internal static void c14001(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"FriendController 14001");


            int type = c.ar.ReadShort();
            int id = c.ar.ReadInt();
            string name = c.ar.ReadString();

            c.con.StartCommand("SELECT f.ftypeid FROM friend f INNER JOIN role r ON f.friendid=r.roleid WHERE f.roleid =? AND f.friendid=? AND ftypeid<=2;");
            c.con.AddValue(c.rlid);
            c.con.AddValue(id);

            //object 
            if (c.con.ExecuteScalar() != null)
                return;

            RoleControl rl = Players.GetPlayer(id);
            if (rl != null)
            {
                c.ar.Clear();

                c.ar.WriteShort(type);
                c.ar.WriteInt(c.rlid);// b_id);
                c.ar.WriteShort(c.Player.role.level);// c_level);
                c.ar.WriteShort(c.Player.role.career);// d_professional);
                c.ar.WriteString(c.Player.role.name);
                c.ar.PackArray(14001);

                rl.Send(c.ar.GetByteArray());
                c.ar.Close();
            }
            else
            {

                c.ot.WriteShort(2);
                c.ot.WriteInt(0);
                c.ot.WriteShort(0);
                c.ot.WriteShort(0);
                c.ot.WriteString(name);
                c.ot.PackArray(14002);
            }
        }

        internal static void c14002(ConnectionInfo c)
        {
            //  Program.Write(">Command invoked: " + "FriendController 14002");

            int type, res, id;
            type = c.ar.ReadShort();
            res = c.ar.ReadShort();
            id = c.ar.ReadInt();

            c.ar = new ByteArray();
            RoleControl rl = Players.GetPlayer(id);
            if (res == 1 && rl != null)
            {
                c.con.StartCommand("SELECT f.ftypeid FROM friend f INNER JOIN role r ON f.friendid=r.roleid WHERE f.roleid =? AND f.friendid=? AND ftypeid>2;");
                c.con.AddValue(c.rlid);
                c.con.AddValue(id);

                object o = c.con.ExecuteScalar();

                if (o != null && Convert.ToInt32(o) > 0)
                {
                    FriendHelper.ChangeToFriend(c, id);
                }

                else
                {
                    FriendHelper.AddFriend(c, id);
                }

                c.ar.WriteShort(1);
                c.ar.WriteInt(c.rlid);// b_id);
                c.ar.WriteShort(c.Player.role.level);// c_level);
                c.ar.WriteShort(c.Player.role.career);// d_professional);
                c.ar.WriteString(c.Player.role.name);
                c.ar.PackArray(14002);
                rl.Send(c.ar.GetByteArray());
                c.ar.Clear();
            }
            else
            {

                if (rl == null)
                {
                    c.ot.WriteShort(2);
                    c.ot.WriteInt(0);
                    c.ot.WriteShort(0);
                    c.ot.WriteShort(0);
                    c.ot.WriteString(c.Player.role.name);
                    c.ot.PackArray(14002);
                }
                else
                {
                    c.ar.WriteShort(0);
                    c.ar.WriteInt(0);
                    c.ar.WriteShort(0);
                    c.ar.WriteShort(0);
                    c.ar.WriteString("");
                    c.ar.PackArray(14002);
                    rl.Send(c.ar.GetByteArray());
                    c.ar.Clear();
                }
            }

        }

        internal static void c14003(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"FriendController 14003");

            int id = c.ar.ReadInt();
            byte res = 0;

            if (id != 0)
            {
                if (c.Player.role.mate_id != id)
                {
                    if (FriendHelper.DeleteFriend(c, id))
                    {
                        res = 1;
                    }

                }
                else
                {
                    res = 2;
                }
            }



            c.ot.WriteShort(res);
            c.ot.PackArray(14003);
        }

        internal static void c14004(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"FriendController 14004");
            int id = c.ar.ReadInt();
            byte res = 0;

            if (id != 0)
            {
                if (c.Player.role.mate_id != id)
                {
                    if (FriendHelper.BlackListFriend(c, id))
                    {
                        res = 1;
                    }

                }
                else
                {
                    res = 3;
                }
            }



            c.ot.WriteShort(res);
            c.ot.WriteInt(id);
            c.ot.PackArray(14004);

        }

        internal static void c14005(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " + "FriendController 14005");

            int id = c.ar.ReadInt();
            byte res = 0;

            if (id != 0)
            {
                if (c.Player.role.mate_id != id)
                {
                    if (FriendHelper.AddEnemy(c, id))
                    {
                        res = 1;
                    }

                }
            }



            c.ot.WriteShort(res);
            c.ot.WriteInt(id);
            c.ot.PackArray(14005);
        }

        internal static void c14006(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " + "FriendController 14006");

            int gid = c.ar.ReadShort();
            string gname = c.ar.ReadString();

            c.ot.WriteShort(FriendHelper.RenameGroup(c, gid, gname) ? 1 : 0);
            c.ot.PackArray(14006);

        }

        internal static void c14007(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"FriendController 14007");


            FriendHelper.GetBlackList(c);

            c.ot.PackArray(14007);
        }

        internal static void c14008(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"FriendController 14008");

            FriendHelper.GetEnemy(c);
            c.ot.PackArray(14008);
        }

        internal static void c14009(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " + "FriendController 14009");

            int fid = c.ar.ReadInt();
            int groupid = c.ar.ReadShort();

            c.ot.WriteShort(FriendHelper.MoveToGroup(c, fid, groupid) ? 1 : 0);
            c.ot.PackArray(14009);
        }

        internal static void c14010(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " + "FriendController 14010");
            string name = c.ar.ReadString();

            //byte res = 2;

            c.con.StartCommand("SELECT f.friendid,r.lvl,r.sex,r.career,g.gname,r.charname FROM friend f INNER JOIN role r ON f.friendid=r.roleid LEFT OUTER JOIN guildmember m ON r.roleid=m.roleid LEFT OUTER JOIN guild g ON g.guildid=m.guildid WHERE f.roleid=? AND r.charname=? AND ftypeid=1;");
            c.con.AddValue(c.rlid);
            c.con.AddValue(name);

            Connector.DataReader rd = c.con.ExecuteRead();



            if (rd.CanRead && rd.NextRow())
            {

                c.ot.WriteShort(1);
                c.ot.WriteInt(rd.ReadInt());
                c.ot.WriteShort(rd.ReadByte());
                c.ot.WriteShort(rd.ReadByte());
                c.ot.WriteShort(rd.ReadByte());
                c.ot.WriteString(rd.ReadString());//e_gangName);
                c.ot.WriteString(rd.ReadString());
            }
            else
            {
                c.ot.WriteBytes(new byte[15]);
            }
            rd.Close();
            c.ot.PackArray(14010);
        }

        /*  internal static void c14011(ConnectionInfo c)
          {
              Program.Write(">Command invoked: " + "FriendController 14011");


          }

          internal static void c14012(ConnectionInfo c)
          {
              Program.Write(">Command invoked: " + "FriendController 14012");


          }*/

        internal static void c14013(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " + "FriendController 14013");

            int id = c.ar.ReadInt();
            RoleControl rl = Players.GetPlayer(id);

            if (rl != null)
            {
                c.ot.WriteInt(id);
                c.ot.WriteShort(rl.role.level);
                c.ot.WriteShort(rl.role.sex);
                c.ot.WriteShort(rl.role.career);
                c.ot.WriteByte(rl.role.faction);
                c.ot.WriteString(rl.role.name);
                c.ot.PackArray(14013);
            }

        }

        internal static void c14020(ConnectionInfo c)
        {
            byte res = 0;

            int id = c.ar.ReadInt();
            id = (id - 1) / 255;

            if (id != 0)
            {
                if (c.Player.role.mate_id != id)
                {
                    res = (byte)(FriendHelper.DeleteFriend(c, id) ? 1 : 0);
                }
            }

            c.ot.WriteShort(res);
            c.ot.PackArray(14020);

        }

        // SOMETHING delete
        internal static void c14021(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "FriendController 14021");


        }

        /*internal static void c14030(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "FriendController 14030");


        }

        // enemy discounect
        internal static void c14031(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "FriendController 14031");


        }*/

        // Seacrh compability
        internal static void c14032(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " + "FriendController 14032");

            c.con.StartCommand("SELECT r.roleid,r.charname,r.sex,r.faction ,r.constellation,((c.starmatch-1)*25) fmatch FROM role r INNER JOIN constellation c  ON r.constellation=c.starpartner WHERE c.starsign=? AND r.roleid !=? AND r.isonline=1 ORDER BY r.sex ?,fmatch DESC LIMIT 5;");
            string n = "";


            if (c.Player.role.sex == 1)
            {
                n = "DESC";
            }

            c.con.AddValue(c.Player.role.star);
            c.con.AddValue(c.rlid);
            c.con.AddValue(n, true);


            Connector.DataReader rd = c.con.ExecuteRead();


            if (rd.CanRead)
            {
                c.ot.WriteShort(rd.Rows);
                while (rd.NextRow())
                {
                    c.ot.WriteInt(rd.ReadInt());
                    c.ot.WriteString(rd.ReadString());
                    c.ot.WriteByte(rd.ReadByte());
                    c.ot.WriteByte(rd.ReadByte());
                    c.ot.WriteByte(rd.ReadByte());
                    c.ot.WriteByte(rd.ReadByte());


                }
            }
            else
            {
                c.ot.WriteShort(0);
            }

            rd.Close();


            c.ot.PackArray(14032);
        }

    }
}
