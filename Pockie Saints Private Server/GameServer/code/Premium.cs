using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{

    public class Premium
    {

        ConnectionInfo c;

        [ContentProto("chance")]
        public byte[] chancesb
        {
            get
            {
                ByteArray ar = new ByteArray();
                byte[] d = null;

                byte i = 0;

                for (i = 0; i < 3; i++)
                    ar.WriteInt(chances[i]);


                d = ar.GetByteArray();
                ar.Close();
                ar = null;
                return d;

            }
            set
            {
                if (value != null)
                {
                    ByteArray ar = new ByteArray(value);

                    for (byte i = 0; i < 3; i++)
                        chances[i] = ar.ReadInt();

                    ar.Close();
                    ar = null;
                }

            }
        }

        public int[] chances { get; set; }

        [ContentProto("discount")]
        public byte[] DiscountBuy { get; set; }

        [ContentProto("marketc")]
        public int MarketBuy { get; set; }

        [ContentProto("shopc")]
        public int ShopBuy { get; set; }

        [ContentProto("gearc")]
        public byte[] gearc
        {
            get
            {
                ByteArray ar = new ByteArray();
                byte[] d = null;

                byte i = 0;

                for (i = 0; i < 3; i++)
                {
                    ar.WriteByte(Gears[i].Count);
                    for (byte x = 0; x < Gears[i].Count; x++)
                    {
                        ar.WriteInt(Gears[i][x]);
                    }
                }

                d = ar.GetByteArray();
                ar.Close();
                ar = null;
                return d;
            }

            set
            {

                if (value != null)
                {
                    ByteArray ar = new ByteArray(value);
                    Gears = new ShuffleList<int>[3];
                    for (byte i = 0; i < 3; i++)
                    {
                        Gears[i] = new ShuffleList<int>();
                        byte v = ar.ReadByte();

                        for (byte x = 0; x < v; x++)
                        {
                            Gears[i].Add(ar.ReadInt());
                        }
                    }


                    ar.Close();
                    ar = null;

                }
            }
        }


        public ShuffleList<int>[] Gears { get; set; }


        public Premium(ConnectionInfo cc)
        {
            ShopBuy = 0;
            MarketBuy = 0;
            Gears = new ShuffleList<int>[3];
            chances = new int[3];
            DiscountBuy = new byte[3];

            byte i = 0;
            for (i = 0; i < 3; i++)
            {
                Gears[i] = new ShuffleList<int>();
            }
            c = cc;
        }

        public void Reset()
        {
            DiscountBuy[0] = 0;
            DiscountBuy[1] = 0;
            DiscountBuy[2] = 0;
            ShopBuy = 0;
        }

        public bool Load()
        {

            c.con.StartCommand("SELECT chance,discount,marketc,shopc,gearc FROM premium WHERE roleid=?;");
            c.con.AddValue(c.rlid);

            return ContentResolver.DoDeserialize<Premium>(this, c.con);
        }

        public bool Save()
        {

            c.con.StartCommand("UPDATE premium SET ? WHERE roleid=?;");
            c.con.AddValue(ContentResolver.DoSerializeUpdate<Premium>(this), true);
            c.con.AddValue(c.rlid);
            return c.con.ExecuteNoneQuery() > 0;
        }

        public static bool Create(byte career,int roleid)
        {
            ConnectionInfo c = new ConnectionInfo(roleid);
            ShuffleList<int>[] Gears = new ShuffleList<int>[3];

            byte i = 0;
            for (i = 0; i < 3; i++)
            {
                Gears[i] = new ShuffleList<int>();
            }

            for (i = 0; i < 6; i++)
            {
                Gears[0].Add(1020042 + career + (1000 * i));
                Gears[1].Add(1020063 + career + (1000 * i));
                Gears[2].Add(1020084 + career + (1000 * i));
            }

            ByteArray ar = new ByteArray();
            byte[] d = null;
            for (i = 0; i < 3; i++)
            {
                ar.WriteByte(Gears[i].Count);
                for (byte x = 0; x < Gears[i].Count; x++)
                {
                    ar.WriteInt(Gears[i][x]);
                }
            }

            d = ar.GetByteArray();
            ar.Close();
            ar = null;


            c.con.StartCommand("INSERT INTO premium(roleid,gearc) VALUES(?,?);"); 
            c.con.AddValue(roleid);
            c.con.AddValue(d);
          

            d = null;

            return c.con.ExecuteNoneQuery() > 0;
        }
    }
}
