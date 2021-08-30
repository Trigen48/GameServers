using System;
using System.Collections.Generic;
using System.Collections;

namespace GameServer.Command
{

	internal static class LuckWheelController
	{

		internal static void GetLuckyWheelStatus(ConnectionInfo c)
		{

            c.ot.WriteByte(c.Player.luckywheel.claim);
            c.ot.PackArray(50025);
            //c.ar.Close();
			
		}

        internal static void TryLuckyWheel(ConnectionInfo c)
        {


           byte res = 4;


           if (c.Player.luckywheel.prize == 0)
           {
               int ix = c.Player.bag.bags[4].items.FindIndex(
                   delegate(Bag.Item m)
                   {
                       return m.type == 6040155;
                   });


               res = 2;
               if (ix != -1)
               {

                   res = 3;
                   if (c.Player.combat.hp > 0)
                   {
                       c.Player.luckywheel.bind = c.Player.bag.bags[4].items[ix].bind;

                       //PowerUpScripter.Use(ix, c.rlid, 1);
                       c.Player.bag.UseItem(1, 4, ix);

                       ShuffleList<int> items;

                       items = new ShuffleList<int>();
                       items.AddRange(LuckyWheelData.items);


                       // items.ShuffleShift();
                       items.ShuffleInplace();
                       c.Player.luckywheel.prize = items.Pop();
                       c.Player.luckywheel.claim = (byte)(LuckyWheelData.PrizeToClock(c.Player.luckywheel.prize) + 1);

                       //LuckyWheelData.LuckyWheelItems litm = LuckyWheelData.litem[c.Player.luckywheel.claim-1];
                       items.Clear();
                       items = null;


                       byte col = gamedata.GameItems.dic[c.Player.luckywheel.prize].color;

                       if (col > 2)
                       {
                           c.con.StartCommand("INSERT INTO luckywheel_log(itemtype,countc,typec,windate,roleid) VALUES(?,?,?,?,?);");

                           c.con.AddValue(c.Player.luckywheel.prize);
                           c.con.AddValue(LuckyWheelData.litem[c.Player.luckywheel.claim - 1].count);
                           c.con.AddValue(col);

                           c.con.AddValue(DateUtil.GetDateIntZone());
                           c.con.AddValue(c.rlid);
                           c.con.ExecuteNoneQuery();
                       }
                       c.Player.luckywheel.Save();
                       res = 1;
                       //c.Player.bag.Save();
                   }

               }

           }

            c.ot.WriteByte(res);
            c.ot.WriteByte(c.Player.luckywheel.claim);
            c.ot.PackArray(50026);

           /* c.ot.WriteShort(5);
            c.ot.WriteShort(13005);
            c.ot.WriteByte(2);*/

        }

		internal static void ClaimPrize(ConnectionInfo c)
		{

            byte res = 2;
            byte claim = 0;
            if (c.Player.luckywheel.claim != 0)
            {
                res = 4;

                c.Player.bag.enableins = true;
                if (c.Player.bag.AddBagItem(c.Player.luckywheel.prize, LuckyWheelData.litem[c.Player.luckywheel.claim - 1].count, c.Player.luckywheel.bind))
                {
                    res = 1;
                    claim = c.Player.luckywheel.claim;
                    c.Player.luckywheel.Reset();
                    c.Player.luckywheel.Save();
                }
                c.Player.bag.enableins = false;
            }


            c.ot.WriteByte(res);
            c.ot.WriteByte(claim);


            c.ot.WriteShort(c.Player.bag.lastinsert.Count);
            for (int x = 0; x < c.Player.bag.lastinsert.Count; x++)
            {
                c.ot.WriteInt(c.Player.bag.lastinsert[x].itemid);
                c.ot.WriteInt(c.Player.bag.lastinsert[x].type);
                c.ot.WriteShort(c.Player.bag.lastinsert[x].slot);
                c.ot.WriteShort(c.Player.bag.lastinsert[x].count);
                c.ot.WriteShort(c.Player.bag.lastinsert[x].bind);
                c.ot.WriteShort(c.Player.bag.lastinsert[x].str);
            }
            c.ot.PackArray(50027);

            c.Player.bag.lastinsert.Clear();


            /*c.ot.WriteShort(5);
            c.ot.WriteShort(13005);
            c.ot.WriteByte(2);*/

		}

		internal static void GetLuckyWheelPlayers(ConnectionInfo c)
		{

            c.con.StartCommand("SELECT l.roleid,r.charname,r.faction,l.itemtype,l.typec,l.countc FROM luckywheel_log l INNER JOIN role r ON l.roleid=r.roleid ORDER BY windate DESC LIMIT 20;");

            Connector.DataReader rd= c.con.ExecuteRead();
         
            if (rd.CanRead)
            {
                Dictionary<int, PrizeRole> user = new Dictionary<int,PrizeRole>();


                while (rd.NextRow())
                {
                    int id = rd.ReadInt();
                    string name = rd.ReadString();
                    byte faction = rd.ReadByte();

                    if (!user.ContainsKey(id))
                        user.Add(id, new PrizeRole(id, name, faction));

                    user[id].items.Add(new PrizeItem(rd.ReadInt(), rd.ReadByte(), rd.ReadByte()));


                }

                c.ot.WriteShort(user.Count);

                foreach (PrizeRole rp in user.Values)
                {
                    c.ot.WriteInt(rp.roleId);
                    c.ot.WriteString(rp.name);
                    c.ot.WriteByte(rp.faction);

                    c.ot.WriteShort(rp.items.Count);
                    foreach (PrizeItem itm in rp.items)
                    {
                        c.ot.WriteInt(itm.itemType);
                        c.ot.WriteByte(itm.type);
                        c.ot.WriteByte(itm.count);
                    }
                }

                user.Clear();


            }
            else
            {
                c.ot.WriteShort(0);
            }

            rd.Close();


            c.ot.PackArray(50028);
		}



	}
}
