using System;
using GameServer.gameconfig;
using System.Collections;

namespace GameServer.Command
{

    internal static class MarketController
    {

        internal static void c27021(ConnectionInfo c)
        {
            // Program.Write(">Command invoked: " + "MarketController 27021");

            short pageindex = (short)c.ar.ReadShort();
            byte type = c.ar.ReadByte();
            byte subtype = c.ar.ReadByte();
            byte quality = c.ar.ReadByte();
            byte career = c.ar.ReadByte();
            byte level = c.ar.ReadByte();
            String name = c.ar.ReadString().Trim();

            string condition = "";

            #region Search Condition Code
            if (type > 0)
                condition += " AND i.typei=" + type.ToString();

            if (subtype > 0)
                condition += " AND i.subtypei=" + subtype.ToString();

            if (quality > 0)
                condition += " AND i.quality=" + (quality - 1).ToString();

            if (career > 0)
                condition += " AND i.career=" + career.ToString();

            if (level > 0)
                condition += " AND i.lvl=" + (level * 10).ToString();


            if (name != "" && name.Length > 0)
                condition += " AND i.name LIKE '%" + Connector.TypeUtil.GetType(name).Replace("'", "") + "%'";

            #endregion

            c.con.StartCommand("SELECT COUNT(*) FROM bagitem m INNER JOIN iteminfo i ON m.typec= i.itemid WHERE m.bagtype=13 AND overtime>? ?;");
            c.con.AddValue(DateUtil.GetDateInt());
            c.con.AddValue(condition, true);
            object o = c.con.ExecuteScalar();

            int count = o != null ? Convert.ToInt32(o) : 0;

            if (count > 0)
            {

                int fill = (pageindex - 1 * 10);
                if (fill < 0) fill = 0;


                int pages = count / 10;

                if (pages * 10 != count)
                    pages++;

                if (fill > pageindex)
                {
                    fill = (pages - 1) * 10;
                    pageindex = (short)(fill / 10);
                }


                c.con.StartCommand("SELECT m.itemid,m.typec,m.countc,m.pricetype,m.price,m.overtime,m.str FROM bagitem m INNER JOIN iteminfo i ON m.typec= i.itemid WHERE m.bagtype=13 AND overtime>? ? ORDER BY m.overtime DESC LIMIT ?,9;");
                c.con.AddValue(DateUtil.GetDateInt());
                c.con.AddValue(condition, true);
                c.con.AddValue(fill);
                Connector.DataReader rd = c.con.ExecuteRead();

                if (rd.CanRead)
                {

                    c.ot.WriteShort(pageindex);
                    c.ot.WriteShort(pages);
                    c.ot.WriteShort(rd.Rows);
                    while (rd.NextRow())
                    {

                        /*.WriteInt(a_EntryOrders);
                        ot.WriteInt(b_goodId);
                        ot.WriteInt(c_goodTypeId);
                        ot.WriteInt(d_goodCount);
                        ot.WriteByte(e_priceType);
                        ot.WriteInt(f_price);
                        ot.WriteInt(g_underTimer);
                        ot.WriteShort(h_addData);*/

                        int id = rd.ReadInt();
                        c.ot.WriteInt(id);
                        c.ot.WriteInt(id);
                        c.ot.WriteInt(rd.ReadInt());
                        c.ot.WriteInt(rd.ReadByte());
                        c.ot.WriteByte(rd.ReadByte());
                        c.ot.WriteInt(rd.ReadInt());
                        c.ot.WriteInt(rd.ReadInt());
                        c.ot.WriteShort(rd.ReadByte());

                    }
                }
                else
                {
                    c.ot.WriteBytes(new byte[6]);
                }
            }
            else
            {
                c.ot.WriteBytes(new byte[6]);
            }

            c.ot.PackArray(27021);


        }

