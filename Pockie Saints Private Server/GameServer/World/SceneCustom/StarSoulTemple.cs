using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace GameServer.World
{
    public class StarSoulTemple: Scene
    {

        public StarSoulTemple(int IDs)
        {
            CreateNew(IDs);

            DropTableData.Add(709007);
            DropTableData.Add(709008);
            DropTableData.Add(709009);
            DropTableData.Add(709010);

            DropTableData.DropSets[709007].AddTableSet();
            DropTableData.DropSets[709007].AddSetItem(0, 2261004, 1, 100, 2);
            DropTableData.DropSets[709007].Build();

            DropTableData.DropSets[709008].AddTableSet();
            DropTableData.DropSets[709008].AddSetItem(0, 2262004, 1, 100, 2);
            DropTableData.DropSets[709008].Build();

            DropTableData.DropSets[709009].AddTableSet();
            DropTableData.DropSets[709009].AddSetItem(0, 2263004, 1, 100, 2);
            DropTableData.DropSets[709009].Build();

            DropTableData.DropSets[709010].AddTableSet();
            DropTableData.DropSets[709010].AddSetItem(0, 2264004, 1, 100, 2);
            DropTableData.DropSets[709010].Build();

            /*DropTableData.
            DropTableData.items.Add(709007, new int[][] { new int[] { ,2,100 } });
            DropTableData.items.Add(709008, new int[][] { new int[] { 2262004, 2, 100 } });
            DropTableData.items.Add(709009, new int[][] { new int[] { 2263004, 2, 100 } });
            DropTableData.items.Add(709010, new int[][] { new int[] { 2264004, 2, 100 } });
            DropTableData.BuildChanceTable();*/
        }

        public override void Start()
        {
            
            tmr = new Timer(World.timerSec);
            tmr.Elapsed += new ElapsedEventHandler(this.Render);
            tmr.Start();
        }


        public override void Render(object sender, ElapsedEventArgs e)
        {
           // RunCheck();// Run a playercheck
            ByteArray ot = new ByteArray();
            Respawn(ot);// Respawn monsters here;
            Destruction();
        }

        public override pos ResolvePosition(int id)
        {
            
            switch((new Random()).Next(0,5))
            {
                case 1:
                   return new pos(44,15);

                case 2:
                   return new pos(46,56);
                case 3:
                    return new pos(15,59);
                case 4:
                    return new pos(46, 56);

            }

           // rand    


            return new pos(11, 15);
        }

      /*  public virtual void MonsterRemove(ByteArray ot, int id)
        {
            lock (Monsters)
            {

                int mid = GetMonster(id);

                if (mid == -1) return;

                SceneMonster m = Monsters[mid];

                ot.WriteShort(12);
                ot.WriteShort(12081);
                ot.WriteInt(m.id);
                ot.WriteInt(0);
                Monsters.RemoveAt(mid);

                lock (respawn)
                {
                    if (MonTemp[m.monster_id].RespawnTime == 0) return;
                    m.respawn = MonTemp[m.monster_id].RespawnTime + (int)DateUtil.GetDateIntZone();
                    respawn.Add(m);
                }

            }
        }*/
    }
}
