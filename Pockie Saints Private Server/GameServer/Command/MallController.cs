using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class MallController
	{

		internal static void c15013(ConnectionInfo c)
		{
            int id = c.ar.ReadInt();

            c.ot.WriteInt(id);
            ShopHelper.GetShop(c, id);
            c.ot.PackArray(15013);
  
		}

		internal static void c15075(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"MallController 15075");

            int MallType = c.ar.ReadInt();
            if (MallType == 10)
            {
                ShopHelper.ShopItem[] sh = null;// = new ShopHelper.ShopItem[3];

                lock (ShopHelper.DayShop)
                {
                    sh = (ShopHelper.ShopItem[])ShopHelper.DayShop.Clone();
                }


                c.ot.WriteInt(MallType);
                c.ot.WriteInt(DateUtil.GetTodayInt(23, 59, 59)-(2*60*60));
                c.ot.WriteShort(3);
                for (byte i = 0; i < 3; i++)
                {
                    c.ot.WriteInt(sh[i].type);// a_typeId);
                    c.ot.WriteByte(sh[i].costtype);// b_costType);
                    c.ot.WriteInt(sh[i].origprice);// c_originalPrice);
                    c.ot.WriteInt(sh[i].cost);// d_presentPrice);
                    c.ot.WriteShort(sh[i].limit);// e_surplusNum);
                    c.ot.WriteByte(1);
                }
            }
            else
            {
                c.ot.WriteInt(MallType);
                c.ot.WriteInt(0);
                c.ot.WriteShort(0);
            }
            c.ot.PackArray(15075);
        }

		internal static void c15076(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"MallController 15076");
			
			
		}

		internal static void c15081(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"MallController 15081");
			
			
		}

	}
}
