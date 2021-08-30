using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{
    public class Buff
    {
        public bool IsActive=false;
        ConnectionInfo c;
    
        public class BuffItem
        {
            [ContentProto("buffid",true)]
            public int Type { get; set; }

            [ContentProto("endtime")]
            public int EndTime { get; set; }

            [ContentProto("starttime")]
            public int StartTime { get; set; }

            [ContentProto("buffvalue")]
            public int Count { get; set; }

            [ContentProto("bufftype")]
            public byte BuffType { get; set; }

            public BuffItem()
            {
            }
        }

        //const string file = "buff";


        public List<BuffItem> Buffs { get; set; } 

        public Buff(ConnectionInfo cc)
        {
            Buffs= new List<BuffItem>();
            c = cc;
        }


        public static int GetHPBuff(int id)
        {
            switch(id)
            {
                case 8010001:
                    return 2000;
                case 8010002:
                    return 3000;
                case 8010003:
                    return 5000;
                default:
                    return 0;
            }
        }

        public static int GetMpBuff(int id)
        {
            switch (id)
            {
                case 8020001:
                    return 800;
                case 8020002:
                    return 1200;
                case 8020003:
                    return 2000;
                default:
                    return 0;
            }

        }
        
        public bool MustUpdate(ByteArray ot)
        {

            if (Buffs.Count == 0) return false;

            BuffItem[] bfs = Buffs.ToArray();
            Buffs.Clear();
            bool modif = false;
            bool cp = false;
            for (int x = 0; x < bfs.Length;x++)
            {
                BuffItem bf = bfs[x];

                if (bf.BuffType == 1)
                {
                    cp= HP(ref bf);
                    if (cp == false)
                    {
                        Buffs.Add(bf);
                        c.currentScene.UpdatePlayerHp(c);
                        continue;
                    }
                    modif = true;
                }
                else if (bf.BuffType == 2)
                {
                    cp = MP(ref bf);
                    if (cp == false)
                    {
                        Buffs.Add(bf);
                        continue;
                    }
                    modif = true;
                }
                else
                {
                }



                if (bf.BuffType==1 ||bf.BuffType==2)
                {
                    if (bf.Count == 0)
                    {
                    }
                    else
                    {

                    }
                }

            }

            return modif;
           /* List<int> RemoveList = new List<int>();
            lock(Buffs)
            {
                foreach (BuffItem bf in Buffs)
                {
                    if (bf.Type == 1)
                    {
                        if(c.Player.combat.hp!=c.Player.combat.hp_lim)
                        {
                            // if set percent== 80 > 70
                            if (c.Player.auto.hp > (byte)(((double)c.Player.combat.hp / (double)c.Player.combat.hp_lim) * 100.00))
                            {
                                int hpval = GetHPBuff(bf.Type);

                                //lets say 300  200
                                if (hpval >= bf.Count)
                                {
                                    hpval = hpval - bf.Count;
                                    //bf = 0;
                                    RemoveList.Add(bf.Type);
                                }
                                else
                                {
                                }
                            }
                        }
                    }
                    else if (bf.Type == 2)
                    {
                    }
                    else
                    {
                    }
                        
                }

            }*/
           // return false;
        }

        public bool Add(BuffItem itm)
        {
            string[] val = ContentResolver.DoSerializeInsert<BuffItem>(itm);
            c.con.StartCommand("INSERT INTO buff(?,roleid) VALUES(?,?);");

            c.con.AddValue(val[0], true);
            c.con.AddValue(val[1], true);
            c.con.AddValue(c.rlid);

            return c.con.ExecuteNoneQuery()>0;
        }

        public bool Update(BuffItem itm)
        {

            c.con.StartCommand("UPDATE buff SET ? WHERE buffid=? AND roleid=?");

            c.con.AddValue(ContentResolver.DoSerializeUpdate<BuffItem>(itm), true);
            c.con.AddValue(itm.Type);
            c.con.AddValue(c.rlid);

            return c.con.ExecuteNoneQuery() > 0;
        }

        public bool Remove(int id)
        {
            int ind = c.Player.buff.Buffs.FindIndex(delegate(Buff.BuffItem bf) { return bf.Type==id; });
           // Buff.BuffItem bb;

            if (ind > -1)
            {
            
                c.con.StartCommand("DELETE FROM buff WHERE buffid=? AND roleid=?;");
                c.con.AddValue(id);
                c.con.AddValue(c.rlid);

                if (c.con.ExecuteNoneQuery() > 0)
                {
                    Buffs.RemoveAt(ind);
                    return true;
                }
            }

            return false;
        }

        public bool HP(ref BuffItem bf)
        {
            // if set percent== 80 > 70
            if (c.Player.auto.hp > (byte)(((double)c.Player.combat.hp / (double)c.Player.combat.hp_lim) * 100.00))
            {
                int hpval = GetHPBuff(bf.Type);

                //lets say 300  200
                if (hpval >= bf.Count)
                {
                    hpval = hpval - bf.Count;
                    //bf = 0;
                  //  RemoveList.Add(bf.Type);
                }
                else
                {
                }
            }
            return false;
        }

        public bool MP(ref BuffItem bf)
        {
            return false;
        }

        public bool Load()
        {

            c.con.StartCommand("SELECT buffid,starttime,endtime,buffvalue,bufftype FROM buff WHERE roleid=?");
            c.con.AddValue(c.rlid);

            Connector.DataReader rd = c.con.ExecuteRead();
            bool can = rd.CanRead;
            if (rd.CanRead)
            {

                while (rd.NextRow())
                {
                    BuffItem itm = new BuffItem();
                    itm.Type = rd.ReadInt();
                    itm.StartTime = rd.ReadInt();
                    itm.EndTime = rd.ReadInt();
                    itm.Count = rd.ReadInt();
                    itm.BuffType = rd.ReadByte();;

                    Buffs.Add(itm);
                }
            }
            return can;
        }

       /* public void Save(ConnectionInfo c)
        {
            ByteC.SaveProto(c.accid + file, this);
        }*/

        /*public static void Create(ConnectionInfo c)
        {
            Buff f = new Buff();
            f.Save(c);
            f = null;
        }*/

    }
}
