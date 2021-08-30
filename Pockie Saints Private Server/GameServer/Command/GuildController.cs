using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class GuildController
	{

		/*internal static void c40000(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40000");
			
			
		}*/

        internal static void c40001(ConnectionInfo c)
        {
            // Program.Write(">Command invoked: " + "GuildController 40001");

            byte guildLev = c.ar.ReadByte();
            String name = c.ar.ReadString();
            string desc = c.ar.ReadString();
            int guildid = 0;
            byte res = 2;

            if (!Guilds.GuildExists(name))
            {
                if (c.Player.guild.GuildID == 0)
                {
                    if (guildLev == 1)
                    {

                        if (c.Player.bag.TotalGold() > 50000)
                        {

                            guildid = Guilds.CreateGuild(name, c.rlid, desc, c.Player.role.faction, 1, 1);

                            if (guildid > 0)
                            {
    
                                c.Player.bag.UseGold(50000);
                                c.Player.bag.Save();

                                res = 1;
                                
                            }
                            else
                            {
                                res = 0;
                            }
                        }
                        else
                        {
                            res = 4;
                        }
                    }
                    else
                    {
                        if (c.Player.bag.ItemTypeExists(4110001))
                        {


                            guildid = Guilds.CreateGuild(name, c.rlid, desc, c.Player.role.faction, 2, 2);

                            if (guildid > 0)
                            {

                                c.Player.bag.UseType(4110001, 1);
                                //c.Player.guild.Save(c);
                                guildLev = 2;
                                res = 1;
                            }
                            else
                            {
                                res = 0;
                            }
                        }
                        else
                        {
                            res = 5;
                        }
                    }

                    if (res == 1)
                    {
                        c.Player.guild.GuildID = guildid;
                        c.Player.guild.GuildName = name;

                        World.Banner.SysSend(c, name + World.Banner.sep + guildLev.ToString(), 31);
                    }
                }
            }
            else
            {
                res = 13;
            }

            short guildcount = Convert.ToInt16(c.con.ExecuteScalar("SELECT COUNT(*) FROM guild;"));

            c.ot.WriteShort(res);
            c.ot.WriteInt(guildid);
            c.ot.WriteString(name);
            c.ot.WriteShort(guildcount);// GuildData.Guilds.Count);
            c.ot.WriteInt(c.Player.bag.gold);
            c.ot.WriteInt(c.Player.bag.bgold);
            c.ot.PackArray(40001);


        }

        internal static void c40002(ConnectionInfo c)
        {
            // disban guild
            //Program.Write(">Command invoked: " + "GuildController 40002");

            byte res = 1;
            int id = c.ar.ReadInt();
            if (id != c.Player.guild.GuildID) id = c.Player.guild.GuildID;

            string gname = "";
            if (id != 0 )
            {
                res = 2;
                if (Guilds.GuildExists(id))
                {
                    c.con.StartCommand("SELECT memberrank FROM guildmember,guild WHERE guild.guildid=guildmember.guildid AND guild.guildid=? and guildmember.roleid=?;");
                    c.con.AddValue(id);
                    c.con.AddValue(c.rlid);
                    object v = c.con.ExecuteScalar();

                    if (v == null)// Guilds.guilds[id].members.ContainsKey(c.rlid))
                    {
                        res = 3;
                        goto backs;
                    }

                    if (Convert.ToByte(v) != 1)
                    {
                        res = 5;
                        goto backs;
                    }

                    try
                    {
                        ByteArray ar = new ByteArray();
                        ar.WriteShort(9);
                        ar.WriteString("");
                        ar.PackArray(40000);
                        byte[] d = ar.GetByteArray();
                        ar.Close();
                        ar = null;

                        gname = c.Player.guild.GuildName;

                        c.con.StartCommand("SELECT roleid FROM guildmember,guild WHERE guildmember.guildid=?;");
                        c.con.AddValue(id);
                        Connector.DataReader rd = c.con.ExecuteRead();

                        if (rd.CanRead)
                        {
                            while (rd.NextRow())
                            {

                                int ids = rd.ReadInt();
                                Mail.OfflineMessage(ids, "Guild Disband", "Your guild " + gname + " has disbaned!");

                                RoleControl rl = Players.GetPlayer(ids);
                                if (rl != null)
                                {
                                    rl.guild.GuildID = 0;
                                    rl.guild.GuildName = "";

                                    //Guilds.ResetGuild(rl.cc);
                                    rl.Send(d);
                                }

                            }
                        }
                        d = null;
                        Guilds.DeleteGuild(id);
                        res = 1;
                    }
                    catch (Exception ex)
                    {
                        log.Save(ex, c);
                    }

 
                }
            }


        backs: ;
            c.ot.WriteShort(res);
            c.ot.PackArray(40002);
        }

		internal static void c40003(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40003");
			
			
		}

		internal static void c40004(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40004");
			
			
		}

		internal static void c40005(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40005");
			
			
		}

		internal static void c40006(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40006");
			
			
		}

		internal static void c40007(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40007");
			
			
		}

		internal static void c40008(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40008");
			
			
		}

		internal static void c40009(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40009");
			
			
		}

		internal static void GetGuilds(ConnectionInfo c)
		{

            c.ot.WriteBytes(Guilds.GuildBytes(c.ar.ReadByte(),(byte)c.ar.ReadShort(),(byte)c.ar.ReadShort()));
		}

		internal static void c40011(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40011");
			
			
		}

		internal static void c40012(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40012");
			
			
		}

		internal static void c40013(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40013");
			
			
		}

		internal static void c40014(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"GuildController >40014> Guild");

            int id = c.ar.ReadInt();
            if (id != c.Player.guild.GuildID) id = c.Player.guild.GuildID;

            c.con.StartCommand("SELECT g.guildid,g.gname,tenet,announce,"
                            + " g.initiatorid, (SELECT charname FROM role WHERE roleid=g.initiatorid) initiatorname,"
                            + " g.chiefid, (SELECT charname FROM role WHERE roleid=g.chiefid) chiefname,"
                            + " g.deputy1,(SELECT charname FROM role WHERE roleid=g.deputy1) deputy1name,"
                            + " g.deputy2,(SELECT charname FROM role WHERE roleid=g.deputy2) deputy2name,"
                            + " deputycount, (SELECT COUNT(*) FROM guildmember m WHERE  m.guildid=g.guildid) membercount,"
                            + " g.memberlimit,g.faction,g.guildlevel,g.reputation, g.money,"
                            + " g.contribution,(SELECT SUM(m.contributiontoday) FROM guildmember m WHERE m.guildid=g.guildid) contributetoday,g.createdtime,g.contributemax,"
                            + " (SELECT COUNT(*) FROM guildapply a WHERE a.guildid= g.guildid) applycount, g.shoplevel,g.IsOverlord"

                            + " FROM guild g,guildmember r WHERE g.guildid=r.guildid AND g.guildid=? AND r.roleid=?");

            c.con.AddValue(id);
            c.con.AddValue(c.rlid);
            Connector.DataReader rd = c.con.ExecuteRead();

            if (rd.CanRead && rd.NextRow())
            {
                
                 c.ot.WriteShort(1);//1);
                c.ot.WriteInt(rd.ReadInt());//gd.ID);
                c.ot.WriteString(rd.ReadString());//gd.Name);

                c.ot.WriteString(rd.ReadString());//gd.d_Tenet);
                c.ot.WriteString(rd.ReadString());//gd.e_Announce);

                c.ot.WriteInt(rd.ReadInt());//gd.f_initiatorID);
                c.ot.WriteString(rd.ReadString());//gd.g_initiatorName);

                c.ot.WriteInt(rd.ReadInt());//gd.h_ChiefID);
                c.ot.WriteString(rd.ReadString());//gd.i_ChiefName);

                c.ot.WriteInt(rd.ReadInt());//gd.j_DeputyChief_1_ID);
                c.ot.WriteString(rd.ReadString());//gd.k_DeputyChief_1_Name);

                c.ot.WriteInt(rd.ReadInt());//gd.l_DeputyChief_2_ID);
                c.ot.WriteString(rd.ReadString());//gd.m_DeputyChief_2_Name);

                 c.ot.WriteShort(rd.ReadShort());//gd.n_DeputyChielfNum);

                 c.ot.WriteShort(rd.ReadShort());//gd.GetMemberCount());
                 c.ot.WriteShort(rd.ReadShort());//Guilds.Population[gd.Guild_Level]);

                 c.ot.WriteShort(rd.ReadShort());//gd.Faction);
                 c.ot.WriteShort(rd.ReadShort());//gd.Guild_Level);
                 c.ot.WriteShort(rd.ReadShort());//gd.s_Reputation);
                c.ot.WriteInt(rd.ReadInt());//gd.t_Money);
                c.ot.WriteInt(rd.ReadInt());//gd.u_Contribution);
                 c.ot.WriteShort(rd.ReadShort());//gd.v_ContributionDaily);
                c.ot.WriteInt(rd.ReadInt());//gd.z0_CreateTime);
                c.ot.WriteInt(rd.ReadInt());//gd.z1_ContributionMax);
                 c.ot.WriteShort(rd.ReadShort());//gd.z2_ApplyNum);

                 c.ot.WriteByte(rd.ReadByte());//gd.Shop_level);
                 c.ot.WriteByte(rd.ReadByte());//gd.isOverlord);
            }
            else
            {
                 c.ot.WriteShort(0);//0);
                c.ot.WriteBytes(new byte[100]);
            }

            rd.Close();
            rd = null;


            c.ot.PackArray(40014);
		}

        internal static void GuildDeclaration(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " + "GuildController 40015");

            byte res = 3;
            int id = c.ar.ReadInt();
            if (id != c.Player.guild.GuildID) id = c.Player.guild.GuildID;

            string tenet= c.ar.ReadString();
            if (id != 0)
            {
                res = 2;
                if (Guilds.GuildExists(id))
                {

                    c.con.StartCommand("SELECT memberrank FROM guildmember,guild WHERE guild.guildid=guildmember.guildid AND guild.guildid=? and guildmember.roleid=?;");
                    c.con.AddValue(id);
                    c.con.AddValue(c.rlid);
                    object v = c.con.ExecuteScalar();

                    if (v == null)// Guilds.guilds[id].members.ContainsKey(c.rlid))
                    {
                        res = 4;
                        goto backs;
                    }

                    if (Convert.ToByte(v) >2)
                    {
                        res = 5;
                        goto backs;
                    }

                    c.con.StartCommand("UPDATE guild SET tenet=? WHERE guildid=?");
                    c.con.AddValue(tenet);
                    c.con.AddValue(id);


                    res= (byte)(c.con.ExecuteNoneQuery()==1 ? 1:0);
                }

            }


        backs: ;
            c.ot.WriteShort(res);
            c.ot.PackArray(40015);
            

        }

		internal static void GuildAnnounce(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"GuildController 40016");

            byte res = 3;
            int id = c.ar.ReadInt();
            if (id != c.Player.guild.GuildID) id = c.Player.guild.GuildID;

            string announce = c.ar.ReadString();
            if (id != 0)
            {
                res = 2;
                if (Guilds.GuildExists(id))
                {

                    c.con.StartCommand("SELECT memberrank FROM guildmember,guild WHERE guild.guildid=guildmember.guildid AND guild.guildid=? and guildmember.roleid=?;");
                    c.con.AddValue(id);
                    c.con.AddValue(c.rlid);
                    object v = c.con.ExecuteScalar();

                    if (v == null)// Guilds.guilds[id].members.ContainsKey(c.rlid))
                    {
                        res = 4;
                        goto backs;
                    }

                    if (Convert.ToByte(v) > 2)
                    {
                        res = 5;
                        goto backs;
                    }

                    c.con.StartCommand("UPDATE guild SET announce=? WHERE guildid=?");
                    c.con.AddValue(announce);
                    c.con.AddValue(id);


                    res = (byte)(c.con.ExecuteNoneQuery() == 1 ? 1 : 0);
                }

            }


        backs: ;
            c.ot.WriteShort(res);
            c.ot.PackArray(40016);
            

		}

		internal static void c40017(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40017");
			
			
		}

		internal static void c40018(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40018");
			
			
		}

		internal static void c40019(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40019");
			
			
		}

		internal static void c40020(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40020");
			
			
		}

		internal static void c40021(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40021");
			
			
		}

		internal static void c40022(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40022");
			
			
		}

        internal static void c40023(ConnectionInfo c)
        {
            // Program.Write(">Command invoked: " + "GuildController 40023");

            byte res = 3;
            int id = c.ar.ReadInt();
            if (id != c.Player.guild.GuildID) id = c.Player.guild.GuildID;

            byte rank = 0;
            byte level = 0;
            byte claim = 0;

            if (id != 0)
            {
                res = 3;
                if (Guilds.GuildExists(id))
                {
                    c.con.StartCommand("SELECT r.memberrank,g.guildlevel, r.claimbenefit FROM guild g,guildmember r WHERE g.guildid=? AND r.roleid=? AND g.guildid= r.guildid");
                    c.con.AddValue(id);
                    c.con.AddValue(c.rlid);

                    Connector.DataReader rd = c.con.ExecuteRead();
                    if (!rd.CanRead || !rd.NextRow())// Guilds.guilds[id].members.ContainsKey(c.rlid))
                    {
                        rd.Close();
                        res = 4;
                        goto backs;
                    }

                    rank = rd.ReadByte();
                    level = rd.ReadByte();
                    claim = rd.ReadByte();
                    rd.Close();
                    res = 1;
                }
            }


        backs: ;
            int gold = 0;
            if (res == 1)
            {
                if (claim == 1)
                {
                    res = 4;
                }
                else
                {
                    gold = Guilds.GetOffer(level, rank);
                    c.Player.bag.bgold += gold;
                    c.Player.bag.Save();

                    c.con.StartCommand("UPDATE guildmember SET claimbenefit=1 WHERE roleid=?;");
                    c.con.AddValue(c.rlid);

                    c.con.ExecuteNoneQuery();
                }

            }


            c.ot.WriteShort(res);
            c.ot.WriteInt(gold);
            c.ot.WriteInt(c.Player.bag.bgold);
            c.ot.PackArray(40023);
        }

        internal static void c40024(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"GuildController 40024");

            byte res = 3;
            int id = c.ar.ReadInt();
            if (id != c.Player.guild.GuildID) id = c.Player.guild.GuildID;

            Connector.DataReader rd = null;
            if (id != 0)
            {
                res = 2;
                if (Guilds.GuildExists(id))
                {
                 
                    c.con.StartCommand("SELECT m.memberrank,g.guildlevel,m.contributiontotal,m.contributionlast,m.contributiontoday,m.guildtitle,m.commentc FROM guild g,guildmember m WHERE g.guildid=? AND g.guildid=m.guildid AND m.roleid=?;");
                    c.con.AddValue(id);
                    c.con.AddValue(c.rlid);
                    rd = c.con.ExecuteRead();
                    /* lock (Guilds.guilds[id].members)
                     {*/


                    if (!rd.CanRead || !rd.NextRow())// Guilds.guilds[id].members.ContainsKey(c.rlid))
                    {
                        res = 4;
                        goto backs;
                    }
                    //  }


                    res = 1;

                }

            }


        backs: ;

            if (res != 1)
            {
                c.ot.WriteShort(res);
                c.ot.WriteBytes(new byte[72]);
            }
            else
            {
                /*lock (Guilds.guilds[id].members)
                {*/
                byte rank = rd.ReadByte();
                byte level = rd.ReadByte();

                c.ot.WriteShort(res);
                c.ot.WriteInt(c.rlid);
                c.ot.WriteString(c.Player.role.name);
                c.ot.WriteShort(c.Player.role.career);
                c.ot.WriteShort(c.Player.role.level);

                c.ot.WriteShort(rank);
                c.ot.WriteInt(rd.ReadInt());//Contribution total);
                c.ot.WriteInt(rd.ReadInt());//Guilds.guilds[id].members[c.rlid].Donations);
                c.ot.WriteInt(rd.ReadShort());//c.Player.guild.todayDonations);

                // Benefit Subs
                // if (c.Player.guild.ClaimedBenefits == 0)
                c.ot.WriteInt(Guilds.GetOffer(level, rank));
                /*   else
                       c.ot.WriteInt(0);*/

                c.ot.WriteString(rd.ReadString());//Guilds.guilds[id].members[c.rlid].Title);
                c.ot.WriteString(rd.ReadString());//Guilds.guilds[id].members[c.rlid].Comment);
                c.ot.WriteInt(c.Player.role.guildhonor);

                rd.Close();
            }
            rd = null;
            c.ot.PackArray(40024);
        }

		internal static void c40025(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40025");
			
			
		}

		internal static void c40026(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40026");
			
			
		}

		internal static void c40027(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40027");
			
			
		}

		internal static void c40028(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40028");
			
			
		}

		internal static void c40029(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40029");
			
			
		}

		internal static void c40030(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40030");
			
			
		}

		internal static void c40031(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40031");
			
			
		}

		internal static void c40032(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40032");
			
			
		}

		internal static void c40033(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40033");
			
			
		}

		internal static void c40034(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40034");
			
			
		}

		internal static void c40035(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40035");
			
			
		}

		internal static void c40036(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40036");
			
			
		}

		internal static void c40037(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"GuildController 40037");
			
			
		}

	}
}
