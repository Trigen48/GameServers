using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;
namespace GameServer
{
    [ProtoContract]
    internal class RoleControl
    {
        const byte level = 1;

      
        public Medal medal;
        public Bag bag;
        public Role role;
        public Vip vip;
        public Skill skill;
        public Title title;
        public Horoscope horoscope;
        public Pet pet;
        public Mount mount;
        public Shortcut shortcut;
        public LuckyWheel luckywheel;

        [ProtoMember(13)]
        public Tasks quest;

        public Active active;
        public ConnectionInfo cc;
        public Combat combat;
        public Escort escort;
        public Reward reward;

       /* [ProtoMember(19)]
        public Instance instance;*/
        public AutoFight auto;

     
        public Buff buff;

       /* [ProtoMember(22)]
        public Wardrobe costume;*/

        // [ProtoMember(23)]
        public Chance chance;

        //[ProtoMember(24)]
        public ZodiacGoal goal;

        // [ProtoMember(25)]
        public Frame gameframe;

       // [ProtoMember(26)]
        public Premium explore;

        //[ProtoMember(27)]
        //public Friend friends;

        public Guild guild;

        //[ProtoMember(30)]
        public Happy happy;

        public StarMap starmap;


        public RoleControl()
        {

        }

        public void Assign(ConnectionInfo c)
        {
            cc = c;
        }

        public RoleControl(ConnectionInfo c)
        {
            cc = c;
            chance = new Chance();

            role = new Role(c); //Char.Load(c, ref charz);
            if (!role.Load())
            {
                c.CutConnection = true;
                return;
            }

            medal = new Medal(c); //Medal.Load(c, ref medal);
            if (!medal.Load())
            {
                c.CutConnection = true;
                return;
            }

            active = new Active(c);
            if (!active.Load())
            {
                c.CutConnection = true;
                return;
            }

            auto = new AutoFight(c);
            if (!auto.Load())
            {
                c.CutConnection = true;
                return;
            }

            horoscope = new Horoscope(c);
            if (!horoscope.Load())
            {
                c.CutConnection = true;
                return;
            }

            luckywheel = new LuckyWheel(c);
            if (!luckywheel.Load())
            {
                c.CutConnection = true;
                return;
            }
            mount = new Mount(c);
            if (!mount.Load())
            {
                c.CutConnection = true;
                return;
            }

            title = new Title(c); //Title.Load(c, ref title);
            if (!title.Load())
            {
                c.CutConnection = true;
                return;
            }
            escort = new Escort(c);
            if (!escort.Load())
            {
                c.CutConnection = true;
                return;
            }

            skill = new Skill(c);
            if (!skill.Load())
            {
                c.CutConnection = true;
                return;
            }

            shortcut = new Shortcut(c);
            if (!shortcut.Load())
            {
                c.CutConnection = true;
                return;
            }

            reward = new Reward(c);
            if (!reward.Load())
            {
                c.CutConnection = true;
                return;
            }

            pet = new Pet(c);
            if (!pet.Load())
            {
                c.CutConnection = true;
                return;
            }

            vip = new Vip(c);

            if (!vip.Load())
            {
                c.CutConnection = true;
                return;
            }

            bag = new Bag(c);
            if (!bag.Load())
            {
                c.CutConnection = true;
                return;
            }


            combat = new Combat(c);
            if (!combat.Load())
            {
                c.CutConnection = true;
                return;
            }

            starmap = new StarMap(c);
            if (!starmap.Load())
            {
                c.CutConnection = true;
                return;
            }

            buff = new Buff(c);
            if (!buff.Load())
            {
                c.CutConnection = true;
                return;
            }

            goal = new ZodiacGoal(c);
            if (!goal.Load())
            {
                c.CutConnection = true;
                return;
            }

     
            quest = new Tasks(c); //Tasks.Load(c, ref quest);
            if (!Tasks.Load(c,ref quest))
            {
                c.CutConnection = true;
                return;
            }
            
            explore = new Premium(c);

            if (!explore.Load())
            {
                c.CutConnection = true;
                return;
            }



            gameframe = new Frame();
            //friends = new Friend(); Friend.Load(c, ref friends);
      

            guild = new Guild(c);
            if (!guild.Load())
            {
                c.CutConnection = true;
                return;
            }

            happy = new Happy(c);
            if (!happy.Load())
            {
                c.CutConnection = true;
                return;
            }

            if (active.day != DateUtil.GetZoneDate().Day || active.Month != DateUtil.GetZoneDate().Month)
            {
                Reset(c);
            }

            // Check instance
            if (World.World.IsInstance(role.map_id))
            {
                if (World.World.Instances[c.rlid] == null || !World.World.Instances[c.rlid].CanEnter)
                {
                    role.posx = 34;
                    role.posy = 42;

                    role.map_id = 502;
                    role.Save();
                }
            }

        }

