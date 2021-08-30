using System;
using System.Collections;

namespace GameServer.Command
{

	internal static class StarMapController
	{

		internal static void c44000(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"StarMapController 44000");
			
			//System.Collections.Generic.ls
		}

        internal static void c44001(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"StarMapController 44001");
            StarMap tag=c.Player.starmap;
            bool UpdateComabt = false;
            if (tag.timeleft > 0 && tag.timeleft <= DateUtil.GetDateInt())
            {
                tag.Increment();
                tag.Save();
              
                UpdateComabt = true;
            }


            c.ot.WriteInt(c.rlid);//a_playerId);
            c.ot.WriteByte(c.Player.role.career);//b_career);
            c.ot.WriteByte(c.Player.starmap.curindex);//c_index); page 
            c.ot.WriteByte(c.Player.starmap.curpos);//d_id); were we are
            c.ot.WriteByte(c.Player.starmap.nextpos);//e_nowId); what is next

            c.ot.WriteInt(c.Player.starmap.timeleft);//f_time);
            c.ot.WriteByte(c.Player.starmap.passive);//g_num1); //   Destucter for enemy

            c.ot.WriteByte(c.Player.starmap.interact);//h_num2); // Helper for


            c.ot.PackArray(44001);

            if (UpdateComabt)
                c.Player.combat.Compute(true);
        }

		internal static void c44002(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"StarMapController 44002");
			
			
		}

		internal static void c44003(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"StarMapController 44003");

            byte index = c.ar.ReadByte();
            byte id = c.ar.ReadByte();
            byte res = 0;

            int n=(c.Player.starmap.curpos+1);
            if (n == 16)
                n = 15;

            StarMapCfg.StarMapItem m= StarMapCfg.maps[c.Player.role.career][c.Player.starmap.curindex][n];

            if (c.Player.role.level >= m.level)
            {

                if (c.Player.starmap.timeleft <= DateUtil.GetDateInt())
                {
                    if (c.Player.bag.TotalGold() >= m.gold)
                    {
                        if (c.Player.role.Trial >= m.trial)
                        {
                            if (c.Player.starmap.timeleft != 0)
                            {
                                c.Player.starmap.Increment();
                        
                                c.Player.combat.Compute(true);
                            }

                            c.Player.starmap.timeleft = (int)(DateUtil.GetDateInt() + m.timeneeded);
                            c.Player.starmap.nextpos = (byte)(c.Player.starmap.curpos + 1);

                            c.Player.bag.UseAllGold(m.gold);
                            c.Player.role.Trial -= m.trial;

                            c.Player.starmap.Save();
                            c.Player.bag.Save();
                            c.Player.role.Save();

                            res = 1;
                        }
                        else
                        {
                            res = 5;
                        }
                    }
                    else
                    {
                        res = 4;
                    }
                }
                else
                {
                    res = 6;
                }
            }
            else
            {
                res = 2;
            }


            c.ot.WriteByte(res);//a_state);
            c.ot.WriteByte(c.Player.starmap.nextpos);//b_id);
            c.ot.WriteInt(c.Player.starmap.timeleft);//c_time);
            c.ot.WriteInt(c.Player.bag.bgold);//d_bindtong);
            c.ot.WriteInt(c.Player.bag.gold);//e_tong);
            c.ot.WriteInt(c.Player.role.Trial);//f_experience);

            c.ot.PackArray(44003);
		}

        internal static void c44004(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "StarMapController 44004");

            byte res = 0;

            if (c.Player.starmap.timeleft >= DateUtil.GetDateInt())
            {
                int last = (int)(c.Player.starmap.timeleft - DateUtil.GetDateInt());

                if (last < 0) last = 0;

                int cost = StarMapCfg.GetFastCost(last);

                if (c.Player.bag.crystal >= cost)
                {

                    c.Player.starmap.Increment();
                   
                    c.Player.bag.crystal -= cost;
                    c.Player.starmap.Save();
                    c.Player.bag.Save();
                    //c.Player.combat.Save();
                    res = 1;
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

            c.ot.WriteByte(res);
            c.ot.WriteByte(c.Player.starmap.curindex);
            c.ot.WriteByte(c.Player.starmap.curpos);
            c.ot.WriteInt(c.Player.bag.crystal);

            c.ot.PackArray(44004);

            if (res == 1)
            {
                c.Player.combat.Compute(true);
            }
        }

		internal static void c44005(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"StarMapController 44005");
			
			
		}

		internal static void c44006(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"StarMapController 44006");
			
			
		}

	}
}
