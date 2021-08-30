using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
namespace GameServer.World
{


    public static class World
    {
        const string Teleports = "world/Teleports.bin";
        public const int timerSec = 1000;
        public static System.Timers.Timer tmr;
        public static int WorldLevel;
        public static Dictionary<int, Scene> Scenez;
        public static InstanceData[] Instances;
        public static Dictionary<int, InstanceDialog[]> InstanceDialogs;

        public static Dictionary<int, int[]> SceneFloors;
        public static bool ServerLock = false;
        public static List<byte[]> MessageQ = new List<byte[]>();
        public static List<byte[]> MessageQ2 = new List<byte[]>();
        public static Dictionary<int, string> NpcLink = new Dictionary<int, string>();
        /* public static List<int> SceneRemove = new List<int>();*/
        public static List<int> InstanceScenes;
        public static int lockt = 60;
        public static bool EnableRunCheck = false;

        public static byte[] BackUpTime = new byte[] { 01, 00, 00 };

        public static byte[] RankUpdateTime = new byte[] { 05, 00, 00 };

        public static bool BackUpTimeEnable = false, RankUpdateTimeEnable = false;

        public static byte day = 0;


        public static void Init()
        {
            Scenez = new Dictionary<int, Scene>();

            tmr = new System.Timers.Timer(timerSec);
            tmr.Elapsed += new System.Timers.ElapsedEventHandler(Render);
            InstanceDialogs = new Dictionary<int, InstanceDialog[]>();
            Instances = new InstanceData[Players.MaxPlayer];
            SceneFloors = new Dictionary<int, int[]>();

            LoadBasic();
            WorldLevel = 70;


            tmr.Start();
        }

        public static void Render(object sender, ElapsedEventArgs e)
        {
            Banner.Render();
            //  RunCheck();
            ServerMessages();
            //RemoveScene();
        }

        public static void ServerMessages()
        {
            lock (MessageQ)
            {
                if (MessageQ.Count == 0 && MessageQ2.Count == 0) return;
                ByteArray ar = new ByteArray();

                if (MessageQ.Count != 0)
                {
                    ar.WriteShort(MessageQ.Count);
                    foreach (byte[] all in MessageQ)
                    {
                        ar.WriteBytes(all);
                    }
                    ar.PackArray(11010);
                }

                lock (MessageQ2)
                {
                    foreach (byte[] all in MessageQ2)
                    {
                        ar.WriteBytes(all);
                    }
                    MessageQ2.Clear();
                }

                byte[] d = ar.GetByteArray();
                chat.SendWorldMsg(ref d, 0);
                ar.Close();

                MessageQ.Clear();
                
            }
        }

        public static void AddScene(int v, Scene s)
        {

            if (Scenez.ContainsKey(v)) return;
            Scenez.Add(v, s);
        }

        public static bool IsInstance(int map)
        {
            return InstanceScenes.Contains(map);
        }

        public static void CreateInstance(int map, ConnectionInfo c)
        {

            if (Instances[c.rlid] == null)
                Instances[c.rlid] = new InstanceData();
            else
                if (Instances[c.rlid].IsActive())
                    Instances[c.rlid].Destroy();

            // string insData="world/sceneConfig/"+ map.ToString();

            foreach (int key in SceneFloors[map])
            {
                Instances[c.rlid].Floors.Add(key, new Scene(key));
            }

            Instances[c.rlid].InitScene();
            Instances[c.rlid].StartTime = (int)DateUtil.GetDateIntZone();
            Instances[c.rlid].RemoveTime = (int)DateUtil.GetDateIntZone() + 60 * 60;

        }

        public static bool InstanceIsCreated(ConnectionInfo c)
        {
            return Instances[c.rlid] != null;
        }



        public static bool isOutside(int map)
        {
            return map >= 100 && map <= 515;
        }

        public static bool isBoss(int map)
        {
            return map >= 701 && map <= 708;
        }

        public static bool isSpecial(int map)
        {
            return map == 709 || map == 900 || map == 930 || map == 970 || map == 977;
        }

        public static Scene GetSceneByMap(int map)
        {
            if (isBoss(map) || isSpecial(map))
            {
                return Scenez[map];
            }

            if (isOutside(map))
            {
                return Scenez[map];
            }



            return null;
        }

        public static Scene GetInstance(ConnectionInfo c, int map)
        {
            if (Instances[c.rlid] != null && Instances[c.rlid].Floors.ContainsKey(map))
            {
                return Instances[c.rlid].Floors[map];
            }

            return null;
        }

       /* public static Scene GetScene(ConnectionInfo c)
        {
            int map = c.Player.role.map_id;

            if (isBoss(map) || isSpecial(map) ||isOutside(map))
            {
                return Scenez[map];
            }


            if (Instances[c.rlid] != null && Instances[c.rlid].Floors.ContainsKey(map))
            {
                return Instances[c.rlid].Floors[map];
            }


            return null;
        }
        */
        /*public static Scene GetScene(int roleid)
        {
            RoleControl cs = Players.GetPlayer(roleid);

            if (cs == null)
                return null;

            return GetScene(cs.cc);
        }*/

