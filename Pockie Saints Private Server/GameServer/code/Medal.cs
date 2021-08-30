using System;
using System.Collections.Generic;
using System.Text;

using Connector;
namespace GameServer
{

    public static class MedalHelper
    {

        public static int[][] MedalLevelData= new int[][]{
            new int[]{0, 0, 0},
            new int[]{197, 284, 399},
            new int[]{385, 559, 789},
            new int[]{632, 922, 1303},
            new int[]{940, 1373, 1943},
            new int[]{1307, 1912, 2707},
            new int[]{1735, 2539, 3597}, 
            new int[]{2222, 3254, 4611}, 
            new int[]{2770, 4057, 5749}, 
            new int[]{3377, 4948, 7013}, 
            new int[]{4045, 5927, 8401},
            new int[]{5158, 7561, 10718}, 
            new int[]{6407, 9392, 13315}, 
            new int[]{7791, 11422, 16194},
            new int[]{9310, 13649, 19353},
            new int[]{10963, 16075, 22792}};

        public static int[][] MedalPower = new int[][]{
            new int[]{0,0,0,0}, 
            new int[]{ 136, 122, 175, 243},
            new int[]{ 228, 426, 620, 875},
            new int[]{ 336, 568, 828, 1170},
            new int[]{ 444, 730, 1066, 1507}, 
            new int[]{ 831, 912, 1333, 1886},
            new int[]{ 5062, 1115, 1630, 2307}, 
            new int[]{ 7312, 1337, 1957, 2771}, 
            new int[]{ 9562, 1580, 2313, 3276}, 
            new int[]{ 14175, 1844, 2699, 3824},
            new int[]{ 19687, 2127, 3115, 4413},
            new int[]{ 26100, 2431, 3560, 5045},
            new int[]{ 33412, 2755, 4036, 5719}, 
            new int[]{ 41625, 3099, 4541, 6435}, 
            new int[]{ 50737, 3464, 5075, 7193}, 
            new int[]{ 60750, 3848, 5639, 7993}, 
            new int[]{ 71662, 4253, 6233, 8836}, 
            new int[]{ 83475, 4679, 6857, 9720},
            new int[]{ 96187, 5124, 7511, 10647}, 
            new int[]{ 109800, 5590, 8194, 11616},
            new int[]{ 124312, 6076, 8906, 12627}, 
            new int[]{ 139725, 6582, 9649, 13680}, 
            new int[]{ 156037, 7109, 10421, 14775}, 
            new int[]{ 173250, 7655, 11223, 15912},
            new int[]{ 191362, 8222, 12055, 17091}, 
            new int[]{ 210375, 8810, 12916, 18313}, 
            new int[]{ 230287, 9417, 13807, 19576}, 
            new int[]{ 251100, 10045, 14728, 20882}, 
            new int[]{ 272812, 10693, 15678, 22230}, 
            new int[]{ 295424, 11136, 16328, 23152}, 
            new int[]{ 400000, 11361, 16658, 23620}};
        
        public static int[] WingStarSoul;
        public static int[][] WingFusion;
      //  public static int[] Starsoul;

        public static int[] MedalSkill;

        public static void Init()
        {
            WingStarSoul = new int[] { 20, 100, 300, 400, 800, 900, 1200, 5555, 8888, 12222, 69554, 856678, 78841111 };
           // Starsoul = new int[] { 10, 100, 500, 1000, 1200, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            WingFusion = new int[][]{
       
                new int[]{0         , 0, 10     , 0     , 0     , 0     , 0}, 
                new int[]{0         , 0, 50     , 164   , 164   , 179   , 241}, 
                new int[]{3320001   , 1, 100    , 232   , 232   , 254   , 342}, 
                new int[]{3320001   , 2, 200    , 311   , 311   , 341   , 461}, 
                new int[]{3320002   , 2, 300    , 403   , 403   , 442   , 599}, 
                new int[]{3320002   , 3, 400    , 506   , 506   , 556   , 754}, 
                new int[]{3320003   , 2, 600    , 622   , 622   , 683   , 927}, 
                new int[]{3320003   , 3, 800    , 749   , 749   , 823   , 1118}, 
                new int[]{3320004   , 3, 1000   , 889   , 889   , 976   , 1328}, 
                new int[]{3320004   , 3, 1200   , 1040  , 1040  , 1143  , 1555}, 
                new int[]{3320004   , 4, 1400   , 1204  , 1204  , 1323  , 1800}, 
                new int[]{3320004   , 4, 1600   , 1379  , 1379  , 1516  , 2063}, 
                new int[]{0         , 0, 0      , 1567  , 1567  , 1722  , 2345}};

            ByteArray w = new ByteArray("system/MedalSkill.bin");

            byte c = w.ReadByte();
 
            byte i;
            

            MedalSkill = new int[c];

