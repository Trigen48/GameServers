#define MDF

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace GameServer
{
    public partial class Scene
    {

        public int idx;
        public string name;

        public byte ResetX = 0;
        public byte ResetY = 0;

        internal int mapw = 0, maph = 0, maprevive = 0, maptype = 0;
        internal byte revivex = 0, revivey = 0;
        internal byte mapx = 0, mapy = 0;
        internal byte[][] mapcol = null;
        public bool CanEnter = true;
        internal int EndTime = 0;
        internal byte minlvl = 0, maxlvl = 255;
        internal byte maxplayers = 0;
        internal int Inst = 0;
        int rx, ry;
        public int RemoveTime = 0;
        // public const int wait = 5000;
        internal int[] SceneEXPFormulea = new int[] { 0, 0 };
        public Timer tmr;
        public List<SceneExit> Exitpoint;
        public List<SceneNpc> NPC;
        public int ID = 0;
        public int StartTime;


        void IDisposable.Dispose()
        {
            if (tmr != null)
            {
                tmr.Dispose();
            }
            tmr = null;
        }

        public Scene()
        {
        }

        public virtual void Start()
        {
            Start(Render);
        }

        public virtual void Start(ElapsedEventHandler esp)
        {
            tmr = new Timer(World.World.timerSec);
            tmr.Elapsed += new ElapsedEventHandler(Render);
            tmr.Start();
        }

        public virtual void Destroy()
        {
            if (tmr != null && tmr.Enabled == true) tmr.Stop();

            // while (tmr.Enabled); // wait untill timer is off
            Exitpoint.Clear();
            Monsters.Clear();
            NPC.Clear();
            players.Clear();
            collects.Clear();
            drops.Clear();
            ChestData.Clear();
            MonTemp.Clear();
            Exitpoint = null;
            MonTemp = null;
            Monsters = null;
            NPC = null;
            players = null;
            collects = null;
            drops = null;
            ChestData = null;
        }

        private void init()
        {
            //   tmr = new Timer();
            Exitpoint = new List<SceneExit>();
            Monsters = new List<SceneMonster>();
            NPC = new List<SceneNpc>();
            players = new Dictionary<int, byte>();
            collects = new Dictionary<int, int>();
            drops = new List<drop>();
            ChestData = new Dictionary<int, int[][]>();
            respawn = new List<SceneMonster>();
            MonTemp = new Dictionary<int, MonsterTemplate>();
        }

        public Scene(int IDs)
        {
            init();
            ID = IDs;
            Load(IDs);
        }

        public void FindPortal()
        {
            ResetX = (byte)Exitpoint[0].x;
            ResetY = (byte)Exitpoint[0].y;
        }

        public void CreateNew(int IDs)
        {
            init();
            ID = IDs;
            Load(IDs);

        }

        public Scene(int IDs, int x, int y)
        {
            init();
            ID = IDs;
            Load(IDs);


            rx = x;
            ry = y;

        }

        public Scene(int IDs, int InstanceID)
        {
            init();
            ID = IDs;
            Load(IDs);

            Inst = InstanceID;
        }

        public void SetResetPoint(int x, int y)
        {
            rx = x; ry = y;
        }

      /*  public void UpdatePlayer(ConnectionInfo c)
        {
            ByteArray ot = new ByteArray();

            ot.WriteShort(c.Player.role.posx);
            ot.WriteShort(c.Player.role.posy);
            ot.WriteInt(c.rlid);
            ot.WriteInt(c.Player.combat.hp);
            ot.WriteInt(c.Player.combat.mp);
            ot.WriteInt(c.Player.combat.hp_lim);
            ot.WriteInt(c.Player.combat.mp_lim);
            ot.WriteByte(c.Player.role.level);
            ot.WriteByte(c.Player.role.career);
            ot.WriteString(c.Player.role.name);
            ot.WriteShort(c.Player.combat.GetSpeed(c));
            ot.WriteInt(c.Player.role.weapon_id);
            ot.WriteByte(c.Player.combat.weapon_st);
            ot.WriteInt(c.Player.role.armor_id);
            ot.WriteByte(c.Player.combat.armor_st);
            ot.WriteByte(c.Player.role.showType);
            ot.WriteInt(c.Player.mount.mount_id);
            ot.WriteInt(c.Player.combat.isFullSet);
            ot.WriteByte(c.Player.combat.full_st);
            ot.WriteByte(c.Player.role.sex);
            ot.WriteByte(0);//s_isTeamLeader);
            ot.WriteByte(c.Player.role.faction);
            ot.WriteByte(c.Player.role.pk_mode);
            ot.WriteInt(c.Player.guild.GuildID);
            ot.WriteString(c.Player.guild.GuildName);
            ot.WriteByte(c.Player.role.faction);
            ot.WriteString(0);//w_team);
            ot.WriteShort(c.Player.role.sin);

            ot.WriteInt(c.Player.pet.PetType);

            ot.WriteString(c.Player.pet.PetName);//z02_petName);
            ot.WriteByte(c.Player.pet.PetQual);//z03_quality);
            ot.WriteByte(c.Player.pet.PetLev);//z04_petlev);

            ot.WriteByte(c.Player.medal.MedalTotal());//z05_medalStar);
            ot.WriteInt(c.Player.skill.GetDeform(c.Player.role.career));//z06_deform);
            ot.WriteByte(c.Player.role.star);
            ot.WriteByte(c.Player.vip.vip_level);//z08_vipLev);
            ot.WriteByte(c.Player.escort.escortState);//z09_escortState);
            ot.WriteByte(c.Player.escort.escortQuality);//z09_escortQuality);
            ot.WriteByte(c.Player.role.rest);
            ot.WriteShort(c.Player.role.title_id);
            ot.WriteString(c.Player.role.mate_name);//z13_mateName);
            ot.WriteByte(c.Player.role.mate_faction);
            ot.WriteByte(c.Player.combat.suit_level);//z15_dressStrengthen);
            ot.PackArray(12003);
        }

        */


        public void Revive(ConnectionInfo c)
        {
            ByteArray ot = new ByteArray();

            ot.WriteShort(c.Player.role.posx);
            ot.WriteShort(c.Player.role.posy);
            ot.WriteInt(c.rlid);
            ot.WriteInt(c.Player.combat.hp);
            ot.WriteInt(c.Player.combat.mp);
            ot.WriteInt(c.Player.combat.hp_lim);
            ot.WriteInt(c.Player.combat.mp_lim);
            ot.WriteByte(c.Player.role.level);
            ot.WriteByte(c.Player.role.career);
            ot.WriteString(c.Player.role.name);
            ot.WriteShort(c.Player.combat.GetSpeed(c));
            ot.WriteInt(c.Player.role.weapon_id);
            ot.WriteByte(c.Player.combat.weapon_st);
            ot.WriteInt(c.Player.role.armor_id);
            ot.WriteByte(c.Player.combat.armor_st);
            ot.WriteByte(c.Player.role.showType);
            ot.WriteInt(c.Player.mount.mount_id);
            ot.WriteInt(c.Player.combat.isFullSet);
            ot.WriteByte(c.Player.combat.allStrengthen);
            ot.WriteByte(c.Player.role.sex);
            ot.WriteByte(0);//s_isTeamLeader);
            ot.WriteByte(c.Player.role.faction);
            ot.WriteByte(c.Player.role.pk_mode);
            ot.WriteInt(c.Player.guild.GuildID);
            ot.WriteString(c.Player.guild.GuildName);
            ot.WriteByte(c.Player.role.faction);
            ot.WriteString(0);//w_team);
            ot.WriteShort(c.Player.role.sin);

            ot.WriteInt(c.Player.pet.PetType);

            ot.WriteString(c.Player.pet.PetName);//z02_petName);
            ot.WriteByte(c.Player.pet.PetQual);//z03_quality);
            ot.WriteByte(c.Player.pet.PetLev);//z04_petlev);

            ot.WriteByte(c.Player.medal.MedalTotal());//z05_medalStar);
            ot.WriteInt(c.Player.skill.GetDeform(c.Player.role.career));//z06_deform);
            ot.WriteByte(c.Player.role.star);
            ot.WriteByte(c.Player.vip.vip_level);//z08_vipLev);
            ot.WriteByte(c.Player.escort.escortState);//z09_escortState);
            ot.WriteByte(c.Player.escort.escortQuality);//z09_escortQuality);
            ot.WriteByte(c.Player.role.rest);
            ot.WriteShort(c.Player.role.title_id);
            ot.WriteString(c.Player.role.mate_name);//z13_mateName);
            ot.WriteByte(c.Player.role.mate_faction);
            ot.WriteByte(c.Player.combat.suit_level);//z15_dressStrengthen);
            ot.PackArray(12003);

            ot.WriteShort(14);
            ot.WriteShort(12010);
            ot.WriteInt(c.rlid);
            ot.WriteShort(c.Player.combat.GetSpeed(c));
            ot.WriteInt(c.Player.mount.mount_id);

            byte[] d = ot.GetByteArray();
            ot.Close();
            ot = null;

            int[] plz = null;

            lock (players)
            {
                //players.Add(c.rlid, 0);
                plz = new int[players.Count];
                players.Keys.CopyTo(plz, 0);
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

        public string GetNPCPos(int id)
        {
            string k = "1#&0";
            SceneNpc n = NPC.Find(delegate(SceneNpc m) { return m.a_id == id; });
            if (n.a_id == id)
            {
                k = n.d_x.ToString() + "#&" + n.e_y.ToString();
            }
            return k;
        }

        public void Load(int scene)
        {
            ID = scene;

            try
            {
                string lfile = "world/scene/" + scene.ToString();
                ByteArray ot;


                // Load Map collision
                lfile += "_col";

                if (System.IO.File.Exists(lfile))
                {
                    ot = new ByteArray("world/scene/" + scene.ToString() + "_col");

                    mapw = ot.ReadInt();
                    maph = ot.ReadInt();
                    maprevive = ot.ReadInt();

                    revivex = ot.ReadByte();
                    revivey = ot.ReadByte();

                    maptype = ot.ReadInt();

                    mapx = ot.ReadByte();
                    mapy = ot.ReadByte();

                    mapcol = new byte[mapx][];

                    for (byte xx = 0; xx < mapx; xx++)
                    {
                        mapcol[xx] = new byte[mapy];

                        for (byte yy = 0; yy < mapy; yy++)
                        {
                            mapcol[xx][yy] = ot.ReadByte();
                        }
                    }

                    ot.Close();
                }

                lfile = "world/scene/" + scene.ToString();
                if (System.IO.File.Exists(lfile))
                {
                    ot = new ByteArray(lfile);

                    int len;
                    int x = 0;

                    minlvl = ot.ReadByte();
                    maxlvl = ot.ReadByte();
                    maxplayers = ot.ReadByte();
                    RemoveTime = ot.ReadInt();

                    SceneEXPFormulea = new int[] { ot.ReadInt(), ot.ReadInt(), ot.ReadInt() };

                    len = ot.ReadShort();
                    for (x = 0; x < len; x++)
                    {
                        SceneExit ex = new SceneExit();
                        ex.scene = ot.ReadInt();
                        ex.text = ot.ReadString();
                        ex.x = ot.ReadByte();
                        ex.y = ot.ReadByte();
                        Exitpoint.Add(ex);

                    }

                    len = ot.ReadShort();
                    for (x = 0; x < len; x++)
                    {
                        MonsterTemplate mtd = new MonsterTemplate();

                        mtd.monster_id = ot.ReadInt();
                        mtd.hp_lim = ot.ReadInt();
                        mtd.mp_lim = ot.ReadInt();
                        mtd.level = ot.ReadByte();
                        mtd.name = ot.ReadString();
                        mtd.speed = (short)ot.ReadShort();
                        mtd.resource_type = ot.ReadInt();
                        mtd.type = ot.ReadByte();
                        mtd.expand = ot.ReadString();
                        mtd.RespawnTime = ot.ReadInt();
                        mtd.exp = ot.ReadInt();
                        byte f = ot.ReadByte();

                        if (f == 1)
                        {
                            mtd.combat = new int[6];

                            for (int i = 0; i < 6; i++)
                                mtd.combat[i] = ot.ReadInt();
                        }

                        if (mtd.type == 0 || mtd.type == 1 || mtd.type == 3 || mtd.type == 6)
                        {
                            mtd.combat = new int[] { 30, 40, 10, 10, 10, 10 };
                        }
                        MonTemp.Add(mtd.monster_id, mtd);
                        
                    }

                    len = ot.ReadShort();
                    for (x = 0; x < len; x++)
                    {
                        SceneMonster m = new SceneMonster();
                        
                        m.id = ot.ReadInt();
                        m.monster_id = ot.ReadInt();
                        m.ox = (byte)ot.ReadByte();
                        m.oy = (byte)ot.ReadByte();

                        m.x = m.ox;
                        m.y = m.oy;
                        m.sid = scene;
                        m.hp = MonTemp[m.monster_id].hp_lim;
                        m.mp = MonTemp[m.monster_id].mp_lim;
                        byte t = MonTemp[m.monster_id].type;
                        m.CanWalk = t == 0 || t == 1 || t == 3;
                        Monsters.Add(m);
                    }

                    if (Monsters.Count > 0)
                    {
                        steps.AddRange(new byte[] { 2, 3, 2, 2, 2, 4, 3, 3, 3, 4 });
                        steps.ShuffleShift();
                    }
                    len = ot.ReadShort();
                    for (x = 0; x < len; x++)
                    {
                        SceneNpc n = new SceneNpc();
                        n.a_id = ot.ReadInt();
                        n.b_typeId = ot.ReadInt();
                        n.c_name = ot.ReadString();
                        n.d_x = (short)ot.ReadByte();
                        n.e_y = (short)ot.ReadByte();
                        n.f_resId = ot.ReadInt();
                        NPC.Add(n);
                    }
                    ot.Close();
                }

            }
            catch (Exception ex)
            {
                log.Save(ex);
            }

        }

        public int GetExp(int tempId)
        {

            if (MonTemp.ContainsKey(tempId))
            {

                //int exp = 0;

                if (MonTemp[tempId].exp != 0)
                {
                    return MonTemp[tempId].exp;
                }

                return SceneEXPFormulea[0] + (((int)MonTemp[tempId].level - SceneEXPFormulea[1]) * SceneEXPFormulea[2]);

            }
            return 0;
        }

        public virtual void Destruction()
        {
            if (RemoveTime == 0) return;

            if (RemoveTime > DateUtil.GetDateIntZone()) return;
            tmr.Stop();
            // System.Threading.Thread.Sleep(time);
            ByteArray ot;
            CanEnter = false;

            //lock(players)


            //  i = (int[])(players.ToArray().Clone());

            lock (players)
            {

                int[] k = new int[players.Count];
                players.Keys.CopyTo(k, 0);
                for (int x = 0; x < k.Length; x++)
                {

                    RoleControl rl = Players.GetPlayer(k[x]);

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
                    players.Remove(k[x]);
                }
                k = null;
            }
            //k = null;
            players.Clear();
            Destroy();


        }

        public virtual void Render(object sender, ElapsedEventArgs e)
        {
            //RunCheck();// Run a playercheck
            ByteArray ot = new ByteArray();
            Respawn(ot);// Respawn monsters here;

#if MDF
            if (Behave)
#endif
                MonsterBehave(ot);

            // ot.Clear();
            CheckDrop(ot);
            Destruction();
        }

        public void GetSceneObjects(ByteArray ot)
        {
            int i; // count num;

            // write exit points
            ot.WriteShort(Exitpoint.Count);
            for (i = 0; i < Exitpoint.Count; i++)
            {
                SceneExit ex = Exitpoint[i];
                ot.WriteInt(ex.scene);
                ot.WriteString(ex.text);
                ot.WriteShort(ex.x);
                ot.WriteShort(ex.y);
            }

            lock (players)
            {
                // write players
                //  RunCheck();
                ot.WriteShort(players.Count);//players2.Count);

                foreach (int ix in players.Keys)
                {
                    RoleControl rl = Players.GetPlayer(ix);
                    if (rl == null)
                    {
                        ot.WriteBytes(new byte[89]);
                    }
                    else
                    {
                        ot.WriteShort(rl.role.posx);
                        ot.WriteShort(rl.role.posy);
                        ot.WriteInt(ix);
                        ot.WriteInt(rl.combat.hp);
                        ot.WriteInt(rl.combat.mp);
                        ot.WriteInt(rl.combat.hp_lim);
                        ot.WriteInt(rl.combat.mp_lim);
                        ot.WriteByte(rl.role.level);
                        ot.WriteByte(rl.role.career);
                        ot.WriteString(rl.role.name);
                        ot.WriteShort(rl.role.speed + rl.mount.mountspeed);
                        ot.WriteInt(rl.role.weapon_id);
                        ot.WriteByte(rl.combat.weapon_st);
                        ot.WriteInt(rl.role.armor_id);
                        ot.WriteByte(rl.combat.armor_st);
                        ot.WriteByte(rl.role.showType);
                        ot.WriteInt(rl.mount.mount_id);
                        ot.WriteInt(rl.combat.isFullSet);
                        ot.WriteByte(rl.combat.allStrengthen);
                        ot.WriteByte(rl.role.sex);
                        ot.WriteByte(0);//s_isTeamLeader);
                        ot.WriteByte(rl.role.faction);
                        ot.WriteByte(rl.role.pk_mode);
                        ot.WriteInt(rl.guild.GuildID);
                        ot.WriteString(rl.guild.GuildName);
                        ot.WriteByte(rl.role.faction);
                        ot.WriteString(0);//w_team);
                        ot.WriteShort(rl.role.sin);


                        ot.WriteInt(rl.pet.PetType);

                        ot.WriteString(rl.pet.PetName);//z02_petName);
                        ot.WriteByte(rl.pet.PetQual);//z03_quality);
                        ot.WriteByte(rl.pet.PetLev);//z04_petlev);
                        ot.WriteByte(rl.medal.MedalTotal());//z05_medalStar);

                        ot.WriteInt(rl.skill.GetDeform(rl.role.career));//z06_deform);
                        ot.WriteByte(rl.role.star);
                        ot.WriteByte(rl.vip.vip_level);//z08_vipLev);
                        ot.WriteByte(rl.escort.escortState);//z09_escortState);
                        ot.WriteByte(rl.escort.escortQuality);//z09_escortQuality);
                        ot.WriteByte(rl.role.rest);
                        ot.WriteShort(rl.role.title_id);
                        ot.WriteString(rl.role.mate_name);//z13_mateName);
                        ot.WriteByte(rl.role.mate_faction);
                        ot.WriteByte(rl.combat.suit_level);//z15_dressStrengthen);
                    }
                    ot.Flush();
                }
            }

            lock (Monsters)
            {
                // write monsters
                ot.WriteShort(Monsters.Count);
                for (i = 0; i < Monsters.Count; i++)
                {
                    SceneMonster m = Monsters[i];
                    ot.WriteShort(m.x);
                    ot.WriteShort(m.y);
                    ot.WriteInt(m.id);
                    ot.WriteInt(m.monster_id);
                    ot.WriteInt(m.hp);
                    ot.WriteInt(m.mp);
                    ot.WriteInt(MonTemp[m.monster_id].hp_lim);
                    ot.WriteInt(MonTemp[m.monster_id].mp_lim);
                    ot.WriteShort(MonTemp[m.monster_id].level);
                    ot.WriteString(MonTemp[m.monster_id].name);
                    ot.WriteShort(MonTemp[m.monster_id].speed);
                    ot.WriteInt(MonTemp[m.monster_id].resource_type);
                    ot.WriteByte(MonTemp[m.monster_id].type);
                    ot.WriteString(MonTemp[m.monster_id].expand);
                    ot.Flush();
                }
            }

            // write npc
            ot.WriteShort(NPC.Count);
            for (i = 0; i < NPC.Count; i++)
            {

                SceneNpc m = NPC[i];
                ot.WriteInt(m.a_id);
                ot.WriteInt(m.b_typeId);
                ot.WriteString(m.c_name);
                ot.WriteShort(m.d_x);
                ot.WriteShort(m.e_y);
                ot.WriteInt(m.f_resId);
                ot.Flush();
            }


        }


    }
}