        public static void LoadBasic()
        {
            AddScene(100, new Scene(100));// Glory Acadamy
            Scenez[100].Behave = true;
            Scenez[100].Start();// Start timer for glory Acadamy

            AddScene(201, new Scene(201));//City Of Trees
            AddScene(301, new Scene(301));//Glory City
            AddScene(401, new Scene(401));//City Of Rage
            AddScene(709, new StarSoulTemple(709));

            int i;

            // add static scenes
            for (i = 501; i < 516; i++)
            {
                AddScene(i, new Scene(i));//outer levels

                if (Scenez[i].Monsters.Count != 0)
                    Scenez[i].Start();
            }

            // add boss levels
            for (i = 701; i < 708; i++)
            {
                AddScene(i, new Scene(i));//boss levels
                Scenez[i].Start();
            }


            Scenez[502].SetResetPoint(35, 42);
            Scenez[709].Start();

            /* AddScene(990, new BattleField());//Battle Field

             Scenez[990].SetResetPoint(35, 42)*/

            InstanceDialogs.Add(502014, new InstanceDialog[] { new InstanceDialog(41, "632#&0#&2"), new InstanceDialog(41, "610#&0#&2"), new InstanceDialog(41, "613#&0#&2"), new InstanceDialog(41, "616#&0#&2"), new InstanceDialog(41, "637#&0#&2"), });
            InstanceDialogs.Add(502015, new InstanceDialog[] { new InstanceDialog(41, "601#&0#&5"), });
            InstanceDialogs.Add(502049, new InstanceDialog[] { new InstanceDialog(41, "3201#&0#&5"), new InstanceDialog(41, "3251#&0#&5"), });
            InstanceDialogs.Add(502020, new InstanceDialog[] { new InstanceDialog(41, "627#&0#&5"), new InstanceDialog(41, "677#&0#&5"), });
            InstanceDialogs.Add(502019, new InstanceDialog[] { new InstanceDialog(41, "605#&0#&5"), new InstanceDialog(41, "655#&0#&5"), });
            InstanceDialogs.Add(502048, new InstanceDialog[] { new InstanceDialog(41, "604#&0#&2"), new InstanceDialog(41, "654#&0#&2"), new InstanceDialog(41, "664#&0#&2"), new InstanceDialog(41, "674#&0#&2"), });
            InstanceDialogs.Add(502016, new InstanceDialog[] { new InstanceDialog(41, "602#&0#&10"), new InstanceDialog(41, "652#&0#&10"), });
            InstanceDialogs.Add(502023, new InstanceDialog[] { new InstanceDialog(41, "635#&0#&2"), new InstanceDialog(41, "619#&0#&2"), new InstanceDialog(41, "621#&0#&2"), new InstanceDialog(41, "623#&0#&2"), new InstanceDialog(41, "640#&0#&2"), });
            InstanceDialogs.Add(502017, new InstanceDialog[] { new InstanceDialog(41, "625#&0#&5"), new InstanceDialog(41, "675#&0#&5"), });
            InstanceDialogs.Add(502050, new InstanceDialog[] { new InstanceDialog(41, "3203#&0#&5"), new InstanceDialog(41, "3253#&0#&5"), });
            InstanceDialogs.Add(502021, new InstanceDialog[] { new InstanceDialog(41, "629#&0#&5"), new InstanceDialog(41, "679#&0#&5"), });



            foreach (int key in InstanceDialogs.Keys)
            {

                foreach (InstanceDialog d in InstanceDialogs[key])
                {
                    SceneNpc np = Scenez[502].NPC.Find(delegate(SceneNpc n) { return n.a_id == key; });

                    NpcLink.Add(int.Parse(d.Dialog.Substring(0, d.Dialog.IndexOf('#'))),

                        key.ToString() + "#&502#&" + np.d_x.ToString() + "#&" + np.e_y.ToString());
                }

            }

            if (System.IO.File.Exists(Teleports))
            {
                ByteArray ar = new ByteArray(Teleports);

                int c = ar.ReadInt();
                int id;
                for (i = 0; i < c; i++)
                {
                    id = ar.ReadInt();
                    pos p = new pos(ar.ReadByte(), ar.ReadByte());
                    Telep.Add(id, p);
                    Scenez[id].ResetX = (byte)p.x;
                    Scenez[id].ResetY = (byte)p.y;
                }
                ar.Close();
            }


            SceneFloors.Add(601, new int[] { 601 });

            InstanceScenes = new List<int>();
            InstanceScenes.AddRange(
                new int[]
                {
                    601,602,652,605,655,625,
                    626,675,676,627,628,677,
                    678,3201,3202,3251,3252,
                    629,630,631,679,680,681,
                    3203,3204,3253,3254
                });

            SceneFloors.Add(602, new int[] { 602 });
            SceneFloors.Add(652, new int[] { 652 });

            SceneFloors.Add(605, new int[] { 605 });
            SceneFloors.Add(655, new int[] { 655 });

            SceneFloors.Add(625, new int[] { 625, 626 });
            SceneFloors.Add(675, new int[] { 675, 676 });

            SceneFloors.Add(627, new int[] { 627, 628 });
            SceneFloors.Add(677, new int[] { 677, 678 });

            SceneFloors.Add(3201, new int[] { 3201, 3202 });
            SceneFloors.Add(3251, new int[] { 3251, 3252 });


            // SceneFloors.Add(, new int[] { });

            SceneFloors.Add(629, new int[] { 629, 630, 631 });
            SceneFloors.Add(679, new int[] { 679, 680, 681 });

            SceneFloors.Add(3203, new int[] { 3203, 3204 });
            SceneFloors.Add(3253, new int[] { 3253, 3254 });


            // Beach background service
            proc.threads.tMakeBeach = new System.Threading.Thread(CreateBeach);
            proc.threads.tMakeBeach.Start();

            // Start background rankings service
            proc.threads.tRanks = new System.Threading.Thread(Rankings.BackgroundWorker);
            proc.threads.tRanks.Start();

            // Daily super clock
            proc.threads.tSuperClock = new System.Threading.Thread(SuperClock);
            proc.threads.tSuperClock.Start();

            // Battle Field Clock
            proc.threads.tBattleField = new System.Threading.Thread(Gameplay.BattleFieldConfig.BattleWorker);
            proc.threads.tBattleField.Start();
        }

