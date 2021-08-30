using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class RewardController
	{

		internal static void c29001(ConnectionInfo c)
		{
            if (c.Player.reward.rewardphase>10)
            {
                c.ot.WriteByte(0);
                c.ot.WriteInt(0);
            }
            else
            {
                c.ot.WriteByte(1);
                c.ot.WriteShort(RewardHelper.fitems[c.Player.reward.rewardphase].id);// c.Player.reward.StartReward[0].id);
                c.ot.WriteShort(0);
            }
            c.ot.PackArray(29001);
		}

        internal static void c29002(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"RewardController 29002");

           
            if (c.Player.reward.rewardphase > 10 || RewardHelper.fitems[c.Player.reward.rewardphase].id != c.ar.ReadShort())
            {
                c.ot.WriteByte(3);
            }
            else
            {

                if (c.Player.role.level >= RewardHelper.fitems[c.Player.reward.rewardphase].level)
                {

                    if (c.Player.bag.CanBagAdd((byte)RewardHelper.fitems[c.Player.reward.rewardphase].items.Count))
                    {
                        RewardItem rw = RewardHelper.fitems[c.Player.reward.rewardphase];
                        //c.Player.reward.StartReward.RemoveAt(0);
                        c.Player.reward.rewardphase++;
                        c.Player.reward.Save();

                        for (int x = 0; x < rw.items.Count; x++)
                        {
                            RewardItemContent cs = rw.items[x];

                            c.Player.bag.AddBagItem(cs.isWeapon ? cs.ItemId + c.Player.role.career : cs.ItemId, (byte)cs.count, 2);
                        }
                        //c.Player.bag.Save();

                        c.ot.WriteByte(1);
                    }
                    else
                    {
                        c.ot.WriteByte(5);
                    }


                }
                else
                {
                    c.ot.WriteByte(2);
                }
            }
            c.ot.PackArray(29002);

        }

		internal static void c29003(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"RewardController 29003");

            c.ot.WriteByte(1);
            c.ot.WriteShort(c.Player.reward.phase);
            c.ot.WriteShort(c.Player.reward.remain);
            c.ot.PackArray(29003);
		
		}

		internal static void c29004(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"RewardController 29004");
			
			if(c.Player.reward.phase!=c.ar.ReadShort())
			{
				c.ot.WriteByte(3);
			}
			else
			{
				if(c.Player.reward.targettime<=DateUtil.GetDateIntZone())
				{
					                   
					if (c.Player.bag.CanBagAdd(RewardHelper.Count(c.Player.reward.phase)))
                    {
                        RewardHelper.Claim(c, c.Player.reward.phase);
						c.Player.reward.phase++;		
						c.Player.reward.remain = RewardHelper.GetTime(c.Player.reward.phase);
						// Console.WriteLine(c.Player.reward.remain.ToString()+" remains");

						c.Player.reward.targettime= (int)DateUtil.GetDateIntZone()+c.Player.reward.remain;
						c.Player.reward.Save();
						c.ot.WriteByte(1);
           
					}
					else
					{
						c.ot.WriteByte(5);
					}
				}
				else
				{
					c.ot.WriteByte(2);
				}
			}

			c.ot.PackArray(29004);
			
			c.ot.WriteShort(9);
			c.ot.WriteShort(29003);
			c.ot.WriteByte(1);
            c.ot.WriteShort(c.Player.reward.phase);
            c.ot.WriteShort(c.Player.reward.remain);
            
           // c.ot.PackArray(29003);
		}
		
			

	}
}
