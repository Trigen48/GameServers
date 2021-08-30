using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{
    public partial class Scene
    {

        public List<SceneMonster> Monsters;
        public Dictionary<int, MonsterTemplate> MonTemp;
        internal List<SceneMonster> respawn;

        public void Respawn(ByteArray ot)
        {
            lock (respawn)
            {

                if (respawn.Count != 0)
                {
                    int cnt = 0;

                    SceneMonster m;
                    while (true)
                    {
                        if (cnt >= respawn.Count) break;

                        int curr = (int)DateUtil.GetDateIntZone();
                        if (respawn[cnt].respawn <= curr)
                        {
                            m = respawn[cnt];


                            m.hp = MonTemp[m.monster_id].hp_lim;
                            m.mp = MonTemp[m.monster_id].mp_lim;
                            lock (Monsters) Monsters.Add(m);

                            ot.WriteShort(45 + MonTemp[m.monster_id].name.Length + MonTemp[m.monster_id].expand.Length);
                            ot.WriteShort(12007);
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
                            lock (Monsters) Monsters.Add(m);
                            respawn.RemoveAt(cnt);
                        }
                        else
                        {
                            cnt++;
                        }
                    }


                    Broadcast(ot.GetByteArray());
                    ot.Clear();
                }
            }
        }

        public bool MonsterExists(int id)
        {
            return GetMonster(id) != -1;
        }

        public int GetMonster(int id)
        {
            return Monsters.FindIndex(delegate(SceneMonster m) { return m.id == id; });
        }

        public virtual void MonsterRemove(ConnectionInfo c, int id)
        {
            lock (Monsters)
            {

                int mid = GetMonster(id);

                if (mid == -1) return;

                SceneMonster m = Monsters[mid];

                lock (drops)
                {
                    if (DropTableData.DropSets.ContainsKey(m.monster_id))
                    {
                        //int item =;
                        List<DropTable.DropTableItem> its = DropTableData.DropSets[m.monster_id].Pop();

                        if (its.Count != 0)
                        {
                            //List<drop> dropsx = new List<drop>();

                            ByteArray ar = new ByteArray();
                            ar.WriteShort(its.Count);
                            foreach (DropTable.DropTableItem drp in its)
                            {

                                drop d = new drop();
                                d.x = m.x;
                                d.y = m.y;
                                d.type = drp.type;
                                d.bind = drp.bind;
                                d.roleid = c.rlid;
                                d.time = (int)DateUtil.GetDateIntZone() + 62;
                                d.id = DropID;
                                DropID++;
                                drops.Add(d);

                                ar.WriteInt(d.id);
                                ar.WriteInt(d.type);
                                ar.WriteInt(d.time);
                                ar.WriteShort(d.x);
                                ar.WriteShort(d.y);

                                // drops.Add(new drop(
                            }
                            ar.PackArray(12017);
                            Broadcast(ar.GetByteArray());
                            ar.Close();
                        }
                        its.Clear();


                    }
                }

                c.ot.WriteShort(12);
                c.ot.WriteShort(12081);
                c.ot.WriteInt(m.id);
                c.ot.WriteInt(0);
                Monsters.RemoveAt(mid);

                lock (respawn)
                {
                    if (MonTemp[m.monster_id].RespawnTime == 0) return;
                    m.respawn = MonTemp[m.monster_id].RespawnTime + (int)DateUtil.GetDateIntZone();
                    m.MonsterActivity = MonsterState.IDLE;
                    m.NextMoveTime = MonsterPatrolTimeOut * Distance(m.ox, m.oy, m.x, m.y);
                    m.x = m.ox;
                    m.y = m.oy;
                    respawn.Add(m);
                }

            }
        }

    }
}
