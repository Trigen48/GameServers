using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{
    public class Packscripter
    {
        public int[] items;
        public byte[] quantity;
        private byte lvl = 0;

        public Packscripter(int data,int num)
        {
            ByteArray ar = new ByteArray("scripts/"+ data.ToString()+".script");


           byte type= ar.ReadByte(); // skip header


            switch(type)
            {
                case 1:
                    BuildPack(ar, num);
                    break;

                case 2:
                    BuildRandom(ar, num);
                    break;
            }

        }

        private void BuildPack(ByteArray ar,int num)
        {
            byte q = ar.ReadByte();

            List<int> it = new List<int>();
            List<byte> qt = new List<byte>();
            int id;
            int count;
            int c = 0;
            byte j;
            for (byte i = 0; i < q; i++)
            {
                id = ar.ReadInt();
                count = ar.ReadByte() * num;

                if (Bag.CanOverlap(id))
                {
                    if (count > 99)
                    {

                        c = count / 99;

                        count = count - (c * 99);

                        for (j = 0; j < c; j++)
                        {
                            it.Add(id);
                            qt.Add(99);
                        }

                        it.Add(id);
                        qt.Add((byte)count);
                    }
                    else
                    {
                        it.Add(id);
                        qt.Add((byte)count);
                    }
                }
                else
                {
                    for (j = 0; j < count; j++)
                    {
                        it.Add(id);
                        qt.Add(1);
                    }
                }

            }

            ar.Close();

            items = it.ToArray();
            quantity = qt.ToArray();


            it.Clear();
            qt.Clear();
            it = null;
            qt = null;
        }

        private void BuildRandom(ByteArray ar, int num)
        {

            byte count = (byte)ar.ReadShort();
            byte i = 0;
            byte q, c;
            List<ExploreItem> ch = new List<ExploreItem>();
            ShuffleList<byte> chance = new ShuffleList<byte>();


            for (i = 0; i < count; i++)
            {
                ExploreItem exp = new ExploreItem();
                exp.type = ar.ReadInt();
                exp.bind = ar.ReadByte();
                exp.count = ar.ReadByte();

                ch.Add(exp);
                q = ar.ReadByte();
                //ar.ReadByte();

                for (c = 0; c < q; c++)
                    chance.Add(i, true);
            }
            ar.Close();

            chance.ShuffleInplace();
            chance.ShuffleShift();
            chance.ShuffleInplace();


            List<ExploreItem> et = new List<ExploreItem>();
            Dictionary<int, ExploreItem> vex = new Dictionary<int, ExploreItem>(); ;
            for (i = 0; i < num; i++)
            {
                byte id = chance.SelectRandom();

                if (Bag.CanOverlap(ch[id].type))
                {

                    if (!vex.ContainsKey(ch[id].type))
                    {
                        vex.Add(ch[id].type, ch[id]);
                    }
                    else
                    {
                           
                        int cc = vex[ch[id].type].count + ch[id].count;

                        if (cc >= 99)
                        {


                           et.Add(new ExploreItem(ch[id].type, 99));


                           if (cc - 99 > 0)
                           {
                               ExploreItem ep = vex[ch[id].type];
                               ep.count = (byte)(cc - 99);
                               vex[ch[id].type] = ep;
                           }
                           else
                           {
                               vex.Remove(ch[id].type);
                           }
                        }
                        else
                        {
                            ExploreItem ep = vex[ch[id].type];
                            ep.count = (byte)cc;
                            vex[ch[id].type] = ep;

                        }
                    }
                }
                else
                {
                    et.Add(new ExploreItem(ch[id].type, ch[id].count));
                }

            }

            foreach (ExploreItem ex in vex.Values)
            {
                et.Add(ex);
            }

            chance.Clear(); chance = null;
            ch.Clear();ch = null;
            vex.Clear();vex = null;

            items = new int[et.Count];
            quantity = new byte[et.Count];

            for (i = 0; i < et.Count; i++)
            {
                items[i] = et[i].type;
                quantity[i] = et[i].count;
            }
            et.Clear();

            et = null;


        }

        public byte LevelReq()
        {
            return lvl;
        }

        public byte GetCounts()
        {
            return (byte)items.Length;
        }

        public void Close()
        {
            items = null;
            quantity = null;
        }

    }
}
