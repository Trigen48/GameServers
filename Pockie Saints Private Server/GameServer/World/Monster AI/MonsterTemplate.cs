using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{
    public class MonsterTemplate
    {

      
        public int hp_lim;
        public int mp_lim;

        public byte level;
        public String name;
        public short speed;
        public int resource_type;
        public byte type;
        public String expand;
        public int[] combat;
        public int monster_id;
        public int RespawnTime;
        public int exp;
        public byte monType;

        internal MonsterClass.MonsterPowerClass Combat = new MonsterClass.MonsterPowerClass();

      //  internal 

       // internal static void 

      /*  public SceneMonster CreateMonster()
        {
            SceneMonster mon = new SceneMonster();

            mon.hp = hp;
            mon.mp = mp;
            mon.level = level;
            mon.name = name;


            return mon;
        }*/

    }

    //internal 
    //internal

    internal static class MonsterClass
    {

        internal static double[][] FightModule;
        internal static double[][] PlayerRatio;

        internal static double[][] FightsMod;

        internal static decimal[][] Fmodule2;

        static MonsterClass()
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


            Fmodule2 = new decimal[3][];

            Fmodule2[0] = new decimal[] { 0.65m, 1.7m, 2.34m, 0.11m, 0.12m, 0.05m, 0.15m };
            Fmodule2[1] = new decimal[] { 1m, 1m, 1.3m, 0.1m, 0.15m, 0.1m, 0.1m };
            Fmodule2[2] = new decimal[] { 0.75m, 1.1m, 1.56m, 0.155m, 0.18m, 0.5m, 0.1m };
        }

        public class MonsterPowerClass
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
            public int speed=160;

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