        public void Reset(ConnectionInfo c)
        {

            #region Reset Active

            active.day = (byte)DateUtil.GetZoneDate().Day;

            if (active.Month != DateUtil.GetZoneDate().Month)
            {
                active.Month = (byte)DateUtil.GetZoneDate().Month;
                active.activepoints = 0;
                active.Claims = "";
                active.DayClaim = 0;
                active.lasttime = 0;
                active.Signin = "";

            }

            active.Save();

            #endregion

            #region Rewards daily at 12am
            if (reward.phase > 6)
            {
                reward.phase = 7;
                reward.remain = RewardHelper.GetTime(reward.phase);
                reward.targettime = (int)DateUtil.GetDateIntZone() + reward.remain;
                //reward.Save(c);
            }
            #endregion

            #region Horoscope Reset

            // ResetHoroscope
            horoscope.GenerateHoroscope();
            horoscope.trys = 3;
            if (vip.vip_level > 3 && vip.vip_level < 11)
            {
                horoscope.trys += vip.vip_level;
            }
            else if (vip.vip_level > 10)
            {
                horoscope.trys = 99;
            }
            horoscope.Save();

            #endregion

            #region Reset GuilPoints

            /*if (guild.GuildID != 0)
            {
                guild.ClaimedBenefits = 0;
                guild.todayDonations = 0;
                //guild.Save(c);
            }*/

            #endregion

            #region Quest reset

            //quest.TransportAmount = 3;

            #endregion

            #region Shop Reset

            if (explore.ShopBuy != ShopHelper.Time)
            {
                explore.Reset();
                explore.ShopBuy = ShopHelper.Time;
                explore.Save();
            }

            #endregion

            #region Vip Reset
            if (vip.vip_level > 0)
            {
                vip.claimbuff = 0;
                vip.claimpack = 0;
                vip.Save();
            }
            #endregion

            if (c.Player != null)
                combat.Compute();
        }

        public bool Send(byte[] data)
        {
            try
            {
                if (cc.Socket == null || !cc.Socket.Connected) return false;

                lock (cc.SendBlock)
                {
                    //while (!connection.Socket.Poll(100, System.Net.Sockets.SelectMode.SelectWrite)) System.Threading.Thread.Sleep(1000);;
                    cc.Socket.Send(data);
                }
                return true;
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                log.Save(ex);
                return false;
            }
        }

        public void Save()
        {
            try
            {

                role.Save();
                medal.SaveMedal();
                vip.Save();
                // skill.Save(c);
                //title.Save(c);

                horoscope.Save();
                pet.Save();
                mount.Save();

                luckywheel.Save();
                //quest.Save();
                active.Save();
                escort.Save();
    
                combat.Save();

                //instance.Save(cc);
                auto.Save();

               // buff.Save(cc);
    
                goal.Save();
                explore.Save();
                happy.Save();
            }
            catch (Exception ex)
            {
                log.Save(ex);
            }
        }

       // public 

        public static void Create(ConnectionInfo c, int rlid, byte career)
        {
            Medal.Create(rlid);
            Active.Create(rlid);
            AutoFight.Create(rlid);
            Horoscope.Create(rlid);
            Mount.Create(career, rlid);
            Bag.Create(rlid); 
            Vip.Create(rlid);
            LuckyWheel.Create(rlid);
            Tasks.Create(rlid);

            Escort.Create(rlid);
            Reward.Create(rlid);
            Combat.Create(career,rlid);
            StarMap.Create(rlid);

            ZodiacGoal.Create(rlid);
            Premium.Create(career,rlid);
            //Friend.Create(c);
            Happy.Create(rlid);

            FriendHelper.AddGroups(rlid);

        }

        public static void Reset(int id)
        {

            ConsoleCode.PassCommand("del," + id.ToString());
            ConnectionInfo c = ConnectionInfo.CreateInstance(id);
            if (CharExists(c))
            {
                // Char ch = new Char();
                /*Char.Load(c, ref ch);*/
                //CharControl.Create(c, ch.career, ch.sex, ch.name, ch.star);
            }
        }

        public static bool CharExists(ConnectionInfo c)
        {
            /* return System.IO.Directory.Exists(c.accid) && System.IO.File.Exists(c.accid + Char.pfile);*/
            return false;
        }

        public static void Backup(int id)
        {
            Backup(id, Game.BackupDir);
        }

        public static void Backup(int id, string backupDir)
        {
            // Check if the backup dir exists
            Game.CreateDir(backupDir);

            ConnectionInfo c = ConnectionInfo.CreateInstance(id);
            if (CharExists(c))
            {

                RoleControl cr = new RoleControl(c);
                ByteC.SaveProto(backupDir + id.ToString() + ".bk", cr);
                cr = null;
            }
            c = null;
        }

        public static void Restore(int id)
        {
            ConsoleCode.PassCommand("del," + id.ToString());
            ConnectionInfo c = ConnectionInfo.CreateInstance(id);
            if (System.IO.Directory.Exists(c.accid))
            {
                if (System.IO.File.Exists(Game.BackupDir + id.ToString() + ".bk"))
                {
                    RoleControl cr = new RoleControl();
                    cr.Assign(c);

                    ByteC.LoadProto(Game.BackupDir + id.ToString() + ".bk", ref cr);

                    cr.Save();
                    cr = null;
                }
            }
            c = null;
        }

        public bool SetOnline()
        {
            return cc.con.ExecuteNoneQuery("UPDATE role SET isonline=1 WHERE roleid=" + cc.rlid+";")==1;
        }

        public bool SetOffline()
        {
            return cc.con.ExecuteNoneQuery("UPDATE role SET isonline=0 WHERE roleid=" + cc.rlid + ";") == 1;
        }
    }

}