        internal static void c27022(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " + "MarketController 27022");

            c.con.StartCommand("SELECT itemid,typec,countc,pricetype,price,overtime,str FROM bagitem WHERE roleid=? AND bagtype=13 ORDER BY overtime ;");
            c.con.AddValue(c.rlid);
            Connector.DataReader rd = c.con.ExecuteRead();


            if (rd.CanRead)
            {
                c.ot.WriteShort(rd.Rows);
                while (rd.NextRow())
                {


                    //itemid,typec,countc,pricetype,price,overtime,str
                    int id = rd.ReadInt();
                    c.ot.WriteInt(id);
                    c.ot.WriteInt(id);
                    c.ot.WriteInt(rd.ReadInt());
                    c.ot.WriteInt(rd.ReadByte());
                    c.ot.WriteByte(rd.ReadByte());
                    c.ot.WriteInt(rd.ReadInt());
                    c.ot.WriteInt(rd.ReadInt());
                    c.ot.WriteShort(rd.ReadByte());

                }
            }
            else
            {
                c.ot.WriteShort(0);
            }
            /*_loc6_ = GoodsBuilder.getData(_loc3_.c_goodTypeId);
            _loc6_.id = _loc3_.b_goodId;
            _loc6_.number = _loc3_.d_goodCount;
            _loc4_.goodsInfo = _loc6_;
            _loc6_.strengthen = _loc3_.h_addData.value;
            _loc4_.name = _loc6_.name;
            _loc4_.goodsInfo = _loc6_;
            _loc4_.OrdersId = _loc3_.a_RestingOrderId;
            _loc4_.price = _loc3_.f_price;
            _loc4_.color = _loc6_.color;
            _loc4_.underTimer = _loc3_.g_under;
            _loc4_.priceType = _loc3_.e_priceType.value;
            _loc4_.goodId = _loc3_.c_goodTypeId;*/

            /*ot.WriteInt(a_RestingOrderId);
            ot.WriteInt(b_goodId);
            ot.WriteInt(c_goodTypeId);
            ot.WriteInt(d_goodCount);
            ot.WriteByte(e_priceType);
            ot.WriteInt(f_price);
            ot.WriteInt(g_under);
            ot.WriteShort(h_addData);*/


            c.ot.PackArray(27022);
        }

        internal static void c27023(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " + "MarketController 27023");

            // buy item

            int itemid = c.ar.ReadInt();
            byte res = 3;

            c.con.StartCommand("SELECT price,pricetype,overtime, roleid FROM bagitem WHERE itemid=? AND bagtype=13;");
            c.con.AddValue(itemid);

            Connector.DataReader rd = c.con.ExecuteRead();


            if (rd.CanRead && rd.NextRow())
            {
                //byte duration = rd.ReadByte();
                int sell_price = rd.ReadInt();
                byte sell_type = rd.ReadByte();
                int overtime = rd.ReadInt();
                int roleid = rd.ReadInt();

                if (overtime > DateUtil.GetDateInt())
                {


                    if (roleid != c.rlid)
                    {

                        if (c.Player.bag.CanBagAdd(1))
                        {
                            if ((sell_type != 0 && sell_type != 1) || !MarketConfig.canSellCrystal)
                                sell_type = 0;

                            /*  if (duration != 6 && duration != 12 && duration != 24)
                                  duration = 6;*/

                            if (sell_price < 1)
                                sell_price = 1;


                            if (sell_type == 1)
                            {
                                if (c.Player.bag.crystal >= sell_price)
                                {
                                    if (c.Player.bag.TransferToBuyer(itemid, roleid))
                                    {
                                        c.Player.bag.crystal -= sell_price;
                                        c.Player.bag.Save();
                                        res = 0;

                                        Mail.OfflineMessage(roleid, "Market item purchase", "You have received crystal for your market item", 0, 0, sell_price, 0, 0, 0);

                                    }
                                }
                                else
                                {
                                    res = 2;
                                }
                            }
                            else
                            {
                                if (c.Player.bag.TotalGold() >= sell_price)
                                {
                                    if (c.Player.bag.TransferToBuyer(itemid, roleid))
                                    {
                                        c.Player.bag.UseAllGold(sell_price);
                                        c.Player.bag.Save();
                                        res = 0;

                                        Mail.OfflineMessage(roleid, "Market item purchase", "You have received gold for your market item", sell_price, 0, 0, 0, 0, 0);
                                    }

                                }
                                else
                                {
                                    res = 1;
                                }
                            }
                        }
                        else
                        {
                            res = 4;
                        }


                    }
                    else
                    {
                        res = 5;
                    }

                }
                else
                {
                    res = 6;
                }
            }

            c.ot.WriteByte(res);
            c.ot.PackArray(27023);
        }

