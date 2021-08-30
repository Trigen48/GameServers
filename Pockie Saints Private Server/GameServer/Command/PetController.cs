using System;

using System.Collections;

namespace GameServer.Command
{

    internal static class PetController
    {

        internal static void c41000(ConnectionInfo c)
        {
            //	Program.Write(">Command invoked: " +"PetController 41000");
        }

        internal static void c41001(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"PetController 41001");

            int itemid = c.ar.ReadInt();
            byte num = (byte)c.ar.ReadShort();

            int ix = c.Player.bag.GetByID(itemid);
            byte res = 2;

            if (ix != -1)
            {

                Bag.Item itm = c.Player.bag.bags[4].items[ix];

                if (itm.type.ToString().StartsWith("3010"))
                {
                    c.Player.bag.UseItem(itemid, 1);
                    // c.Player.bag.RemoveByID(itemid);

                    byte lev = 0;

                    if (itm.type >= 3010013 && itm.type != 3010033) lev = 3;

                    itemid = c.Player.pet.CreatePet(itm.type, lev, c.Player.role.career);
                    res = 1;
                    //c.Player.bag.Save();
                    //c.Player.pet.Save();
                }
                else
                {
                    res = 0;
                }

            }
            else
            {
                itemid = 0;
            }


            c.ot.WriteShort(res);
            c.ot.WriteInt(itemid);
            c.ot.WriteString("");
            c.ot.PackArray(41001);
        }

        internal static void c41002(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"PetController 41002");

            int id = c.ar.ReadInt();
            int key = Pet.ToId(id,c.Player.role.career);
            byte res = 2;
            if (c.Player.pet.pets.ContainsKey(key))
            {
                c.Player.pet.pets.Remove(key);

                if (key == c.Player.pet.CurrentPet)
                    c.Player.pet.ResetPet();

                c.Player.Save();
                res = 1;
            }



