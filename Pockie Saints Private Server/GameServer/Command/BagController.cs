using System;
using System.Collections.Generic;
using System.Collections;

namespace GameServer.Command
{

    internal static class BagController
    {
        internal static byte[] Props = new byte[] { 1, 2, 3, 4, 7, 6, 8, 5 };
        /*internal static void c13005(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "BagController 13005");
        }*/

        internal static void c15000(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"BagController 15000");

            int id = c.ar.ReadInt();

            c.con.StartCommand("SELECT itemid, typec, slot, countc, str, bind, overtime, basestats, extrastats, gems, gemcount, color, lvl, luck,durability, bagtype FROM bagitem WHERE itemid=? and roleid=? LIMIT 1;");
            c.con.AddValue(id); c.con.AddValue(c.rlid);

            Bag.Item itm = new Bag.Item();

            if (ContentResolver.DoDeserialize<Bag.Item>(itm, c.con))
            {
                byte i = 0;
                int val = 0;
                //Bag.Item itm = itm;

                c.ot.WriteInt(itm.itemid);
                c.ot.WriteInt(itm.type);
                c.ot.WriteShort(itm.slot);
                c.ot.WriteShort(itm.count);
                c.ot.WriteShort(itm.bind);
                c.ot.WriteShort(itm.isBusiness);//f_isBusiness);
                c.ot.WriteShort(itm.isSell);//g_isSell);
                c.ot.WriteShort(itm.isDiscard);//h_isDiscard);
                c.ot.WriteShort(itm.Durability);//i_durable);
                c.ot.WriteShort(itm.Color);
                c.ot.WriteShort(itm.str);
                c.ot.WriteShort(itm.str);


                c.ot.WriteShort(itm.gemcount);

                for (i = 0; i < 3; i++)
                {
                    c.ot.WriteInt(itm.Gems[i]);
                }

                c.ot.WriteShort(itm.setid);//q_setID);
                c.ot.WriteShort(itm.setno);//r_setNum);
                c.ot.WriteInt(itm.overtime);//s_overTime);



                c.ot.WriteShort((itm.BaseStats.Count * 2) + itm.ExtraStats.Count + itm.gemcount);
                for (i = 0; i < itm.BaseStats.Count; i++)
                {
                    c.ot.WriteShort(0);
                    c.ot.WriteShort(itm.BaseStats[i].Prop);
                    c.ot.WriteByte(0); // Value Type and star
                    c.ot.WriteByte(0);
                    c.ot.WriteInt(itm.BaseStats[i].Value);

                    // stars added power
                    c.ot.WriteShort(2);
                    c.ot.WriteShort(itm.BaseStats[i].Prop);
                    c.ot.WriteByte(0); // Value Type and star
                    c.ot.WriteByte(0);
                    val = Combat.GetPower(itm.BaseStats[i].Value, itm.str) - itm.BaseStats[i].Value;
                    c.ot.WriteInt(val);
                }

                // Auto generated stats
                for (i = 0; i < itm.ExtraStats.Count; i++)
                {
                    c.ot.WriteShort(1);
                    c.ot.WriteShort(itm.ExtraStats[i].Prop);
                    c.ot.WriteByte(itm.ExtraStats[i].isPercent);
                    c.ot.WriteByte(itm.ExtraStats[i].Star);
                    c.ot.WriteInt(itm.ExtraStats[i].Value);
                }

                byte lev = 0;
                byte type = 0;

                for (i = 0; i < itm.gemcount; i++)
                {

                    val = 0;
                    if (itm.Gems[i] != 0)
                    {
                        lev = (byte)((itm.Gems[i] - 1114001) / 8);
                        type = (byte)((itm.Gems[i] - 1114001) - (lev * 8));
                        val = Combat.GemPower[lev][type];
                    }
                    c.ot.WriteShort(3);
                    c.ot.WriteShort(Props[type]);
                    c.ot.WriteByte(0);
                    c.ot.WriteByte(0);
                    c.ot.WriteInt(val);
                }
                c.ot.PackArray(15000);
            }


            itm = null;

        }

