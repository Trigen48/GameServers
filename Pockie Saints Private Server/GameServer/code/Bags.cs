using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{

    public class Bag
    {
        //public const string file = "Bag";
        private const byte BagsSize = 6;
        ConnectionInfo c;
        //[Content("")]
        #region Classes

        public class Item
        {
            [ContentProto("itemid", true)]
            public int itemid { get; set; }

            [ContentProto("typec")]
            public int type { get; set; }

            [ContentProto("slot")]
            public byte slot { get; set; }

            [ContentProto("countc")]
            public byte count { get; set; }

            [ContentProto("str")]
            public byte str { get; set; }

            [ContentProto("bind")]
            public byte bind { get; set; }

            [ContentProto("overtime")]
            public int overtime { get; set; }

            [ContentProto("basestats")]
            public byte[] basestatsb
            {
                get
                {
                    ByteArray ar = new ByteArray();
                    ar.WriteByte((byte)BaseStats.Count);


                    for (byte i = 0; i < BaseStats.Count; i++)
                    {
                        ar.WriteByte(BaseStats[i].Prop);
                        ar.WriteByte(BaseStats[i].isPercent);
                        ar.WriteByte(BaseStats[i].Star);
                        ar.WriteInt(BaseStats[i].Value);
                    }
                    ar.Flush();
                    byte[] d = ar.GetByteArray();

                    ar.Close();
                    ar = null;
                    return d;
                }

                set
                {
                    if (value != null)
                    {
                        BaseStats.Clear();
                        ByteArray ar = new ByteArray(value);
                        byte max = ar.ReadByte();

                        for (byte i = 0; i < max; i++)
                        {
                            ItemStat its = new ItemStat();
                            its.Prop = ar.ReadByte();
                            its.isPercent = ar.ReadByte();
                            its.Star = ar.ReadByte();
                            its.Value = ar.ReadInt();
                            BaseStats.Add(its);
                        }

                        ar.Close();
                        ar = null;
                    }
                }
            }

            public List<ItemStat> BaseStats { get; set; }

            [ContentProto("extrastats")]
            public byte[] extrastatsb
            {
                get
                {
                    ByteArray ar = new ByteArray();
                    ar.WriteByte((byte)ExtraStats.Count);


                    for (byte i = 0; i < ExtraStats.Count; i++)
                    {
                        ar.WriteByte(ExtraStats[i].Prop);
                        ar.WriteByte(ExtraStats[i].isPercent);
                        ar.WriteByte(ExtraStats[i].Star);
                        ar.WriteInt(ExtraStats[i].Value);
                    }
                    ar.Flush();
                    byte[] d = ar.GetByteArray();

                    ar.Close();
                    ar = null;
                    return d;
                }

                set
                {
                    if (value != null)
                    {
                        ExtraStats.Clear();
                        ByteArray ar = new ByteArray(value);
                        byte max = ar.ReadByte();

                        for (byte i = 0; i < max; i++)
                        {
                            ItemStat its = new ItemStat();
                            its.Prop = ar.ReadByte();
                            its.isPercent = ar.ReadByte();
                            its.Star = ar.ReadByte();
                            its.Value = ar.ReadInt();
                            ExtraStats.Add(its);
                        }

                        ar.Close();
                        ar = null;
                    }
                }
            }

            public List<ItemStat> ExtraStats { get; set; }

            [ContentProto("gems")]
            public byte[] gemsb
            {
                get
                {
                    ByteArray ar = new ByteArray();

                    if (Gems != null)
                    {
                        ar.WriteByte((byte)Gems.Length);

                        for (byte i = 0; i < Gems.Length; i++)
                        {
                            ar.WriteInt(Gems[i]);
                        }
                    }
                    else
                    {
                        ar.WriteByte(0);
                    }

                    ar.Flush();
                    byte[] d = ar.GetByteArray();

                    ar.Close();
                    ar = null;
                    return d;
                }
                set
                {
                    if (value != null)
                    {

                        ByteArray ar = new ByteArray(value);
                        byte max = ar.ReadByte();

                        Gems = new int[max];

                        for (byte i = 0; i < max; i++)
                        {
                            Gems[i] = ar.ReadInt();
                        }

                        ar.Close();
                        ar = null;
                    }
                }
            }

            public int[] Gems { get; set; }

            [ContentProto("gemcount")]
            public byte gemcount { get; set; }

            [ContentProto("color")]
            public byte Color { get; set; }

            [ContentProto("lvl")]
            public byte Level { get; set; }

            [ContentProto("luck")]
            public byte Luck { get; set; }

            [ContentProto("durability")]
            public byte Durability { get; set; }


            [ContentProto("pricetype", true)]
            public byte PriceType { get; set; }

            [ContentProto("price", true)]
            public int Price { get; set; }


            [ContentProto("isbusiness", true)]
            public byte isBusiness { get; set; }

            [ContentProto("issell", true)]
            public byte isSell { get; set; }


            [ContentProto("isdiscard", true)]
            public byte isDiscard { get; set; }

            [ContentProto("setid", true)]
            public byte setid { get; set; }

            [ContentProto("setno", true)]
            public byte setno { get; set; }

            public Item()
            {
                BaseStats = new List<ItemStat>();
                ExtraStats = new List<ItemStat>();
            }
            public Item(int Itemid, int Typeid, byte Slot, byte Count, byte Str, byte Bind, int OverTime)
            {
                itemid = Itemid;
                type = Typeid;
                slot = Slot;
                count = Count;
                str = Str;
                bind = Bind;
                overtime = OverTime;
                ExtraStats = new List<ItemStat>();
                BaseStats = new List<ItemStat>();
                Gems = new int[0];
                gemcount = 0;
                Color = 0;
                Level = 0;
                Luck = 0;


                Item i = this;
                gamedata.GameItems.CopyProperties(ref i);

                Durability = 100;

            }

            public Item(int Itemid, int Typeid, byte Slot, byte Count, byte Str, byte Bind, int OverTime, bool loads)
            {
                itemid = Itemid;
                type = Typeid;
                slot = Slot;
                count = Count;
                str = Str;
                bind = Bind;
                overtime = OverTime;
                ExtraStats = new List<ItemStat>();
                BaseStats = new List<ItemStat>();
                Gems = new int[0];
                gemcount = 0;
                Color = 0;
                Level = 0;
                Luck = 0;
                /* if (Typeid < 1110000)
                     Equip.BuildStats(this);*/
            }


        }

        public class ItemStat
        {
            public byte Prop { get; set; }
            public byte isPercent { get; set; }
            public byte Star { get; set; }
            public int Value { get; set; }

            public ItemStat()
            {
            }
            public ItemStat(byte prop, int value)
            {
                Prop = prop;
                Value = value;
                Star = 0;
                isPercent = 0;
            }

            public ItemStat(byte prop, double value)
            {
                Prop = prop;
                Value = (int)value;
                Star = 0;
                isPercent = 0;
            }

            public ItemStat(byte prop, int value, byte star, byte ispercent)
            {
                Prop = prop;
                Value = value;
                Star = star;
                isPercent = ispercent;
            }
        }

        public class BagType
        {
            public byte max { get; set; }

            //public Item 
            public List<Item> items { get; set; }

            public BagType()
            {
                items = new List<Item>();
            }
        }

        #endregion

        public bool SaveItemLog(byte type, Item itm)
        {
            return SaveItemLog(type, itm, c.rlid, c.con);
        }

        public static bool SaveItemLog(byte type, Item itm, int rlid, Connector.MySqlConnector con)
        {
            string[] itemd = ContentResolver.DoSerializeInsert<Item>(itm);

            con.StartCommand("INSERT INTO bagitem_log(itemid,?,logtype,roleid) VALUES(?,?,?,?);");

            con.AddValue(itemd[0], true);

            con.AddValue(itm.itemid);
            con.AddValue(itemd[1], true);
            con.AddValue(type);
            con.AddValue(rlid);
            itemd = null;
            return con.ExecuteNoneQuery() > 0;
        }



        [ContentProto("gold")]
        public int gold { get; set; }

        [ContentProto("bgold")]
        public int bgold { get; set; }

        [ContentProto("crystal")]
        public int crystal { get; set; }

        [ContentProto("bcrystal")]
        public int bcrystal { get; set; }

        [ContentProto("bcount")]
        public byte[] bcount
        {
            get
            {
                byte[] data = new byte[6];

                for (byte i = 0; i < 6; i++)
                {
                    data[i] = bags[i].max;
                }
                return data;
            }
            set
            {
                if (value != null && value.Length == 6)
                {
                    byte[] data = value;

                    for (byte i = 0; i < 6; i++)
                    {
                        bags[i].max = data[i];
                    }
                }
            }
        }

        public BagType[] bags { get; set; }

        public byte[] slots;
        public byte[] EquipSlots;

        public Bag(ConnectionInfo cc)
        {
            bags = new BagType[Bag.BagsSize];

            bags[0] = new BagType(); // Weapons
            bags[0].max = 16;

            bags[1] = new BagType(); // Explore inventory
            bags[3] = new BagType(); // Wardrobe

            bags[2] = new BagType();// something

            bags[4] = new BagType();
            bags[4].max = 56;

            bags[5] = new BagType(); // Inventory
            bags[5].max = 6;
            c = cc;
        }

        public static bool CanOverlap(int id)
        {
            return ((id > 1110000 && id < 2284001) || (id > 2286000 && id < 9030123));
        }

        public void RemoveByType(int type)
        {
            RemoveByType(type, 4);
        }

        public void RemoveByType(int type, byte index)
        {
            int ix = GetByType(type);
            RemoveItem(ix, index);
        }

        public bool RemoveByID(int itemid)
        {
            return RemoveByID(itemid, 4);
        }

        public bool RemoveByID(int itemid, byte index)
        {
            int ix = GetByID(itemid, index);
            return RemoveItem(ix, index);
        }

        public bool RemoveItemPerm(int itemid)
        {
            return RemoveItemPerm(itemid, 4);
        }

        public bool RemoveItemPerm(int itemid, byte index)
        {
            try
            {
                int ix = GetByID(itemid, index);

                if (ix != -1)
                {
                    if (index == 4)
                    {
                        slots[bags[index].items[ix].slot - 1] = 0;
                    }
                    else if (index == 0)
                    {
                        EquipSlots[bags[index].items[ix].slot - 1] = 0;
                    }

                    int id = bags[index].items[ix].itemid;
                    bags[index].items.RemoveAt(ix);

                    return true;
                }
            }
            catch (Exception ex)
            {

                log.Save(ex);
            }

            return false;
        }

        public bool RemoveItem(int ix, byte index)
        {
            if (ix != -1)
            {
                if (index == 4)
                {
                    slots[bags[index].items[ix].slot - 1] = 0;
                }
                else if (index == 0)
                {
                    EquipSlots[bags[index].items[ix].slot - 1] = 0;
                }

                int id = bags[index].items[ix].itemid;

                c.con.StartCommand("DELETE FROM bagitem WHERE itemid=? AND roleid=?;");

                c.con.AddValue(id);
                c.con.AddValue(c.rlid);

                if (c.con.ExecuteNoneQuery() < 1)
                {
                    SaveItemLog(4, bags[index].items[ix]);
                    return false;
                }

                bags[index].items.RemoveAt(ix);

                return true;
            }

            return false;
        }

        public Item GetItemByID(int itmid)
        {

            int id = GetByID(itmid);

            if (id != -1)
            {
                return GetItem(id);
            }

            return new Item();
        }
        public Item GetItem(int index)
        {
            return GetItem(index, 4);
        }

        public Item GetItem(int index, byte inx)
        {
            try
            {
                if (index == -1)
                    return new Item();
                return bags[inx].items[index];
            }
            catch (Exception ex)
            {
                log.Save(ex);

                return new Item();
            }
        }

        public Item GetItemByGrid(byte grid)
        {
            Item t;

            t = bags[4].items.Find(delegate(Item itm) { return itm.slot == grid; });
            return t;
        }

        /*  public void UpdateItem(Item itm, int index)
          {
              UpdateItem(itm, index, 4);
          }

          public void UpdateItem(Item itm, int index, byte inx)
          {

              try
              {
                 /* if (!AddItemCount(itm))
                  {
                      SaveItemLog(2, itm);
                      return false;
                  }*/
        /*    bags[inx].items[index] = itm;
        }
        catch (Exception ex)
        {
            log.Save(ex);
        }

    }*/

        public void UseItem(int itemid, byte count)
        {
            UseItem(itemid, count, 4);
        }

        public void UseItem(int itemid, byte count, byte index)
        {

            int ix = GetByID(itemid);
            if (ix != -1)
            {
                UseItem(count, index, ix);
            }
        }

        public bool UseItem(byte count, byte index, int ix)
        {
            Item itm = bags[index].items[ix];

            if (itm.count > count)
            {
                itm.count -= count;

                if (!AddItemCount(itm))
                {
                    SaveItemLog(2, itm);
                    return false;
                }
                bags[index].items[ix] = itm;
            }
            else
            {
                /* if (index == 4) slots[itm.slot - 1] = 0;
                 bags[index].items.RemoveAt(ix);
                 */
                RemoveItem(ix, index);
            }
            return true;
        }

        public bool UseType(int type, int count)
        {
            int c = count;
            List<int> remId = new List<int>();


            int cb = 0;
            for (int x = 0; x < bags[4].items.Count; x++)
            {
                if (bags[4].items[x].type == type)
                {
                    remId.Add(bags[4].items[x].itemid);
                    cb += bags[4].items[x].count;

                    if (cb >= c) break;
                }
            }

            if (cb < c) return false;

            int ix = 0;
            while (true)
            {

                ix = GetByID(remId[0]);


                if (c >= bags[4].items[ix].count)
                {
                    c = c - bags[4].items[ix].count;


                    /*slots[bags[4].items[ix].slot - 1] = 0;
                    bags[4].items.RemoveAt(ix);*/

                    RemoveItem(ix, 4);
                }
                else
                {
                    Item m = bags[4].items[ix];
                    m.count -= (byte)c;

                    if (!AddItemCount(m))
                    {
                        SaveItemLog(2, m);
                        return false;
                    }

                    bags[4].items[ix] = m;
                    c = 0;
                }
                remId.RemoveAt(0);

                if (c == 0) break;
                //   break;
            }

            return true;
        }

        public bool UseExplore(int type, int count, List<ExploreItem> ex)
        {
            int c = count;
            List<int> remId = new List<int>();


            int cb = 0;
            for (int x = 0; x < bags[4].items.Count; x++)
            {
                if (bags[4].items[x].type == type)
                {
                    remId.Add(bags[4].items[x].itemid);
                    cb += bags[4].items[x].count;

                    if (cb >= c) break;
                }
            }

            if (cb < c) return false;

            int ix = 0;
            int cc = 0;
            //int top = 0;
            while (true)
            {

                ix = GetByID(remId[0]);


                if (c >= bags[4].items[ix].count)
                {

                    for (byte i = 0; i < bags[4].items[ix].count; i++)
                    {
                        ExploreItem e = ex[cc];
                        e.bind = bags[4].items[ix].bind;
                        ex[cc] = e;
                        cc++;
                    }
                    c = c - bags[4].items[ix].count;


                    /* slots[bags[4].items[ix].slot - 1] = 0;
                     bags[4].items.RemoveAt(ix);*/
                    RemoveItem(ix, 4);


                }
                else
                {
                    Item m = bags[4].items[ix];
                    m.count -= (byte)c;

                    if (!AddItemCount(m))
                    {
                        SaveItemLog(2, m);
                        return false;
                    }

                    bags[4].items[ix] = m;


                    for (byte i = 0; i < c; i++)
                    {
                        ExploreItem e = ex[cc];
                        e.bind = bags[4].items[ix].bind;
                        ex[cc] = e;
                        cc++;
                    }
                    c = 0;

                }


                remId.RemoveAt(0);

                if (c == 0) break;
                //   break;
            }

            return true;
        }

        public bool ItemTypeExists(int type)
        {
            return ItemTypeExists(type, 4);
        }

        public bool ItemTypeExists(int type, byte id)
        {
            int ix = GetByType(type, id);

            return ix != -1;
        }

        public void UseGold(int cost)
        {
            if (bgold < cost)
            {
                cost = cost - bgold;
                bgold = 0;
                gold = gold - cost;

            }
            else
            {
                bgold = bgold - cost;
            }
        }

        public byte GetSplitCount(int type, byte num)
        {
            if (CanOverlap(type)) return 1;
            else return num;
        }

        public int TotalGold()
        {
            return gold + bgold;
        }

        public byte UseAllGold(int cost)
        {
            if (bgold > 0)
            {
                // bind = 2;

                if (bgold < cost)
                {
                    cost -= bgold;
                    bgold = 0;
                    gold -= cost;
                }
                else
                {
                    bgold -= cost;
                }
            }
            else
            {
                //  bind = 1;
                gold -= cost;
                return 1;
            }
            return 2;
        }

        public int GetTypeCount(int type)
        {
            return GetTypeCount(type, 4);
        }

        public int GetTypeCount(int type, byte id)
        {
            int cb = 0;
            for (int x = 0; x < bags[id].items.Count; x++)
            {
                if (bags[id].items[x].type == type)
                {
                    cb += bags[id].items[x].count;
                }
            }

            return cb;
        }

        public int GetTypeCount(int type, byte bind, byte id)
        {
            int cb = 0;
            for (int x = 0; x < bags[id].items.Count; x++)
            {
                if (bags[id].items[x].type == type && bags[id].items[x].bind == bind)
                {
                    cb += bags[id].items[x].count;
                }
            }

            return cb;
        }



        public byte UseTypeBind(int type, int count)
        {
            return UseTypeBind(type, count, 0);
        }

        public byte UseTypeBind(int type, int count, byte bindtype)
        {
            int c = count;
            List<int> remId = new List<int>();

            byte bind = 1;
            int cb = 0;

            if (bindtype == 0)
            {
                for (int x = 0; x < bags[4].items.Count; x++)
                {
                    if (bags[4].items[x].type == type)
                    {
                        remId.Add(bags[4].items[x].itemid);
                        cb += bags[4].items[x].count;

                        if (bind == 1 && bags[4].items[x].bind == 2)
                            bind = 2;

                        if (cb >= c) break;
                    }
                }
            }
            else
            {
                bind = bindtype;

                for (int x = 0; x < bags[4].items.Count; x++)
                {
                    if (bags[4].items[x].type == type && bags[4].items[x].bind == bindtype)
                    {
                        remId.Add(bags[4].items[x].itemid);
                        cb += bags[4].items[x].count;
                        if (cb >= c) break;
                    }
                }
            }


            int ix = 0;
            while (true)
            {

                ix = GetByID(remId[0]);


                if (c >= bags[4].items[ix].count)
                {
                    c = c - bags[4].items[ix].count;
                    RemoveItem(ix, 4);
                }
                else
                {
                    Item m = bags[4].items[ix];
                    m.count -= (byte)c;

                    if (!AddItemCount(m))
                    {
                        SaveItemLog(2, m);
                        return bind;
                    }

                    bags[4].items[ix] = m;
                    c = 0;
                }
                remId.RemoveAt(0);

                if (c == 0) break;
                //   break;
            }

            return bind;
        }

        public int GetByID(int id)
        {
            return GetByID(id, 4);
        }

        public int GetByID(int id, int index)
        {
            int ix = 0;
            ix = bags[index].items.FindIndex(
                delegate(Bag.Item m)
                {
                    return m.itemid == id;
                });

            return ix;
        }

        public int GetByType(int type)
        {
            return GetByType(type, 4);
        }

        public int GetByType(int type, int index)
        {
            int ix = 0;
            ix = bags[index].items.FindIndex(
                delegate(Bag.Item m)
                {
                    return m.type == type;
                });

            return ix;
        }


        public List<Item> lastinsert = new List<Item>();
        public bool enableins = false;

        public bool AddBagItem(int itemtype, byte count, byte bind)
        {
            // List<Bag.Item> it= new List<Item>();

            int ix = bags[4].items.FindIndex(
                delegate(Item itm)
                {
                    return itm.bind == bind && itemtype == itm.type && itm.count < 99;
                });

            Item m;

            byte store = (byte)(bags[4].max - bags[4].items.Count);
            if (store > 0)
            {
                bool canov = CanOverlap(itemtype);
                if (ix == -1 || !canov)
                {
                    if (!canov)
                    {
                        for (byte i = 0; i < count; i++)
                        {
                            // m = new Item(accounts.AccountHandler.NextItem(), itemtype, UseSlot(), count, 0, bind, 0);
                            Item itm = new Item(0, itemtype, UseSlot(), 1, 0, bind, 0);
                            //gamedata.GameItems.CopyProperties(ref itm);

                            int id = 0;

                            if (!BagAdd(itm, out id, 4))
                            {
                                return false;
                            }

                            itm.itemid = id;
                            bags[4].items.Add(itm);
                            if (enableins)
                                lastinsert.Add(itm);
                        }
                    }
                    else
                    {
                        m = new Item(0, itemtype, UseSlot(), count, 0, bind, 0);

                        // gamedata.GameItems.CopyProperties(ref m);

                        int id = 0;

                        if (!BagAdd(m, out id, 4))
                        {
                            return false;
                        }

                        m.itemid = id;

                        bags[4].items.Add(m);
                        if (enableins)
                            lastinsert.Add(m);
                    }
                    return true;
                }
                else
                {
                    int sp = count;
                    m = bags[4].items[ix];
                    m.count = (byte)(m.count + sp);


                    if (m.count < 100)
                    {
                        if (!AddItemCount(m))
                        {
                            SaveItemLog(2, m);
                            return false;
                        }
                        bags[4].items[ix] = m;
                        if (enableins)
                            lastinsert.Add(m);
                        return true;
                    }

                    sp = m.count - 99;
                    m.count = 99;

                    if (!AddItemCount(m))
                    {
                        SaveItemLog(2, m);
                        return false;
                    }

                    bags[4].items[ix] = m;

                    if (enableins)
                        lastinsert.Add(m);

                    return AddBagItem(itemtype, (byte)sp, bind);

                }
            }

            return false;
        }

        public bool UpdateBagItem(Item itm)
        {

            c.con.StartCommand("UPDATE bagitem SET ? WHERE itemid=? AND roleid=?;");

            c.con.AddValue(ContentResolver.DoSerializeUpdate<Item>(itm), true);
            c.con.AddValue(itm.itemid);
            c.con.AddValue(c.rlid);
            return c.con.ExecuteNoneQuery() > 0;
        }

        public bool UpdateBagSortedItem(Item itm)
        {

            itm.slot = UseSlot();

            if (UpdateBagItem(itm))
            {

                bags[4].items.Add(itm);

                return true;
            }
            // Reverse slot use
            slots[itm.slot - 1] = 0;


            SaveItemLog(1, itm);
            return false;
        }


        public bool UpdateBagSortedItemN(Item itm)
        {
            itm.slot = UseSlot();
            bags[4].items.Add(itm);
            return false;
        }

        /*
        public bool AddBagItem(Item itm)
        {
            if (!CanOverlap(itm.type))
            {
                itm.slot = UseSlot();

                bags[4].items.Add(itm);
            }
            else
            {
                return AddBagItem(itm.type, itm.count, itm.bind);
            }

            return true;
        }
        */


        public bool AddToExploreBag(int itemtype, byte count, byte bind)
        {
            int ix = bags[1].items.FindIndex(
                delegate(Item itm)
                {
                    return itm.bind == bind && itemtype == itm.type && itm.count < 99;
                });

            Item m;

            byte store = (byte)(bags[1].max - bags[1].items.Count);

            bool canov = CanOverlap(itemtype);
            if (ix == -1 || !canov)
            {
                if (!canov)
                {
                    for (byte i = 0; i < count; i++)
                    {
                        // m = new Item(accounts.AccountHandler.NextItem(), itemtype, UseSlot(), count, 0, bind, 0);
                        Item itm = new Item(0, itemtype, 1, 1, 0, bind, 0);
                        //gamedata.GameItems.CopyProperties(ref itm);
                        int id = 0;

                        if (!BagAdd(itm, out id, 1))
                        {
                            return false;
                        }

                        itm.itemid = id;
                        bags[1].items.Add(itm);
                    }
                }
                else
                {
                    m = new Item(0, itemtype, 1, count, 0, bind, 0);
                    //gamedata.GameItems.CopyProperties(ref m);
                    int id = 0;

                    if (!BagAdd(m, out id, 1))
                    {
                        return false;
                    }

                    m.itemid = id;

                    bags[1].items.Add(m);
                }
                return true;
            }
            else
            {
                int sp = count;
                m = bags[1].items[ix];
                m.count = (byte)(m.count + sp);


                if (m.count < 100)
                {

                    if (!AddItemCount(m))
                    {
                        SaveItemLog(2, m);
                        return false;
                    }

                    bags[1].items[ix] = m;
                    return true;
                }

                sp = m.count - 99;
                m.count = 99;

                if (!AddItemCount(m))
                {
                    SaveItemLog(2, m);
                    return false;
                }

                bags[1].items[ix] = m;
                return AddToExploreBag(itemtype, (byte)sp, bind);

            }

        }

        public bool BagAdd(Item m, out int id)
        {
            return BagAdd(m, out id, 4);
        }

        public bool BagAdd(Item m, out int id, byte bagtype)
        {
            string[] itemd = ContentResolver.DoSerializeInsert<Item>(m);

            c.con.StartCommand("INSERT INTO bagitem(?,bagtype,roleid) VALUES(?,?,?);");
            c.con.AddValue(itemd[0], true);

            c.con.AddValue(itemd[1], true);
            c.con.AddValue(bagtype);
            c.con.AddValue(c.rlid);
            itemd = null;
            if (c.con.ExecuteNoneQuery() < 1)
            {
                SaveItemLog(3, m);
                id = 0;
                return false;
            }

            id = (int)c.con.LastID;
            return true;
        }

        public bool AddItemNew(int type, byte num, byte bind, byte str)
        {
            Item m = new Item(0, type, UseSlot(), num, str, bind, 0);
            // gamedata.GameItems.CopyProperties(ref m);

            int id = 0;

            if (!BagAdd(m, out id))
            {
                return false;
            }

            m.itemid = id;
            bags[4].items.Add(m);
            return true;
        }

        // Former AddNew
        public bool ItemSplit(int ix, byte num)
        {
            Item m = bags[4].items[ix];
            m.count -= num;

            if (!AddItemCount(m))
            {
                c.ot.WriteShort(0);
                SaveItemLog(2, m);
                return false;
            }

            bags[4].items[ix] = m;

            m = new Item(0, bags[4].items[ix].type, UseSlot(), num, 0, bags[4].items[ix].bind, 0);
            // gamedata.GameItems.CopyProperties(ref m);


            int id = 0;

            if (!BagAdd(m, out id))
            {
                c.ot.WriteShort(0);
                return false;
            }

            m.itemid = id;
            bags[4].items.Add(m);


            c.ot.WriteShort(2);

            c.ot.WriteInt(bags[4].items[ix].itemid);
            c.ot.WriteInt(bags[4].items[ix].type);
            c.ot.WriteShort(bags[4].items[ix].slot);
            c.ot.WriteShort(bags[4].items[ix].count);
            c.ot.WriteShort(bags[4].items[ix].bind);
            c.ot.WriteShort(bags[4].items[ix].str);
            c.ot.WriteInt(bags[4].items[ix].overtime);

            c.ot.WriteInt(m.itemid);
            c.ot.WriteInt(m.type);
            c.ot.WriteShort(m.slot);
            c.ot.WriteShort(m.count);
            c.ot.WriteShort(m.bind);
            c.ot.WriteShort(m.str);
            c.ot.WriteInt(m.overtime);




            return true;


        }

        public bool MoveToBag(int itemid)
        {
            return MoveToBag(itemid, 5);
        }

        public bool MoveToBag(int itemid, byte index)
        {

            int ix = GetByID(itemid, index);

            if (ix == -1) return false;

            Item tmp = bags[index].items[ix];


            byte store = (byte)(bags[4].max - bags[4].items.Count);

            if (store > 0)
            {
                bags[index].items.RemoveAt(ix);

                return MoveToBag(tmp);
            }

            return false;
        }

        public bool MoveToBag(Item t)
        {
            int ix = bags[4].items.FindIndex(
                delegate(Item itm)
                {
                    return itm.bind == t.bind && t.type == itm.type && itm.count < 99;
                });

            if (ix == -1 || !CanOverlap(t.type) || t.count == 99)
            {
                t.slot = UseSlot();

                if (!BagMove(t.itemid, 4, t.slot))
                {
                    SaveItemLog(1, t);
                    return false;
                }

                bags[4].items.Add(t);
                return true;
            }
            else
            {
                int sp = t.count;
                Item m = bags[4].items[ix];
                m.count = (byte)(m.count + sp);


                if (m.count < 100)
                {

                    if (!AddItemCount(m))
                    {
                        SaveItemLog(2, m);
                        return false;
                    }

                    bags[4].items[ix] = m;
                    return true;
                }

                sp = m.count - 99;
                m.count = 99;

                if (!AddItemCount(m))
                {
                    SaveItemLog(2, m);
                    return false;
                }

                bags[4].items[ix] = m;

                t.count = (byte)sp;


                return MoveToBag(t);

            }

        }

        public bool MoveToInventory(int itemid)
        {

            int ix = GetByID(itemid);

            if (ix == -1) return false;

            Item tmp = bags[4].items[ix];


            byte store = (byte)(bags[5].max - bags[5].items.Count);

            if (store > 0)
            {
                slots[tmp.slot - 1] = 0;
                bags[4].items.RemoveAt(ix);

                return MoveToInventory(tmp);
            }

            return false;
        }

        public bool MoveToMarket(int itemid, int price, byte pricetype, byte duration)
        {

            c.con.StartCommand("UPDATE bagitem SET bagtype=13 , price=? , pricetype=?, overtime=?,overtimetype=? WHERE itemid=? AND roleid=?");

            c.con.AddValue(price);
            c.con.AddValue(pricetype);
            c.con.AddValue(DateUtil.GetHoursInt(duration));
            c.con.AddValue(duration);
            c.con.AddValue(itemid);
            c.con.AddValue(c.rlid);

            bool ex = c.con.ExecuteNoneQuery() > 0;


            if (ex)
            {
                ex = RemoveItemPerm(itemid);
            }

            return ex;
        }

        public bool TransferToBuyer(int itemid, int owner)
        {

            Item itm = new Item();
            c.con.StartCommand("SELECT itemid, typec, slot, countc, str, bind, overtime, basestats, extrastats, gems, gemcount, color, lvl,durability, luck FROM bagitem WHERE itemid=? AND roleid=? and bagtype=13;");
            c.con.AddValue(itemid);
            c.con.AddValue(owner);


            bool resl = ContentResolver.DoDeserialize<Bag.Item>(itm, c.con);

            if (resl)
            {
                c.con.StartCommand("UPDATE bagitem SET roleid=? WHERE itemid=? AND roleid=?");
                c.con.AddValue(c.rlid);

                c.con.AddValue(itemid);
                c.con.AddValue(owner);


                resl = c.con.ExecuteNoneQuery() > 0;

                if (resl)
                {
                    itm.overtime = 0;
                    resl = MoveToBag(itm);
                }
                else
                {
                    SaveItemLog(5, itm, owner, DatabaseInfo.GetConnection());
                }

            }


            return resl;

        }


        public bool UpdateMarketItem(int itemid, int price, byte pricetype, byte duration)
        {

            c.con.StartCommand("UPDATE bagitem SET price=? , pricetype=?, overtime=?,overtimetype=? WHERE itemid=? AND roleid=?");

            c.con.AddValue(price);
            c.con.AddValue(pricetype);
            c.con.AddValue(DateUtil.GetHoursInt(duration));
            c.con.AddValue(duration);
            c.con.AddValue(itemid);
            c.con.AddValue(c.rlid);

            return c.con.ExecuteNoneQuery() > 0;
        }

        public bool AddItemCount(Item itm)
        {
            return AddItemCount(itm.itemid, itm.count);
        }

        public bool AddItemCount(int itemid, byte count)
        {
            c.con.StartCommand("UPDATE bagitem SET countc=? WHERE itemid=? AND roleid=?;");
            c.con.AddValue(count);
            c.con.AddValue(itemid);
            c.con.AddValue(c.rlid);
            return c.con.ExecuteNoneQuery() > 0;
        }

        public bool BagMove(int itemid, byte bagid, byte slotid)
        {
            c.con.StartCommand("UPDATE bagitem SET bagtype=?,slot=?,overtime=0,overtimetype=0,price=0,pricetype=0 WHERE itemid=? AND roleid=?;");
            c.con.AddValue(bagid);
            c.con.AddValue(slotid);
            c.con.AddValue(itemid);
            c.con.AddValue(c.rlid);
            return c.con.ExecuteNoneQuery() > 0;
        }


        public bool MoveToInventory(Item t)
        {
            int ix = bags[5].items.FindIndex(
                delegate(Item itm)
                {
                    return itm.bind == t.bind && t.type == itm.type && itm.count < 99;
                });


            if (ix == -1 || !CanOverlap(t.type) || t.count == 99)
            {

                if (!BagMove(t.itemid, 5, t.slot))
                {
                    SaveItemLog(1, t);
                    return false;
                }

                slots[t.slot - 1] = 0;
                bags[5].items.Add(t);
                return true;
            }
            else
            {
                int sp = t.count;
                Item m = bags[5].items[ix];
                m.count = (byte)(m.count + sp);


                if (m.count < 100)
                {
                    if (!AddItemCount(m))
                    {
                        SaveItemLog(2, m);
                        return false;
                    }

                    bags[5].items[ix] = m;
                    return true;
                }

                sp = m.count - 99;
                m.count = 99;

                if (!AddItemCount(m))
                {
                    SaveItemLog(2, m);
                    return false;
                }

                bags[5].items[ix] = m;
                t.count = (byte)sp;

                return MoveToInventory(t);

            }
        }

        public bool SetItemSlot(int itemid, byte slotid)
        {
            c.con.StartCommand("UPDATE bagitem SET slot=? WHERE itemid=? AND roleid=?;");
            c.con.AddValue(slotid);
            c.con.AddValue(itemid);
            c.con.AddValue(c.rlid);
            return c.con.ExecuteNoneQuery() > 0;
        }

        public bool Swap(byte slot1, byte slot2)
        {
            int s1, s2;

            s1 = bags[4].items.FindIndex(delegate(Item s) { return slot1 == s.slot; });
            s2 = bags[4].items.FindIndex(delegate(Item s) { return slot2 == s.slot; });

            if (s1 == -1) return false;
            Item m = bags[4].items[s1];

            if (!SetItemSlot(m.itemid, slot2))
            {
                return false;
            }
            m.slot = slot2;

            bags[4].items[s1] = m;
            if (s2 != -1)
            {
                m = bags[4].items[s2];
                if (!SetItemSlot(m.itemid, slot1))
                {
                    return false;
                }

                m.slot = slot1;
                bags[4].items[s2] = m;
            }
            else
            {
                slots[slot2] = 1;
                slots[slot1] = 0;
            }


            return true;
        }

        public bool CanBagAdd(int num)
        {

            return (((int)(bags[4].max - bags[4].items.Count)) >= num);
        }

        public bool CanInventoryAdd(byte num)
        {

            return (((byte)(bags[5].max - bags[5].items.Count)) >= num);
        }

        public bool Load()
        {

            bool st = false;

            c.con.StartCommand("SELECT gold, bgold, crystal, bcrystal, bcount FROM bag WHERE roleid=? LIMIT 1;");
            c.con.AddValue(c.rlid);
            st = ContentResolver.DoDeserialize<Bag>(this, c.con);

            if (st == true)
            {
                // c.con.StartCommand("SELECT itemid, typec, slot, countc, str, bind, overtime, basestats, extrastats, gems, gemcount, color, lvl, luck,durability, bagtype FROM bagitem WHERE roleid=? and bagtype!=13;");
                c.con.StartCommand("SELECT * FROM bagitem WHERE roleid=? and bagtype!=13;");
                c.con.AddValue(c.rlid);

                Connector.DataReader rd = c.con.ExecuteRead();

                st = rd.CanRead;
                if (st)
                {
                    while (rd.NextRow())
                    {
                        Item itm = new Item();
                        ContentResolver.DoDeserializeLoop<Item>(itm, rd);
                        object v = rd.GetValue("bagtype");
                        byte id = Convert.ToByte(v);

                        bags[id].items.Add(itm);

                    }
                }
                rd.Close();
                rd = null;
            }
            // ByteC.LoadProto(c.accid + file, ref val);

            /* for (int i = 0; i < 6; i++)
             {*/
            bags[0].items.Sort((x, y) => x.slot.CompareTo(y.slot)); // sort equipment 
            bags[4].items.Sort((x, y) => x.slot.CompareTo(y.slot)); // sort bag items
            // }


            BuildSlots();
            BuildEquipSlots();

            return st;
        }

        public void BuildSlots()
        {
            slots = new byte[bags[4].max];
            for (int i = 0; i < bags[4].items.Count; i++)
            {
                slots[bags[4].items[i].slot - 1] = 1;
            }
        }

        public void BuildEquipSlots()
        {
            EquipSlots = new byte[15];
            for (int i = 0; i < bags[0].items.Count; i++)
            {
                EquipSlots[bags[0].items[i].slot - 1] = 1;
            }
        }

        public byte UseSlot()
        {
        reb: ;
            for (byte i = 0; i < slots.Length; i++)
            {
                if (slots[i] == 0)
                {
                    slots[i] = 1;
                    return (byte)(i + 1);
                }
            }

            if (bags[4].items.Count != bags[4].max)
            {
                BuildSlots();
                goto reb;
            }

            return 1;
        }

        public bool Save()
        {
            //ByteC.SaveProto(c.accid + file, this);

            c.con.StartCommand("UPDATE bag SET ? WHERE roleid=?;");
            c.con.AddValue(ContentResolver.DoSerializeUpdate<Bag>(this), true);
            c.con.AddValue(c.rlid);

            return c.con.ExecuteNoneQuery() > 0;
        }

        public static bool Create(int roleid)
        {
            ConnectionInfo c = new ConnectionInfo(roleid);
            c.con.StartCommand("INSERT INTO bag(roleid,gold,bgold,crystal,bcrystal,bcount) VALUES(?,?,?,?,?,?);");
            c.con.AddValue(roleid);
            c.con.AddValue(Game.Gold);
            c.con.AddValue(Game.BGold);
            c.con.AddValue(Game.Crystal);
            c.con.AddValue(Game.BCrystal);
            c.con.AddValue(new byte[] { 16, 0, 0, 0, 56, 6 });


            return c.con.ExecuteNoneQuery() > 0;
        }

    }

}
