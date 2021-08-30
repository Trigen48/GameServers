using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace GameServer.gamedata
{

    public class GameItem
    {
        public int agi;
        public int agile_limit;
        public double atk;
        public int attrition;
        public byte bind;
        public byte career_id;
        public short cd;
        public byte color;
        public double crit;
        public double def;
        public double dodge;
        public byte equip_type;
        public double extra;
        public int str;
        public int forza_limit;
        public int goods_id;
        public String goods_name;
        public double hit;
        public double hp;
        //public String icon;
        //public int img;
        public String intro;
        public byte job;
        public byte level;
        public byte max_hole;
        public byte max_overlap;
        public byte max_quality;
        public byte max_stren;
        public double mp;
        public int price;
        public byte price_type;
        public byte realm;
        public int sell;
        public int sell_price;
        public byte sex;
        public double speed;
        public int star;
        public byte subtype;
        public byte suit_id;
        public double fort;
        //public int throws ;
        public byte trade;
        public byte type;
        //public int vitality ;
        public int intl;
        public int wit_limit;

    }

    internal class GameItems
    {
        //internal static Dictionary<string, GameItem> items = new Dictionary<string, GameItem>();
       // internal static List<GameItem> items = new List<GameItem>();
        internal static Dictionary<int, GameItem> dic = new Dictionary<int, GameItem>();
        internal static bool Load()
        {

            Connector.MySqlConnector con = DatabaseInfo.GetConnection();
        
            dic = JsonLib.LoadFile<Dictionary<int, GameItem>>("system/gameitems.json");
            con.StartCommand("SELECT COUNT(*) FROM iteminfo");

            object o = con.ExecuteScalar();

            if (o != null)
            {

                if (Convert.ToInt32(o) != dic.Count)
                {
                    Console.WriteLine("Setting up item info. This may take time.");
                    con.StartCommand("DELETE FROM iteminfo");
                    con.ExecuteNoneQuery();


                    foreach (GameItem itm in dic.Values)
                    {
                        con.StartCommand("INSERT INTO iteminfo(itemid,name,typei,subtypei,quality,career,lvl) VALUES(?,?,?,?,?,?,?);");
                        con.AddValue(itm.goods_id);
                        con.AddValue(itm.goods_name);
                        con.AddValue(itm.type);
                        con.AddValue(itm.subtype);
                        con.AddValue(itm.color);
                        con.AddValue(itm.career_id);
                        con.AddValue(itm.level);
                        con.PushCommand();
                    }

                   int trans= con.ExecuteMassUpdate();

                   if (trans != -1)
                       return true;
           
                }
            }


            return false;
        }

        internal static void CopyProperties(ref Bag.Item itm)
        {
            try
            {
                GameItem itms = dic[itm.type];

                itm.Color = itms.color;
                itm.Level = itms.level;
                itm.setid = itms.suit_id;
                
                // this must be a weapon
                if (itms.equip_type != 0)
                {
                    //itm.BaseStats

                    itm.Gems = new int[3];
                    itm.BaseStats = new List<Bag.ItemStat>();
                    itm.ExtraStats = new List<Bag.ItemStat>();
                    //itm.Durability = (byte)itms.attrition;

                    if (itms.hp > 0)
                    {
                        itm.BaseStats.Add(new Bag.ItemStat(1, itms.hp));
                    }
                    if (itms.mp > 0)
                    {
                        itm.BaseStats.Add(new Bag.ItemStat(2, itms.mp));
                    }
                    if (itms.atk > 0)
                    {
                        itm.BaseStats.Add(new Bag.ItemStat(3, itms.atk));
                    }
                    if (itms.def > 0)
                    {
                        itm.BaseStats.Add(new Bag.ItemStat(4, itms.def));
                    }
                    if (itms.hit > 0)
                    {
                        itm.BaseStats.Add(new Bag.ItemStat(5, itms.hit));
                    }
                    if (itms.dodge > 0)
                    {
                        itm.BaseStats.Add(new Bag.ItemStat(6, itms.dodge));
                    }
                    if (itms.crit > 0)
                    {
                        itm.BaseStats.Add(new Bag.ItemStat(7, itms.crit));
                    }
                    if (itms.fort > 0)
                    {
                        itm.BaseStats.Add(new Bag.ItemStat(8, itms.fort));
                    }
                    if (itms.str > 0)
                    {
                        itm.BaseStats.Add(new Bag.ItemStat(11, itms.str));
                    }
                    if (itms.intl > 0)
                    {
                        itm.BaseStats.Add(new Bag.ItemStat(12, itms.intl));
                    }
                    if (itms.agi > 0)
                    {
                        itm.BaseStats.Add(new Bag.ItemStat(13, itms.agi));
                    }
                    if (itms.speed > 0)
                    {
                        itm.BaseStats.Add(new Bag.ItemStat(9, itms.speed));
                    }


                    ShuffleList<byte> slots = new ShuffleList<byte>();
                    byte i = 0;


                    if (itms.equip_type != 4)
                    {
                        if (itm.Color > 1)
                        {
                            if (itm.Color != 4)
                            {
                                if (itm.Color == 2)
                                {
                                    itm.gemcount = 1;
                                }
                                else
                                {
                                    for (i = 0; i < 25; i++)
                                        slots.Add(1);

                                    for (i = 0; i < 60; i++)
                                        slots.Add(2, true);

                                    for (i = 0; i < 15; i++)
                                        slots.Add(3, true);

                                    slots.ShuffleInplace();
                                    slots.ShuffleShift();
                                    itm.gemcount = slots.PopRandom();//slots[0];
                                }
                            }
                            else
                            {
                                itm.gemcount = 3;
                            }
                        }
                    }


                    // Set the costume 32
                    if (itms.equip_type == 4)
                    {
                        itm.ExtraStats.Add(new Bag.ItemStat(11, 32, 0, 0));
                        itm.ExtraStats.Add(new Bag.ItemStat(12, 32, 0, 0));
                        itm.ExtraStats.Add(new Bag.ItemStat(13, 32, 0, 0));
                    }

                }

            }
            catch (Exception ex)
            {
                log.Save(ex);
            }
        }


    }
}