            c.ot.WriteShort(res);
            c.ot.WriteInt(id);
            c.ot.PackArray(41002);
        }

        internal static void c41003(ConnectionInfo c)
        {
            //	Program.Write(">Command invoked: " +"PetController 41003");

            int id = Pet.ToId(c.ar.ReadInt(), c.Player.role.career);
            string name = c.ar.ReadString();

            int res = 2;

            if (c.Player.pet.pets.ContainsKey(id))
            {
                Pet.PetItem p = c.Player.pet.pets[id];
                p.name = name;
                p.RenameCount++;

              //  c.Player.pet.pets[id] = p;
                c.Player.pet.Update(p);

               /* if (id == c.Player.pet.CurrentPet)
                    c.Player.pet.UpdatePet();*/

                c.Player.pet.Save();

                res = 1;
            }

            c.ot.WriteShort(res);
            c.ot.WriteInt(Pet.ToModule(id,c.Player.role.career));
            c.ot.WriteString(name);
            c.ot.WriteShort(0);
            c.ot.WriteInt(0);

            c.ot.PackArray(41003);
            c.currentScene.UpdatePet(c);
        }

        internal static void c41004(ConnectionInfo c)
        {
            int id = c.ar.ReadInt();
            int pid = Pet.ToId(id, c.Player.role.career);
            byte res = 2;

            if (c.Player.pet.pets.ContainsKey(pid))
            {
                if (c.Player.pet.pets[pid].joy > 0)
                {
                    c.Player.pet.SetDefualtPet(pid);
                    res = 1;
                   // c.Player.pet.Save();
                }
                else
                {
                    res = 3;
                }

            }

            c.ot.WriteShort(res);
            c.ot.WriteInt(id);
            c.ot.WriteShort(res == 1 ? c.Player.pet.pets[pid].isActive : 0);
            c.ot.PackArray(41004);

            if (res == 1)
            {
                c.Player.combat.Compute(true);
                c.currentScene.UpdatePlayerHp(c);
                c.currentScene.UpdatePet(c);
            }
        }

        internal static void c41005(ConnectionInfo c)
        {


            int id = c.ar.ReadInt();
            byte res = 2;

            if (c.Player.pet.pets.ContainsKey(Pet.ToId(id, c.Player.role.career)))
            {
                c.Player.pet.ResetPet();
                res = 1;
                //c.Player.pet.Save();
            }

            c.ot.WriteShort(res);
            c.ot.WriteInt(id);
            c.ot.PackArray(41005);

            if (res == 1)
            {
                c.Player.combat.Compute(true);
                c.currentScene.UpdatePlayerHp(c);
                c.currentScene.UpdatePet(c);
            }
        }

        internal static void c41006(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " + "PetController 41006");

            int id = c.ar.ReadInt();
            byte type = (byte)c.ar.ReadShort();

            int pid = Pet.ToId(id, c.Player.role.career);
            int cost = 0;
            byte res = 2;
                Pet.PetItem pt = c.Player.pet.GetPet(pid);

            if (pt.PetID == pid)
            {


                cost = (((pt.str_base + pt.intl_base + pt.agi_base) * 16) - 110);


                if (c.Player.bag.TotalGold() >= cost)
                {

                    c.Player.bag.UseGold(cost);
                    ShuffleList<short> cool = new ShuffleList<short>();

                    cool.AddRange(new short[] { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 });
                    cool.ShuffleInplace();
                    cool.ShuffleShift();


                    pt.agi_new = (short)(pt.agi_base + cool.SelectRandom());
                    pt.str_new = (short)(pt.str_base + cool.SelectRandom());
                    pt.intl_new = (short)(pt.intl_base + cool.SelectRandom());

                    short max= Pet.StatMax[pt.quality];



                    cool.Clear();
                    cool = null;

                    if (pt.agi_new < 0)
                        pt.agi_new = 0;
                    else if (pt.agi_new > max)
                        pt.agi_new = max;


                    if (pt.intl_new < 0)
                        pt.intl_new = 0;
                    else if (pt.intl_new > max)
                        pt.intl_new = max;

                    if (pt.str_new < 0)
                        pt.str_new = 0;
                    else if (pt.str_new > max)
                        pt.str_new = max;

                    c.Player.pet.Update(pt);
                    c.Player.pet.Save();
                    c.Player.bag.Save();
                    res = 1;
                }
                else
                {
                    res = 5;
                }




            }


            c.ot.WriteShort(res);
            c.ot.WriteInt(id);
            c.ot.WriteShort(type);
            c.ot.WriteShort(pt.str_new);
            c.ot.WriteShort(pt.intl_new);
            c.ot.WriteShort(pt.agi_new);
            c.ot.WriteInt(c.Player.bag.gold);
            c.ot.WriteInt(c.Player.bag.bgold);
            c.ot.PackArray(41006);
        }

        internal static void c41007(ConnectionInfo c)
        {
          //  Program.Write(">Command invoked: " + "PetController 41007");

            int id = c.ar.ReadInt();
            byte type = (byte)c.ar.ReadShort();

            int pid = Pet.ToId(id, c.Player.role.career);
      
            byte res = 2;
            Pet.PetItem pt = c.Player.pet.GetPet(pid);

            if (pt.PetID == pid)
            {

                if (pt.agi_new != 0 && pt.intl_base != 0 && pt.str_new != 0)
                {

                    pt.str_base = pt.str_new;
                    pt.agi_base = pt.agi_new;
                    pt.intl_base = pt.intl_new;

                    pt.agi_new = 0;
                    pt.intl_new = 0;
                    pt.str_new = 0;


                    c.Player.pet.Update(pt);
                    c.Player.pet.Save();
                    res = 1;
                }
                else
                {
                    res = 5;
                }
               
            }


            c.ot.WriteShort(res);
            c.ot.WriteInt(id);
            c.ot.WriteShort(type);
            c.ot.WriteShort(pt.str_base);
            c.ot.WriteShort(pt.intl_base);
            c.ot.WriteShort(pt.agi_base);
            c.ot.PackArray(41007);
        }

        internal static void c41012(ConnectionInfo c)
        {
            int pid = c.ar.ReadInt();
            int itmid = c.ar.ReadInt();
            byte num = (byte)c.ar.ReadShort();
            int key = Pet.ToId(pid, c.Player.role.career);
            byte res = 6;

            int ix = -1;
            ix = c.Player.bag.GetByID(itmid);

            if (ix != -1)
            {
                Bag.Item t = c.Player.bag.GetItem(ix);
                int joy = Pet.GetJoyValue(t.type);

                if (joy != 0)
                {
                    if (t.count >= num)
                    {

                        Pet.PetItem p = c.Player.pet.GetPet(key);
                        if (p.PetID != 0)
                        {
                            if (p.joy < p.Joy_lim)
                            {

                                joy = joy * num;

                                p.joy += (short)joy;

                                if (p.joy > p.Joy_lim) p.joy = p.Joy_lim;


                                c.Player.pet.Update(p);
                                c.Player.pet.Save();
                                c.Player.bag.UseItem(t.itemid, num);
                                //c.Player.bag.Save();
                                res = 1;
                            }
                            else
                            {
                                res = 5;
                            }
                        }
                        else
                        {
                            res = 3;
                        }
                    }
                    else
                    {
                        res = 9;
                    }
                }
                else
                {
                    res = 8;
                }


            }


            c.ot.WriteShort(res);
            c.ot.WriteInt(pid);
            c.ot.WriteShort(c.Player.pet.GetPet(key).joy);
            c.ot.PackArray(41012);


        }

        internal static void c41013(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "PetController 41013");


        }

        internal static void c41014(ConnectionInfo c)
        {


            int id = c.ar.ReadInt();
            int key = Pet.ToId(id, c.Player.role.career);
            byte res = 10;
            int lucks = 0;

            bool newlev = false;
            Pet.PetItem p = new Pet.PetItem();
            if (c.Player.pet.pets.ContainsKey(key))
            {
                byte tot = c.Player.pet.GetLevel(key);

                int[] Indo = Pet.PetUp[tot];

                int total = c.Player.bag.GetTypeCount(Indo[0]);

                p = c.Player.pet.GetPet(key);
                if (p.quality < 9)
                {
                    if (total >= Indo[1])
                    {
                        p.Luck += 5;
                        double luck = (((double)p.Luck) / (double)Indo[2]);
                        c.Player.bag.UseType(Indo[0], Indo[1]);
                        if (c.Player.chance.NoviceChance(luck))
                        {
                            p.starLv++;
                            p.Luck = 0;
                            res = 1;

                            if (p.starLv == 10)
                            {
                                p.starLv = 0;
                                p.quality++;
                                newlev = true;
                            }

                        }
                        else
                        {
                            lucks = p.Luck;
                        }

                        c.Player.pet.Update(p);

                        c.Player.pet.Save();
                        //c.Player.bag.Save();
                    }
                    else
                    {
                        res = 9;
                    }

                }
                else
                {
                    res = 5;
                }

            }


            c.ot.WriteByte(res);
            c.ot.WriteShort(lucks);
            c.ot.PackArray(41014);

            if (res == 1)
            {
                c.Player.combat.Compute(true);
                c.currentScene.UpdatePlayerHp(c); 


                if (newlev)
                {
                    c.currentScene.UpdatePet(c);
                }

                if (p.quality >= 5)
                    World.Banner.SysSend(c, p.name + "#&" + p.quality.ToString() + "#&" + p.quality.ToString() + "#&" + p.starLv.ToString(), 11);

                c.ot.WriteShort(6);
                c.ot.WriteShort(41000);
                c.ot.WriteShort(1);
            }
        }

        internal static void c41015(ConnectionInfo c)
        {

            byte res = 2;

            if (c.Player.pet.JoyTimer < DateUtil.GetDateIntZone())
            {
                Pet.PetItem p = c.Player.pet.GetPet();

                if (p.PetID == 0) return;


                if (p.joy < 0) p.joy = 0;
                p.joy -= 10;
                c.Player.pet.Update(p);
                c.Player.pet.JoyTimer = (int)DateUtil.GetDateIntZone() + 50;
                c.Player.pet.Save();
                res = 1;
            }

            int joy = c.Player.pet.GetPet().joy;
            c.ot.WriteShort(res);
            c.ot.WriteShort(0);
            c.ot.WriteInt(Pet.ToModule(c.Player.pet.GetPet().PetID, c.Player.role.career));
            c.ot.WriteShort(joy);
            c.ot.WriteShort(0);
            c.ot.PackArray(41015);

        }

        internal static void c41016(ConnectionInfo c)
        {
            int a_id, b_role;
            a_id = c.ar.ReadInt();
            b_role = c.ar.ReadInt();

            int key = a_id;

            RoleControl rl = Players.GetPlayer(b_role);
            if (rl != null)
            {

                if (key > ((b_role + 1) * 100)) key = Pet.ToId(key, rl.role.career);
                if (rl.pet.pets.ContainsKey(key))
                {
                    c.ot.WriteShort(1);
                    c.ot.WriteInt(c.rlid);
                    c.ot.WriteInt(rl.pet.pets[key].PetID);
                    c.ot.WriteByte(rl.pet.pets[key].career);
                    c.ot.WriteString(rl.pet.pets[key].name);
                    c.ot.WriteShort(rl.pet.pets[key].RenameCount);
                    c.ot.WriteShort(rl.pet.pets[key].level);
                    c.ot.WriteShort(rl.pet.pets[key].quality);

                    c.ot.WriteShort(rl.pet.pets[key].f_strength);
                    c.ot.WriteShort(rl.pet.pets[key].g_wit);
                    c.ot.WriteShort(rl.pet.pets[key].h_agility);


                    c.ot.WriteShort(rl.pet.pets[key].str_base);
                    c.ot.WriteShort(rl.pet.pets[key].intl_base);
                    c.ot.WriteShort(rl.pet.pets[key].agi_base);

                    c.ot.WriteShort(rl.pet.pets[key].str_new);
                    c.ot.WriteShort(rl.pet.pets[key].intl_new);
                    c.ot.WriteShort(rl.pet.pets[key].agi_new);

                    c.ot.WriteBytes(new byte[8]);
                    /*  c.ot.WriteShort(rl.pet.pets[key].o_aptitudeStrength);
                      c.ot.WriteShort(rl.pet.pets[key].p_aptitudeWit);

                      c.ot.WriteShort(rl.pet.pets[key].q_aptitudeAgility);

                      c.ot.WriteShort(rl.pet.pets[key].r_maxAptitude);*/

                    c.ot.WriteShort(rl.pet.pets[key].joy);
                    c.ot.WriteShort(rl.pet.pets[key].isActive);
                    c.ot.WriteShort(rl.pet.pets[key].w_fightPos);
                    c.ot.WriteShort(rl.pet.pets[key].Joy_lim);
                    c.ot.WriteInt(rl.pet.pets[key].PetType);
                    c.ot.WriteInt(rl.pet.pets[key].starLv);
                    c.ot.WriteInt(rl.pet.pets[key].Luck);
                    c.ot.WriteInt(rl.pet.pets[key].exp);
                    c.ot.WriteInt(Pet.ExpMax((byte)rl.pet.pets[key].level));// rl.pet.pets[key].z03_expMax);
                    c.ot.WriteInt(rl.pet.pets[key].Hp);
                    c.ot.WriteInt(rl.pet.pets[key].Mp);
                    c.ot.WriteInt(rl.pet.pets[key].Atk);
                    c.ot.WriteInt(rl.pet.pets[key].Def);
                    c.ot.WriteInt(rl.pet.pets[key].Hit);
                    c.ot.WriteInt(rl.pet.pets[key].Dod);
                    c.ot.WriteInt(rl.pet.pets[key].Crit);
                    c.ot.WriteInt(rl.pet.pets[key].Fort);
                    c.ot.WriteShort(Pet.SkillSlot[rl.pet.pets[key].quality]);
                    c.ot.WriteShort(rl.pet.pets[key].skills.Count);

                    foreach (Pet.PetSkill sk in rl.pet.pets[key].skills)
                    {
                        c.ot.WriteInt(sk.ID);
                        c.ot.WriteByte(sk.Level);
                    }

                    c.ot.WriteInt(rl.pet.pets[key].z15_specialSkillId);
                }
                else
                {
                    c.ot.WriteShort(2);
                    c.ot.WriteBytes(new byte[150]);
                }
            }
            else
            {
                c.ot.WriteShort(2);
                c.ot.WriteBytes(new byte[150]);
            }
            // c.ot.PackArray(41016);


            c.ot.PackArray(41016);
        }

        internal static void c41017(ConnectionInfo c)
        {
            int rid = c.ar.ReadInt();

            c.ot.WriteShort(1);

            RoleControl rl = Players.GetPlayer(rid);

            c.ot.WriteShort(rl.pet.pets.Count);
            foreach (int key in rl.pet.pets.Keys)
            {
                c.ot.WriteInt(c.rlid);
                c.ot.WriteInt(rl.pet.pets[key].PetID);
                c.ot.WriteByte(rl.pet.pets[key].career);
                c.ot.WriteString(rl.pet.pets[key].name);
                c.ot.WriteShort(rl.pet.pets[key].RenameCount);
                c.ot.WriteShort(rl.pet.pets[key].level);
                c.ot.WriteShort(rl.pet.pets[key].quality);

                c.ot.WriteShort(rl.pet.pets[key].f_strength);
                c.ot.WriteShort(rl.pet.pets[key].g_wit);
                c.ot.WriteShort(rl.pet.pets[key].h_agility);

                c.ot.WriteShort(rl.pet.pets[key].str_base);
                c.ot.WriteShort(rl.pet.pets[key].intl_base);
                c.ot.WriteShort(rl.pet.pets[key].agi_base);

                c.ot.WriteShort(rl.pet.pets[key].str_new);
                c.ot.WriteShort(rl.pet.pets[key].intl_new);
                c.ot.WriteShort(rl.pet.pets[key].agi_new);

                c.ot.WriteBytes(new byte[8]);
              /*  c.ot.WriteShort(rl.pet.pets[key].o_aptitudeStrength);
                c.ot.WriteShort(rl.pet.pets[key].p_aptitudeWit);
                c.ot.WriteShort(rl.pet.pets[key].q_aptitudeAgility);

                c.ot.WriteShort(rl.pet.pets[key].r_maxAptitude);*/

                c.ot.WriteShort(rl.pet.pets[key].joy);
                c.ot.WriteShort(rl.pet.pets[key].isActive);
                c.ot.WriteShort(rl.pet.pets[key].w_fightPos);
                c.ot.WriteShort(rl.pet.pets[key].Joy_lim);
                c.ot.WriteInt(rl.pet.pets[key].PetType);
                c.ot.WriteInt(rl.pet.pets[key].starLv);
                c.ot.WriteInt(rl.pet.pets[key].Luck);
                c.ot.WriteInt(rl.pet.pets[key].exp);
                c.ot.WriteInt(Pet.ExpMax((byte)rl.pet.pets[key].level));// rl.pet.pets[key].z03_expMax);
                c.ot.WriteInt(rl.pet.pets[key].Hp);
                c.ot.WriteInt(rl.pet.pets[key].Mp);
                c.ot.WriteInt(rl.pet.pets[key].Atk);
                c.ot.WriteInt(rl.pet.pets[key].Def);
                c.ot.WriteInt(rl.pet.pets[key].Hit);
                c.ot.WriteInt(rl.pet.pets[key].Dod);
                c.ot.WriteInt(rl.pet.pets[key].Crit);
                c.ot.WriteInt(rl.pet.pets[key].Fort);
                c.ot.WriteShort(Pet.SkillSlot[rl.pet.pets[key].quality]);
                c.ot.WriteShort(rl.pet.pets[key].skills.Count);

                foreach (Pet.PetSkill sk in rl.pet.pets[key].skills)
                {
                    c.ot.WriteInt(sk.ID);
                    c.ot.WriteByte(sk.Level);
                }

                c.ot.WriteInt(rl.pet.pets[key].z15_specialSkillId);
            }
            c.ot.PackArray(41017);
        }

        internal static void c41018(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "PetController 41018");


        }

        internal static void c41020(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "PetController 41020");


        }

        internal static void c41021(ConnectionInfo c)
        {

            byte res = 2;

            if (c.Player.pet.ExpTimer < DateUtil.GetDateIntZone())
            {
                Pet.PetItem p = c.Player.pet.GetPet();

                if (p.PetID == 0) return;

                p.exp += (95 + (int)(95D * c.Player.horoscope.petexp));

                
                c.Player.pet.Update(p);
                c.Player.pet.ExpTimer = (int)DateUtil.GetDateIntZone() + 50;
                c.Player.pet.Save();
                res = 1;
            }


            c.ot.WriteShort(res);
            c.ot.WriteInt(c.Player.pet.GetPet().exp);
            c.ot.WriteInt(c.Player.pet.GetExpMax());
            c.ot.PackArray(41021);
        }

        internal static void c41022(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"PetController 41022");

            int id = c.ar.ReadInt();
            int key = Pet.ToId(id, c.Player.role.career);
            byte res = 2;
            if (c.Player.pet.pets.ContainsKey(key))
            {
                Pet.PetItem p = c.Player.pet.pets[key];

                if (c.Player.role.Trial >= Pet.PetExpTrailCost[p.level])
                {
                    if (p.level < 120)
                    {
                        if (p.level < c.Player.role.level)
                        {
                            if (p.exp >= Pet.ExpMax((byte)p.level))
                            {
                                c.Player.role.Trial -= Pet.PetExpTrailCost[p.level];
                                p.exp -= Pet.ExpMax((byte)p.level);
                                p.level++;
                                c.Player.pet.Update(p);
                                c.Player.pet.Save();
                                c.Player.role.Save();
                                res = 1;


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
                else
                {
                    res = 0;
                }
            }

            c.ot.WriteShort(res);
            c.ot.PackArray(41022);

            if (res == 1)
            {
                c.ot.WriteShort(6);
                c.ot.WriteShort(41000);
                c.ot.WriteShort(1);

                if (c.Player.pet.pets[key].level >= 2 && c.Player.goal.zodiac[4] == 0)
                {
                    c.Player.goal.zodiac[4] = 1;
                    c.Player.goal.Save();
                    StarTargetController.SendGoal(c);
                }

                c.ot.WriteShort(8);
                c.ot.WriteShort(13020);
                c.ot.WriteInt(c.Player.role.Trial);
                c.Player.combat.Compute(true);
                c.currentScene.UpdatePlayerHp(c);
                c.currentScene.UpdatePet(c);
                //c.Player.
            }
        }

        internal static void c41024(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"PetController 41024");

            int pid = c.ar.ReadInt();
            int itmid = c.ar.ReadInt();
            byte num = (byte)c.ar.ReadShort();

            int key = Pet.ToId(pid, c.Player.role.career);
            byte res = 3;

            int ix = -1;
            ix = c.Player.bag.GetByID(itmid);

            if (ix != -1)
            {
                Bag.Item t = c.Player.bag.GetItem(ix);
                int pScroll = Pet.GetExpScroll(t.type);

                if (pScroll != 0)
                {
                    if (t.count >= num)
                    {
                        Pet.PetItem p = c.Player.pet.GetPet(key);
                        if (p.PetID != 0 && (long)p.exp + ((long)pScroll * num) < int.MaxValue)
                        {
                            pScroll = pScroll * num;
                            p.exp += pScroll;
                            c.Player.pet.Update(p);
                            c.Player.pet.Save();
                            c.Player.bag.UseItem(t.itemid, num);
                            //c.Player.bag.Save();
                            res = 1;

                        }
                        else
                        {
                            res = 2;
                        }
                    }
                    else
                    {
                        res = 6;
                    }
                }
                else
                {
                    res = 5;
                }


            }


            c.ot.WriteShort(res);
            c.ot.WriteInt(pid);
            c.ot.WriteInt(c.Player.pet.GetPet(key).exp);
            c.ot.PackArray(41024);
        }

        internal static void c41025(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "PetController 41025");


        }

        internal static void c41026(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "PetController 41026");


        }

        internal static void c41027(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "PetController 41027");


        }

        internal static void c41028(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "PetController 41028");


        }

        internal static void c41029(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "PetController 41029");


        }

        internal static void c41030(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "PetController 41030");


        }

        internal static void c41031(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "PetController 41031");


        }

        internal static void c41032(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "PetController 41032");


        }

        internal static void c41033(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "PetController 41033");


        }

        internal static void c41034(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "PetController 41034");


        }

    }
}