            for (i = 0; i < c; i++)
            {
                MedalSkill[i] = w.ReadInt();
            }
            w.Close();
        }
    }
    
   
    public class Medal
    {
       // const string file = "medal";

       // Order Fire,Soil,Wind,Water
        public class MedalItem
        {
            
            public byte level { get; set; }
            public int WingStarSoul { get; set; }
            public int fails { get; set; }
            public MedalItem()
            {
            }
        }

       
        public byte medal_lev { get; set; }

        
        public int starsoul { get; set; }

       
        public MedalItem[] Wings { get; set; }
        //public int[][] Wings { get; set; }

        ConnectionInfo c;
        public void ActivateMedal()
        {
            medal_lev = 1;
        }

        public Medal(ConnectionInfo cc)
        {
            Wings = new MedalItem[4];
            c = cc;

            for (int x = 0; x < 4; x++)
            {
                Wings[x] = new MedalItem();
            }
        }

        public int GetPoints()
        {
            int p = 0;

            for (byte i = 0; i < 4; i++)
            {
                p += Wings[i].level;
                if (Wings[i].WingStarSoul == MedalHelper.WingStarSoul[Wings[i].level]) p += 1;
            }

            return p;
        }

        public byte getMedalLevel()
        {
                     
            byte lev=0;
            byte wing=MedalTotal();

            if (wing <= 16)
            {
                lev =(byte)Math.Max((wing / 2) - 1, 0);
            }
            else if (wing!=0)
            {
                lev = (byte)((wing / 4) + 3);
            }
            return lev;
        }

        public bool SaveMedal()
        {

            c.con.StartCommand("UPDATE medal SET medallvl=?,starsoul=? WHERE roleid=?;");

            c.con.AddValue(medal_lev);
            c.con.AddValue(starsoul);
            c.con.AddValue(c.rlid);

            return c.con.ExecuteNoneQuery() == 1;
        }

        public bool SaveWing(byte wingtype)
        {

            if (wingtype == 0)
            {
                c.con.StartCommand("UPDATE medal SET firelvl=?,firesoul=?,firefail=? WHERE roleid=?;");
            }
            else if (wingtype == 1)
            {
                c.con.StartCommand("UPDATE medal SET earthlvl=?,earthsoul=?,earthfail=? WHERE roleid=?;");
            }
            else if (wingtype == 2)
            {
                c.con.StartCommand("UPDATE medal SET windlvl=?,windsoul=?,windfail=? WHERE roleid=?;");
            }
            else if (wingtype == 3)
            {
                c.con.StartCommand("UPDATE medal SET waterlvl=?,watersoul=?,waterfail=? WHERE roleid=?;");
            }
            //c.con.StartCommand("UpdateMedalWing(?,?,?,?,?)");

            
            c.con.AddValue(Wings[wingtype].level);
            c.con.AddValue(Wings[wingtype].WingStarSoul);
            c.con.AddValue(Wings[wingtype].fails);

            c.con.AddValue(c.rlid);
            int i = c.con.ExecuteNoneQuery();
            return i == 1;
        }

        public bool Load()
        {

            c.con.StartCommand("SELECT medallvl, starsoul, firelvl, firesoul, firefail, earthlvl, earthsoul, earthfail , windlvl, windsoul, windfail, waterlvl, watersoul, waterfail FROM medal WHERE roleid=? LIMIT 1;");
            c.con.AddValue(c.rlid);

            DataReader rd = c.con.ExecuteRead();


            if (rd.CanRead && rd.NextRow())
            {

                medal_lev = rd.ReadByte();
                starsoul = rd.ReadInt();

                for (int x = 0; x < 4; x++)
                {
                    Wings[x].level = rd.ReadByte();
                    Wings[x].WingStarSoul = rd.ReadInt();
                    Wings[x].fails = rd.ReadInt();
                }

                rd.Close();
                rd = null;
                return true;
            }

            rd.Close();
            rd = null;
            return false;
        }

        public static bool Create(int roleid)
        {
            ConnectionInfo c = new ConnectionInfo(roleid);
            c.con.StartCommand("INSERT INTO Medal(roleid) VALUES(?);");
            c.con.AddValue(roleid);

            return c.con.ExecuteNoneQuery()>0;
        }

        public byte MedalTotal()
        {

            byte i=0;
            byte c=0;

            for(i=0;i<4;i++)
            {
                c += (byte)Wings[i].level;
            }

            return c;
        }

        public bool TryUpgrade(byte wing)
        {
            if (Wings[wing].level < 2)
            {
              //  return true;
            }
            else
            {

                if (!c.Player.chance.HardChance(((double)Wings[wing].fails * 5) / (double)MedalHelper.WingFusion[Wings[wing].level][2]))
                {
                    Wings[wing].fails += 1;
                    return false;
                }
 
            }
            Wings[wing].level++;
            Wings[wing].WingStarSoul = 0;
            Wings[wing].fails = 0;
            return true;
        }

        
    }

}
