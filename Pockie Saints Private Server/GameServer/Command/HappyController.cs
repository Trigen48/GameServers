using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class HappyController
	{

        internal static void c50020(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"HappyController 50020");

            byte day = c.ar.ReadByte();
            c.ar.Close();

            if (day == 0 || day > 7)
            {

                c.ot.WriteInt(Events.Happy.happy.HappyEvents[1].Date);
                c.ot.WriteByte(Events.Happy.happy.dayCount);

                c.ot.WriteShort(0);
                c.ot.WriteInt(0);
                c.ot.WriteShort(0);
            }
            else
            {
                c.ot.WriteInt(Events.Happy.happy.HappyEvents[day].Date);
                c.ot.WriteByte(day);

                c.ot.WriteByte(Events.Happy.Condition(c, day));
                c.ot.WriteByte(Events.Happy.Condition2(c, day));

                c.ot.WriteInt(Events.Happy.happy.HappyEvents[day].UserID);
                c.ot.WriteString(Events.Happy.happy.HappyEvents[day].UserName);


            }
            c.ot.PackArray(50020);

        }

        internal static void c50021(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"HappyController 50021");

            byte index = c.ar.ReadByte();
            byte id = c.ar.ReadByte();

            byte res = 0;

            if (id == 1)
            {
                if (Events.Happy.Condition(c, index) == 1)
                {
                    if (c.Player.bag.CanBagAdd(3))
                    {
                        Events.Happy.HappyItem[] items = null;
                        lock (Events.Happy.SecondList)
                        {
                            items = Events.Happy.SecondList[index].Items.ToArray();
                        }

                        foreach (Events.Happy.HappyItem itm in items)
                        {
                            c.Player.bag.AddBagItem(itm.Item, itm.Count, 2);
                        }
                        //c.Player.bag.Save();

                        c.Player.happy.Claimed[index] = 1;
                        c.Player.happy.Save();
                        res = 1;
                        items = null;
                    }
                    else
                    {
                        res = 2;
                    }
                }
                else
                {
                    res = 3;
                }
            }
            else
            {

                if (id == 2)
                {
                    if (Events.Happy.Condition2(c, index) == 1)
                    {
                        if (c.Player.bag.CanBagAdd(3))
                        {
                            Events.Happy.HappyItem item = null;
                            lock (Events.Happy.SecondList)
                            {
                                item = Events.Happy.MainList[index];
                            }


                            c.Player.bag.AddBagItem(item.Item+ c.Player.role.career, item.Count, 2);

                            //c.Player.bag.Save();

                            c.Player.happy.MainClaimed[index] = 1;
                            c.Player.happy.Save();
                            res = 1;
                            item = null;
                        }
                        else
                        {
                            res = 2;
                        }
                    }
                    else
                    {
                        res = 3;
                    }
                }
                else
                {
                }
            }

            c.ot.WriteByte(res);
            c.ot.WriteByte(index);
            c.ot.WriteByte(id);
            c.ot.PackArray(50021);

        }

		internal static void c50022(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"HappyController 50022");
			
			
		}

	}
}
