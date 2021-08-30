using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class InfoGoodsController
	{

		internal static void c15001(ConnectionInfo c)
		{
			//Program.Write(">Command invoked: " +"InfoGoodsController 15001");

            int pid = c.ar.ReadInt();
            int id = c.ar.ReadInt();

            RoleControl rl = Players.GetPlayer(pid);
            if (rl== null) return;

            byte ii = 0;
            int ix = -1;
            int val = 0;
            byte i = 0;
            for (i = 0; i < 5; i++)
            {
                ix = rl.bag.GetByID(id, i);

                if (ix != -1)
                {
                    ii = i;
                    break;
                }
            }



            if (ix != -1)
            {

                Bag.Item b =rl.bag.bags[ii].items[ix];

                c.ot.WriteInt(b.itemid);
                c.ot.WriteInt(b.type);
                c.ot.WriteShort(b.slot);
                c.ot.WriteShort(b.count);
                c.ot.WriteShort(b.bind);
                c.ot.WriteShort(b.isBusiness);//f_isBusiness);
                c.ot.WriteShort(b.isSell);//g_isSell);
                c.ot.WriteShort(b.isDiscard);//h_isDiscard);
                c.ot.WriteShort(b.Durability);//i_durable);
                c.ot.WriteShort(b.Color);
                c.ot.WriteShort(b.str);
                c.ot.WriteShort(b.str);


                c.ot.WriteShort(b.gemcount);

                for (i = 0; i < 3; i++)
                {
                    c.ot.WriteInt(b.Gems[i]);
                }

                c.ot.WriteShort(b.setid);//q_setID);
                c.ot.WriteShort(b.setno);//r_setNum);
                c.ot.WriteInt(b.overtime);//s_overTime);



                c.ot.WriteShort((b.BaseStats.Count * 2) + b.ExtraStats.Count + b.gemcount);
                for (i = 0; i < b.BaseStats.Count; i++)
                {
                    c.ot.WriteShort(0);
                    c.ot.WriteShort(b.BaseStats[i].Prop);
                    c.ot.WriteByte(0); // Value Type and star
                    c.ot.WriteByte(0);
                    c.ot.WriteInt(b.BaseStats[i].Value);

                    // stars added power
                    c.ot.WriteShort(2);
                    c.ot.WriteShort(b.BaseStats[i].Prop);
                    c.ot.WriteByte(0); // Value Type and star
                    c.ot.WriteByte(0);
                    val = Combat.GetPower(b.BaseStats[i].Value, b.str) - b.BaseStats[i].Value;
                    c.ot.WriteInt(val);
                }

                // Auto generated stats
                for (i = 0; i < b.ExtraStats.Count; i++)
                {
                    c.ot.WriteShort(1);
                    c.ot.WriteShort(b.ExtraStats[i].Prop);
                    c.ot.WriteByte(b.ExtraStats[i].isPercent);
                    c.ot.WriteByte(b.ExtraStats[i].Star);
                    c.ot.WriteInt(b.ExtraStats[i].Value);
                }

                byte lev = 0;
                byte type = 0;

                for (i = 0; i < b.gemcount; i++)
                {

                    val = 0;
                    if (b.Gems[i] != 0)
                    {
                        lev = (byte)((b.Gems[i] - 1114001) / 8);
                        type = (byte)((b.Gems[i] - 1114001) - (lev * 8));
                        val = Combat.GemPower[lev][type];
                    }
                    c.ot.WriteShort(3);
                    c.ot.WriteShort(BagController.Props[type]);
                    c.ot.WriteByte(0);
                    c.ot.WriteByte(0);
                    c.ot.WriteInt(val);
                }
                c.ot.PackArray(15001);
            }

            c.ar.Close();
		}

	}
}
