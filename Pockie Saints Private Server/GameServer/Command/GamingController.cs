using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class GamingController
	{

        internal static void c42000(ConnectionInfo c)
        {

            c.ot.WriteShort(3);

            for (byte i = 0; i < 3; i++)
            {
                c.ot.WriteByte(i + 1);
                c.ot.WriteShort(167 - c.Player.explore.chances[i]);
                c.ot.WriteByte(100);
            }

            c.ot.WriteShort(0);
            c.ot.PackArray(42000);
        }

        internal static void c42001(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"GamingController 42001");
            byte num = c.ar.ReadByte();
            byte itr = c.ar.ReadByte();


            int scroll = ExploreWiz.ExploreScroll[itr - 1];
            int scrollcount = c.Player.bag.GetTypeCount(scroll);

            System.Collections.Generic.List<ExploreItem> ex = new System.Collections.Generic.List<ExploreItem>();

            byte res = 3;
            if (scrollcount >= num)
            {
                ExploreWiz.Pop(ex, c, num, itr - 1);

                // transform items
                c.Player.bag.UseExplore(scroll, num, ex);

                res = 1;
            }
            else
            {

                int cost = ExploreWiz.GetCost(itr, num);

                if (c.Player.bag.crystal >= cost && cost!=0)
                {
                    c.Player.bag.crystal -= cost;
                    ExploreWiz.Pop(ex, c, num, itr - 1); 
                    res = 1;
                }

              
            }

            if (res == 1)
            {
                for (byte x = 0; x < ex.Count; x++)
                {
                    c.Player.bag.AddToExploreBag(ex[x].type, ex[x].count, ex[x].bind);
                }
                c.Player.explore.Save();
                c.Player.bag.Save();
            }


            c.ot.WriteByte(res);
            c.ot.WriteByte(itr);
            c.ot.WriteInt(c.Player.bag.crystal);

            c.ot.WriteShort(3);
            for (byte i = 0; i < 3; i++)
            {
                c.ot.WriteByte(i + 1);
                c.ot.WriteShort(167 - c.Player.explore.chances[i]);
                c.ot.WriteByte(100);
            }

            c.ot.WriteShort(ex.Count);
            for (byte i = 0; i < ex.Count; i++)
            {
                c.ot.WriteInt(ex[i].type);
                c.ot.WriteByte(ex[i].bind);
            }
            c.ot.PackArray(42001);
            ex.Clear();
            ex = null;

		}

	}
}