        internal static void GetBags(ConnectionInfo c)
        {
            //	Program.Write(">Command invoked: " +"BagController 15010");

            int ix = c.ar.ReadShort();
            // Program.Write("-> Bag Command> " + ix);


            int id = ix;

            c.ot.WriteShort(id);

            id = ix > 5 ? ix - 10 : ix;

            c.ot.WriteShort(c.Player.bag.bags[id].max);
            c.ot.WriteInt(c.Player.bag.gold);
            c.ot.WriteInt(c.Player.bag.bgold);
            c.ot.WriteInt(c.Player.bag.bcrystal);
            c.ot.WriteInt(c.Player.bag.crystal);

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

            c.ot.PackArray(15010);

        }

        internal static void c15012(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "BagController 15012+ Equip Durability");


        }

        internal static void c15014(ConnectionInfo c)
        {

            int cnt = 0;

            c.ar = new ByteArray();
            byte i = 0;
            byte gm = 0;
            byte gmc = 0;
            for (i = 0; i < c.Player.bag.bags[0].items.Count; i++)
            {
                c.ar.WriteInt(c.Player.bag.bags[0].items[i].itemid);
                c.ar.WriteShort(c.Player.bag.bags[0].items[i].gemcount);//b_holdsMax);

                for (gm = 0; gm < 3; gm++)
                {
                    if (c.Player.bag.bags[0].items[i].Gems[gm] != 0) gmc++;
                }
                c.ar.WriteShort(gmc);
                c.ar.WriteShort(c.Player.bag.bags[0].items[i].str);//d_strengthen);
                c.ar.WriteShort(c.Player.bag.bags[0].items[i].Color);//e_quality);
                c.ar.WriteShort(c.Player.bag.bags[0].items[i].Luck);
                cnt++;
                gmc = 0;
            }


            for (i = 0; i < c.Player.bag.bags[4].items.Count; i++)
            {
                if (c.Player.bag.bags[4].items[i].type >= 1110000) continue;
                c.ar.WriteInt(c.Player.bag.bags[4].items[i].itemid);
                c.ar.WriteShort(c.Player.bag.bags[4].items[i].gemcount);//b_holdsMax);

                for (gm = 0; gm < 3; gm++)
                {
                    if (c.Player.bag.bags[4].items[i].Gems[gm] != 0) gmc++;
                }
                c.ar.WriteShort(gmc);
                c.ar.WriteShort(c.Player.bag.bags[4].items[i].str);//d_strengthen);
                c.ar.WriteShort(c.Player.bag.bags[4].items[i].Color);//e_quality);
                c.ar.WriteShort(c.Player.bag.bags[4].items[i].Luck);
                cnt++;
                gmc = 0;
            }

            for (i = 0; i < c.Player.bag.bags[3].items.Count; i++)
            {
                c.ar.WriteInt(c.Player.bag.bags[3].items[i].itemid);
                c.ar.WriteShort(0);//b_holdsMax);
                c.ar.WriteShort(0);
                c.ar.WriteShort(c.Player.bag.bags[3].items[i].str);//d_strengthen);
                c.ar.WriteShort(c.Player.bag.bags[3].items[i].Color);//e_quality);
                c.ar.WriteShort(c.Player.bag.bags[3].items[i].Luck);
                cnt++;
            }

            c.ot.WriteShort(cnt);
            c.ot.WriteBytes(c.ar.GetByteArray());
            c.ot.PackArray(15014);
            c.ar.Close();


        }

        internal static void c15020(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"BagController 15020");

            int id = c.ar.ReadInt();
            int num = (byte)c.ar.ReadShort();
            int shopid = c.ar.ReadInt();
            byte res = 1;
            int cost = 0;


            ShopHelper.ShopItem ss;

            int sid = ShopHelper.shops[shopid].FindIndex(
                delegate(ShopHelper.ShopItem sm)
                {
                    return sm.type == id;
                });


            ss = ShopHelper.shops[shopid][sid];
            /*if (num > ss.limit)
                num = ss.limit;
            */
            if (shopid == 10)
            {
                if (c.Player.explore.DiscountBuy[sid] != 0)
                {
                    res = 5;
                }
                else if (ShopHelper.shops[10][sid].limit == 0)
                {
                    res = 7;
                }


                num = 1;
            }

            if (res == 1)
            {
                cost = ss.cost * num;


                byte bind = 1;

                if (Bag.CanOverlap(id))
                {
                    res = (byte)(c.Player.bag.CanBagAdd(1) == true ? 1 : 4);
                }
                else
                {
                    res = (byte)(c.Player.bag.CanBagAdd(num) == true ? 1 : 4);
                }


                if (res == 1)
                {
                    if (ss.type == id)
                    {
                        switch (ss.costtype)
                        {
                            case 0:
                                res = 0;
                                break;
                            ///////////////////////////////////////////////////////////////////////
                            case 1:
                                if (c.Player.bag.gold < cost)
                                {
                                    res = 3;
                                }
                                else
                                {
                                    c.Player.bag.gold -= cost;
                                }

                                break;
                            /////////////////////////////////////////////////////////////////////////////
                            case 2:
                                if (c.Player.bag.bcrystal < cost)
                                {
                                    res = 3;
                                }
                                else
                                {
                                    c.Player.bag.bcrystal -= cost; bind = 2;
                                }
                                break;
                            //////////////////////////////////////////////////////////
                            case 3:
                                if (c.Player.bag.crystal < cost)
                                {
                                    res = 3;
                                }
                                else
                                {
                                    c.Player.bag.crystal -= cost;
                                }
                                break;
                            //////////////////////////////////////////////////////////////////////
                            case 4:
                                if (c.Player.bag.bgold < cost)
                                {
                                    res = 3;
                                }
                                else
                                {
                                    c.Player.bag.bgold -= cost;
                                    bind = 2;
                                }
                                break;
                            ////////////////////////////////////////////////////////////////////////////////
                            case 5:

                                if (c.Player.bag.TotalGold() < cost)
                                {
                                    res = 3;
                                }
                                else
                                {

                                    bind = c.Player.bag.UseAllGold(cost);
                                }
                                break;
                        }

                        if (res == 1)
                        {
                            if (num > 99)
                            {
                                if (shopid == 10)
                                    bind = 2;

                                int cv = num / 99;
                                int dv = num - (cv * 99);


                                for (int x = 0; x < cv; x++)
                                {
                                    c.Player.bag.AddBagItem(id, 99, bind);
                                }

                                if (dv != 0)
                                    c.Player.bag.AddBagItem(id, (byte)dv, bind);
                            }
                            else
                            {
                                c.Player.bag.AddBagItem(id, (byte)num, bind);
                            }
                            c.Player.bag.Save();
                        }
                    }
                    else
                    {
                        res = 2;
                    }

                }

                if (res == 1 && shopid == 10)
                {
                    c.Player.explore.DiscountBuy[sid] = 1;
                    c.Player.explore.Save();

                    lock (ShopHelper.shops[10])
                    {
                        lock (ShopHelper.DayShop)
                        {
                            if (ShopHelper.shops[10][sid].limit > 0)
                                ShopHelper.shops[10][sid].limit--;

                            if (ShopHelper.shops[10][sid].limit != ShopHelper.DayShop[sid].limit)
                            {
                                ShopHelper.DayShop[sid].limit = ShopHelper.shops[10][sid].limit;
                            }
                            ShopHelper.SaveDayShop();
                        }
                    }
                }
            }
            c.ot.WriteShort(res);

            c.ot.WriteInt(id);
            c.ot.WriteShort(num);
            c.ot.WriteInt(shopid);

            int type = id;
            id = 4;
            c.ot.WriteInt(c.Player.bag.gold);
            c.ot.WriteInt(c.Player.bag.bgold);
            c.ot.WriteInt(c.Player.bag.bcrystal);
            c.ot.WriteInt(c.Player.bag.crystal);


            c.ot.WriteShort(c.Player.bag.bags[id].items.Count);
            if (res == 1)
            {
                int ix = c.Player.bag.GetByType(type);
                c.ot.WriteInt(c.Player.bag.bags[id].items[ix].itemid);
                c.ot.WriteInt(c.Player.bag.bags[id].items[ix].type);
                c.ot.WriteShort(c.Player.bag.bags[id].items[ix].slot);
                c.ot.WriteShort(c.Player.bag.bags[id].items[ix].count);
                c.ot.WriteShort(c.Player.bag.bags[id].items[ix].bind);
                c.ot.WriteShort(c.Player.bag.bags[id].items[ix].str);
                c.ot.WriteInt(c.Player.bag.bags[id].items[ix].overtime);
            }


            for (byte i = 0; i < c.Player.bag.bags[id].items.Count; i++)
            {
                if (res == 1 && type != 0 && c.Player.bag.bags[id].items[i].type == type)
                {
                    type = 0;
                    continue;
                }
                c.ot.WriteInt(c.Player.bag.bags[id].items[i].itemid);
                c.ot.WriteInt(c.Player.bag.bags[id].items[i].type);
                c.ot.WriteShort(c.Player.bag.bags[id].items[i].slot);
                c.ot.WriteShort(c.Player.bag.bags[id].items[i].count);
                c.ot.WriteShort(c.Player.bag.bags[id].items[i].bind);
                c.ot.WriteShort(c.Player.bag.bags[id].items[i].str);
                c.ot.WriteInt(c.Player.bag.bags[id].items[i].overtime);
            }

            c.ot.PackArray(15020);

        }

        internal static void c15021(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"BagController 15021");


            int id = c.ar.ReadInt();
            int count = c.ar.ReadShort();
            byte res = 0;

            int ix = c.Player.bag.GetByID(id);

            if (ix != -1)
            {

                int cost = ShopHelper.GetCost(c.Player.bag.bags[4].items[ix].type);


                if (c.Player.bag.bags[4].items[ix].bind == 1)
                {
                    c.Player.bag.gold += cost * count;
                }
                else
                {
                    c.Player.bag.bgold += cost * count;
                }

                c.Player.bag.UseItem(id, (byte)count);
                // PowerUpScripter.Use(ix, c.rlid, count);
                c.Player.bag.Save();
                res = 1;

            }
            else
            {
                res = 2;
            }

            c.ot.WriteShort(res);
            c.ot.WriteInt(id);
            c.ot.WriteShort(count);
            c.ot.WriteInt(c.Player.bag.gold);// d_coins);
            c.ot.WriteInt(c.Player.bag.bgold);//e_bindtong);

            c.ot.PackArray(15021);
        }

        internal static void c15030(ConnectionInfo c)
        {
            int id = c.ar.ReadInt();
            short grid = (short)c.ar.ReadShort();

            Equip.TryEquip(id, c);

        }

        internal static void c15031(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"BagController 15031");

            int id = c.ar.ReadInt();
            Equip.TryDeEquip(id, c);
        }

        internal static void c15033(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "BagController 15033");


        }

        internal static void MoveToSlot(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"BagController 15040");

            int id;
            byte oldslot;
            byte newslot;
            id = c.ar.ReadInt();

            oldslot = (byte)c.ar.ReadShort();
            newslot = (byte)c.ar.ReadShort();


            int ix1 = c.Player.bag.bags[4].items.FindIndex(
                delegate(Bag.Item b)
                {
                    return b.itemid == id && b.slot == oldslot;
                });


            if (ix1 != -1)
            {
                //bgcode: ;
                if (c.Player.bag.slots[newslot - 1] == 0)
                {

                    c.Player.bag.slots[newslot - 1] = 1;
                    c.Player.bag.slots[oldslot - 1] = 0;

                    Bag.Item m = c.Player.bag.bags[4].items[ix1];
                    m.slot = newslot;

                    if (!c.Player.bag.SetItemSlot(m.itemid, m.slot))
                    {
                        //return false;
                    }
                    c.Player.bag.bags[4].items[ix1] = m;

                    c.ot.WriteShort(1);
                    c.ot.WriteInt(m.itemid);
                    c.ot.WriteInt(m.type);
                    c.ot.WriteByte(m.count);
                    c.ot.WriteShort(newslot);

                    c.ot.WriteBytes(new byte[11]);

                    //c.Player.bag.Save();
                }
                else
                {
                    int ix2 = c.Player.bag.bags[4].items.FindIndex(
                    delegate(Bag.Item b)
                    {
                        return b.slot == newslot;
                    });

                    if (ix2 == -1)
                    {
                        c.Player.bag.slots[newslot - 1] = 1;
                        c.Player.bag.slots[oldslot - 1] = 0;

                        Bag.Item m = c.Player.bag.bags[4].items[ix1];
                        m.slot = newslot;
                        if (!c.Player.bag.SetItemSlot(m.itemid, m.slot))
                        {
                            //return false;
                        }
                        c.Player.bag.bags[4].items[ix1] = m;

                        c.ot.WriteShort(1);
                        c.ot.WriteInt(m.itemid);
                        c.ot.WriteInt(m.type);
                        c.ot.WriteByte(m.count);
                        c.ot.WriteShort(newslot);

                        c.ot.WriteBytes(new byte[11]);
                    }
                    else
                    {
                        c.Player.bag.slots[newslot - 1] = 1;
                        c.Player.bag.slots[oldslot - 1] = 1;

                        Bag.Item m = c.Player.bag.bags[4].items[ix1];
                        m.slot = newslot;

                        if (!c.Player.bag.SetItemSlot(m.itemid, m.slot))
                        {
                            //return false;
                        }
                        c.Player.bag.bags[4].items[ix1] = m;


                        c.ot.WriteShort(1);
                        c.ot.WriteInt(m.itemid);
                        c.ot.WriteInt(m.type);
                        c.ot.WriteByte(m.count);
                        c.ot.WriteShort(newslot);

                        m = c.Player.bag.bags[4].items[ix2];
                        m.slot = oldslot;

                        if (!c.Player.bag.SetItemSlot(m.itemid, m.slot))
                        {
                            //return false;
                        }
                        c.Player.bag.bags[4].items[ix2] = m;

                        c.ot.WriteInt(m.itemid);
                        c.ot.WriteInt(m.type);
                        c.ot.WriteByte(m.count);
                        c.ot.WriteShort(oldslot);

                    }
                    //c.Player.bag.Save();
                }

            }
            else
            {
                c.ot.WriteShort(2);
                c.ot.WriteBytes(new byte[22]);

            }

            c.ot.PackArray(15040);

        }

        internal static void UseItem(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"BagController 15050");

            int id, num;
            id = c.ar.ReadInt();
            num = c.ar.ReadShort();
            int type = 0;
            int ix = c.Player.bag.bags[4].items.FindIndex(
                delegate(Bag.Item b)
                {
                    return b.itemid == id && b.count >= num;
                });

            if (ix != -1)
            {
                type = c.Player.bag.bags[4].items[ix].type;
                if (PowerUpScripter.Execute(ix, type, ref num, c.Player.bag.bags[4].items[ix].bind, c))
                {

                    c.ot.WriteShort(1);
                    c.Player.bag.Save();
                    c.Player.role.Save();
                }
                else
                {
                    c.ot.WriteShort(5);
                }

            }
            else
            {
                c.ot.WriteShort(2);
            }

            c.ot.WriteInt(id);
            c.ot.WriteInt(type);
            c.ot.WriteShort(num);
            c.ot.WriteInt(c.Player.combat.hp);
            c.ot.WriteInt(c.Player.combat.mp);
            c.ot.PackArray(15050);


        }

        internal static void c15051(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"BagController 15051");
            int id = c.ar.ReadInt();
            int num = c.ar.ReadShort();
            int ix = c.Player.bag.GetByID(id);
            byte res = 2;
            if (ix != -1)
            {
                num = 0;
                c.Player.bag.RemoveByID(id);
                //c.Player.bag.Save();
                res = 1;
            }
            c.ot.WriteShort(res);
            c.ot.WriteInt(id);
            c.ot.WriteShort(num);
            c.ot.PackArray(15051);
        }

        internal static void Organize(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"BagController 15052");

            if (c.Player.bag.bags[4].items.Count != 0)
            {

                BagHelper.SortBag(c);


                byte i;
                byte id = 4;
                c.ot.WriteShort(c.Player.bag.bags[id].items.Count);

                for (i = 0; i < c.Player.bag.bags[id].items.Count; i++)
                {
                    c.ot.WriteInt(c.Player.bag.bags[id].items[i].itemid);
                    c.ot.WriteInt(c.Player.bag.bags[id].items[i].type);
                    c.ot.WriteShort(c.Player.bag.bags[id].items[i].slot);
                    c.ot.WriteShort(c.Player.bag.bags[id].items[i].count);
                    c.ot.WriteShort(c.Player.bag.bags[id].items[i].bind);
                    c.ot.WriteShort(c.Player.bag.bags[id].items[i].str);
                    c.ot.WriteInt(c.Player.bag.bags[id].items[i].overtime);
                }
            }
            else
            {

                c.ot.WriteShort(0);
            }

            c.ot.PackArray(15052);

        }

        internal static void Dismantle(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"BagController 15069");

            int id = c.ar.ReadInt();
            byte num = (byte)c.ar.ReadShort();



            int ix = c.Player.bag.bags[4].items.FindIndex(
                delegate(Bag.Item b)
                {
                    return b.itemid == id && num < b.count;
                });

            if (ix != -1)
            {

                if (c.Player.bag.CanBagAdd(1))
                {
                    c.ot.WriteShort(1);
                    c.Player.bag.ItemSplit(ix, num);
                    //c.Player.bag.Save();
                }
                else
                {
                    c.ot.WriteShort(0);
                    c.ot.WriteShort(0);
                }


            }
            else
            {
                c.ot.WriteShort(0);
                c.ot.WriteShort(0);
            }

            c.ot.PackArray(15069);
        }

        internal static void c15074(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"BagController 15074");

            int id, num;
            id = c.ar.ReadInt();
            num = c.ar.ReadShort();
            int type = 0;


            int ix = c.Player.bag.bags[4].items.FindIndex(
                delegate(Bag.Item b)
                {
                    return b.itemid == id && b.count >= num;
                });

            if (ix != -1 && System.IO.File.Exists("scripts/" + c.Player.bag.bags[4].items[ix].type.ToString() + ".script"))
            {
                byte bind = c.Player.bag.bags[4].items[ix].bind;
                type = c.Player.bag.bags[4].items[ix].type;
                Packscripter p = new Packscripter(type, num);

                int l = (c.Player.bag.bags[4].items[ix].count - num == 0) ? 1 : 0;
                if (c.Player.bag.CanBagAdd((byte)(p.GetCounts() - l)))
                {

                    //PowerUpScripter.Use(ix, c.rlid, num);
                    c.Player.bag.UseItem((byte)num, 4, ix);


                    c.ot.WriteShort(1);
                    c.ot.WriteInt(id);
                    c.ot.WriteInt(type);
                    c.ot.WriteShort(0);
                    c.ot.WriteShort(p.GetCounts());
                    for (byte i = 0; i < p.items.Length; i++)
                    {

                        if (p.items[i] < 1040001)
                        {
                            p.items[i] = p.items[i] + (c.Player.role.career - 1);
                        }

                        c.Player.bag.AddBagItem(p.items[i], p.quantity[i], bind);

                        c.ot.WriteInt(p.items[i]);
                        c.ot.WriteShort(p.quantity[i]);
                    }
                    p.Close();
                    p = null;
                    // c.Player.bag.Save();
                }
                else
                {
                    c.ot.WriteShort(5);
                    c.ot.WriteInt(id);
                    c.ot.WriteInt(type);
                    c.ot.WriteShort(0);
                    c.ot.WriteShort(0);

                }

            }
            else
            {
                c.ot.WriteShort(2);

                c.ot.WriteBytes(new byte[14]);
            }
            c.ot.PackArray(15074);
        }

        internal static void c29029(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " + "BagController 29029");

            byte res = 2;
            short a_type = (short)c.ar.ReadShort();
            int b_typeId = c.ar.ReadInt();
            int c_num = c.ar.ReadInt();
            short d_bind = (short)c.ar.ReadShort();

            if (c.Player.role.IsGm)
            {

                if (c_num > 99)
                    c_num = 99;
                else if (c_num < 1)
                    c_num = 1;

                if (Bag.CanOverlap(b_typeId))
                {

                    if (c.Player.bag.CanBagAdd(1))
                    {
                        if (c.Player.bag.AddBagItem(b_typeId, (byte)c_num, 2))
                            res = 1;
                    }

                }
                else
                {
                    if (c.Player.bag.CanBagAdd(c_num))
                    {
                        if (c.Player.bag.AddBagItem(b_typeId, (byte)c_num, 2))
                            res = 1;
                    }
                }


            }
            c.ot.WriteByte(res);
            c.ot.PackArray(29029);
        }

        internal static void c45020(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "BagController 45020");


        }

    }
}
