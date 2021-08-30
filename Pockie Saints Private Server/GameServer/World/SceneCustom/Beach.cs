using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace GameServer.World
{
    public class Beach: Scene
    {

        #region Server Beach Times 


        internal static byte[][] Times = new byte[][] {
            new byte[]{ 20, 21, 0},
            new byte[]{ 19, 30, 0}
                                };
        internal static int chestSpawnRate = 120;
        internal static int NextSpawnRate = 123;


        internal static int Duration = 3600;

        

        public static int GetNextTime()
        {

            if (Times == null)
                throw new Exception("No beach time created");

            int time1;
            int time = (int)DateUtil.GetDateIntZone();

            foreach (byte[] timep in Times)
            {
                time1 = (int)DateUtil.GetTodayInt(timep[0], timep[1], timep[2]);
                if (time < time1 + Beach.Duration)
                {
                    return time1;
                }
            }


            time1 = (int)DateUtil.GetTodayInt(Times[0][0], Times[0][1], Times[0][2]);
            return time1 + (86400);
        }

        #endregion

        int ChestId = 3000;
      //  int rem;


        ShuffleList<pos> ChestLocation;
        ShuffleList<byte> chestNum;
        ShuffleList<int[]> op1, op2;
        //int chests = 0;
        int SpawnTime;
        int ChestRemoveTime;
        public bool BlockChest = false;
        public Beach(int IDs, int removetime)
        {
            RemoveTime = removetime;
           // rem = endtime;
            CreateNew(IDs);

            ChestLocation = new ShuffleList<pos>();
            chestNum = new ShuffleList<byte>();
            op1 = new ShuffleList<int[]>();
            op2 = new ShuffleList<int[]>();

            // Chest Locations
            ChestLocation.Add(new pos(5, 29));//
            ChestLocation.Add(new pos(15, 26));//
            ChestLocation.Add(new pos(7, 12));//
            ChestLocation.Add(new pos(16, 46));//
            ChestLocation.Add(new pos(3, 49));//
            ChestLocation.Add(new pos(9, 57));//
            ChestLocation.Add(new pos(14, 63));//
            ChestLocation.Add(new pos(27, 49));//
            ChestLocation.Add(new pos(35, 48));
            ChestLocation.Add(new pos(45, 45));
            ChestLocation.Add(new pos(42, 18));
            ChestLocation.Add(new pos(24, 35));//
            ChestLocation.ShuffleInplace();

            int[][] d = new int[][] {
                new int[]{ 2286001, 1,1}, // Clown Doll <
                new int[]{ 6040080, 1,2}, // Purple Seed
                new int[]{ 6040138, 3,2}, // Fusion Potion Piece
                new int[]{ 6040083, 1,2}, // Supply Scroll
                new int[]{ 2286001, 1,1}, // Clown Doll     <    
                new int[]{ 6040147,1,2}   // Refining Stone Piece

            };

            op1.AddRange(d);

            d = new int[][] { 
                new int[]{ 8010002, 1,2}, // Hp Crystal <
                new int[]{ 6040135, 3,2}, // Starlight Stone Piece
                new int[]{ 8010002, 1,2}, // Hp Crystal <
                new int[]{ 6040082, 3,2}, // Gem Piece
                new int[]{ 8010002, 1,2}, // Hp Crystal <
                new int[]{ 3012006, 2,2}  // Low Upgrade Core
            }; 


            op2.AddRange(d);
            d = null;

            op1.ShuffleInplace();
            op2.ShuffleInplace();


            AddChestSpawns(1, 3);
            AddChestSpawns(3, 5);
            AddChestSpawns(2, 5);
            AddChestSpawns(4, 3);
            chestNum.ShuffleInplace();
        
           // int minutes = ((int)DateUtil.GetDateIntZone() - rem)/(60000);

            MonsterTemplate mm = new MonsterTemplate();

            mm.hp_lim = 1;
            mm.type = 2;
            //mm.mp = 10000;
            mm.mp_lim = 10000;
            mm.level = 30;
            mm.name = "Chest";
            mm.monster_id = 601101;
            mm.resource_type = 601101;
            mm.expand = "";

            MonTemp.Add(mm.monster_id,mm);
            Start(Render);

        }

        private void SpawnChests()
        {
            if(BlockChest) return;
           // if(chests==0) return;
            int time = (int)DateUtil.GetDateIntZone();


            if (time > SpawnTime)
            {

                int chests = (RemoveTime - time) / chestSpawnRate;

                if (chests <= 0)
                {
                    BlockChest = true;
                    return;
                }

                SpawnTime = (int)DateUtil.GetDateIntZone() + NextSpawnRate;
                ChestRemoveTime = SpawnTime - 3;
                CreateChest();


            }

        }

        public void AddChestSpawns(byte num, byte count)
        {
            for (byte i = 0; i < count; i++) 
                chestNum.Add(num);
        }

        public void CreateChest()
        {

            chestNum.ShuffleInplace();
            ChestLocation.ShuffleInplace();
                
            ChestData.Clear();         
   
            ByteArray ot = new ByteArray();
            lock (Monsters)
            {
                SceneMonster m = new SceneMonster();
                m.hp = 1;
                m.mp = 1;
                m.monster_id = 601101;

                //int maxnum = 45 + MonTemp[m.monster_id].name.Length + MonTemp[m.monster_id].expand.Length;

                ByteArray ar;
                for (int x = 0; x < chestNum[0]; x++)
                {
                    ar = new ByteArray();

                    m.x = (byte)ChestLocation[x].x;
                    m.y = (byte)ChestLocation[x].y;
                    m.id = ChestId;

                 //   ot.WriteShort(maxnum);
                  //  ot.WriteShort(12007);

                    ar.WriteShort(m.x);
                    ar.WriteShort(m.y);
                    ar.WriteInt(m.id);
                    ar.WriteInt(m.monster_id);
                    ar.WriteInt(m.hp);
                    ar.WriteInt(m.mp);
                    ar.WriteInt(MonTemp[m.monster_id].hp_lim);
                    ar.WriteInt(MonTemp[m.monster_id].mp_lim);
                    ar.WriteShort(MonTemp[m.monster_id].level);
                    ar.WriteString(MonTemp[m.monster_id].name);
                    ar.WriteShort(MonTemp[m.monster_id].speed);
                    ar.WriteInt(MonTemp[m.monster_id].resource_type);
                    ar.WriteByte(MonTemp[m.monster_id].type);
                    ar.WriteString(MonTemp[m.monster_id].expand);

                    /*ot.WriteShort(a_x);
                    ot.WriteShort(b_y);
                    ot.WriteInt(c_id);
                    ot.WriteInt(c_typeId);
                    ot.WriteInt(d_hp);
                    ot.WriteInt(e_mp);
                    ot.WriteInt(f_hp_lim);
                    ot.WriteInt(g_mp_lim);
                    ot.WriteShort(h_lev);
                    ot.WriteString(i_name);
                    ot.WriteShort(j_speed);
                    ot.WriteInt(k_resId);
                    ot.WriteByte(l_type);
                    ot.WriteString(m_expand);*/

                    ar.PackArray(12007);
                    ot.WriteBytes(ar.GetByteArray());

                    //if (!MonsterExists(m.id)) throw new Exception();
                    Monsters.Add(m);
                    ChestData.Add(ChestId, GetChestDrop());
                  

                    ChestId++;
                    ar.Close();
                }
                byte[] d = ot.GetByteArray();

                ot.Close();
                int[] plz = null;
                lock (players)
                {
                    plz = new int[players.Count]; players.Keys.CopyTo(plz, 0);
                }
                for (int x = 0; x < plz.Length; x++)
                {
                    RoleControl rl = Players.GetPlayer(plz[x]);
                    if (rl == null) continue;

                    if (rl.cc.currentScene.ID == ID)
                        if (!rl.Send(d))
                            Program.CloseConnection(rl.cc);
                }
                d = null;
            }

        }

        private int[][] GetChestDrop()
        {
            //drop d= new drop();

            int[][] data = new int[4][];

            data[0]=new int[]{ 6020001,2,1}; 
            data[1]=new int[]{ 6020002,1,1};

            op1.ShuffleInplace();
            data[2] = op1[0];

            op2.ShuffleInplace();
            data[3] = op2[0];



            return data;
        }

        public override void Render(object sender, ElapsedEventArgs e)
        {
            //RunCheck();// Run a playercheck
            SpawnChests(); // Spawn Chests Here
            ClearChests(); // RemoveChests Here
            Destruction();
        }

        public override void Destroy()
        {

            op1.Clear();
            op2.Clear();

            ChestLocation.Clear();
           // ChestData.Clear();
            ChestLocation = null;
           // ChestData = null;
            op1 = null;
            op2 = null;

            base.Destroy();

        }

        public override void Destruction()
        {
            if (RemoveTime == 0) return;

            if (RemoveTime > DateUtil.GetDateIntZone()) return;
            tmr.Stop();

            // System.Threading.Thread.Sleep(time);
            ByteArray ot;
            CanEnter = false;

            //lock(players)
          //  int[] k = (int[])(players.ToArray().Clone());

            lock (players)
            {
                int[] k = new int[players.Count];
                players.Keys.CopyTo(k, 0);
                for (int x = 0; x < k.Length; x++)
                {

                    RoleControl rl=Players.GetPlayer(k[x]);
                    if (rl == null) continue;
                    ot = new ByteArray();


                    rl.role.posx = 34;
                    rl.role.posy = 42;
                    rl.role.map_id = 502;

                    ot.WriteInt(502);
                    ot.WriteShort(34);
                    ot.WriteShort(42);
                    ot.WriteString("");
                    ot.WriteInt(502);
                    ot.PackArray(12005);

                    rl.Send(ot.GetByteArray());

                    ot.Close();
                }
                k = null;
            }

            players.Clear();
            Destroy();
           /* lock (World.SceneRemove)
            {
                //World.AddSceneRemove(ID,(int)DateUtil.GetDateIntZone()+60);
            }*/

        }

        public void ClearChests()
        {

            if (BlockChest) return;

            if (ChestRemoveTime > DateUtil.GetDateIntZone()) return;
            ByteArray ot = new ByteArray();

            lock (Monsters)
            {
                if (Monsters.Count != 0)
                {
                    foreach (SceneMonster m in Monsters)
                    {
                        ot.WriteShort(12);
                        ot.WriteShort(12081);
                        ot.WriteInt(m.id);
                        ot.WriteInt(0);

                    }
                    byte[] d = ot.GetByteArray();
                    ot.Close();

                    int[] plz = null;
                    lock (players)
                    {
                          plz = new int[players.Count];  players.Keys.CopyTo(plz, 0);
                    }
                    for (int x = 0; x < plz.Length; x++)
                    {
                        RoleControl rl = Players.GetPlayer(plz[x]);
                        if (rl == null) continue;

                        if (rl.cc.currentScene.ID == ID)
                            if (!rl.Send(d))
                                Program.CloseConnection(rl.cc);
                    }
                    Monsters.Clear();
                    ChestData.Clear();
                    d = null;
                }
            }
        }

        public override pos ResolvePosition(int id)
        {
            return new pos(11,30);
        }

        public override void RemoveCollect(int id)
        {
            
                lock (Monsters)
                {

                    ByteArray ot = new ByteArray();

                    int mid = GetMonster(id);

                    if (mid == -1) return;

                    SceneMonster m = Monsters[mid];

                    ot.WriteShort(12);
                    ot.WriteShort(12081);
                    ot.WriteInt(m.id);
                    ot.WriteInt(0);

                    byte[] d = ot.GetByteArray();
                    ot.Close();

                    Broadcast(d);
                    /*lock (players)
                    {

                        for (int x = 0; x < players.Count; x++)
                        {
                            if (Players.GetPlayer(players[x]) == null) continue;
                            Players.GetPlayer(players[x]).Send(d);
                        }
                    }*/

                    Monsters.RemoveAt(mid);
                    if (ChestData.ContainsKey(mid))
                    {
                        ChestData.Remove(mid);
                    }

                }
            
        }

    }
}
