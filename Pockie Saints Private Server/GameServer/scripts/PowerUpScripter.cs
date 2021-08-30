using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{
    public static class PowerUpScripter
    {
       /* public static void Use(int ix, ConnectionInfo c,int num)
        {

            Bag.Item m = c.Player.bag.bags[4].items[ix];

            m.count = (byte)(m.count - num);

            if (m.count == 0)
            {
                c.Player.bag.slots[m.slot - 1] = 0;
                c.Player.bag.bags[4].items.RemoveAt(ix);
            }
            else
            {
                c.Player.bag.bags[4].items[ix] = m;
            }

        }*/

        public static bool Execute(int ix,int Item,ref int num,byte bind, ConnectionInfo c)
        {

            string file="scripts/"+Item.ToString()+".script";
            if(!System.IO.File.Exists(file)) return false;

            ByteArray ar= new ByteArray(file);
            
            switch (ar.ReadByte())
            {

                case 0: // exp
                    c.Player.bag.UseItem((byte)num, 4, ix);
                    CharExp(ar, num, c);
                    break;

                case 1:
                    c.Player.bag.UseItem((byte)num, 4, ix);
                    TrialUp(ar, num, c);
                    break;

                case 2:
                    c.Player.bag.UseItem((byte)num, 4, ix);
                    GoldUp(ar, num, bind, c);
                    break;

                case 3:
                    c.Player.bag.UseItem((byte)num, 4, ix);
                    return CrystaldUp(ar, num, bind, c);

                case 4:
                    if(BagdUp(ar, ref num, bind, c)==false) return false;
                    c.Player.bag.UseItem((byte)num, 4, ix);
                    break;

                case 5:
                    VipUp(ar, ref num, bind, c);
                    c.Player.bag.UseItem((byte)num, 4, ix);
                    break;

                case 6: //Hp
                    if (!HPUp(ar, c)) return false;
                    num = 1;
                    c.Player.bag.UseItem((byte)num, 4, ix);
                    c.Player.combat.Save();
                    c.currentScene.UpdatePlayerHp(c.Player.cc);
                    break;

                case 7://MP
                                     
                    if(!MPUp(ar, c)) return false;
                    num = 1;
                    c.Player.bag.UseItem((byte)num, 4, ix);
                    c.Player.combat.Save();
                    break;

                case 8:
                                        
                    if(!HpMpUp(ar, c)) return false;
                    num = 1;
                    c.Player.bag.UseItem((byte)num, 4, ix);
                    c.Player.combat.Save();
                    c.currentScene.UpdatePlayerHp(c.Player.cc);
                    break;

                case 9:
                                       
                    if(!MedalUp(ar,ref num, c)) return false;
                    c.Player.bag.UseItem((byte)num, 4, ix);
                    c.Player.combat.Save();

                    if (c.Player.quest.Qlist.ContainsKey(129002) &&c.Player.medal.GetPoints() >= 4)
                    {
                        c.Player.quest.RemoveQtask(129002);
                        c.Player.quest.AddTaskComplete(129002, 502006, 1, 1, 502);
                        c.Player.quest.Save();

                        ByteArray ss= new ByteArray();
                        
                        ss.WriteShort(4);
                        ss.WriteShort(30006);

                        c.Player.Send(ss.GetByteArray());
                        ss.Close();
                        Command.SceneController.UpdateNPC(c.Player.cc);
                        //return;
                    }
                    break;

                case 100:
                    if (!HpCrystalUp(ar, ref num, c,Item)) return false;
                    c.Player.bag.UseItem((byte)num, 4, ix);
                    //c.Player.buff.Save(c.Player.cc);

                    byte[] q=Command.BuffController.GetBuff(c);

                    if (q != null) c.Player.Send(q);
                    
                    break;

                case 101:
                    if (!MpCrystalUp(ar, ref num, c, Item)) return false;
                    c.Player.bag.UseItem((byte)num, 4, ix);
                    //c.Player.buff.Save(c.Player.cc);
                    
                    byte[] q2=Command.BuffController.GetBuff(c);

                    if (q2 != null) c.Player.Send(q2);
                    break;
                default:
                    return false;

            }

            //ar.Close();
            return true;
        }

        private static void CharExp(ByteArray ar, int num, ConnectionInfo c)
        {
            c.Player.role.exp += ar.ReadInt() * num;

            ar.Close();
            ar = new ByteArray();

            if (c.Player.role.LevelUp())
            {
                Command.RoleController.SendRoleUpgrade(c.Player.cc ,true);   
                //c.currentScene.LevelUp(c.Player.cc);
 
            }
            else
            {
                ar.WriteInt(c.Player.role.exp);

                ar.PackArray(13002);
                c.Player.Send(ar.GetByteArray());
            }
            ar.Close();
        }

        private static void TrialUp(ByteArray ar, int num, ConnectionInfo c)
        {

            c.Player.role.Trial += ar.ReadInt() * num;


            ar = new ByteArray();

            ar.WriteInt(c.Player.role.Trial);
            ar.PackArray(13020);
            c.Player.Send(ar.GetByteArray());
            ar.Close();
            
            //13024
        }
  
        private static void GoldUp(ByteArray ar, int num, byte bind, ConnectionInfo c)
        {

            if (bind == 2)
            {
              c.Player.bag.bgold += ar.ReadInt() * num;
            }
            else
            {
                c.Player.bag.gold += ar.ReadInt() * num;
            }

        }

        private static bool CrystaldUp(ByteArray ar, int num, byte bind, ConnectionInfo c)
        {

            int val=ar.ReadInt() * num;


            if (ar.ReadByte() == 1)
            {
                byte lev = ar.ReadByte();

                if (c.Player.role.level < lev)
                {
                    ar.Close();
                    return false;
                }

                int id = ar.ReadInt();

                if (!c.Player.bag.CanBagAdd(1))
                {
                    ar.Close();
                    return false;
                }

                if (!c.Player.bag.AddBagItem(id, (byte)num, bind))
                {
                    ar.Close();
                    return false;
                }

            }
            
          /*  if (bind == 2)
            {
                c.Player.bag.bcrystal += val;
            }
            else
            {*/
                c.Player.bag.bcrystal += val;
           // }

        


            return true;
        }

        private static bool BagdUp(ByteArray ar, ref int num,byte bind, ConnectionInfo c)
        {

            byte stor;
            if (ar.ReadByte() == 1)
            {
                stor= ar.ReadByte();



                if (c.Player.bag.bags[4].max != 147)
                {
                    List<byte> l = new List<byte>();
                    l.AddRange(c.Player.bag.slots);
                    if (num == 1)
                    {

                        if (c.Player.bag.bags[4].max + stor > 147)
                        {

                            l.AddRange(new byte[147 - c.Player.bag.bags[4].max]);
                            c.Player.bag.bags[4].max = 147;
                        }
                        else
                        {
                            l.AddRange(new byte[stor]);
                            c.Player.bag.bags[4].max += stor;
                        }

                        c.Player.bag.slots = l.ToArray();
                        l.Clear();
                        l = null;

                    }
                    else
                    {
                        if (num * stor > 147-c.Player.bag.bags[4].max)
                        {
                            int v = 147 - c.Player.bag.bags[4].max;

                            v /= stor;

                            if (v * stor < 147 - c.Player.bag.bags[4].max) v++;

                            num = v;
                            l.AddRange(new byte[147 - c.Player.bag.bags[4].max]);
                            c.Player.bag.bags[4].max = 147;
                        }
                        else
                        {
                            l.AddRange(new byte[(byte)(num * stor)]);
                            c.Player.bag.bags[4].max += (byte)(num*stor);
                            //c.Player.bag.bags[4].max += v*stor;
                        }

                        c.Player.bag.slots = l.ToArray();
                        l.Clear();
                        l = null;

                    }
                }
                else
                    return false;
            }
            else
            {
                 
                stor= ar.ReadByte();
                if (c.Player.bag.bags[5].max != 147)
                {
                    if (num == 1)
                    {

                        if (c.Player.bag.bags[5].max + stor > 147)
                        {
                            c.Player.bag.bags[5].max = 147;
                        }
                        else
                        {
                            c.Player.bag.bags[5].max += stor;
                        }

                    }
                    else
                    {
                        if (num * stor > 147-c.Player.bag.bags[5].max)
                        {
                            int v = 147 - c.Player.bag.bags[5].max;
                            v /= stor;
                            if (v * stor < 147 - c.Player.bag.bags[5].max) v++;
                            num = v;
                            c.Player.bag.bags[5].max = 147;
                        }
                        else
                        {
                            c.Player.bag.bags[5].max += (byte)(num * stor);
                        }
                    }
                    ar.Close();

                    ar = new ByteArray();

                    ar.WriteShort(1);
                    ar.WriteInt(0);
                    ar.WriteShort(0);
                    ar.PackArray(15041);
                    c.Player.Send(ar.GetByteArray());
                }

                else
                    return false;

            }


                ar.Close();
            return true;
        }

        private static bool VipUp(ByteArray ar, ref int num, byte bind, ConnectionInfo c)
        {

            byte lev= ar.ReadByte();

            int val;
            if(ar.ReadByte()==1)
            {
           
                val= ar.ReadByte()*num;
                c.Player.vip.vip_level = lev;
                c.Player.vip.time = (int)DateUtil.GetDaysIntZone(val);
            }
            else
            {
                 val = ar.ReadByte() * num;

                 c.Player.vip.vip_level = lev;
                 c.Player.vip.time = (int)DateUtil.GetMinutesIntZone(val);
            }

            c.Player.vip.Save();

            ar.Close();

            c.currentScene.UpdateChangeVip(c.Player.cc);

            ar = new ByteArray();
            ar.WriteByte(lev);
            ar.WriteInt(Vip.exps[lev]);
            ar.PackArray(25010);
            c.Player.Send(ar.GetByteArray());
            ar.Close();


            return true;
        }

        public static bool HPUp(ByteArray ar, ConnectionInfo c)
        {
            if (c.Player.combat.hp == c.Player.combat.hp_lim)
            {
                ar.Close();
                return false;
            }

            c.Player.combat.hp += ar.ReadInt();
            ar.Close();

            if (c.Player.combat.hp_lim < c.Player.combat.hp)
            {
                c.Player.combat.hp = c.Player.combat.hp_lim;
            }
            return true;
        }

        public static bool MPUp(ByteArray ar, ConnectionInfo c)
        {
            if (c.Player.combat.mp == c.Player.combat.mp_lim)
            {
                ar.Close();
                return false;
            }

            c.Player.combat.mp += ar.ReadInt();
            ar.Close();

            if (c.Player.combat.mp_lim < c.Player.combat.mp)
            {
                c.Player.combat.mp = c.Player.combat.mp_lim;
            }
            return true;
        }

        public static bool HpMpUp(ByteArray ar, ConnectionInfo c)
        {
            if (c.Player.combat.mp == c.Player.combat.mp_lim || c.Player.combat.hp == c.Player.combat.hp_lim)
            {
                ar.Close();
                return false;
            }

            c.Player.combat.hp += ar.ReadInt();          
            c.Player.combat.mp += ar.ReadInt();
            ar.Close();

            if (c.Player.combat.hp_lim < c.Player.combat.hp)
            {
                c.Player.combat.hp = c.Player.combat.hp_lim;
            }

            if (c.Player.combat.mp_lim < c.Player.combat.mp)
            {
                c.Player.combat.mp = c.Player.combat.mp_lim;
            }

            return true;
        }

        public static bool MedalUp(ByteArray ar, ref int num, ConnectionInfo c)
        {
            if (c.Player.medal.medal_lev == 0) return false;
            byte v = ar.ReadByte();
            int val = ar.ReadInt();
            ar.Close();

            int use=0;
            //int val = 0;
            if (v == 1)
            {
                v -= 1;
                if (c.Player.medal.medal_lev >= 30) return false;
                c.Player.medal.starsoul += num * val;
                //val = c.Player.medal.starsoul;
                c.Player.medal.SaveMedal();
            }
            else
            {
                v -= 2;
                if (c.Player.medal.Wings[v].WingStarSoul == MedalHelper.WingStarSoul[c.Player.medal.Wings[v].level] || c.Player.medal.Wings[v].level >= 12) return false;

                c.Player.medal.Wings[v].WingStarSoul += val * num;

                if (c.Player.medal.Wings[v].WingStarSoul > MedalHelper.WingStarSoul[c.Player.medal.Wings[v].level])
                {
                    use = c.Player.medal.Wings[v].WingStarSoul - MedalHelper.WingStarSoul[c.Player.medal.Wings[v].level];
                    c.Player.medal.Wings[v].WingStarSoul = MedalHelper.WingStarSoul[c.Player.medal.Wings[v].level];
                    num -= use / val;
                }
                use = c.Player.medal.Wings[v].WingStarSoul;

                c.Player.medal.SaveWing(v);

                v += 1;
            }

            

            ar = new ByteArray();

            ar.WriteShort(13);
            ar.WriteShort(18010);
            ar.WriteInt(c.Player.medal.starsoul);
            ar.WriteByte(v);
            ar.WriteInt(use);

            c.Player.Send(ar.GetByteArray());
            ar.Close();
            return true;
        }

        public static bool HpCrystalUp(ByteArray ar, ref int num, ConnectionInfo c,int itm)
        {

            int id=0;
            id = c.Player.buff.Buffs.FindIndex(delegate(Buff.BuffItem bf) { return bf.BuffType == 1; });
            Buff.BuffItem bb;

            if (id != -1)
            {

                bb = c.Player.buff.Buffs[id];

                if (bb.Type > itm) return false;

                int last=bb.Count;

                if (bb.Type != itm)
                {
                    bb.Type = itm;
                    bb.Count = ar.ReadInt() * num;
                }
                else
                {
                    bb.Count += ar.ReadInt() * num;

                }
                // c.Player.buff.Buffs[id] = bb;

                if (c.Player.buff.Update(bb))
                {
                    bb.Count = last;
                    return false;
                }
                c.Player.buff.Buffs[id] = bb;

            }
            else
            {
                bb = new Buff.BuffItem();

                bb.Type = itm;
                bb.BuffType = 1;
                bb.Count = ar.ReadInt();
                bb.StartTime = (int)DateUtil.GetDateIntZone();
                if (!c.Player.buff.Add(bb))
                    return false;

            }
            ar.Close();

            return true;
        }

        public static bool MpCrystalUp(ByteArray ar, ref int num, ConnectionInfo c,int itm)
        {
            int id = 0;
            id = c.Player.buff.Buffs.FindIndex(delegate(Buff.BuffItem bf) { return bf.BuffType == 2; });
            Buff.BuffItem bb;

            if (id != -1)
            {
                
                bb = c.Player.buff.Buffs[id];

                if (bb.Type > itm) return false;
                int last = bb.Count;

                if (bb.Type != itm)
                {
                    bb.Type = itm;
                    bb.Count = ar.ReadInt() * num;
                }
                else
                {
                    bb.Count += ar.ReadInt() * num;

                }

                if (c.Player.buff.Update(bb))
                {
                    bb.Count = last;
                    return false;
                }
                c.Player.buff.Buffs[id] = bb;
            }
            else
            {
                bb = new Buff.BuffItem();

                bb.Type = itm;
                bb.BuffType = 2;
                bb.Count = ar.ReadInt() * num;
                bb.StartTime = (int)DateUtil.GetDateIntZone();
                if (!c.Player.buff.Add(bb))
                    return false;
            }
            ar.Close();
            return true;
        }
    }
}
