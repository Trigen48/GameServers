using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{
    public partial class Scene
    {
        public Dictionary<int, int> collects;

        public virtual void StartCollect(int id, ConnectionInfo c)
        {
            lock (collects)
            {
                c.Player.quest.collectid = id;
                collects.Add(id, c.rlid);
            }
        }

        public virtual bool StopCollect(ConnectionInfo c)
        {
            lock (collects)
            {
                if (collects.ContainsKey(c.Player.quest.collectid))
                {
                    collects.Remove(c.Player.quest.collectid);
                    c.Player.quest.collectid = -1;
                    return true;
                }
                return false;
            }
        }

        public virtual bool CompleteCollect(ConnectionInfo c)
        {
            lock (collects)
            {
                if (collects.ContainsKey(c.Player.quest.collectid) && MonsterExists(c.Player.quest.collectid))
                {
                    collects.Remove(c.Player.quest.collectid);
                    return true;
                }
                return false;
            }
        }

        public virtual void RemoveCollect(int id)
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
                d = null;

                Monsters.RemoveAt(mid);
                lock (respawn)
                {
                    if (MonTemp[m.monster_id].RespawnTime == 0) return;
                    m.respawn = MonTemp[m.monster_id].RespawnTime + (int)DateUtil.GetDateIntZone();
                    respawn.Add(m);
                }
            }


        }

        public virtual bool CanCollect(int id)
        {
            lock (collects)
            {

                if (collects.ContainsKey(id))
                {
                    RoleControl rl = Players.GetPlayer(collects[id]);
                    /*if (rl == null) continue;

                    if (World.World.GetScene(plz[x]).ID == ID)
                        if (!rl.Send(d))
                            Program.CloseConnection(rl.cc);*/
                    if (rl == null || rl.quest.collectid != id)
                    {
                        collects.Remove(id);
                    }
                }
                return !collects.ContainsKey(id) && MonsterExists(id);
            }
        }


    }
}
