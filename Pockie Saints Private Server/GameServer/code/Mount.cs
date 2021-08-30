using System;
using System.Collections.Generic;
using System.Text;

using Connector;
namespace GameServer
{
  

    public class Mount
    {
        //const string file = "mounts";
        ConnectionInfo c;
      
        public class MountItem
        {
            [ContentProto("mounttype")]
            public int mount_type { get; set; }

            [ContentProto("selected")]
            public byte Selected { get; set; }

            [ContentProto("mounttime")]
            public int mount_time { get; set; }

            public MountItem()
            {
            }
        }


        [ContentProto("mountlvl")]
        public byte mount_level { get; set; }

        [ContentProto("mountexp")]
        public int mount_exp { get; set; }

        [ContentProto("mountstar")]
        public byte mount_star { get; set; }

        [ContentProto("mountstarexp")]
        public int mount_star_exp { get; set; }

        [ContentProto("mounttime")]
        public int mount_time { get; set; }

        [ContentProto("mountstart")]
        public int start_time { get; set; }

        [ContentProto("imountclaimed")]
        public bool iMountClaimed { get; set; }

        [ContentProto("mountstate")]
        public byte mount_state { get; set; }

        [ContentProto("selMount",true)]
        public int mounttype { get; set; }

        [ContentProto("fact")]
        public byte fact { get; set; }

        public List<MountItem> mounts { get; set; }

        public int mount_id;

        public short mountspeed = 0;

        public int hp, atk, def, hit, dod, crit, fort;

        public bool levelup = false;

        public Mount(ConnectionInfo cc)
        {
            c = cc;
            mounts = new List<MountItem>();
        }

        public bool Add(int id)
        {
            return Add(id, 0);
        }

        public bool Add(int id, int time)
        {

            if (GetMount(id) != -1) return false;

            MountItem m = new MountItem();
            m.mount_type = id;
            m.mount_time = time;


            if (mounts.Count == 0)
            {
                mounttype = id;
                m.Selected = 1;
                mount_level = 1;

            }


            c.con.StartCommand("INSERT INTO mountitem(roleid, mounttype, selected, mounttime) VALUES (?,?,?,?);");
            c.con.AddValue(c.rlid);
            c.con.AddValue(m.mount_type);
            c.con.AddValue(m.Selected);
            c.con.AddValue(m.mount_time);

            if (c.con.ExecuteNoneQuery() <1)
            {
                return false;
            }


            mounts.Add(m);

            ComputeCombat();

            return true;
        }

        public bool ChangeMount(int id, byte status)
        {

            c.con.StartCommand("UPDATE mountitem SET selected=? WHERE mounttype=? AND roleid=?");
            c.con.AddValue(status);
            c.con.AddValue(id);        
            c.con.AddValue(c.rlid);

            return c.con.ExecuteNoneQuery() > 0;
        }

        public bool Remove(int id)
        {

            int p = GetMount(id);

            if (p == -1) return false;

            c.con.StartCommand("DELETE FROM mountitem WHERE roleid=? AND mounttype=?;");
            c.con.AddValue(c.rlid);
            c.con.AddValue(id);

            if (c.con.ExecuteNoneQuery() < 1)
            {
                return false;
            }

            mounts.RemoveAt(p);

            ComputeCombat();
            return true;
        }

        public int GetMount(int id)
        {
            int i = 0;
            i = mounts.FindIndex(delegate(MountItem bk) { return bk.mount_type == id; });
            return i;
        }

        public bool CanUpgrade()
        {
            int time = (mount_time - start_time);

            if (time > 900 && DateUtil.GetDateIntZone() < mount_time)
            {
                return false;
            }

            return (mount_star < 30);
        }

        public bool UpgradeGold()
        {

            if (DateUtil.GetDateIntZone() >= mount_time)
            {
                start_time = (int)DateUtil.GetDateIntZone();
                mount_time = start_time;
            }

            mount_time += 60;

            mount_star_exp += 13;


            if (mount_star_exp >= MountHelper.starArray[mount_star])
            {
                mount_star_exp = mount_star_exp - MountHelper.starArray[mount_star];
                mount_star++;
                levelup = true;
                ComputeCombat();
            }

            return CanUpgrade();
        }

