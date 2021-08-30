using System;

using System.Collections;

namespace GameServer.Command
{

    internal static class StorageController
    {

        internal static void c15041(ConnectionInfo c)
        {

            int id, num;
            id = c.ar.ReadInt();
            num = c.ar.ReadShort();
            c.ar.Close();
            byte res;
            byte sol = 0;
            if (c.Player.bag.CanInventoryAdd(1))
            {
                if (c.Player.bag.MoveToInventory(id))
                {
                    res = 1;
                    sol = 1;
                    //c.Player.bag.Save();
                }
                else
                {
                    res = 2;
                }
            }
            else
            {
                res = 6;

            }
            c.ot.WriteShort(res);
            c.ot.WriteInt(id);
            c.ot.WriteShort(sol);
            c.ot.PackArray(15041);

        }

        internal static void c15042(ConnectionInfo c)
        {

            int id, num;
            id = c.ar.ReadInt();
            num = c.ar.ReadShort();
            c.ar.Close();
            byte res = 2;


            if (c.Player.bag.CanBagAdd(1))
            {
                int ix = c.Player.bag.GetByID(id, 5);

                if (ix != -1)
                {
                    ix = 5;
                }
                else
                {
                    ix = c.Player.bag.GetByID(id, 1);
                    if (ix != -1)
                    {
                        ix = 1;
                    }
                }


                if (ix != -1 && c.Player.bag.MoveToBag(id, (byte)ix))
                {
                    res = 1;

                    //c.Player.bag.Save();
                }
                else
                {
                    res = 2;
                }
            }
            else
            {
                res = 6;
            }




            c.ot.WriteShort(res);
            c.ot.WriteInt(id);
            c.ot.WriteShort(0);
            c.ot.PackArray(15042);

            c.ot.WriteShort(5);
            c.ot.WriteShort(13005);
            c.ot.WriteByte(2);


        }

    }
}
