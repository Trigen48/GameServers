using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class FigureController
	{

		internal static void c13026(ConnectionInfo c)
		{
		//	Program.Write(">Command invoked: " +"FigureController 13026");

            byte fig = c.ar.ReadByte();
            byte ii=c.Player.role.showType;

            c.Player.role.showType = fig;


            bool isSuit = c.Player.role.showType == 1 || c.Player.role.showType == 0;
            int id = 0;


            if (isSuit)
            {
                id = c.Player.bag.bags[0].items.FindIndex(
                    delegate(Bag.Item b)
                    {
                        return b.slot == 13;
                    });



                if (id != -1)
                {
                    c.Player.role.armor_id = c.Player.bag.bags[0].items[id].type;
                }
                else
                {
                    id = 0;
                }

            }
            else
            {
                id = c.Player.bag.bags[0].items.FindIndex(
                delegate(Bag.Item b)
                {
                    return b.slot == 3;
                });

                if (id != -1)
                {
                    c.Player.role.armor_id = c.Player.bag.bags[0].items[id].type;
                }
                else
                {
                    id = 0;
                }
            }

            c.ot.WriteByte(1);
            c.ot.WriteByte(fig);
            c.ot.PackArray(13026);

            c.Player.role.Save();
             c.currentScene.UpdateGear(c);
		}

		internal static void c15032(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"FigureController 15032");
			
			
		}

		internal static void c15034(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"FigureController 15034");
			
			
		}

		internal static void c15078(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"FigureController 15078");
			
			
		}

	}
}
