using System;
using System.Collections.Generic;
using System.Collections;
using Connector;
namespace GameServer.Command
{

    internal static class LoginController
    {
        const byte StartUpLevel = 1;
        const byte StartUpVip = 0;
        public static short TimeZoneValue = 2;

        internal static void Login(ConnectionInfo c)
        {

            const string key="Swilaps09C$%a1#";
            const int expire= (60)*15;
            int accid, timestamp;
            accid = c.ar.ReadInt();
            timestamp = c.ar.ReadInt();
            //c.ar.ReadBytes(8);

            string name, ticket, extra;
            name = c.ar.ReadString().ToLower();
            ticket = c.ar.ReadString().ToLower();
            extra = c.ar.ReadString().ToLower();
            c.ar.Close();

            object o=null;

            string login = MD5Checksum.ComputeToString(accid.ToString() + name + key + timestamp.ToString()).ToLower();

            if (login == ticket && timestamp+expire > DateUtil.GetDateInt())
            {
                // c.con.StartCommand("SELECT accstatus FROM account WHERE accid= ? AND sessioncode= ? AND sessionexpire >= NOW();");
                c.con.StartCommand("SELECT accstatus FROM account WHERE accid=?");
                c.con.AddValue(accid);
                c.con.AddValue(ticket);

                o = c.con.ExecuteScalar();
            }

            byte res = (byte)(o == null ? 0x02 : (sbyte)o);


            if (res != 1)
            {
                c.ot.WriteByte(9);
                c.ot.WriteInt(DateUtil.GetDateInt());
                //c.ot.WriteString("Disconnected, Account does not exist!, <font color=\"#00FF00\"><u><a style=\"color:lime !important\" href=\"create.php\">Create Here</a></u></font> , then ");

                if (res == 3)
                {
                    c.ot.WriteString("Disconnected, Account Suspended");
                }
                else if (res == 4)
                {
                    c.ot.WriteString("Disconnected, Account Banned!");
                }
                else
                {
                    c.ot.WriteString("Disconnected, Invalid account paremeters");
                }

                c.ot.PackArray(60002);
                try
                {
                    c.Socket.Send(c.ot.GetByteArray());
                }
                catch (Exception ex)
                {
                    log.Save(ex);
                }
                c.ot.Clear();
                c.CutConnection = true;
                return;
            }

            c.accid = accid.ToString();
            name = null;
            ticket = null;



            c.ot.WriteByte(1); // return result;
            c.ot.WriteByte(TimeZoneValue); // Time Zone
            c.ot.WriteInt(DateUtil.GetDateInt()); // Server Time
            c.ot.PackArray(10000);

        }

        internal static void GetRoles(ConnectionInfo c)
        {
            c.ar.Close();

            c.con.StartCommand("SELECT roleid,rolestatus,career,sex,lvl,charname FROM account, role WHERE account.accid = role.accid AND account.accid = ?");
            c.con.AddValue(c.accid, true);

            DataReader roles = c.con.ExecuteRead();

            if (!roles.CanRead)
            {
                c.CutConnection = true;
                return;
            }


            c.ot.WriteShort(roles.Rows);
            if (roles.Rows > 0)
            {

                while (roles.NextRow())
                {
                    c.ot.WriteInt(roles.ReadInt());     // Char RoleID
                    c.ot.WriteShort(roles.ReadByte());        // Something!! Char active Default?
                    c.ot.WriteShort(roles.ReadByte());  // Char Carear
                    c.ot.WriteShort(roles.ReadByte()); // Char Sex
                    c.ot.WriteShort(roles.ReadByte()); // Char Level
                    c.ot.WriteString(roles.ReadString()); // Char Name
                }

                roles.Close();
                roles = null;

            }
            c.ot.PackArray(10002);
        }

        internal static void CreateRole(ConnectionInfo c)
        {

            int rlid = 0;

            c.ar.ReadByte();
            byte career = c.ar.ReadByte();
            byte sex = c.ar.ReadByte();
            byte constellation = c.ar.ReadByte();
            string name = c.ar.ReadString().Trim();
            c.ar.Close();

            // To Do
            //Write Checks for this input!!!!!


            byte res = 0;

            if (name.Length > 2)
            {
                c.con.StartCommand("SELECT roleid FROM role WHERE charname=?;");
                c.con.AddValue(name);

                DataReader roleinfo = c.con.ExecuteRead();


                if (!roleinfo.CanRead)
                {
                    c.CutConnection = true;
                    return;
                }

                int roleidname = 0;

                if (roleinfo.NextRow())
                {
                    roleidname = roleinfo.ReadInt();
                }

                roleinfo.Close();

                if (roleidname == 0)
                {

                    c.con.StartCommand("SELECT accstatus FROM account WHERE accid=?;");
                    c.con.AddValue(c.accid, true);

                    object o = c.con.ExecuteScalar();

                    if (o != null && ((sbyte)o) == 1)
                    {

                        rlid = Role.Create(c, career, sex, name, constellation);
                        if (rlid > 0)
                        {
                            res = 1;
                            RoleControl.Create(c, rlid, career);
                        }
                        else
                        {
                            res = 2; //could not do sql stuff lol
                        }

                    }
                    else
                    {

                        res = 2;// show the error!!!!! uid incorrect
                        c.CutConnection = true;
                    }

                }
                else
                {
                    res = 3; // Name already used!!
                }
            }
            else
            {
                res = 5;
            }

            c.ot.WriteShort(res);
            c.ot.WriteInt(rlid);
            c.ot.PackArray(10003);

        }

        internal static void SelectRole(ConnectionInfo c)
        {



            
            int role = c.ar.ReadInt();

            if (c.rlid == role)
                return; // we have created the role from a different part!!!

            c.ar.Close();

            c.con.StartCommand("SELECT accid FROM role WHERE roleid=?;");
            c.con.AddValue(role);

            DataReader roleinfo = c.con.ExecuteRead();

            byte res = 0;

            if (!roleinfo.CanRead)
            {
                c.CutConnection = true;
                return;
            }


            if (roleinfo.NextRow())
            {
                int accid = roleinfo.ReadInt();
                int roleid = role;
                if (accid.ToString() == c.accid)
                {
                    res = 1;

                    // check if we already have an online player then kick that player out of the game

                    RoleControl rc = null;
                    rc = Players.GetPlayer(roleid);

                    if (rc != null)
                    {
                        Program.CloseConnection(rc.cc); // close char
                    }

                    c.rlid = role;
                    // Load up all Char Info!!
                    c.Player = new RoleControl(c);
                    Players.AddRole(c.Player);//Players.players[c.rlid] = ;

                    c.Player.SetOnline();


                }
                else
                {
                    res = 2;
                }
            }
            else
            {
                res = 2;
            }

            c.ot.WriteShort(res);
            c.ot.PackArray(10004);

            World.Banner.AnnounceLogin(c, 2);
        }

    }
}
