using System;

using System.Collections;
using System.Collections.Generic;
namespace GameServer.Command
{

	internal static class StarTargetController
	{

        internal static void SendGoal(ConnectionInfo c)
        {

            List<byte> all = new List<byte>();

            byte i = 0;
      
            byte sen = c.Player.goal.GetLevel();
            for (i = 0; i < ZodiacGoal.count[sen]; i++)
            {
                if (c.Player.goal.zodiac[i] == 1)
                {
                    all.Add((byte)(i + 1));
                    break;

                }
            }

            c.ot.WriteShort(all.Count+6);
            c.ot.WriteShort(23010);
            c.ot.WriteShort(all.Count);
            for (i = 0; i < all.Count; i++)
            {
                c.ot.WriteByte(1);
            }
            all.Clear();

        }


        internal static void c23001(ConnectionInfo c)
        {
            // Program.Write(">Command invoked: " + "StarTargetController 23001");

            byte sec = c.ar.ReadByte();
            c.ot.WriteByte(1);

            if (sec == 0)
            {
                sec = c.Player.goal.GetLevel();

                c.ot.WriteByte(sec);
                c.ot.WriteByte(sec);
            }
            else
            {
                c.ot.WriteByte(c.Player.goal.GetLevel());
                c.ot.WriteByte(sec);
            }

            int c2 = ZodiacGoal.count[sec - 1];
            int n = ZodiacGoal.count[sec];



            c.ot.WriteShort(n - c2);
            for (int x = c2; x < n; x++)
            {
                c.ot.WriteByte(x + 1);
                c.ot.WriteByte(c.Player.goal.zodiac[x]);
            }

            c.ot.PackArray(23001);
        }

        internal static void c23002(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"StarTargetController 23002");

            byte code = c.ar.ReadByte();
            byte res = 2;
            byte codex = (byte)(code - 1);



            if (code > 0 && code < 31)
            {

                if (c.Player.goal.zodiac[codex] == 1)
                {
                    if (c.Player.bag.CanBagAdd((byte)ZodiacGoalHelper.GoalItems[codex].Items.Length))
                    {
                        res = 1;
                        c.Player.goal.zodiac[codex] = 2;
                        c.Player.bag.bcrystal += ZodiacGoalHelper.GoalItems[codex].BoundCrystal;
                        c.Player.bag.bgold += ZodiacGoalHelper.GoalItems[codex].BoundGold;

                        for (byte i = 0; i < ZodiacGoalHelper.GoalItems[codex].Items.Length; i++)
                        {
                            c.Player.bag.AddBagItem(ZodiacGoalHelper.GoalItems[codex].Items[i][0], (byte)ZodiacGoalHelper.GoalItems[codex].Items[i][1], 2);
                        }
                        c.Player.bag.Save();
                        c.Player.goal.Save();
                    }
                    else
                    {
                        res = 4;
                    }
                }
                else if (c.Player.goal.zodiac[codex] == 2)
                {
                    res = 3;
                }

            }

            c.ot.WriteByte(res);
            c.ot.PackArray(23002);


        }

        internal static void c23003(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " + "StarTargetController 23003");

            byte sec = c.Player.goal.GetLevel();

            byte res = 2;
            byte e = 1;

            if (c.Player.goal.zodiac[5] == 0)
            {
                c.Player.goal.zodiac[5] = 1;

                c.Player.goal.Save();
                res = 1;
            }

            c.ot.WriteByte(res);
            c.ot.WriteByte(e);
            c.ot.PackArray(23003);

            if (res == 1)
                SendGoal(c);
        }

		internal static void c23010(ConnectionInfo c)
		{
            SendGoal(c);
		}

	}
}
