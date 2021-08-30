using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class MountController
	{

		internal static void c16010(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"MountController 16010");

            int id = 0;

            id = c.ar.ReadInt();

            int ix = c.Player.bag.bags[4].items.FindIndex(
                delegate(Bag.Item b)
                {
                    return b.itemid == id;

                });


            byte result = 1;

            if (ix != -1)
            {

                int type = c.Player.bag.bags[4].items[ix].type;


                if (type.ToString().Remove(4) == "3110")
                {
                    lock (c.Player.mount)
                    {
                        if (c.Player.mount.Add(type))
                        {
                            c.Player.bag.UseItem(1, 4, ix);
                            c.Player.combat.Compute(true);
                            c.currentScene.UpdatePlayerHp(c);
                            if(type!=3110001) World.Banner.SysSend(c, type.ToString(), 15);

                        }
                        else
                        {
                            result = 5;

                        }
                    }
                }
                else
                {
                    result = 4;
                }
            }
            else
            {
                result = 2;
            }

            c.ot.WriteByte(result);
            c.ot.PackArray(16010);
		}

		internal static void c16011(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"MountController 16011");


            int newmount =c.ar.ReadInt();

            int ix= c.Player.mount.GetMount(newmount);

            if (ix == -1)
            {
                c.ot.WriteByte(0);
            }
            else
            {

                // Get mount item
                Mount.MountItem m = c.Player.mount.mounts[ix];
                m.Selected = 1;
                c.Player.mount.mounts[ix] = m;
                bool can = true;
                if (newmount != c.Player.mount.mounttype)
                {
                    ix = c.Player.mount.GetMount(c.Player.mount.mounttype);

                    if (ix != -1)
                    {
                        m = c.Player.mount.mounts[ix];
                        can = c.Player.mount.ChangeMount(m.mount_type, 0);
                        m.Selected = 0;
                        c.Player.mount.mounts[ix] = m;
                    }

                    if (can)
                        can = c.Player.mount.ChangeMount(newmount, 1);
                }
                c.Player.mount.mounttype = newmount;
                //c.Player.charz.Save();
                //if(can)c.Player.mount.Save();
                //.Selected=1;

                c.ot.WriteByte(can ? 1 : 0);
            }

            c.ot.PackArray(16011);

            if (c.Player.mount.mount_id != 0)
            {
                // dismount if the player is already mounted
                c.ar = new ByteArray();
                c.Player.mount.mount_id = 0;
               // c.Player.charz.speed = (short)200;
                c.Player.mount.mountspeed= 0;//MountHelper.mountList[];
                
                c.ar.WriteByte(1);
                c.ar.WriteInt(c.Player.mount.mount_id);
                c.ar.PackArray(16014);
                c.currentScene.UpdateMount(c);
                c.ot.WriteBytes(c.ar.GetByteArray());
                c.ar.Close();

            }

		}

        internal static void c16013(ConnectionInfo c)
        {
            //	Program.Write(">Command invoked: " +"MountController 16013");
            if (c.Player.mount.mounttype == 0)
            {
                c.ot.WriteByte(0);
                c.ot.WriteInt(0);
            }
            else
            {
                c.Player.mount.mount_id = c.Player.mount.mounttype;
                c.Player.mount.mountspeed = (short)MountHelper.mount_stats[c.Player.mount.mounttype][0];

                c.ot.WriteByte(1);
                c.ot.WriteInt(c.Player.mount.mount_id);

            }

            c.ot.PackArray(16013);
            c.Player.combat.Compute();

            
            c.ot.WriteShort(14);
            c.ot.WriteShort(12010);
            c.ot.WriteInt(c.rlid);
            c.ot.WriteShort(c.Player.combat.GetSpeed(c));
            c.ot.WriteInt(c.Player.mount.mount_id);

            c.currentScene.UpdateMount(c);

        }

        internal static void c16014(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"MountController 16014");

            if (c.Player.mount.mounttype == 0)
            {
                c.ot.WriteByte(0);
                c.ot.WriteInt(0);
            }
            else
            {

                c.Player.mount.mount_id = 0;
                //c.Player.charz.speed = (short)200;

                c.Player.mount.mountspeed = 0;//MountHelper.mountList[];
                c.ot.WriteByte(1);
                c.ot.WriteInt(c.Player.mount.mount_id);

            }

            c.ot.PackArray(16014);
            c.currentScene.UpdateMount(c);
        }

		internal static void c16016(ConnectionInfo c)
		{

            if (c.Player.mount.mounts.Count == 0)
            {
                c.ot.WriteByte(0);
                c.ot.WriteByte(0);
                c.ot.WriteShort(0);
            }
            else
            {
                c.ot.WriteByte(1); 
                
                if(c.Player.mount.mount_id==0)
                    c.ot.WriteByte(0);
                else
                    c.ot.WriteByte(1);


                c.ot.WriteShort(c.Player.mount.mounts.Count);
                foreach (Mount.MountItem m in c.Player.mount.mounts)
                {
                    c.ot.WriteInt(m.mount_type);
                    c.ot.WriteByte(m.Selected);
                    c.ot.WriteInt(m.mount_time);
                }
            }
               
            c.ot.PackArray(16016);
		}

        internal static void c16017(ConnectionInfo c)
        {
         //   Program.Write(">Command invoked: " + "MountController 16017");

            byte res = 2;
            int count = 0;

            bool update = false;
            if (c.Player.mount.mount_level < c.Player.role.level)
            {
                System.Collections.Generic.List<int> Feeds = new System.Collections.Generic.List<int>();

                count = c.ar.ReadShort();

                int FeedAmount = 0;

                for (int x = 0; x < count; x++)
                {
                    int id = c.ar.ReadInt();

                    Bag.Item itm = c.Player.bag.GetItemByID(id);

                    if (itm.itemid != 0 && itm.type < 1040000)
                    {

                        FeedAmount += ((itm.Color + 1) * 3) + itm.Level+10;
                        c.Player.bag.RemoveByID(itm.itemid);

                    }
                    else
                    {
                        res = 2;
                    }

                }


                if (FeedAmount != 0)
                {

                    c.Player.mount.mount_exp += FeedAmount;

                    while (c.Player.mount.mount_exp >= MountHelper.expArray[c.Player.mount.mount_level])
                    {
                        update = true;
                        c.Player.mount.mount_level++;
                        c.Player.mount.mount_exp -= MountHelper.expArray[c.Player.mount.mount_level];

                        if (c.Player.role.level == c.Player.mount.mount_level)
                        {
                            c.Player.mount.mount_exp = 0;
                            break;
                        }
                    }

                    c.Player.mount.Save();
                    //c.Player.bag.Save();
                    res = 1;
                }
            }
            else
            {
                res = 3;
            }
            c.ot.WriteByte(res);
            c.ot.WriteByte(c.Player.mount.mount_level);
            c.ot.WriteInt(c.Player.mount.mount_exp);
            c.ot.PackArray(16017);

            if (update)
            {
                c.Player.combat.Compute(true);
                c.currentScene.UpdatePlayerHp(c);
            }
        }

        internal static void c16018(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"MountController 16018 > " +type);
            
            byte type = c.ar.ReadByte();
            byte result=1;
            byte mstate=0;

            if (c.Player.mount.mount_star == 30)
            {
                result = 0;
                mstate = 1;
            }
            else
            {
                if (type == 0)
                {
                    if (c.Player.mount.CanUpgrade())
                    {

                        if (c.Player.mount.DeductCost(c))
                        {
                            mstate = (byte)(c.Player.mount.UpgradeGold() == true ? 0 : 1);
                            c.Player.mount.Save();

                            if (c.Player.mount.levelup)
                            {
                                c.Player.mount.levelup = false;
                                c.Player.combat.Compute(true);
                                c.currentScene.UpdatePlayerHp(c);
                                World.Banner.SysSend(c, c.Player.mount.mount_star.ToString(), 16); 
                            }
                        }
                        else
                        {
                            result = 2;
                        }
                    }
                    else
                    {
                        result = 4;
                    }

                }
                else
                {


                    if (c.Player.mount.DeductCrystal(c, type))
                    {
                        mstate = (byte)(c.Player.mount.CanUpgrade() == true ? 0 : 1);
                        c.Player.mount.Save();

                        if (c.Player.mount.levelup)
                        {
                            
                            c.Player.mount.levelup = false;
                            c.Player.combat.Compute(true);   
                            c.currentScene.UpdatePlayerHp(c);
                            World.Banner.SysSend(c, c.Player.mount.mount_star.ToString(), 16);                         
                        }
                    }
                    else
                    {
                        result = 3;
                    }

                }

            }
            c.ot.WriteByte(result);
            c.ot.WriteByte(c.Player.mount.mount_star);
            c.ot.WriteInt(c.Player.mount.mount_star_exp);
            c.ot.WriteInt(c.Player.mount.mount_time - (DateUtil.ZoneDeduct));
            c.ot.WriteByte(mstate);
            c.ot.WriteInt(c.Player.bag.gold);
            c.ot.WriteInt(c.Player.bag.bgold);
            c.ot.WriteInt(c.Player.bag.crystal);
            c.ot.WriteByte(0);
            c.ot.WriteByte(0);
            c.ot.WriteByte(0);
            c.ot.WriteByte(type);

            c.ot.PackArray(16018);


		}

        internal static void c16019(ConnectionInfo c)
        {
           // Program.Write(">Command invoked: " + "MountController 16019");

            byte state = 0;
            byte mstate;


            decimal m=((decimal)(c.Player.mount.mount_time - DateUtil.GetDateIntZone()))/ 150m;
            int cost = (int)  m+1; 

            if (c.Player.bag.crystal < cost)
            {
                state = 2;
            }
            else
            {
                c.Player.mount.mount_time = 0;
                c.Player.mount.start_time = 0;

                c.Player.bag.crystal -= cost;
                c.Player.mount.Save();
                c.Player.bag.Save();
                state = 1;
            }

            mstate = (byte)(c.Player.mount.CanUpgrade() == true ? 0 : 1);

            c.ot.WriteByte(state);
            c.ot.WriteByte(mstate);
            c.ot.WriteInt(c.Player.mount.mount_time -(c.Player.mount.mount_time!=0? (DateUtil.ZoneDeduct):0));
            c.ot.WriteInt(c.Player.bag.crystal);
            c.ot.PackArray(16019);

        }

		internal static void c16020(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"MountController 16020");

            int id, mid, res;
            id =c.ar.ReadInt();
            mid =c.ar.ReadInt();

            c.ar.Close();
            res = 1;

            RoleControl rl = Players.GetPlayer(id);
            if (mid!=0)
            {
                res = 0;
                for (byte i = 0; i < rl.mount.mounts.Count; i++)
                {
                    if (rl.mount.mounts[i].mount_type == mid)
                    {
                        res = 1;
                        break;
                    }
                }
                if (res == 0) mid = 0;
            }

            c.ot.WriteByte(res);
            c.ot.WriteInt(id);
            c.ot.WriteInt(mid);
            c.ot.WriteByte(rl.mount.mount_level);
            c.ot.WriteInt(rl.mount.mount_exp);
            c.ot.WriteByte(rl.mount.mount_star);
            c.ot.WriteInt(rl.mount.mount_star_exp);
            c.ot.WriteInt(rl.mount.mount_time - (DateUtil.ZoneDeduct));
            c.ot.WriteByte((byte)(c.Player.mount.CanUpgrade() == true ? 0 : 1));
            c.ot.WriteInt(rl.mount.hp);
            c.ot.WriteInt(rl.mount.atk);
            c.ot.WriteInt(rl.mount.def);
            c.ot.WriteInt(rl.mount.hit);
            c.ot.WriteInt(rl.mount.dod);
            c.ot.WriteInt(rl.mount.crit);
            c.ot.WriteInt(rl.mount.fort);
            c.ot.WriteByte(rl.role.faction);

            c.ot.PackArray(16020);

		}

	}
}
