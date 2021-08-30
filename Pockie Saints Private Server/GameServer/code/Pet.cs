using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{

    public class Pet
    {
        ConnectionInfo c;
        #region Calculations

        public static int[] PetExpTrailCost;
        public static byte[] StatMax;
        public static byte[] SkillSlot;


        public static int[][] PetUp;

        static Pet()
        {
            PetExpTrailCost = new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 34, 64, 100, 
                139, 184, 234, 944, 1140, 1353, 1585, 1836, 2105, 2395, 2704, 3034, 8207, 10395, 
                12752, 15282, 17992, 20884, 23963, 27232, 30697, 34362, 38232, 42308, 46599, 51106, 
                55836, 60789, 65974, 71393, 77051, 82951, 89099, 94553, 100152, 105893, 111779, 117809, 
                123984, 130301, 136763, 143369, 150120, 157013, 164051, 171233, 178560, 186029, 193643,
                201401, 209304, 217349, 225539, 233873, 242352, 250973, 259739, 268649, 277704, 286901, 
                296243, 305729, 315360, 325133, 335051, 345113, 355320, 365669, 376163, 386801, 397584, 
                408509, 419579, 430793, 442152, 453653, 465299, 477089, 489024, 501101, 513323, 525689 };

            StatMax = new byte[] { 40, 60, 80, 100, 120, 140, 160, 180, 200 };
            SkillSlot = new byte[] { 1, 2, 2, 3, 3, 5, 5, 8, 8 };

            PetUp = new int[90][];
            PetUp[0] = new int[] { 3012006, 1, 10 };
            PetUp[1] = new int[] { 3012006, 1, 15 };
            PetUp[2] = new int[] { 3012006, 1, 20 };
            PetUp[3] = new int[] { 3012006, 1, 25 };
            PetUp[4] = new int[] { 3012006, 1, 30 };
            PetUp[5] = new int[] { 3012006, 1, 35 };
            PetUp[6] = new int[] { 3012006, 1, 40 };
            PetUp[7] = new int[] { 3012006, 1, 45 };
            PetUp[8] = new int[] { 3012006, 1, 50 };
            PetUp[9] = new int[] { 3012006, 1, 55 };
            PetUp[10] = new int[] { 3012006, 2, 55 };
            PetUp[11] = new int[] { 3012006, 2, 65 };
            PetUp[12] = new int[] { 3012006, 2, 75 };
            PetUp[13] = new int[] { 3012006, 2, 80 };
            PetUp[14] = new int[] { 3012006, 2, 90 };
            PetUp[15] = new int[] { 3012006, 2, 100 };
            PetUp[16] = new int[] { 3012006, 2, 110 };
            PetUp[17] = new int[] { 3012006, 2, 115 };
            PetUp[18] = new int[] { 3012006, 2, 125 };
            PetUp[19] = new int[] { 3012006, 2, 135 };
            PetUp[20] = new int[] { 3012007, 1, 135 };
            PetUp[21] = new int[] { 3012007, 1, 135 };
            PetUp[22] = new int[] { 3012007, 1, 135 };
            PetUp[23] = new int[] { 3012007, 1, 135 };
            PetUp[24] = new int[] { 3012007, 1, 135 };
            PetUp[25] = new int[] { 3012007, 2, 135 };
            PetUp[26] = new int[] { 3012007, 2, 135 };
            PetUp[27] = new int[] { 3012007, 2, 135 };
            PetUp[28] = new int[] { 3012007, 2, 135 };
            PetUp[29] = new int[] { 3012007, 2, 135 };
            PetUp[30] = new int[] { 3012007, 3, 135 };
            PetUp[31] = new int[] { 3012007, 3, 135 };
            PetUp[32] = new int[] { 3012007, 3, 145 };
            PetUp[33] = new int[] { 3012007, 3, 160 };
            PetUp[34] = new int[] { 3012007, 3, 175 };
            PetUp[35] = new int[] { 3012007, 4, 190 };
            PetUp[36] = new int[] { 3012007, 4, 210 };
            PetUp[37] = new int[] { 3012007, 4, 225 };
            PetUp[38] = new int[] { 3012007, 4, 240 };
            PetUp[39] = new int[] { 3012007, 4, 255 };
            PetUp[40] = new int[] { 3012008, 2, 255 };
            PetUp[41] = new int[] { 3012008, 2, 255 };
            PetUp[42] = new int[] { 3012008, 2, 255 };
            PetUp[43] = new int[] { 3012008, 2, 260 };
            PetUp[44] = new int[] { 3012008, 2, 275 };
            PetUp[45] = new int[] { 3012008, 2, 290 };
            PetUp[46] = new int[] { 3012008, 2, 310 };
            PetUp[47] = new int[] { 3012008, 2, 325 };
            PetUp[48] = new int[] { 3012008, 2, 340 };
            PetUp[49] = new int[] { 3012008, 2, 355 };
            PetUp[50] = new int[] { 3012008, 3, 355 };
            PetUp[51] = new int[] { 3012008, 3, 355 };
            PetUp[52] = new int[] { 3012008, 3, 355 };
            PetUp[53] = new int[] { 3012008, 3, 355 };
            PetUp[54] = new int[] { 3012008, 3, 355 };
            PetUp[55] = new int[] { 3012008, 3, 355 };
            PetUp[56] = new int[] { 3012008, 3, 375 };
            PetUp[57] = new int[] { 3012008, 3, 395 };
            PetUp[58] = new int[] { 3012008, 3, 415 };
            PetUp[59] = new int[] { 3012008, 3, 440 };
            PetUp[60] = new int[] { 3012009, 2, 440 };
            PetUp[61] = new int[] { 3012009, 2, 440 };
            PetUp[62] = new int[] { 3012009, 2, 440 };
            PetUp[63] = new int[] { 3012009, 2, 440 };
            PetUp[64] = new int[] { 3012009, 2, 440 };
            PetUp[65] = new int[] { 3012009, 3, 440 };
            PetUp[66] = new int[] { 3012009, 3, 440 };
            PetUp[67] = new int[] { 3012009, 3, 440 };
            PetUp[68] = new int[] { 3012009, 3, 440 };
            PetUp[69] = new int[] { 3012009, 3, 440 };
            PetUp[70] = new int[] { 3012009, 4, 440 };
            PetUp[71] = new int[] { 3012009, 4, 440 };
            PetUp[72] = new int[] { 3012009, 4, 440 };
            PetUp[73] = new int[] { 3012009, 4, 440 };
            PetUp[74] = new int[] { 3012009, 4, 440 };
            PetUp[75] = new int[] { 3012009, 4, 440 };
            PetUp[76] = new int[] { 3012009, 4, 440 };
            PetUp[77] = new int[] { 3012009, 4, 475 };
            PetUp[78] = new int[] { 3012009, 4, 515 };
            PetUp[79] = new int[] { 3012009, 4, 555 };
            PetUp[80] = new int[] { 3012009, 5, 555 };
            PetUp[81] = new int[] { 3012009, 5, 695 };
            PetUp[82] = new int[] { 3012009, 5, 695 };
            PetUp[83] = new int[] { 3012009, 5, 695 };
            PetUp[84] = new int[] { 3012009, 5, 695 };
            PetUp[85] = new int[] { 3012009, 6, 695 };
            PetUp[86] = new int[] { 3012009, 6, 695 };
            PetUp[87] = new int[] { 3012009, 6, 695 };
            PetUp[88] = new int[] { 3012009, 6, 695 };
            PetUp[89] = new int[] { 3012009, 6, 695 };

        }

        public static int GetJoyValue(int type)
        {

            switch (type)
            {
                case 3011001:
                    return 100;

                case 3011002:
                    return 250;

                case 3011003:
                    return 500;

                default:
                    return 0;
            }

        }
        public static void UpdatePetCombat(ref PetItem p)
        {
            double[] clue = GetPetCombat(p.level, p.quality, p.starLv, 0, p.str_base, p.agi_base, p.intl_base, p.career);

            p.Hp = (int)Math.Round(clue[3]);
            p.Mp = (int)Math.Round(clue[4]);

            p.Atk = (int)Math.Round(clue[5]);
            p.Def = (int)Math.Round(clue[6]);

            p.Hit = (int)Math.Round(clue[7]);
            p.Dod = (int)Math.Round(clue[8]);
            p.Crit = (int)Math.Round(clue[9]);
            p.Fort = (int)Math.Round(clue[10]);

            p.f_strength = (short)Math.Abs(clue[0]);
            p.g_wit = (short)Math.Abs(clue[2]);
            p.h_agility = (short)Math.Abs(clue[1]);

        }
        public static int GetExpScroll(int type)
        {
            switch (type)
            {
                case 3018001:
                    return 500;

                case 3018002:
                    return 10000;

                case 3018003:
                    return 100000;

                default:
                    return 0;
            }
        }

        public static int ExpMax(byte lev)
        {
            if (lev < 20)
            {
                return 55 + (lev * 3);
            }
            else
            {
                byte e = (byte)(lev - 19);

                return (55 + (lev * 3)) + (e * 1230);
            }

        }

        #endregion


        public class PetItem
        {
            [ContentProto("petid", true)]
            public int PetID { get; set; }

            [ContentProto("career")]
            public byte career { get; set; }

            [ContentProto("name")]
            public String name { get; set; }

            [ContentProto("renamecount")]
            public short RenameCount { get; set; }

            [ContentProto("lvl")]
            public short level { get; set; }

            [ContentProto("quality")]
            public short quality { get; set; }

            // [ProtoMember(7)]
            public short f_strength { get; set; }

            // [ProtoMember(8)]
            public short g_wit { get; set; }

            // [ProtoMember(9)]
            public short h_agility { get; set; }

            [ContentProto("str_base")]
            public short str_base { get; set; }

            [ContentProto("intl_base")]
            public short intl_base { get; set; }

            [ContentProto("agi_base")]
            public short agi_base { get; set; }

            [ContentProto("str_new")]
            public short str_new { get; set; }

            [ContentProto("intl_new")]
            public short intl_new { get; set; }

            [ContentProto("agi_new")]
            public short agi_new { get; set; }

            [ContentProto("joy")]
            public short joy { get; set; }

            [ContentProto("isactive")]
            public short isActive { get; set; }

            [ContentProto("w_fightpos")]
            public short w_fightPos { get; set; }

            [ContentProto("joy_lim")]
            public short Joy_lim { get; set; }

            [ContentProto("pettype")]
            public int PetType { get; set; }

            [ContentProto("starlv")]
            public int starLv { get; set; }

            [ContentProto("luck")]
            public int Luck { get; set; }

            [ContentProto("expc")]
            public int exp { get; set; }

            [ContentProto("expc_lim")]
            public int exp_lim { get; set; }

            //[ProtoMember(25)]
            public int Hp { get; set; }

            //  [ProtoMember(26)]
            public int Mp { get; set; }

            // [ProtoMember(27)]
            public int Atk { get; set; }

            //  [ProtoMember(28)]
            public int Def { get; set; }

            //  [ProtoMember(29)]
            public int Hit { get; set; }

            //[ProtoMember(30)]
            public int Dod { get; set; }

            // [ProtoMember(31)]
            public int Crit { get; set; }

            //   [ProtoMember(32)]
            public int Fort { get; set; }

            [ContentProto("skill_slots")]
            public short Skill_Slots { get; set; }

            [ContentProto("z15_specialskillid")]
            public int z15_specialSkillId { get; set; }

            [ContentProto("skillsb")]
            public byte[] skillsB
            {

                get
                {

                    ByteArray ar = new ByteArray();

                    ar.WriteByte((byte)skills.Count);
                    for (int x = 0; x < skills.Count; x++)
                    {
                        ar.WriteInt(skills[x].ID);
                        ar.WriteByte(skills[x].Level);
                        ar.WriteInt(skills[x].Level);
                    }

                    //ar.WriteBytes(new byte[73 - ar.Length()]);
                    byte[] data = ar.GetByteArray();
                    ar.Close();
                    ar = null;
                    return data;
                    //return xc;
                }

                set
                {
                    if (value != null)
                    {
                        ByteArray ar = new ByteArray(value);
                        int cnt = ar.ReadByte();

                        skills.Clear();

                        for (int x = 0; x < cnt; x++)
                        {
                            PetSkill sk = new PetSkill();
                            sk.ID = ar.ReadInt();
                            sk.Level = ar.ReadByte();
                            sk.Value = ar.ReadInt();
                            skills.Add(sk);
                        }
                        ar.Close();
                    }
                }

            }

            public List<PetSkill> skills { get; set; }

            public PetItem()
            {
                skills = new List<PetSkill>();
            }
        }


        public class PetSkill
        {

            public int ID;
            public byte Level;
            public int Value;
            public PetSkill()
            {

            }
        };

        //const string file = "pet";


        public int CurrentPet = 0;
        public int PetType = 0;
        public string PetName = "";
        public int ExpTimer = 0;
        public int JoyTimer = 0;

        public byte PetLev = 0;//1;
        public byte PetQual = 0;//1;

        //public List<Pet> pets= new List<Pet>();


        public Dictionary<int, PetItem> pets { get; set; }// = new Dictionary<int, PetItem>();


        //public int IdBase { get; set; }// = 0;

        public Pet(ConnectionInfo cc)
        {
            c = cc;
            pets = new Dictionary<int, PetItem>();
        }

        /*  public void CreateId(ConnectionInfo c)
          {
              //IdBase = (c.rlid * 100) + 1;
          }*/

        public static int ToModule(int id, byte role)
        {
            return (id * 256) + role;
        }

        public static int ToId(int id, byte role)
        {
            return (id - role) / 256;
        }

        public static double[] GetPetCombat(double Level, double quality, double StarLev, double AptitudeStr, double BaseStr, double BaseAgi, double BaseInt, int RoleID)// param2:int, param3:int, param4:int, param5:int, param6:int, param7:int, param8:int)
        {
            var Fmodule = Combat.FightModule[RoleID - 1]; //PlayerConfig.getPlayerModulus(param8);
            var PRatio = Combat.PlayerRatio[RoleID - 1];// PlayerConfig.getPlayerRatios(param8);

            var Star_Quality = 10.0 * quality + StarLev + 10.0;
            var _loc_12 = 25.0 * Level * Level + 25.0 * Level + 150;

            var _loc_13 = 5.5 / 1000.0 * (25.0 * Star_Quality * Star_Quality + 25.0 * Star_Quality + 150.0) + Level;
            var ASTR = ((4.0 * Star_Quality / 25.0 + 6.0 * BaseStr / 200.0) / 2000.0 * _loc_12 + _loc_13) * 1.0 + 0.0;
            var AAGI = ((4.0 * Star_Quality / 25.0 + 6.0 * BaseAgi / 200.0) / 2000.0 * _loc_12 + _loc_13) * 1.0 + 0.0;
            var AINT = ((4.0 * Star_Quality / 25.0 + 6.0 * BaseInt / 200.0) / 2000.0 * _loc_12 + _loc_13) * 1.0 + 0.0;
            var HP = Math.Ceiling((ASTR * Fmodule[0] + 0.0) * PRatio[0] + 0.0);
            var MP = Math.Ceiling((AINT * Fmodule[7] + 0.0) * PRatio[7] + 0.0);
            var ATK = Math.Ceiling(((ASTR + AINT) * Fmodule[4] + 0.0) * PRatio[4] + 0.0);
            var DEF = Math.Ceiling(((ASTR + 2.0 * AAGI + AINT) * Fmodule[1] + 0.0) * PRatio[1] + 0.0);
            var HIT = Math.Ceiling((AAGI * Fmodule[5] + 0) * PRatio[5] + 0.0);
            var DOD = Math.Ceiling(((2.0 * AAGI + AINT) * Fmodule[2] + 0.0) * PRatio[2] + 0.0);
            var CRIT = Math.Ceiling((AAGI * Fmodule[6] + 10.0 + 0) * PRatio[6] + 0.0);
            var FORT = Math.Ceiling((AINT * Fmodule[3] + 20.0 + 0) * PRatio[3] + 0.0);
            return new double[] { ASTR, AAGI, AINT, HP, MP, ATK, DEF, HIT, DOD, CRIT, FORT };


            /*  p.Hp = (int)Math.Round(clue[3]);
              p.Mp = (int)Math.Round(clue[4]);

              p.Atk = (int)Math.Round(clue[5]);
              p.Def = (int)Math.Round(clue[6]);

              p.Hit = (int)Math.Round(clue[7]);
              p.Dod = (int)Math.Round(clue[8]);
              p.Crit = (int)Math.Round(clue[9]);
              p.Fort = (int)Math.Round(clue[10]);

              p.f_strength = (short)Math.Abs(clue[0]);
              p.g_wit = (short)Math.Abs(clue[1]);
              p.h_agility = (short)Math.Abs(clue[2]);*/
        }// end function

        public int CreatePet(int petype, byte petQuality, byte carear)
        {
            int id = -1;//IdBase;

            PetItem p = new PetItem();
            p.PetID = id;
            p.PetType = petype;
            p.joy = 1000;
            p.Joy_lim = 1000;
            p.career = carear;
            p.exp = 0;
            p.name = "Pet";
            p.level = 1;
            p.quality = petQuality;
            p.skills = new List<PetSkill>();
            p.z15_specialSkillId = petype;

            if (petQuality == 0)
            {
                p.agi_base = 10;
                p.intl_base = 10;
                p.str_base = 10;
            }
            else
            {
                p.agi_base = 40;
                p.intl_base = 40;
                p.str_base = 40;
            }
            //p.Skill_Slots

            UpdatePetCombat(ref p);

            c.con.StartCommand("INSERT INTO pet(PetType,career,name,quality,z15_specialSkillId,agi_base,intl_base,str_base,roleid) VALUES(?,?,?,?,?,?,?,?,?);");


            c.con.AddValue(p.PetType);
            //c.con.AddValue(p.joy);
            // c.con.AddValue(p.Joy_lim);
            c.con.AddValue(p.career);
            c.con.AddValue(p.name);
            //c.con.AddValue(p.level);
            c.con.AddValue(p.quality);
            //c.con.AddValue(p.skills);
            c.con.AddValue(p.z15_specialSkillId);

            c.con.AddValue(p.agi_base);
            c.con.AddValue(p.intl_base);
            c.con.AddValue(p.str_base);
            c.con.AddValue(c.rlid);
            // int id = -1;

            if (c.con.ExecuteNoneQuery() > 0)
            {
                id = (int)c.con.LastID;
                p.PetID = id;
                pets.Add(id, p);
            }


            // IdBase++;
            return id;
        }

        public void DoPetLoad()
        {

            if (pets.Count == 0) return;

            int[] keys = new int[pets.Count];

            pets.Keys.CopyTo(keys, 0);
            int fight = 0;

            foreach (int key in keys)
            {
                PetItem p = pets[key];

                if (p.isActive != 0)
                {
                    fight = p.PetID;
                }

                /* if (p.skills.Count == 0)
                 {
                     PetSkill sk = new PetSkill();
                     sk.ID = 1;
                     sk.Level = 4;
                     sk.Value = 1000;
                     p.skills.Add(sk);
                 }*/
                UpdatePetCombat(ref p);

                pets[key] = p;

            }

            if (fight != 0)
                SetDefualtPet(fight);

        }

        public bool Load()
        {
            //ByteC.LoadProto(c.accid + file, ref p);
            c.con.StartCommand("SELECT petid, career, name, RenameCount, lvl, quality, str_base, intl_base, agi_base, str_new, intl_new, agi_new, joy, isActive, w_fightPos, Joy_lim, PetType, starLv, Luck, expc, expc_lim, Skill_Slots, z15_specialSkillId, skillsb FROM pet WHERE roleid=?;");
            c.con.AddValue(c.rlid);

            Connector.DataReader rd = c.con.ExecuteRead();

            bool b = rd.CanRead;

            if (b)
            {
                while (rd.NextRow())
                {
                    PetItem itm = new PetItem();
                    ContentResolver.DoDeserializeLoop<PetItem>(itm, rd);
                    pets.Add(itm.PetID, itm);
                }
                DoPetLoad();
            }
            rd.Close();

            return b;
        }

        public bool Save()
        {
            if (CurrentPet == 0)
                return true;
            //ByteC.SaveProto(c.accid + file, this);
            c.con.StartCommand("UPDATE pet SET ? WHERE petid=? AND roleid=?;");
            c.con.AddValue(ContentResolver.DoSerializeUpdate<PetItem>(pets[CurrentPet]), true);
            c.con.AddValue(CurrentPet);
            c.con.AddValue(c.rlid);

            return c.con.ExecuteNoneQuery() > 0;
        }

        public bool setPetState(int petid, byte state)
        {
            c.con.StartCommand("UPDATE pet SET isactive=? WHERE petid=? AND roleid=?;");
            c.con.AddValue(state);
            c.con.AddValue(petid);
            c.con.AddValue(c.rlid);

            return c.con.ExecuteNoneQuery() > 0;

        }

        public bool SetDefualtPet(int id)
        {

            if (CurrentPet != 0)
            {
                PetItem pp = pets[CurrentPet];


                if (!setPetState(CurrentPet, 0))
                    return false;

                pp.isActive = 0;
                pets[CurrentPet] = pp;
            }

            CurrentPet = pets[id].PetID;
            PetType = pets[id].PetType;
            PetName = pets[id].name;
            PetLev = (byte)pets[id].level;
            PetQual = (byte)pets[id].quality;

            PetItem p = pets[CurrentPet];
            p.isActive = 1;

            if (!setPetState(CurrentPet, 1))
                return false;

            pets[CurrentPet] = p;

            return true;
        }

        public byte GetLevel(int id)
        {
            return (byte)((pets[id].quality * 10) + pets[id].starLv);
        }

        public void UpdatePet()
        {
            int id = CurrentPet;
            // CurrentPet = pets[id].a_id;
            PetType = pets[id].PetType;
            PetName = pets[id].name;
            PetLev = (byte)pets[id].level;
            PetQual = (byte)pets[id].quality;

        }
        public void ResetPet()
        {
            if (CurrentPet != 0)
            {
                PetItem pp = pets[CurrentPet];
                pp.isActive = 0;

                setPetState(CurrentPet, 0);

                pets[CurrentPet] = pp;
            }
            CurrentPet = 0;
            PetType = 0;
            PetName = "";
            PetLev = 0;
            PetQual = 0;
        }


        public PetItem GetPet()
        {
            return GetPet(CurrentPet);
        }
        public PetItem GetPet(int id)
        {
            if (id == 0) return new PetItem();
            return pets[id];
        }
        public int GetExpMax()
        {
            return GetExpMax(CurrentPet);
        }

        public int GetExpMax(int id)
        {
            if (id == 0) return 0;
            return ExpMax((byte)pets[id].level);
        }

        public void Update(PetItem p)
        {
            if (p.PetID == 0) return;

            UpdatePetCombat(ref p);
            pets[p.PetID] = p;

            if (p.PetID == CurrentPet)
                UpdatePet();
        }

        /*public static void Create(ConnectionInfo c)
        {
            Pet p = new Pet();
            p.CreateId(c);
            p.Save(c);
            p = null;
        }*/

    }

}
