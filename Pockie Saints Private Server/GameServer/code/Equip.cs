using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{
    public static class Equip
    {

        public static int[][] EnhancePrice = new int[][]{
            new int[]{50, 100, 150, 200, 400, 600, 1200, 3000, 5000, 10000, 40000, 160000},
            new int[]{100, 200, 300, 400, 800, 1200, 2400, 6000, 10000, 20000, 80000, 320000},
            new int[]{250, 500, 750, 1000, 2000, 3000, 6000, 15000, 25000, 50000, 200000, 800000},
            new int[]{400, 800, 1200, 1600, 3200, 4800, 9600, 24000, 40000, 80000, 320000, 1280000},
            new int[]{600, 1200, 1800, 2400, 4800, 7200, 14400, 36000, 60000, 120000, 480000, 1920000}};

        public static double[][] EnhanceSuccess = new double[][]{
            new double[]{1, 1, 1, 0.8, 0.6, 0.45, 0.3, 0.2, 0.1, 0.1, 0.1, 0.1},
            new double[]{1, 1, 1, 0.7875, 0.5875, 0.4375, 0.2875, 0.1875, 0.0875, 0.0875, 0.0875, 0.0875},
            new double[]{1, 1, 1, 0.775, 0.575, 0.425, 0.275, 0.175, 0.075, 0.075, 0.075, 0.075},
            new double[]{1, 1, 1, 0.7625, 0.5625, 0.4125, 0.2625, 0.1625, 0.0625, 0.0625, 0.0625, 0.0625},
            new double[]{1, 1, 1, 0.75, 0.55, 0.4, 0.25, 0.15, 0.05, 0.05, 0.05, 0.05}};

        public static int[] GemCost = new int[]{
            1250, 2500, 5000, 10000, 20000,
            40000, 80000, 160000, 320000, 640000};

        public static byte GetSlot(int id, int roleid)
        {

            //gamedata.GameItem itm = gamedata.GameItems.dic[id];

            if (id < 1020001) return 1; // Weapon

            if (id < 1021001) return 2; // Hood

            if (id < 1022001) return 3; // Armor

            if (id < 1023001) return 4; // Pants

            if (id < 1024001) return 5; // Boots

            if (id < 1025001) return 6; // Belt

            if (id < 1030001) return 7; // Glove

            if (id < 1031001) return 8; // Cloak

            if (id < 1032001) return 9; // Girdle

            if (id < 1033001)           // Ring
            {
                if (Players.GetPlayer(roleid).bag.EquipSlots[10] == 1) return 12;
                return 11;
            }

            if (id < 1040001) return 10; // Necklace

            if (id < 1050001) return 13;

            if (id < 1110001) return 14;

            return 0;
        }

        public static bool TryEquip(int id, ConnectionInfo c)
        {

            int ix = c.Player.bag.GetByID(id);
            bool res = false;
            bool isSuit;

            if (ix == -1)
            {
                ix = c.Player.bag.GetByID(id, 3);

                if (ix == -1)
                {
                    c.ot.WriteShort(2);
                    c.ot.WriteInt(0);
                    c.ot.WriteInt(0);
                    c.ot.WriteInt(0);
                    c.ot.WriteShort(0);
                    c.ot.WriteShort(0);
                    c.ot.WriteShort(0);
                    c.ot.WriteShort(0);
                }
                else
                {
                    Bag.Item itm = c.Player.bag.bags[3].items[ix];
                    itm.slot = 13;




                    res = EquipSuit(itm, c);


                    c.Player.bag.bags[3].items.RemoveAt(ix);



                    isSuit = c.Player.role.showType == 1 || c.Player.role.showType == 0;
                    if (isSuit) c.Player.role.armor_id = itm.type;
                    c.currentScene.UpdateGear(c);
                }

            }
            else
            {
                Bag.Item itm = c.Player.bag.bags[4].items[ix];


                if (!c.Player.bag.ItemTypeExists(itm.type, 3))
                {
                    c.Player.bag.bags[4].items.RemoveAt(ix);

                    c.Player.bag.slots[itm.slot - 1] = 0;

                    byte slot = GetSlot(itm.type, c.rlid);
                    itm.slot = slot;

                    if (slot == 13)
                    {
                        //bool active=false;

                        res = EquipSuit(itm, c);
                        World.Banner.SysSend(c, itm.type + "#&" + itm.str.ToString(), 82);
                    }
                    else
                    {
                        res = EquipGear(itm, c);
                    }

                    switch (itm.slot)
                    {
                        case 1:
                            c.Player.role.weapon_id = itm.type;
                            c.currentScene.UpdateGear(c);
                            break;

                        case 3:
                            isSuit = c.Player.role.showType == 1 || c.Player.role.showType == 0;
                            if (!isSuit || c.Player.bag.EquipSlots[12] == 0) c.Player.role.armor_id = itm.type;
                            c.currentScene.UpdateGear(c);
                            break;

                        case 13:

                            isSuit = c.Player.role.showType == 1 || c.Player.role.showType == 0;

                            if (isSuit || c.Player.bag.EquipSlots[2] == 0) c.Player.role.armor_id = itm.type;
                            c.currentScene.UpdateGear(c);
                            break;
                    }
                }
                else
                {
                    c.ot.WriteShort(6);
                    c.ot.WriteInt(0);
                    c.ot.WriteInt(0);
                    c.ot.WriteInt(0);
                    c.ot.WriteShort(0);
                    c.ot.WriteShort(0);
                    c.ot.WriteShort(0);
                    c.ot.WriteShort(0);
                    // ii++;
                }

            }
            c.Player.combat.Compute();

            c.ot.WriteInt(c.Player.combat.hp_lim);//i_HP);
            c.ot.WriteInt(c.Player.combat.mp_lim);//j_MP);
            c.ot.WriteInt(c.Player.combat.atk);//k_attack);
            c.ot.WriteInt(c.Player.combat.def);//l_avoid);
            c.ot.WriteInt(c.Player.combat.hit);//m_mingzhong);
            c.ot.WriteInt(c.Player.combat.dod);//n_duobi);
            c.ot.WriteInt(c.Player.combat.crit);//o_baoji);
            c.ot.WriteInt(c.Player.combat.fort);

            c.ot.PackArray(15030);

            if (res) c.Player.bag.bags[0].items.Sort((x, y) => x.slot.CompareTo(y.slot));

            c.Player.role.Save();
            //c.Player.bag.Save();
            c.Player.bag.BuildEquipSlots();
            c.Player.bag.BuildSlots();
            c.Player.combat.Compute(true);
            return res;

        }

        public static bool EquipGear(Bag.Item itm, ConnectionInfo c)
        {

            int ix = c.Player.bag.bags[0].items.FindIndex(
            delegate(Bag.Item b)
            {
                return b.slot == itm.slot;
            });


            if (ix != -1)
            {
                Bag.Item bx = c.Player.bag.bags[0].items[ix];
                c.Player.bag.bags[0].items.RemoveAt(ix);
                bx.slot = c.Player.bag.UseSlot();

                if (!c.Player.bag.BagMove(bx.itemid, 4, bx.slot))
                {
                    c.Player.bag.SaveItemLog(1, bx);
                    //return false;
                }

                c.ot.WriteShort(1);
                c.ot.WriteInt(itm.itemid);
                c.ot.WriteInt(bx.itemid);
                c.ot.WriteInt(bx.type);
                c.ot.WriteShort(itm.slot);
                c.ot.WriteShort(bx.slot);
                c.ot.WriteShort(bx.bind);
                c.ot.WriteShort(bx.str);
                c.Player.bag.bags[4].items.Add(bx);

            }
            else
            {
                c.ot.WriteShort(1);
                c.ot.WriteInt(itm.itemid);
                c.ot.WriteInt(0);
                c.ot.WriteInt(0);
                c.ot.WriteShort(itm.slot);
                c.ot.WriteShort(0);
                c.ot.WriteShort(0);
                c.ot.WriteShort(0);

            }

            if (!c.Player.bag.BagMove(itm.itemid, 0, itm.slot))
            {
                c.Player.bag.SaveItemLog(1, itm);
                // return false;
            }
            c.Player.bag.bags[0].items.Add(itm);


            return true;
        }

        public static bool EquipSuit(Bag.Item itm, ConnectionInfo c)
        {

            int ix = c.Player.bag.bags[0].items.FindIndex(
            delegate(Bag.Item b)
            {
                return b.slot == itm.slot;
            });


            if (ix != -1)
            {
                Bag.Item b = c.Player.bag.bags[0].items[ix];
                b.slot = (byte)c.Player.bag.bags[3].items.Count;

                if (!c.Player.bag.BagMove(b.itemid, 3, b.slot))
                {
                    c.Player.bag.SaveItemLog(1, b);
                    //return false;
                }
                c.Player.bag.bags[3].items.Add(b);
                c.Player.bag.bags[0].items.RemoveAt(ix);
            }

            c.ot.WriteShort(1);
            c.ot.WriteInt(itm.itemid);
            c.ot.WriteInt(0);
            c.ot.WriteInt(0);
            c.ot.WriteShort(itm.slot);
            c.ot.WriteShort(0);
            c.ot.WriteShort(0);
            c.ot.WriteShort(0);


            if (!c.Player.bag.BagMove(itm.itemid, 0, itm.slot))
            {
                c.Player.bag.SaveItemLog(1, itm);
                // return false;
            }
            c.Player.bag.bags[0].items.Add(itm);

            if (!c.Player.bag.ItemTypeExists(itm.type, 3) && !c.Player.bag.ItemTypeExists(itm.type, 0))
            {

                Bag.Item d = new Bag.Item();
                d = itm;
                d.slot = (byte)(c.Player.bag.bags[3].items.Count + 1);
                c.Player.bag.bags[3].items.Add(d);
                return true;
            }



            return false;
        }

        public static bool TryDeEquip(int id, ConnectionInfo c)
        {
            bool res = false;
            int ix = 0;

            ix = c.Player.bag.GetByID(id, 0);


            byte[] empty = new byte[16];
            if (ix != -1)
            {
                //c.ot.WriteShort(1);
                //c.ot.WriteBytes(new byte[16]);

                if (c.Player.bag.CanBagAdd(1))
                {

                    Bag.Item b = c.Player.bag.bags[0].items[ix];
                    c.Player.bag.bags[0].items.RemoveAt(ix);

                    c.ot.WriteShort(1);
                    c.ot.WriteInt(b.itemid);
                    c.ot.WriteInt(b.type);
                    c.ot.WriteShort(b.slot);

                    if (b.slot == 3)
                    {
                        SetCostume(c, b.type);
                    }
                    else if (b.slot == 1)
                    {
                        c.Player.role.weapon_id = 0;
                    }

                    if (b.slot == 13)
                    {
                        c.ot.WriteInt(0);
                        c.ot.WriteShort(0);

                        if (!c.Player.bag.BagMove(b.itemid, 3, b.slot))
                        {
                            c.Player.bag.SaveItemLog(1, b);
                            // return false;
                        }
                        c.Player.bag.bags[3].items.Add(b);
                        SetCloth(c);
                    }
                    else
                    {

                        b.slot = c.Player.bag.UseSlot();

                        if (!c.Player.bag.BagMove(b.itemid, 4, b.slot))
                        {
                            c.Player.bag.SaveItemLog(1, b);
                            // return false;
                        }

                        c.Player.bag.bags[4].items.Add(b);
                        c.ot.WriteShort(b.slot);
                        c.ot.WriteShort(b.bind);
                        c.ot.WriteShort(b.str);

                    }
                    c.currentScene.UpdateGear(c);
                }
                else
                {
                    c.ot.WriteShort(4);
                    c.ot.WriteBytes(empty);
                }


            }
            else
            {
                c.ot.WriteShort(2);
                c.ot.WriteBytes(empty);
            }
            c.Player.combat.Compute();

            c.ot.WriteInt(c.Player.combat.hp_lim);//i_HP);
            c.ot.WriteInt(c.Player.combat.mp_lim);//j_MP);
            c.ot.WriteInt(c.Player.combat.atk);//k_attack);
            c.ot.WriteInt(c.Player.combat.def);//l_avoid);
            c.ot.WriteInt(c.Player.combat.hit);//m_mingzhong);
            c.ot.WriteInt(c.Player.combat.dod);//n_duobi);
            c.ot.WriteInt(c.Player.combat.crit);//o_baoji);
            c.ot.WriteInt(c.Player.combat.fort);

            c.ot.PackArray(15031);

            if (res) c.Player.bag.bags[0].items.Sort((x, y) => x.slot.CompareTo(y.slot));

            c.Player.role.Save();
            //c.Player.bag.Save();
            c.Player.bag.BuildEquipSlots();
            c.Player.bag.BuildSlots();
            c.Player.combat.Compute(true);


            return res;


        }

        public static bool SetCloth(ConnectionInfo c)
        {
            int id;
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
                c.Player.role.armor_id = 0;
            }
            return true;
        }

        public static bool SetCostume(ConnectionInfo c, int type)
        {

            bool isSuit = c.Player.role.showType == 1 || c.Player.role.showType == 0;

            if (isSuit && c.Player.role.armor_id != 0 && c.Player.role.armor_id != type)
            {

            }
            else
            {
                c.Player.role.armor_id = 0;
            }

            return true;
        }

        public static byte Enhance(ConnectionInfo c, out Bag.Item itm)
        {
            byte res = 2;
            itm = new Bag.Item();
            int ii = c.ar.ReadInt();
            byte index = 4;
            int ix = c.Player.bag.GetByID(ii);

            //  bool IsCostume = false;

            if (ix == -1)
            {
                index = 3;
                ix = c.Player.bag.GetByID(ii, 3);
                //  IsCostume = true;
            }

            if (ix != -1)
            {
                itm = c.Player.bag.bags[index].items[ix];
                byte bind = itm.bind;
                int ix2 = c.Player.bag.GetByID(c.ar.ReadInt());

                if (itm.str != 12)
                {
                    if (c.Player.bag.TotalGold() >= EnhancePrice[itm.Color][itm.str])
                    {
                        if (ix2 != -1)
                        {

                            Bag.Item stone = c.Player.bag.bags[4].items[ix2];

                            if (stone.bind == 2) bind = 2;
                            if (stone.type == GetStone(itm.str))
                            {
                                Bag.Item talisman = new Bag.Item();

                                int ix3 = c.Player.bag.GetByID(c.ar.ReadInt());

                                if (ix3 != -1)
                                {
                                    talisman = c.Player.bag.bags[4].items[ix3];
                                    if (talisman.bind == 2) bind = 2;
                                }

                                List<KeyValuePair<int, byte>> itemuse = new List<KeyValuePair<int, byte>>();

                                int cnt = c.ar.ReadShort();
                                int i;
                                byte luck = 0;
                                byte luck2 = 0;
                                for (i = 0; i < cnt; i++)
                                {
                                    int ico = c.ar.ReadInt();
                                    int id = c.Player.bag.GetByID(ico);
                                    byte count = (byte)c.ar.ReadShort();

                                    if (id == -1 || c.Player.bag.bags[4].items[id].count < count || count == 0) return 2;
                                    luck = GetLuck(c.Player.bag.bags[4].items[id].type, itm.str);

                                    if (luck == 0) { itemuse.Clear(); return 2; }

                                    luck = (byte)(luck * count);
                                    // itm.Luck += luck;
                                    luck2 += luck;
                                    itemuse.Add(new KeyValuePair<int, byte>(ico, count));

                                    if (c.Player.bag.bags[4].items[id].bind == 2) bind = 2;
                                }
                                c.ar.Close();

                                bool IsTalis = IsTalisman(talisman.type, itm.str);

                                if (!IsTalis && talisman.itemid != 0) return 2;

                                c.Player.bag.UseGold(EnhancePrice[itm.Color][itm.str]);// USe gold
                                bool Enhanced = true;// Get ENhance State

                                double lu = ((double)luck2 / 100.00) + EnhanceSuccess[itm.Color][itm.str] + (itm.Luck / 100.0) + (GetVipLuck(c) / 100.0) + c.Player.horoscope.wluck;

                                Enhanced = c.Player.chance.MediumChance(lu);
                                if (Enhanced)
                                {
                                    itm.str += 1;
                                    if (itm.str > 6)
                                    {
                                        itm.Luck = 0;

                                    }//  res = 1;
                                    if (itm.str > 5)
                                    {

                                        World.Banner.SysSend(c, itm.itemid.ToString() + "#&" + itm.type + "#&" + itm.str.ToString(), 1);

                                    }

                                }
                                else
                                {
                                    if (!IsTalis) itm.str -= 1;
                                    itm.Luck += 5;
                                    // res = 0;
                                }

                                itm.bind = bind;// Change Bind Status
                                c.Player.bag.bags[index].items[ix] = itm;// edit item

                                c.Player.bag.UpdateBagItem(itm);

                                c.Player.bag.UseItem(stone.itemid, 1); // Delete starlight stone
                                if (IsTalis) c.Player.bag.UseItem(talisman.itemid, 1); // Delete talisman

                                for (i = 0; i < cnt; i++)
                                {
                                    c.Player.bag.UseItem(itemuse[i].Key, itemuse[i].Value);// Delete luckscrolls
                                }
                                itemuse.Clear();
                                itemuse = null;

                                c.Player.bag.Save();
                                res = 1;

                            }
                            else
                            {
                                res = 4;
                            }

                        }

                    }
                    else
                    {
                        res = 7;
                    }

                }
                else
                {
                    res = 0;
                }
            }
            return res;
        }

        public static int GetStone(int str)
        {

            if (str < 3)
            {
                return 1110001;
            }
            else if (str < 6)
            {
                return 1110002;
            }
            else
            {
                return 1110003;
            }
        }

        public static byte GetLuck(int type, byte str)
        {

            switch (type)
            {
                case 1211001: // luck 5
                    return 5;

                case 1211002: //luck 10
                    return 10;

                case 1211003: // luck 15
                    return 15;

                case 1211004:
                case 1211005:

                case 1211006:

                case 1211007:

                case 1211008:

                case 1211009:

                case 1211010:
                    int id = (type - 1210998);
                    if (str == id) return 10;

                    break;
            }




            return 0;
        }

        public static byte GetGemLuck(int type, byte level)
        {

            switch (type)
            {
                case 1214001:

                    if (level < 3)
                        return 25;
                    break;

                case 1214002:
                    if (level < 5)
                        return 25;
                    break;

                case 1214003:
                    if (level < 7)
                        return 25;
                    break;

                case 1214004:
                    if (level < 10)
                        return 25;
                    break;
            }
            return 0;
        }

        public static byte GetDismantleLuck(int type, byte level)
        {

            switch (type)
            {
                case 1216001:

                    if (level < 3)
                        return 25;
                    break;

                case 1216002:
                    if (level < 5)
                        return 25;
                    break;

                case 1216003:
                    if (level < 7)
                        return 25;
                    break;

                case 1216004:
                    if (level < 10)
                        return 25;
                    break;
            }
            return 0;
        }

        public static byte GetSynthLuck(int type, byte level)
        {

            switch (type)
            {
                case 1213001:

                    if (level < 3)
                        return 25;
                    break;

                case 1213002:
                    if (level < 5)
                        return 25;
                    break;

                case 1213003:
                    if (level < 7)
                        return 25;
                    break;

                case 1213004:
                    if (level < 10)
                        return 25;
                    break;
            }
            return 0;
        }

        public static bool IsTalisman(int type, byte str)
        {

            switch (type)
            {
                case 1210001:
                    if (str > 2 && str < 6) return true;
                    break;
                case 1210002:
                    if (str > 5 && str < 8) return true;
                    break;
                case 1210003:
                    if (str > 7 && str < 10) return true;
                    break;
                case 1210004:
                case 1210005:
                case 1210006:
                case 1210007:
                case 1210008:
                case 1210009:
                case 1210010:
                case 1210011:
                case 1210012:
                case 1210013:

                    int id = type - 1210001;
                    if (str == id) return true;

                    break;
            }

            return false;
        }

        public static byte EmbedGem(ConnectionInfo c, out Bag.Item itm)
        {
            byte res = 2;

            itm = new Bag.Item();

            int ii = c.ar.ReadInt();

            int ix = c.Player.bag.GetByID(ii);

            byte level;
            byte type;


            if (ix != -1)
            {

                itm = c.Player.bag.bags[4].items[ix];


                byte slot = 3;

                for (byte i = 0; i < itm.gemcount; i++)
                {
                    if (itm.Gems[i] == 0)
                    {
                        slot = i;
                        break;
                    }
                }
                if (slot == 3) return 6;

                byte bind = itm.bind;
                int ix2 = c.Player.bag.GetByID(c.ar.ReadInt());
                if (ix2 != -1)
                {
                    Bag.Item Gem = c.Player.bag.bags[4].items[ix2];
                    if (Gem.bind == 2) bind = 2;

                    if (Gem.type < 1114001 || Gem.type > 1114080) return 2;

                    level = (byte)((Gem.type - 1114001) / 8);
                    type = (byte)((Gem.type - 1114001) - (level * 8));

                    if (c.Player.bag.TotalGold() >= GemCost[level])
                    {
                        List<KeyValuePair<int, byte>> itemuse = new List<KeyValuePair<int, byte>>();

                        int cnt = c.ar.ReadShort();
                        int i;
                        byte luck = 0;
                        byte lu = 0;
                        for (i = 0; i < cnt; i++)
                        {
                            int ico = c.ar.ReadInt();
                            int id = c.Player.bag.GetByID(ico);
                            byte count = (byte)c.ar.ReadShort();

                            if (id == -1 || c.Player.bag.bags[4].items[id].count < count || count == 0) return 2;
                            luck = GetGemLuck(c.Player.bag.bags[4].items[id].type, level);

                            if (luck == 0) { itemuse.Clear(); return 2; }

                            luck = (byte)(luck * count);
                            lu += luck;

                            itemuse.Add(new KeyValuePair<int, byte>(ico, count));

                            if (c.Player.bag.bags[4].items[id].bind == 2) bind = 2;
                        }
                        c.ar.Close();

                        c.Player.bag.UseGold(GemCost[level]);

                        lu += 25;

                        bool embed = false;

                        embed = c.Player.chance.MediumChance(((double)lu / 100.00));

                        if (embed)
                        {
                            itm.bind = bind;// Change Bind Status
                            itm.Gems[slot] = Gem.type;
                            c.Player.bag.bags[4].items[ix] = itm;// edit item
                            c.Player.bag.UpdateBagItem(itm);
                        }
                        else
                        {
                            itm = new Bag.Item();
                        }

                        c.Player.bag.UseItem(Gem.itemid, 1); // Delete Gem

                        for (i = 0; i < cnt; i++)
                        {
                            c.Player.bag.UseItem(itemuse[i].Key, itemuse[i].Value);// Delete Glues
                        }
                        itemuse.Clear();
                        itemuse = null;

                        c.Player.bag.Save();
                        res = 1;
                    }
                    else
                    {
                        return 8;
                    }
                }


            }

            return res;

        }

        public static byte DismantleGem(ConnectionInfo c, out Bag.Item itm)
        {
            byte res = 2;

            itm = new Bag.Item();

            int ii = c.ar.ReadInt();

            int ix = c.Player.bag.GetByID(ii);

            byte level;
            byte type;

            if (c.Player.bag.CanBagAdd(1))
            {
                if (ix != -1)
                {

                    itm = c.Player.bag.bags[4].items[ix];

                    short k = (short)c.ar.ReadShort();


                    if (itm.Gems[k - 1] == 0) return 8;


                    byte bind = itm.bind;

                    level = (byte)((itm.Gems[k - 1] - 1114001) / 8);
                    type = (byte)((itm.Gems[k - 1] - 1114001) - (level * 8));


                    if (c.Player.bag.TotalGold() >= GemCost[level])
                    {
                        List<KeyValuePair<int, byte>> itemuse = new List<KeyValuePair<int, byte>>();

                        int cnt = c.ar.ReadShort();
                        int i;
                        byte luck = 0;
                        byte lu = 0;
                        for (i = 0; i < cnt; i++)
                        {
                            int ico = c.ar.ReadInt();
                            int id = c.Player.bag.GetByID(ico);
                            byte count = (byte)c.ar.ReadShort();

                            if (id == -1 || c.Player.bag.bags[4].items[id].count < count || count == 0) return 2;

                            luck = GetDismantleLuck(c.Player.bag.bags[4].items[id].type, level);

                            if (luck == 0) { itemuse.Clear(); return 2; }

                            luck = (byte)(luck * count);
                            lu += luck;

                            itemuse.Add(new KeyValuePair<int, byte>(ico, count));

                            if (c.Player.bag.bags[4].items[id].bind == 2) bind = 2;
                        }
                        c.ar.Close();

                        c.Player.bag.UseGold(GemCost[level]);

                        lu += 25;

                        bool embed = false;

                        embed = c.Player.chance.MediumChance(((double)lu / 100.00));
                        int gem = 0;

                        gem = itm.Gems[k - 1];
                        itm.Gems[k - 1] = 0;
                        #region Sort Gems
                        List<int> m = new List<int>();
                        m.AddRange(itm.Gems);

                        m.Sort((x, y) => y.CompareTo(x));

                        itm.Gems = m.ToArray();
                        m.Clear();
                        m = null;


                        #endregion

                        if (embed)
                        {
                            itm.bind = bind;// Change Bind Status
                            res = 1;
                            c.Player.bag.AddBagItem(gem, 1, bind); // Delete Gem
                        }
                        else
                        {
                            res = 0;
                        }

                        c.Player.bag.bags[4].items[ix] = itm;// edit item                  
                        c.Player.bag.UpdateBagItem(itm);
                        for (i = 0; i < cnt; i++)
                        {
                            c.Player.bag.UseItem(itemuse[i].Key, itemuse[i].Value);// Delete dismantles
                        }
                        itemuse.Clear();
                        itemuse = null;

                        c.Player.bag.Save();
                    }
                    else
                    {
                        res = 6;
                    }

                }
            }
            else
            {
                res = 7;
            }

            return res;

        }

        public static byte GetVipLuck(ConnectionInfo c)
        {

            switch (c.Player.vip.vip_level)
            {
                case 5:
                    {
                        return 3;
                    }
                case 6:
                    {
                        return 4;
                    }
                case 7:
                    {
                        return 5;
                    }
                case 8:
                    {
                        return 6;
                    }
                case 9:
                    {
                        return 7;
                    }
                case 10:
                    {
                        return 8;
                    }
                case 11:
                    {
                        return 10;
                    }
                case 12:
                    {
                        return 12;
                    }
                case 13:
                    {
                        return 14;
                    }
                case 14:
                    {
                        return 16;
                    }
                case 15:
                    {
                        return 18;
                    }
            }
            return 0;
        }

        public static byte GemSynth(ConnectionInfo c, out Bag.Item itm)
        {

            int synthid = c.ar.ReadInt();

            int gemtype = c.ar.ReadInt();
            Bag.Item syn = new Bag.Item();
            itm = new Bag.Item();
            if (gemtype < 1114001 || gemtype > 1114080) return 5;

            if (!c.Player.bag.CanBagAdd(1)) return 9;

            if (synthid != 0)
            {
                int id = c.Player.bag.GetByID(synthid);
                if (id == -1) return 2;
                syn = c.Player.bag.bags[4].items[id];

                if (syn.type < 1213001 || syn.type > 1213004) return 7;

            }

            List<KeyValuePair<int, byte>> itemuse = new List<KeyValuePair<int, byte>>();

            int cnt = c.ar.ReadShort();
            int i;
            byte luck = 0;
            byte lu = 0;
            byte level;
            byte type;
            byte bind = 1;

            level = (byte)((gemtype - 1114001) / 8);
            type = (byte)((gemtype - 1114001) - (level * 8));
            byte cntt = 0;
            for (i = 0; i < cnt; i++)
            {
                int ico = c.ar.ReadInt();
                int id = c.Player.bag.GetByID(ico);
                byte count = (byte)c.ar.ReadShort();

                if (id == -1 || c.Player.bag.bags[4].items[id].count < count || count == 0)
                    return 2;

                if (c.Player.bag.bags[4].items[id].type != gemtype)
                    return 7;

                luck = (byte)(25 * count);
                lu += luck;
                cntt += count;
                itemuse.Add(new KeyValuePair<int, byte>(ico, count));

                if (c.Player.bag.bags[4].items[id].bind == 2) bind = 2;
            }
            c.ar.Close();

            int cost = 2500;

            for (i = 0; i < level; i++)
            {
                cost = cost * 2;
            }


            if (c.Player.bag.TotalGold() < cost) return 8;
            c.Player.bag.UseGold(cost);

            lu -= 25;

            if (syn.type != 0) lu += 25;


            if (cntt < 2) return 6;

            bool embed = false;
            embed = c.Player.chance.MediumChance(((double)lu / 100.00));

            if (embed)
            {
                itm.type = gemtype + 8;
                c.Player.bag.AddBagItem(itm.type, 1, bind);
            }

            if (syn.type != 0)
            {
                c.Player.bag.UseItem(syn.itemid, 1);// Delete synths
            }

            for (i = 0; i < cnt; i++)
            {
                c.Player.bag.UseItem(itemuse[i].Key, itemuse[i].Value);// Delete synths
            }

            itemuse.Clear();
            itemuse = null;

            c.Player.bag.Save();


            return 1;

        }
    }
}