        public static void SuperClock()
        {
            string clock = Game.mainDir + "clock.clk";
            if (System.IO.File.Exists(clock))
            {
                byte[] dz = System.IO.File.ReadAllBytes(clock);
                day = dz[0];
                dz = null;

                if (DateUtil.GetZoneDate().Day != day)
                {
                    if (Events.Happy.happy.dayCount < 9)
                    {
                        Events.Happy.happy.dayCount++;
                        Events.Happy.Save();
                    }
                    day = (byte)DateUtil.GetZoneDate().Day;
                    System.IO.File.WriteAllBytes(clock, new byte[] { day });
                }
            }
            else
            {
                day = (byte)DateUtil.GetZoneDate().Day;
                System.IO.File.WriteAllBytes(clock, new byte[] { day });
            }

            if (ShopHelper.CanChange())
            {
                ShopHelper.ChangeDailyShop();
                ShopHelper.BuildDailyShop();
            }

            int d = 0;

        ret: ;
            d = (int)(DateUtil.GetTommorowIntZone(0, 0, 0) - DateUtil.GetDateIntZone());


            System.Threading.Thread.Sleep(d * 1000);

            day = (byte)DateUtil.GetZoneDate().Day;
            System.IO.File.WriteAllBytes(clock, new byte[] { day });

            lock (Events.Happy.happy)
            {
                if (Events.Happy.happy.dayCount < 9)
                {
                    Events.Happy.happy.dayCount++;
                    Events.Happy.Save();
                }

            }

            if (ShopHelper.CanChange())
            {
                ShopHelper.ChangeDailyShop();
            }

            goto ret;

        }

        public static void SaveTeleports()
        {
            if (Telep.Count == 0) return;

            int[] keys = new int[Telep.Count];

            Telep.Keys.CopyTo(keys, 0);

            ByteArray ar = new ByteArray();
            ar.WriteInt(keys.Length);
            for (int x = 0; x < keys.Length; x++)
            {
                ar.WriteInt(keys[x]);
                ar.WriteByte(Telep[keys[x]].x);
                ar.WriteByte(Telep[keys[x]].y);
            }
            ar.SaveFile(Teleports);
            ar.Close();
        }

        public static Dictionary<int, pos> Telep = new Dictionary<int, pos>();

        public static void CreateBeach()
        {
            int today = (int)DateUtil.GetDateIntZone();
            int nxt = Beach.GetNextTime();
            today = nxt - today;

            if (today < 0) today = 0;

            // sleep until it is time to deploy the beach
            System.Threading.Thread.Sleep(today * 1000);
            today = ((Beach.GetNextTime() + Beach.Duration + 120) - (int)DateUtil.GetDateIntZone());

            Scenez.Add(930, new Beach(930, nxt + Beach.Duration));

            proc.threads.tRemBeach = new System.Threading.Thread(() => RemoveBeach(today));
            proc.threads.tRemBeach.Start();

        }

        public static void RemoveBeach(int time)
        {
            System.Threading.Thread.Sleep(time * 1000);
            RemoveScene(930);
            CreateBeach();
        }

        public static void RemoveScene(int WorldSceneID)
        {
            lock (Scenez)
            {
                //Scenez[930].Destroy(); // Set Memory Free
                Scenez[WorldSceneID] = null; //
                Scenez.Remove(WorldSceneID);// Remove scene
            }
        }

    }
}