        internal static void c27024(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " + "MarketController 27024");

            int itemid = c.ar.ReadInt();
            byte sell_type = c.ar.ReadByte();
            int sell_price = c.ar.ReadInt();
            byte duration = c.ar.ReadByte();

            byte res = 1;

            c.con.StartCommand("SELECT COUNT(*) FROM bagitem WHERE roleid=? AND bagtype=13 ORDER BY overtime;");
            c.con.AddValue(c.rlid);
            object o = c.con.ExecuteScalar();
            int count = o != null ? Convert.ToInt32(o) : 0;



            if (count < 5)
            {
                Bag.Item itm = c.Player.bag.GetItemByID(itemid);

                if ((sell_type != 0 && sell_type != 1) || !MarketConfig.canSellCrystal)
                    sell_type = 0;

                if (duration != 6 && duration != 12 && duration != 24)
                    duration = 6;

                if (sell_price < 1)
                    sell_price = 1;

                int fee = MarketConfig.Calculate(sell_price, sell_type, duration);

                if (itm != null)
                {
                    if (itm.bind == 1)
                    {
                        res = 3;
                        if (sell_type == 1)
                        {
                            if (c.Player.bag.crystal >= fee)
                            {

                                if (c.Player.bag.MoveToMarket(itemid, sell_price, sell_type, duration))
                                {
                                    c.Player.bag.crystal -= fee;
                                    c.Player.bag.Save();
                                    res = 0;
                                }
                                else
                                {
                                    res = 6;
                                }
                            }
                        }
                        else
                        {
                            if (c.Player.bag.TotalGold() >= fee)
                            {
                                if (c.Player.bag.MoveToMarket(itemid, sell_price, sell_type, duration))
                                {
                                    c.Player.bag.UseAllGold(fee);
                                    c.Player.bag.Save();
                                    res = 0;
                                }
                                else
                                {
                                    res = 6;
                                }
                            }

                        }
                    }
                    else
                    {
                        res = 4;
                    }
                }
                else
                {
                    res = 2;
                }
            }

            c.ot.WriteByte(res);
            c.ot.PackArray(27024);
        }

        
        internal static void c27025(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " + "MarketController 27025");


        }

        internal static void c27026(ConnectionInfo c)
        {
           // Program.Write(">Command invoked: " + "MarketController 27026");


        }

        internal static void c27027(ConnectionInfo c)
        {
            int orderid = c.ar.ReadInt();

            byte res = 1;


            if (c.Player.bag.CanBagAdd(1))
            {
                c.con.StartCommand("SELECT itemid, typec, slot, countc, str, bind, overtime, basestats, extrastats, gems, gemcount, color, lvl, luck,durability FROM bagitem WHERE itemid=? AND roleid=? and bagtype=13;");
                c.con.AddValue(orderid);
                c.con.AddValue(c.rlid);
                Bag.Item itm = new Bag.Item();


                if (ContentResolver.DoDeserialize<Bag.Item>(itm, c.con))
                {

                    itm.overtime = 0;
                    if (c.Player.bag.MoveToBag(itm))
                    {
                        res = 0;
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


            c.ot.WriteByte(res);
            c.ot.PackArray(27027);

        }

        internal static void c27028(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"MarketController 27028");

            // resale
            int itemid = c.ar.ReadInt();

            byte res = 3;

            c.con.StartCommand("SELECT overtimetype,price,pricetype,overtime FROM bagitem WHERE itemid=? AND roleid=? and bagtype=13;");
            c.con.AddValue(itemid);
            c.con.AddValue(c.rlid);

            Connector.DataReader rd = c.con.ExecuteRead();


            if (rd.CanRead && rd.NextRow())
            {
                byte duration = rd.ReadByte();
                int sell_price = rd.ReadInt();
                byte sell_type = rd.ReadByte();
                int overtime = rd.ReadInt();

                if (overtime < DateUtil.GetDateInt())
                {

                    if ((sell_type != 0 && sell_type != 1) || !MarketConfig.canSellCrystal)
                        sell_type = 0;

                    if (duration != 6 && duration != 12 && duration != 24)
                        duration = 6;

                    if (sell_price < 1)
                        sell_price = 1;

                    int fee = MarketConfig.Calculate(sell_price, sell_type, duration);

                    res = 1;
                    if (sell_type == 1)
                    {
                        if (c.Player.bag.crystal >= fee)
                        {

                            if (c.Player.bag.UpdateMarketItem(itemid, sell_price, sell_type, duration))
                            {
                                c.Player.bag.crystal -= fee;
                                c.Player.bag.Save();
                                res = 0;
                            }
                            else
                            {
                                res = 2;
                            }
                        }
                    }
                    else
                    {
                        if (c.Player.bag.TotalGold() >= fee)
                        {
                            if (c.Player.bag.UpdateMarketItem(itemid, sell_price, sell_type, duration))
                            {
                                c.Player.bag.UseAllGold(fee);
                                c.Player.bag.Save();
                                res = 0;
                            }
                            else
                            {
                                res = 2;
                            }
                        }

                    }

                }
                else
                {
                    res = 4;
                }

            }

            rd.Close();
            rd = null;

            c.ot.WriteByte(res);
            c.ot.PackArray(27028);
        }

    }
}
