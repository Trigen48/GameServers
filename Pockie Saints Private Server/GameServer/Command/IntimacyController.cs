using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class IntimacyController
	{

        internal static void CheckIntamcy(int roleid)
        {

            RoleControl rl = Players.GetPlayer(roleid);

            if (rl != null)
            {
                if (rl.role.charm >= 9999 && rl.mount.iMountClaimed != true)
                {
                    rl.mount.iMountClaimed = true;
                    rl.mount.Save();
                    Mail.OfflineMessage(roleid, "Charm reward", "Congratulations!</br>you now own a new mount!", 0, 0, 0, 0, 3110072, 1);
                }
            }
        }

        internal static void c43001(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"IntimacyController 43001");

            byte anon = c.ar.ReadByte();

            int roseid = c.ar.ReadInt();
            int count = c.ar.ReadShort();
            int sendid = c.ar.ReadInt();
            string name = c.ar.ReadString();
            byte res = 6;

            RoleControl rl = Players.GetPlayer(sendid);
            int typecount = c.Player.bag.GetTypeCount(roseid);

            if (typecount != 0)
            {

                if (sendid != c.rlid)
                {

                    if (rl != null && FriendHelper.NotBlackListed(c, sendid))
                    {

                        if (typecount >= count)
                        {
                            //int count
                            int Intimacy = 0;
                            switch (roseid)
                            {
                                case 2282001:

                                    if (count != 1 || count != 9)
                                    {
                                        res = 10;
                                        goto gets;
                                    }
                                    Intimacy += count;
                                    break;

                                case 2282002:
                                    if (count != 1)
                                    {
                                        res = 10;
                                        goto gets;
                                    }
                                    count = 1;
                                    Intimacy = 99;
                                    break;

                                case 2282003:
                                    if (count != 1)
                                    {
                                        res = 10;
                                        goto gets;
                                    }
                                    count = 1;
                                    Intimacy = 999;
                                    break;

                                default:
                                    res = 9;
                                    goto gets;
                            }
                            c.Player.bag.UseType(roseid, count);
                            //c.Player.bag.Save();

                            c.Player.role.charm += Intimacy;
                            rl.role.charm += Intimacy;

                            c.Player.role.Save();
                            rl.role.Save();

                            FriendHelper.AddIntimacy(c, sendid, Intimacy);

                            CheckIntamcy(c.rlid);
                            CheckIntamcy(sendid);

                            World.Banner.SysSendRose(c.rlid, sendid, anon, Intimacy);

                            res = 1;
                        }
                        else
                        {
                            res = 4;
                        }

                    }
                    else
                    {
                        res = 3;
                    }
                }
                else
                {
                    res = 2;
                }
            }


        gets: ;
            c.ot.WriteByte(res);
            c.ot.WriteInt(0);
            c.ot.WriteInt(0);
            c.ot.WriteInt(0);
            c.ot.PackArray(43001);

            if (res == 1)
            {
                RoleController.SendRoles(c);
                RoleController.SendRoles(rl.cc);
            }
        }


		internal static void c43003(ConnectionInfo c)
		{
		//	Program.Write(">Command invoked: " +"IntimacyController 43003");
            int id = c.ar.ReadInt();
            byte res = 2;
            RoleControl rl = Players.GetPlayer(id);
            if (rl != null)
            {
                ByteArray ot = new ByteArray();
                ot.WriteInt(id);
                ot.WriteInt(c.rlid);
                ot.WriteString(c.Player.role.name);
                ot.PackArray(43002);
                rl.Send(ot.GetByteArray());
                ot.Close();

                res = 1;
            }

            c.ot.WriteByte(res);
            c.ot.PackArray(43003);
			
		}


		internal static void c43005(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"IntimacyController 43005");

            int id= c.ar.ReadInt();
            byte res=2;


            RoleControl rl = Players.GetPlayer(id);
            if (rl != null)
            {
                ByteArray ot = new ByteArray();
                ot.WriteInt(id);
                ot.WriteInt(c.rlid);
                ot.WriteString(c.Player.role.name);
                ot.WriteByte(c.Player.role.faction);
                ot.PackArray(43004);

                rl.Send(ot.GetByteArray());
                ot.Close();

                res = 1;
            }

            c.ot.WriteByte(res);
            c.ot.PackArray(43005);
		}

	}
}