        public void ComputeCombat()
        {

            hp = 0;
            atk = 0;
            def = 0;
            hit = 0;
            dod = 0;
            crit = 0;
            fort = 0;

            // Add Mount Power
            byte i;
            for (i = 0; i < mounts.Count; i++)
            {
                int id = mounts[i].mount_type;

                hp += MountHelper.mount_stats[id][3];

                atk += MountHelper.mount_stats[id][1];
                def += MountHelper.mount_stats[id][2];

                hit += MountHelper.mount_stats[id][4];
                dod += MountHelper.mount_stats[id][5];
                crit += MountHelper.mount_stats[id][6];
                fort += MountHelper.mount_stats[id][7];
            }

            var _loc_4 = Combat.Fmodule2[fact - 1];
            var _loc_5 = 0.1m * 0.4m * ((25m * (decimal)mount_level * (decimal)mount_level + 25m * (decimal)mount_level) + 150m);
            decimal _loc_6 = 0.1m * 0.5m * (decimal)(25m * this.getNumber(mount_level, mount_star) * this.getNumber(mount_level, mount_star) + 25m * this.getNumber(mount_level, mount_star));

            i = 0;
            atk += (int)(decimal.Round((_loc_6 + _loc_5) * _loc_4[i])); i++;
            def += (int)decimal.Round((_loc_6 + _loc_5) * _loc_4[i]); i++;
            hp += (int)decimal.Round((_loc_6 + _loc_5) * _loc_4[i]); i++;
            hit += (int)decimal.Round((_loc_6 + _loc_5) * _loc_4[i]); i++;
            dod += (int)decimal.Round((_loc_6 + _loc_5) * _loc_4[i]); i++;
            crit += (int)decimal.Round((_loc_6 + _loc_5) * _loc_4[i]); i++;
            fort += (int)decimal.Round((_loc_6 + _loc_5) * _loc_4[i]); i++;

        }

        public bool DeductCrystal(ConnectionInfo c, byte type)
        {

            int cost = 0;

            if (type == 1) cost = 13;
            else if (type == 2) cost = 130;
            else cost = 650;


            if (c.Player.bag.crystal < cost) return false;


            c.Player.bag.crystal -= cost;
            c.Player.bag.Save();

            mount_star_exp += (cost / 13) * 35;

            while (mount_star_exp >= MountHelper.starArray[mount_star])
            {
                mount_star_exp = mount_star_exp - MountHelper.starArray[mount_star];
                mount_star++;
                levelup = true;
                ComputeCombat();
                if (mount_star == 30) break;
            }



            return true;

        }

        private decimal getNumber(byte param1, byte param2)
        {
            if (param2 < 21)
            {
                return 5 * param2;
            }
            return 2 * param2 + 60;
        }// end function

        public bool DeductCost(ConnectionInfo c)
        {
            int cost = (mount_star * mount_star * 20) + 250;
            if (c.Player.bag.bgold + c.Player.bag.gold < cost)
            {
                return false;
            }


            if (c.Player.bag.bgold < cost)
            {
                cost = cost - c.Player.bag.bgold;
                c.Player.bag.bgold = 0;

                if (c.Player.bag.gold < cost)
                {
                    cost = cost - c.Player.bag.gold;
                    c.Player.bag.gold = 0;

                }
                else
                {
                    c.Player.bag.gold = c.Player.bag.gold - cost;
                }

            }
            else
            {
                c.Player.bag.bgold = c.Player.bag.bgold - cost;
            }

            c.Player.bag.Save();

            return true;
        }

        public bool Load()
        {
            //ByteC.LoadProto(c.accid + file, ref val);
            c.con.StartCommand("SELECT m.mountlvl, m.mountexp, m.mountstar, m.mountstarexp, m.mounttime, m.mountstart, m.mountstate, m.fact, i.mountType selMount,m.imountclaimed"
                                + " FROM mount m"
                                + " LEFT OUTER JOIN mountitem i"
                                + " on m.roleid=i.roleid AND i.selected=1"
                                + " WHERE  m.roleid=? LIMIT 1;");

            c.con.AddValue(c.rlid);
            bool loaded = ContentResolver.DoDeserialize<Mount>(this, c.con);


            if (loaded == true)
            {
                c.con.StartCommand("SELECT mounttype, selected, mounttime FROM mountitem WHERE roleid=?;");
                c.con.AddValue(c.rlid);

                DataReader rd = c.con.ExecuteRead();

                if (rd.CanRead)
                {
                    while (rd.NextRow())
                    {
                        MountItem mnt = new MountItem();

                        mnt.mount_type = rd.ReadInt();
                        mnt.Selected = rd.ReadByte();
                        mnt.mount_time = rd.ReadInt();
                        mounts.Add(mnt);
                    }
                }

                rd.Close();
                ComputeCombat();
            }


            return loaded;
        }

        public bool Save()
        {
            c.con.StartCommand("UPDATE mount SET ? WHERE roleid=?;");
            c.con.AddValue(ContentResolver.DoSerializeUpdate<Mount>(this), true);
            c.con.AddValue(c.rlid);
            return c.con.ExecuteNoneQuery() > 0;
        }

        public static bool Create(byte car,int roleid)
        {
            ConnectionInfo c = new ConnectionInfo(roleid);
            c.con.StartCommand("INSERT INTO mount(roleid,mountlvl,fact) VALUES(?,?,?);");
            c.con.AddValue(roleid);
            c.con.AddValue(1);
            c.con.AddValue(car);
            return c.con.ExecuteNoneQuery() > 0;
        }
    }

}
