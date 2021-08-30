using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{
    internal static class BagHelper
    {

        internal class OrganziedBag
        {

            //Dictionary<int,Dictionary<byte,item

            public List<Bag.Item> items { get; set; }

            public List<int> DeleteList { get; set; }
            public bool ChangedCount = false;

            public OrganziedBag(Bag.Item[] itemColl)
            {
                items = new List<Bag.Item>();
                items.AddRange(itemColl);
                DeleteList = new List<int>();

            }

            public bool Start()
            {
                items.Sort((x, y) => Compare(x, y));
                Bag.Item[] itemColl = items.ToArray();


                items.Clear();


                for (int x = 0; x < itemColl.Length; x++)
                {

                    if (items.Count == 0 || itemColl[x].count == 99 || !Bag.CanOverlap(itemColl[x].type))
                    {
                        items.Add(itemColl[x]);
                    }
                    else
                    {

                        int last = items.Count - 1;
                        if (items[last].count < 99 && items[last].type == itemColl[x].type && items[last].bind == itemColl[x].bind)
                        {
                            byte count = (byte)(items[last].count + itemColl[x].count);

                            if (count <= 99)
                            {

                                items[last].count = count;
                                DeleteList.Add(itemColl[x].itemid);

                                itemColl[x] = null; // no longer a need to keep you anymore

                            }
                            else
                            {
                                items[last].count = 99;
                                itemColl[x].count = (byte)(count - 99);
                                items.Add(itemColl[x]);

                                if (!ChangedCount)
                                    ChangedCount = true;

                            }

                        }
                        else
                        {
                            items.Add(itemColl[x]);
                        }
                    }

                }

                itemColl = null;
                return true;
            }

            internal static int Compare(Bag.Item x, Bag.Item y)
            {

                int r = 0;

                r = x.type.CompareTo(y.type);

                if (r == 0)
                {
                    r = x.bind.CompareTo(y.bind);

                    if (r == 0)
                    {
                        r = y.count.CompareTo(x.count);
                    }
                }


                return r;
            }

            public void Close()
            {
                items.Clear();
                DeleteList.Clear();
                
            }
        }

        internal static bool SortBag(ConnectionInfo c)
        {


            OrganziedBag or = new OrganziedBag(c.Player.bag.bags[4].items.ToArray());
            or.Start();
            int errors = 0;

            c.Player.bag.bags[4].items.Clear();
            c.Player.bag.BuildSlots();

                byte i;
                if (or.DeleteList.Count != 0 || or.ChangedCount)
                {


                    if (or.DeleteList.Count != 0)
                    {
                        string cmd = "DELETE FROM bagitem WHERE itemid=" + or.DeleteList[0].ToString() + " ";

                        for (i = 1; i < or.DeleteList.Count; i++)
                        {
                            cmd += " OR itemid=" + or.DeleteList[i].ToString() + " ";
                        }

                        if (c.con.ExecuteNoneQuery(cmd) < 1)
                        {
                            errors++;
                        }
                    }


                    for (i = 0; i < or.items.Count; i++)
                    {

                        Bag.Item itm = or.items[i];

                        c.Player.bag.UpdateBagSortedItemN(itm);


                        c.con.StartCommand("UPDATE bagitem SET slot=?,countc=? WHERE itemid=? AND roleid=?;");
                        c.con.AddValue(itm.slot);
                        c.con.AddValue(itm.count);
                        c.con.AddValue(itm.itemid);
                        c.con.AddValue(c.rlid);
                        c.con.PushCommand();
                    }

                    int result = c.con.ExecuteMassUpdate();

                    if (result == -1)
                    {
                        errors++;
                    }
                }
                else
                {
                    c.con.StartCommand("UpdateBagItemOrder(?);");
                    c.con.AddValue(c.rlid);
                    int casual = c.con.ExecuteNoneQueryp();

                    for (i = 0; i < or.items.Count; i++)
                    {
                        if (!c.Player.bag.UpdateBagSortedItemN(or.items[i]))
                        {
                            errors++;
                        }
                    }
                }

            or.Close();
            or = null;
            if (errors != 0)
            {
                log.Save("Item update errors, " + errors.ToString() + " For role: " + c.rlid.ToString());

            }
            return true;

        }

    }
}
