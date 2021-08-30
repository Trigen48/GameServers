using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace GameServer.World
{
    internal class Zone
    {

        internal int ZoneID { get; set; }

        internal const int timerSec = 1000;
        internal System.Timers.Timer tmr;

        internal Dictionary<int, Scene> Scenez;
        internal InstanceData[] Instances;

        internal bool ServerLock = false;
        internal List<byte[]> MessageQ = new List<byte[]>();
        internal List<byte[]> MessageQ2 = new List<byte[]>();

        internal bool EnableRunCheck = false;


        internal void Init()
        {
            Scenez = new Dictionary<int, Scene>();

            tmr = new System.Timers.Timer(timerSec);
            tmr.Elapsed += new System.Timers.ElapsedEventHandler(Render);
            //InstanceDialogs = new Dictionary<int, InstanceDialog[]>();
            Instances = new InstanceData[Players.MaxPlayer];


            LoadBasic();
            tmr.Start();
        }

        internal void Render(object sender, ElapsedEventArgs e)
        {
            Banner.Render();
            ServerMessages();
        }

        internal void ServerMessages()
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

        internal void AddScene(int v, Scene s)
        {

            if (Scenez.ContainsKey(v)) return;
            Scenez.Add(v, s);
        }

        internal bool IsInstance(int map)
        {
            return World.InstanceScenes.Contains(map);
        }

        internal void CreateInstance(int map, ConnectionInfo c)
        {

            if (Instances[c.rlid] == null)
                Instances[c.rlid] = new InstanceData();
            else
                if (Instances[c.rlid].IsActive())
                    Instances[c.rlid].Destroy();

            // string insData="world/sceneConfig/"+ map.ToString();

            foreach (int key in World.SceneFloors[map])
            {
                Instances[c.rlid].Floors.Add(key, new Scene(key));
            }

            Instances[c.rlid].InitScene();
            Instances[c.rlid].StartTime = (int)DateUtil.GetDateIntZone();
            Instances[c.rlid].RemoveTime = (int)DateUtil.GetDateIntZone() + 60 * 60;

        }

        internal bool InstanceIsCreated(ConnectionInfo c)
        {
            return Instances[c.rlid] != null;
        }

        internal Scene GetScene(ConnectionInfo c)
        {
            return GetScene(c.rlid);
        }

        internal Scene GetScene(int roleid)
        {
            int map = Players.GetPlayer(roleid).role.map_id;
            bool IsBoss = map >= 701 && map <= 708;
            bool isOutSide = map <= 515 || map == 709 || map == 900 || map == 930 || map == 970 || map == 977;

            if (IsBoss || isOutSide)
            {
                return Scenez[map];
            }


            if (Instances[roleid] != null && Instances[roleid].Floors.ContainsKey(map))
            {
                return Instances[roleid].Floors[map];
            }
            return null;
        }

        internal void LoadBasic()
        {
            AddScene(100, new Scene(100));// Glory Acadamy
            Scenez[100].Behave = true;
            //Scenez[100].Start();// Start timer for glory Acadamy

            AddScene(201, new Scene(201));//City Of Trees
            AddScene(301, new Scene(301));//Glory City
            AddScene(401, new Scene(401));//City Of Rage
            AddScene(709, new StarSoulTemple(709));

            int i;

            // add  scenes
            for (i = 501; i < 516; i++)
            {
                AddScene(i, new Scene(i));//outer levels

                if (Scenez[i].Monsters.Count != 0)
                {
                    // Scenez[i].Start();
                }
            }

            // add boss levels
            for (i = 701; i < 708; i++)
            {
                AddScene(i, new Scene(i));//boss levels
               // Scenez[i].Start();
            }


            Scenez[502].SetResetPoint(35, 42);
           // Scenez[709].Start();


        }



        /*
        internal void SaveTeleports()
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
        */


        internal Dictionary<int, pos> Telep = new Dictionary<int, pos>();


        internal void RemoveScene(int WorldSceneID)
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
