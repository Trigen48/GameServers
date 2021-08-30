 using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{

    public class Combat
    {
        //const string file = "combat";
        //const string rfile = "rank";
        #region Combat Calculations
        internal static int[][] GemPower = new int[][]{
            new int[]{101,120,47,74,26,18,21,16},
            new int[]{370,240,171,271,94,66,78,54},
            new int[]{812,360,375,593,204,142,165,116},
            new int[]{1427,480,659,1043,358,248,291,202},
            new int[]{2216,600,1023,1619,554,386,450,312},
            new int[]{3178,720,1467,2323,796,550,645,448},
            new int[]{4313,840,1991,3152,1080,748,873,606},
            new int[]{5622,960,2595,4109,1408,974,1137,790},
            new int[]{7104,1080,3279,5191,1776,1230,1437,998},
            new int[]{8759,1200,4043,6401,2192,1518,1770,1232}};
        internal static double[] FashionMod = new double[] { 1.73, 0.82, 1.18, 0.17, 0.15, 0.22, 0.12 };
        internal static double[] FasionStr = new double[] { 0, 0.2, 0.3, 0.5, 0.8, 1.2, 1.7, 3, 5, 8, 11, 15, 20 };

        internal static double[][] FightModule;
        internal static double[][] PlayerRatio;

        internal static double[][] FightsMod;
        static Combat()
        {
            FightModule = new double[][]
            {
                new double [] {11.7, 3.4, 0.4, 1.5, 2.16667, 1.1, 0.5, 1.2},            //{2.42, 2.7, 3.2, 0.1, 0, 0.51, 0.15, 0.75, 0.69, 1.65, 0.55, 0},
                new double []{13, 1.5, 0.375, 0.5, 3, 1, 1, 1.6},                       //{3.02, 1.98, 2.81, 0.11, 0, 0.37, 0.33, 0.8, 0.55, 0.83, 0.7, 0},
                new double []{15.6, 1.833333, 0.36, 1, 3.75, 0.775, 2.5, 0.8}          //{3.72, 3.06, 1.98, 0.11, 0, 0.44, 0.23, 0.53, 0.7, 0.3, 0.5, 0}
            };

            FightsMod = new double[][]
            {
                new double []{2.42, 2.7, 3.2, 0.1, 0, 0.51, 0.15, 0.75, 0.69, 1.65, 0.55, 0},
                new double []{3.02, 1.98, 2.81, 0.11, 0, 0.37, 0.33, 0.8, 0.55, 0.83, 0.7, 0},
                new double []{3.72, 3.06, 1.98, 0.11, 0, 0.44, 0.23, 0.53, 0.7, 0.3, 0.5, 0}
            };
            PlayerRatio = new double[][]
            { 
                new double []{1, 0.75, 0.73, 2, 1.34, 1, 1, 1}, 
                new double []{1, 1, 1, 1, 1, 1, 1, 1}, 
                new double []{1, 0.75, 1, 1, 0.83, 2, 1, 1}
            };
        }


        internal static Dictionary<int, short> WardobePoint;

        internal static decimal[][] Fmodule2;

        internal static int RoundOff(double value)
        {

            int c = (int)value;

            if (value - c >= 0.60)
            {
                c += 1;
            }
            return c;
        }


        internal static void Init()
        {

            Fmodule2 = new decimal[3][];

            Fmodule2[0] = new decimal[] { 0.65m, 1.7m, 2.34m, 0.11m, 0.12m, 0.05m, 0.15m };
            Fmodule2[1] = new decimal[] { 1m, 1m, 1.3m, 0.1m, 0.15m, 0.1m, 0.1m };
            Fmodule2[2] = new decimal[] { 0.75m, 1.1m, 1.56m, 0.155m, 0.18m, 0.5m, 0.1m };

            WardobePoint = new Dictionary<int, short>();

            ByteArray ar = new ByteArray("system/Wardrobe.bin");

            int len = ar.ReadShort();

            for (int i = 0; i < len; i++)
            {
                WardobePoint.Add(ar.ReadInt(), (short)ar.ReadShort());
            }
            ar.Close();

        }

        #endregion

        /*[ProtoContract]
        public class RankData
        {
            [ProtoMember(1)]
            public int RoleID { get; set; }

            [ProtoMember(2)]
            public String name { get; set; }

            [ProtoMember(3)]
            public byte vip_level { get; set; }

            [ProtoMember(4)]
            public byte sex { get; set; }

            [ProtoMember(5)]
            public byte career { get; set; }

            [ProtoMember(6)]
            public byte faction { get; set; }

            [ProtoMember(7)]
            public string GuildName { get; set; }

            [ProtoMember(8)]
            public int CombatPower { get; set; }

            [ProtoMember(9)]
            public int Prestige { get; set; }

            [ProtoMember(10)]
            public int Gold { get; set; }

            [ProtoMember(11)]
            public byte Level { get; set; }

            [ProtoMember(12)]
            public int BattleHonor { get; set; }

            public RankData()
            {

            }

            public void FillData(ConnectionInfo c)
            {
                RoleID = c.rlid;

                name = c.Player.role.name;
                vip_level = c.Player.vip.vip_level;
                sex = c.Player.role.sex;
                career = c.Player.role.career;
                faction = c.Player.role.faction;
                GuildName = c.Player.guild.GuildName;


                CombatPower = c.Player.combat.CombatPower();
                Prestige = c.Player.role.state_prestige;
                Gold = c.Player.bag.gold;
                Level = c.Player.role.level;
                BattleHonor = c.Player.role.bhonor;


            }
        }
        */
        [ContentProto("hp")]
        public int hp { get; set; }

        [ContentProto("mp")]
        public int mp { get; set; }

        /*[ProtoMember(3)]
        public RankData rank { get; set; }*/

        public int hp_lim, mp_lim;
        public int atk;
        public int def;

        public int str;
        public int intl;
        public int agi;

        public int hit;
        public int dod;
        public int crit;
        public int fort;
        public int speed;

        public byte weapon_st;
        public byte armor_st;
        //public byte suit_st;
        public byte suit_level;

        public byte allStrengthen;
        public byte isFullSet;
        internal WeaponsPower wp = new WeaponsPower();
        internal PowerClass Base = new PowerClass(), Extra = new PowerClass();


        ConnectionInfo c;
        public Combat(ConnectionInfo cc)
        {
           // rank = new RankData();
            c = cc;
        }

        public void Compute()
        {
            //suit_level = 2;

            weapon_st = 0;
            byte care = c.Player.role.career;
            // care--;

            byte lev = c.Player.role.level;
            //lev--;

            byte i = 0;

            Base.CalculateBase(lev, care);
            hp_lim = Base.hp_lim;
            mp_lim = Base.mp_lim;

            atk = Base.atk;
            def = Base.def;

            hit = Base.hit;
            dod = Base.dod;
            crit = Base.crit;
            fort = Base.fort;

            str = Base.str;
            intl = Base.intl;
            agi = Base.agi;

            speed = 0;

            //mount data
            if (c.Player.mount.mounts.Count != 0)
            {
                c.Player.mount.ComputeCombat();

                hp_lim += c.Player.mount.hp;
                atk += c.Player.mount.atk;
                def += c.Player.mount.def;
                hit += c.Player.mount.hit;
                dod += c.Player.mount.dod;
                crit += c.Player.mount.crit;
                fort += c.Player.mount.fort;
            }


            // wing data
            i = c.Player.medal.getMedalLevel();
            atk += MedalHelper.MedalPower[c.Player.medal.medal_lev][1] + MedalHelper.MedalLevelData[i][0];
            def += MedalHelper.MedalPower[c.Player.medal.medal_lev][2] + MedalHelper.MedalLevelData[i][1];
            hp_lim += MedalHelper.MedalPower[c.Player.medal.medal_lev][3] + MedalHelper.MedalLevelData[i][2];

            crit += MedalHelper.WingFusion[c.Player.medal.Wings[0].level][3];
            fort += MedalHelper.WingFusion[c.Player.medal.Wings[1].level][4];
            dod += MedalHelper.WingFusion[c.Player.medal.Wings[2].level][6];
            hit += MedalHelper.WingFusion[c.Player.medal.Wings[3].level][5];


            // Title Data
            //            TitleList.Add(1003, new int[] { 360, 480, 0, 3600, 0, 0, 0, 600, 40 });
            int tid = c.Player.role.title_id;
            atk += TitleHelper.TitleList[tid][0];
            def += TitleHelper.TitleList[tid][1];
            crit += TitleHelper.TitleList[tid][2];
            hp_lim += TitleHelper.TitleList[tid][3];
            fort += TitleHelper.TitleList[tid][4];
            hit += TitleHelper.TitleList[tid][5];
            dod += TitleHelper.TitleList[tid][6];
            mp_lim += TitleHelper.TitleList[tid][7];
            speed += TitleHelper.TitleList[tid][8];


            // Star Map add
            StarMap tag = c.Player.starmap;
            if (tag.combat == null)
                tag.SetCombat();

            //hp,mp,atk,hit,dod,crit,def,fort
            hp_lim  += tag.combat[0];
            mp_lim  += tag.combat[1];
            atk     += tag.combat[2];
            hit     += tag.combat[3];
            dod     += tag.combat[4];
            crit    += tag.combat[5];
            def     += tag.combat[6];
            fort    += tag.combat[7];

            // Adds out extra power horoscope
            if (c.Player.role.level > 13)
            {
                c.Player.horoscope.CalculatePower(c);
            }

            //Equipment

            wp.Build(c.Player.bag.bags[0], this);
            wp.BuildWardrobe(c.Player.bag.bags[3], this,c.Player.role.level);
            atk += wp.atk;
            def += wp.def;
            crit += wp.crit;
            hp_lim += wp.hp_lim;
            fort += wp.fort;
            hit += wp.hit;
            dod += wp.dod;
            mp_lim += wp.mp_lim;
            speed += wp.speed;

            str += wp.str;
            agi += wp.agi;
            intl += wp.intl;

            // Calculate STR INT AGI Power boost
            Extra.CalculateExtra(str - Base.str, intl - Base.intl, agi - Base.agi, care);
            hp_lim += Extra.hp_lim;
            mp_lim += Extra.mp_lim;

            atk += Extra.atk;
            def += Extra.def;

            hit += Extra.hit;
            dod += Extra.dod;
            crit += Extra.crit;
            fort += Extra.fort;

            str += Extra.str;
            intl += Extra.intl;
            agi += Extra.agi;

            if (c.Player.pet.CurrentPet != 0)
            {
                atk += c.Player.pet.GetPet().Atk;

                atk += wp.atk;
                def += c.Player.pet.GetPet().Def;
                crit += c.Player.pet.GetPet().Crit;
                hp_lim += c.Player.pet.GetPet().Hp;
                fort += c.Player.pet.GetPet().Fort;
                hit += c.Player.pet.GetPet().Hit;
                dod += c.Player.pet.GetPet().Dod;
                mp_lim += c.Player.pet.GetPet().Mp;
            }

            //bool save = false;
            if (mp_lim < mp)
            {
                mp = mp_lim;
                // save = true;
            }
            if (hp_lim < hp)
            {
                hp = hp_lim;
                //  save = true;
            }
            /*if (save)*/
            Save();

            //SaveRank(c);
            //Command.RoleController.SendRoles(c);
        }

        public int CombatPower()
        {
            return getFightingValue(c.Player.role.career, hp_lim, mp_lim, atk, def, hit, dod, crit, fort, speed + c.Player.mount.mountspeed + c.Player.role.speed, 0, 0, 0);
            //return 0;
        }

        public static int GetPower(int value, byte star)
        {

            double val;

            val = Math.Floor((double)value * Math.Pow(1.15, (double)star));

            return (int)val;

        }

        public void MaxHpMp()
        {
            hp = hp_lim;
            mp = mp_lim;
            Save();
        }

        // public void AddBaseStat

        static double[] getFightingModulus(int RoleType)
        {
            return FightsMod[RoleType - 1];
            //return null;
        }

        public static int getFightingValue(int RoleType, int Str, int Intl, int Agi, int Hp, int Mp, int Atk, int Def, int Hit, int Dod, int Crit, int Fort, int speed)
        {

            double[] FightModule = getFightingModulus(RoleType);

            if (FightModule != null)
            {
                return (int)Math.Ceiling((FightModule[0] * (double)Crit) + (FightModule[1] * (double)Fort) +
                    (FightModule[2] * (double)speed) + (FightModule[3] * (double)Str) +
                    (FightModule[4] * (double)Intl) + (FightModule[5] * (double)Agi) +
                    (FightModule[6] * (double)Hp) + (FightModule[7] * (double)Mp) +
                    (FightModule[8] * (double)Atk) + (FightModule[9] * (double)Def) +
                    (FightModule[10] * (double)Hit) + (FightModule[11] * (double)Dod));
            }
            return 0;
        }

        public void Compute(bool v)
        {
            Compute();
            Command.RoleController.SendRoles(c);
        }

        public bool Load()
        {
            c.con.StartCommand("SELECT hp,mp FROM combat WHERE roleid=? LIMIT 1;");
            c.con.AddValue(c.rlid);
            return ContentResolver.DoDeserialize<Combat>(this, c.con);
        }

        public int MonsterDamage(ConnectionInfo c, int enemy)
        {
            Compute();
            SceneMonster m;
            //MonsterTemplate mon;
            int ix = c.currentScene.GetMonster(enemy);

            if (ix == -1) return -2;

            m = c.currentScene.Monsters[ix];


            int damage = 0;
            //atk 0
            //def 1
            //hit 2
            //dod 3
            //crit 4
            //fort 5


            if (c.Player.chance.Random(hit) <= c.Player.chance.Random(c.currentScene.MonTemp[m.monster_id].combat[3]))
            {
                return 0;
            }

            int ex1, ex2;

            ex1 = c.Player.chance.Random(crit);
            ex2 = c.Player.chance.Random(c.currentScene.MonTemp[m.monster_id].combat[5]);

            if (ex1 > ex2)
            {
                damage += (atk + (ex1 - ex2)) - c.currentScene.MonTemp[m.monster_id].combat[1];
            }
            else
            {
                damage += atk - (c.currentScene.MonTemp[m.monster_id].combat[1] + (ex2 - ex1));
            }

            return damage / 3;
        }

        public int GetSpeed(ConnectionInfo c)
        {
            return c.Player.role.speed + c.Player.mount.mountspeed + c.Player.combat.speed;
        }

        public int PlayerDamage(ConnectionInfo c, int enemyid)
        {
            Compute();

            int damage = 0;
            //atk 0
            //def 1
            //hit 2
            //dod 3
            //crit 4
            //fort 5
            // c.Player.chance.

            RoleControl enemy=Players.GetPlayer(enemyid);
            enemy.combat.Compute();

            Combat cb = enemy.combat;

            //int temp = ;

            // temp = hit / temp;

            if (c.Player.chance.SimpleChance((double)hit / (double)cb.dod) == false)
            {
                return 0;
            }

            int ex1, ex2;

            ex1 = c.Player.chance.Random(crit);
            ex2 = c.Player.chance.Random(cb.fort);


            // int atk, def;
            int edef = cb.def;


            int dmg = (((atk) * 2) - (edef / 10)) / 10;

            dmg += (ex1 - ex2);

            damage = dmg;


            if (damage < 0) damage = 0;

            if (damage > enemy.combat.hp)
            {
                damage = enemy.combat.hp;
            }

            enemy.combat.hp -= damage;

            enemy.combat.Save();
            return damage;
        }

        public bool Save()
        {
            //log.trace.Save(Environment.StackTrace);
           // Compute();
            c.con.StartCommand("UPDATE combat SET hp=?, mp=?, combatpower=? WHERE roleid=?;");
            c.con.AddValue(hp);
            c.con.AddValue(mp);
            c.con.AddValue(CombatPower());
            c.con.AddValue(c.rlid);

            return c.con.ExecuteNoneQuery() > 0;
        }

        public static bool Create( byte i,int roleid)
        {
            ConnectionInfo c = new ConnectionInfo(roleid);

            PowerClass w = new PowerClass();
            w.CalculateBase(Game.StartLevel, i);

            c.con.StartCommand("INSERT INTO combat(roleid,hp,mp) VALUES(?,?,?);");

            c.con.AddValue(roleid);
            c.con.AddValue(w.hp_lim);
            c.con.AddValue(w.mp_lim);

            w = null;


            return c.con.ExecuteNoneQuery() > 0;
        }

        public class WeaponsPower
        {
            // public int hp, mp;
            public int hp_lim, mp_lim;
            public int atk;
            public int def;

            public int str;
            public int intl;
            public int agi;

            public int hit;
            public int dod;
            public int crit;
            public int fort;
            public int speed;
            public short WardrobePoints = 0;
            Bag.Item w;
            public void Build(Bag.BagType t, Combat c)
            {
                hp_lim = 0;
                mp_lim = 0;
                atk = 0;
                def = 0;

                str = 0;
                intl = 0;
                agi = 0;

                hit = 0;
                dod = 0;
                crit = 0;
                fort = 0;
                speed = 0;
                w = new Bag.Item();

                Dictionary<int, int> suit = new Dictionary<int, int>();
                //byte level = 10;

                for (byte i = 0; i < t.items.Count; i++)
                {
                    Bag.Item it = t.items[i];
                    if (it.slot == 1) c.weapon_st = it.str;
                    else if (it.slot == 3) c.armor_st = it.str;



                    if (it.setid != 0)
                    {
                        if (gamedata.SuitInfo.suits.ContainsKey(it.setid) && gamedata.SuitInfo.suits[it.setid].Equip.ContainsKey(it.type))
                        {
                            if (!suit.ContainsKey(it.setid))
                                suit.Add(it.setid, 0);
                            suit[it.setid]++;
                        }
                    }

                    for (byte j = 0; j < t.items[i].BaseStats.Count; j++)
                    {
                        GetStats(it.BaseStats[j], it.str, true);
                    }

                    for (byte j = 0; j < t.items[i].ExtraStats.Count; j++)
                    {
                        GetStats(it.ExtraStats[j], 0, false);
                    }

                    GetGems(it);

                    if (it.slot == 13) w = it;
                    //else if (it.slot < 13 && it.str < level) level = it.str;
                        
                }

                //c.suit_level = level;

                c.isFullSet = 0;
                foreach (int k in suit.Keys)
                {
                    int i = suit[k];

                    List<gamedata.SuitEffect> effs = gamedata.SuitInfo.suits[k].SuiteEffects;


                    for (int x = 0; x < effs.Count; x++)
                    {
                        if (i >= effs[x].Count)
                        {
                            SetProperty(effs[x].Type, effs[x].Value);
                        }
                    }

                    if (c.isFullSet==0 &&i == 6 && gamedata.SuitInfo.suits[k].Equip.Count == 6)
                    {
                        c.isFullSet = (byte)k;
                    }
                    /*else if (i == 3 && gamedata.SuitInfo.suits[k].Equip.Count == 3)
                    {
                    }*/
                }

            }

            public void GetStats(Bag.ItemStat stat, byte star, bool isBase)
            {
                int v;

                if (isBase)
                {
                    v = GetPower(stat.Value, star);
                }
                else
                {
                    v = stat.Value;
                }

                SetProperty(stat.Prop, v);

            }

            public void SetProperty(byte prop, int v)
            {
                switch (prop)
                {
                    case 1:
                        hp_lim += v;
                        break;
                    case 2:
                        mp_lim += v;
                        break;
                    case 3:
                        atk += v;
                        break;
                    case 4:
                        def += v;
                        break;
                    case 5:
                        hit += v;
                        break;
                    case 6:
                        dod += v;
                        break;

                    case 7:
                        crit += v;
                        break;

                    case 8:
                        fort += v;
                        break;

                    case 9:
                        speed += v;
                        break;

                    case 11:
                        str += v;
                        break;
                    case 12:
                        agi += v;
                        break;
                    case 13:
                        intl += v;
                        break;
                }
            }


            public void BuildWardrobe(Bag.BagType t, Combat c, byte level)
            {

                double points = 0;
                double warp;
                for (byte i = 0; i < t.items.Count; i++)
                {
                    warp = WardobePoint[t.items[i].type];
                    points += Math.Ceiling(warp + (warp * FasionStr[t.items[i].str]));
                }

                if (w.itemid != 0)
                {
                    warp = WardobePoint[w.type];
                    warp = Math.Ceiling(warp + (warp * FasionStr[w.str]));
                    points += warp;
                }

                if (points < 1) return;


                byte flevel = 0;
                if (points < 100)
                {
                    flevel = 1;
                }
                else if (points < 400)
                {
                    flevel = 2;
                }
                else if (points < 800)
                {
                    if (level >= 30)
                    {
                        flevel = 3;
                    }
                    else
                    {
                        points = 400;
                        flevel = 2;
                    }
                }
                else if (points <= 1500)
                {
                    if (level >= 40)
                    {
                        flevel = 4;
                    }
                    else
                    {
                        points = 800;
                        flevel = 3;
                    }
                }
                else if (points < 2000)
                {
                    if (level >= 55)
                    {
                        flevel = 5;
                    }
                    else
                    {
                        points = 1500;
                        flevel = 4;
                    }
                }
                else if (points >= 2000)
                {
                    if (level >= 75)
                    {
                        flevel = 6;
                    }
                    else
                    {
                        points = 2000;
                        flevel = 5;
                    }
                }

                c.suit_level = flevel;

                hp_lim += GetFact(points, 0);
                atk += GetFact(points, 1);
                def += GetFact(points, 2);
                hit += GetFact(points, 3);
                dod += GetFact(points, 4);
                crit += GetFact(points, 5);
                fort += GetFact(points, 6);

                w = new Bag.Item();




               // c.suit_level = suit_level;

            }


            public int GetFact(double point, int index)
            {
                int val = (int)Math.Ceiling(0.03 * ((double)82 * point + (double)150) * FashionMod[index]);
                return val;
            }
            public void GetGems(Bag.Item b)
            {
                if (b.gemcount == 0) return;
                int v = 0;

                byte lev, type;
                for (byte i = 0; i < b.gemcount; i++)
                {
                    if (b.Gems[i] == 0) continue;

                    lev = (byte)((b.Gems[i] - 1114001) / 8);
                    type = (byte)((b.Gems[i] - 1114001) - (lev * 8));
                    v = Combat.GemPower[lev][type];
                    switch (Command.BagController.Props[type])
                    {
                        case 1:
                            hp_lim += v;
                            break;
                        case 2:
                            mp_lim += v;
                            break;
                        case 3:
                            atk += v;
                            break;
                        case 4:
                            def += v;
                            break;
                        case 5:
                            hit += v;
                            break;
                        case 6:
                            dod += v;
                            break;

                        case 7:
                            crit += v;
                            break;

                        case 8:
                            fort += v;
                            break;

                        case 9:
                            speed += v;
                            break;

                        case 11:
                            str += v;
                            break;


                        case 12:
                            agi += v;
                            break;
                        case 13:
                            intl += v;
                            break;
                    }
                }
            }
        }

        public class PowerClass
        {
            public int hp_lim, mp_lim;
            public int atk;
            public int def;

            public int str;
            public int intl;
            public int agi;

            public int hit;
            public int dod;
            public int crit;
            public int fort;
            public int speed;

            public void CalculateBase(byte level, byte car)
            {
                int ASTR, AINT, AAGI;
                var Fmodule = FightModule[car - 1];

                switch (car - 1)
                {
                    case 0:

                        ASTR = 1 + ((level - 1) * 10);
                        AINT = 1 + ((level - 1) * 5);
                        AAGI = 1 + ((level - 1) * 5);
                        break;

                    case 1:
                        ASTR = 1 + ((level - 1) * 5);
                        AINT = 1 + ((level - 1) * 10);
                        AAGI = 1 + ((level - 1) * 5);
                        break;

                    case 2:
                        ASTR = 1 + ((level - 1) * 5);
                        AINT = 1 + ((level - 1) * 5);
                        AAGI = 1 + ((level - 1) * 10);
                        break;

                    default:
                        return;
                }


                var HP = Math.Ceiling((ASTR * Fmodule[0] + 0.0));
                var MP = Math.Ceiling((AINT * Fmodule[7] + 0.0));
                var ATK = Math.Ceiling(((ASTR + AINT) * Fmodule[4] + 0.0));
                var DEF = Math.Ceiling(((ASTR + 2.0 * AAGI + AINT) * Fmodule[1] + 0.0));
                var HIT = Math.Ceiling((AAGI * Fmodule[5] + 0));
                var DOD = Math.Ceiling(((2.0 * AAGI + AINT) * Fmodule[2] + 0.0));
                var CRIT = Math.Ceiling((AAGI * Fmodule[6] + 10.0 + 0));
                var FORT = Math.Ceiling((AINT * Fmodule[3] + 20.0 + 0));

                hp_lim = (int)HP;
                mp_lim = (int)MP;
                atk = (int)ATK;
                def = (int)DEF;
                hit = (int)HIT;
                dod = (int)DOD;
                crit = (int)CRIT;
                fort = (int)FORT;
                str = (int)ASTR;
                intl = (int)AINT;
                agi = (int)AAGI;

            }

            public void CalculateExtra(int Str, int Intl, int Agi, byte car)
            {
                str = Str;
                intl = Intl;
                agi = Agi;

                double ASTR = str, AINT = intl, AAGI = agi;

                var Fmodule = FightModule[car - 1];

                if (str != 0)
                    hp_lim = (int)Math.Ceiling((ASTR * Fmodule[0] + 0.0));//(int)HP;hp_lim = Round((decimal)str * 11.72M);

                if (intl != 0)
                {
                    mp_lim = (int)Math.Ceiling((AINT * Fmodule[7] + 0.0));//mp_lim = 1 + Round((decimal)intl * 1.21M);
                    fort = (int)Math.Ceiling((AINT * Fmodule[3] + 20.0 + 0));//FORT;fort = 21 + Round((decimal)intl * 1.49m);
                }

                if (agi != 0)
                {
                    hit = (int)Math.Ceiling((AAGI * Fmodule[5] + 0));//HIT;hit = 1 + Round((decimal)agi * 1.09M);
                    crit = (int)Math.Ceiling((AAGI * Fmodule[6] + 10.0 + 0));//CRIT;crit = 10 + Round((decimal)agi * 0.59m);
                }

                if (intl != 0 || agi != 0)
                {
                    dod = (int)Math.Ceiling(((2.0 * AAGI + AINT) * Fmodule[2] + 0.0));//DOD;dod = Round(((decimal)intl * 0.63m) + ((decimal)agi * 0.63m));
                }

                if (intl != 0 || str != 0)
                {
                    atk = (int)Math.Ceiling(((ASTR + AINT) * Fmodule[4] + 0.0));//ATK;atk = Round(((decimal)str * 2.19m) + ((decimal)intl * 2.16m));
                }

                if (intl != 0 || agi != 0 || str != 0)
                {
                    def = (int)Math.Ceiling(((ASTR + 2.0 * AAGI + AINT) * Fmodule[1] + 0.0));//DEF;def = 1 + Round(((decimal)str * 4.34m) + ((decimal)intl * 4.16m) + ((decimal)agi * 4.16m));
                }

            }

            static int Round(decimal value)
            {
                return (int)decimal.Round(value, 0);
            }
        }
    }
}
