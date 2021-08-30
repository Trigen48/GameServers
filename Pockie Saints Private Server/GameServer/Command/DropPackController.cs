using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class DropPackController
	{
       // static int cs =2;
		internal static void c15053(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"DropPackController 15053");

            int id = c.ar.ReadInt();
            drop d;

            d = c.currentScene.PullDrop(id,c);

            byte cs = 2;

            if (d.id != 0)
            {

                if (d.roleid == c.rlid)
                {
                    if (c.Player.bag.CanBagAdd(1))
                    {
                        c.Player.bag.AddBagItem(d.type, 1, d.bind);
                        //c.Player.bag.Save();
                        cs = 1;
                    }
                    else
                    {
                        cs = 5;
                    }
                }
                else
                {
                    cs = 3;
                }
            }


            c.ot.WriteShort(cs);
            c.ot.WriteInt(id);
            c.ot.PackArray(15053);
		}

	}
}
