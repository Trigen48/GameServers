using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{
    public partial class Scene
    {
        public List<drop> drops;
        public Dictionary<int, int[][]> ChestData;
        public int DropID = 1;
        public DropTable DropTableData = new DropTable();

    
        public drop PullDrop(int id, ConnectionInfo c)
        {
            drop dd = new drop();
            lock (drops)
            {
                int idz = 0;

                idz = drops.FindIndex(delegate(drop d) { return d.id == id; });

                if (idz == -1)
                {
                    return dd;
                }
                else
                {
                    dd = drops[idz];

                    if (dd.roleid == c.rlid && c.Player.bag.CanBagAdd(1))
                    {
                        drops.RemoveAt(idz);

                        ByteArray ot = new ByteArray();
                        ot.WriteShort(12);
                        ot.WriteShort(12019);
                        ot.WriteInt(dd.id);
                        ot.WriteInt(0);
                        Broadcast(ot.GetByteArray());
                        ot.Close();
                    }
                }
            }
            return dd;
        }

        public void GetSceneDrops(ByteArray ot)
        {
            lock (drops)
            {

                if (drops.Count == 0) return;
                ByteArray ar = new ByteArray();
                ar.WriteShort(drops.Count);
                foreach (drop d in drops)
                {
                    // ot.WriteShort(
                    ar.WriteInt(d.id);
                    ar.WriteInt(d.type);
                    ar.WriteInt(d.time);
                    ar.WriteShort(d.x);
                    ar.WriteShort(d.y);
                }
                ar.PackArray(12017);

                ot.WriteBytes(ar.GetByteArray());
                ar.Close();
            }
        }

        public virtual void CheckDrop(ByteArray ot)
        {
            lock (drops)
            {
                if (drops.Count == 0) return;


                while (drops.Count != 0 && drops[0].time > DateUtil.GetDateIntZone())
                {
                    ot.WriteShort(12);
                    ot.WriteShort(12019);
                    ot.WriteInt(drops[0].id);
                    ot.WriteInt(0);
                    drops.RemoveAt(0);
                }
                Broadcast(ot.GetByteArray());
                ot.Clear();
            }


        }


    }
}
