using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class BuildController
	{

/*
		internal static void c15014(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BuildController 15014");
			
			
		}

*/
		internal static void c15060(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BuildController 15060");
			
			
		}

		internal static void c15061(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BuildController 15061");
			
			
		}

		internal static void c15062(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"BuildController 15062");

            Bag.Item itm = new Bag.Item();
            byte res=Equip.Enhance(c, out itm);
            c.ot.WriteShort(res);

            c.ot.WriteInt(itm.itemid);
            c.ot.WriteShort(itm.str);
            c.ot.WriteInt(c.Player.bag.gold);
            c.ot.WriteInt(c.Player.bag.bgold);
            c.ot.WriteShort(itm.Luck);
            c.ot.PackArray(15062);

            if (res == 1)
            {
                c.Player.combat.Compute(true);
            }
			
		}

		internal static void c15063(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BuildController 15063");
			
			
		}

		internal static void c15064(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"BuildController 15064");


            Bag.Item itm = new Bag.Item();
            c.ot.WriteShort(Equip.GemSynth(c,out itm));
            c.ot.WriteInt(itm.type);
            c.ot.PackArray(15064);
		}

		internal static void c15065(ConnectionInfo c)
		{

            Bag.Item itm = new Bag.Item();
            c.ot.WriteShort(Equip.EmbedGem(c, out itm));
            c.ot.WriteInt(itm.itemid);
            c.ot.WriteInt(c.Player.bag.gold);
            c.ot.PackArray(15065);
			
		}

		internal static void c15066(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"BuildController 15066");


            Bag.Item itm = new Bag.Item();

            c.ot.WriteByte(Equip.DismantleGem(c, out itm));
            c.ot.WriteInt(itm.itemid);
            c.ot.WriteInt(c.Player.bag.gold);
            c.ot.WriteInt(c.Player.bag.bgold);

            byte id = 4;
            c.ot.WriteShort(c.Player.bag.bags[id].items.Count);

            for (byte i = 0; i < c.Player.bag.bags[id].items.Count; i++)
            {
                c.ot.WriteInt(c.Player.bag.bags[id].items[i].itemid);
                c.ot.WriteInt(c.Player.bag.bags[id].items[i].type);
                c.ot.WriteShort(c.Player.bag.bags[id].items[i].slot);
                c.ot.WriteShort(c.Player.bag.bags[id].items[i].count);
                c.ot.WriteShort(c.Player.bag.bags[id].items[i].bind);
                c.ot.WriteShort(c.Player.bag.bags[id].items[i].str);
                c.ot.WriteInt(c.Player.bag.bags[id].items[i].overtime);
            }

            c.ot.PackArray(15066);

          //  c.ar.Close();
		}

		internal static void c15067(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BuildController 15067");



		}

		internal static void c15072(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"BuildController 15072");


            c.ot.WriteByte(Refine.RefineGear(c));
            c.ot.WriteInt(c.Player.bag.gold);
            c.ot.WriteInt(c.Player.bag.bgold);

            byte id = 4;
            c.ot.WriteShort(c.Player.bag.bags[id].items.Count);

            for (byte i = 0; i < c.Player.bag.bags[id].items.Count; i++)
            {
                c.ot.WriteInt(c.Player.bag.bags[id].items[i].itemid);
                c.ot.WriteInt(c.Player.bag.bags[id].items[i].type);
                c.ot.WriteShort(c.Player.bag.bags[id].items[i].slot);
                c.ot.WriteShort(c.Player.bag.bags[id].items[i].count);
                c.ot.WriteShort(c.Player.bag.bags[id].items[i].bind);
                c.ot.WriteShort(c.Player.bag.bags[id].items[i].str);
                c.ot.WriteInt(c.Player.bag.bags[id].items[i].overtime);
            }

            c.ot.PackArray(15072);


		}

		internal static void c15073(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BuildController 15073");
			
			
		}

		internal static void c15077(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BuildController 15077");
			
			
		}

		internal static void c15080(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"BuildController 15080");
			
			
		}

	}
}
