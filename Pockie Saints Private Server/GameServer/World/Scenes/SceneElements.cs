using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{

    public enum MonsterState
    {
        IDLE=0x0,
        ATTACKING=0x01,
        FOLLOWING=0x02,
        RETURNING=0x03
    }


    public class SceneMonster
    {

        public int sid;
        public byte x;
        public byte y;

        public byte ox;
        public byte oy;

        public int id;
        public int monster_id;
        public int hp, mp;
        public int respawn;
        //

        public int NextMoveTime;
        public bool IsFighting;
        public MonsterState MonsterActivity;
        public List<int> engaged;
        public bool CanWalk;
    }


  
    public struct SceneExit
    {
        public int scene;
        public byte x, y;
        public string text;
        //public int tx, ty;
    }

    public struct pos
    {
        public int x, y;
        public pos(int X, int Y)
        {
            x = X;
            y = Y;
        }
    }

    public struct SceneNpc
    {
        public int a_id;
        public int b_typeId;
        public String c_name;
        public short d_x;
        public short e_y;
        public int f_resId;
    }

    public class DropTable
    {

        public Dictionary<int, DropTableSet> DropSets = new Dictionary<int, DropTableSet>();

        public class DropTableSet
        {
            public List<DropTableSetItems> SetItems = new List<DropTableSetItems>();

            public void AddTableSet()
            {
                SetItems.Add(new DropTableSetItems());
            }

            public void AddSetItem(int Pid, int ItemType, byte count, int percent, byte bind)
            {
                SetItems[SetItems.Count - 1].AddSetItem(ItemType, count, percent, bind);
            }

            public void Build()
            {
                for (int x = 0; x < SetItems.Count; x++)
                {
                    SetItems[x].Build();
                }
            }

            public List<DropTableItem> Pop()
            {
                List<DropTableItem> items = new List<DropTableItem>();


                for (int x = 0; x < SetItems.Count; x++)
                {
                    DropTableItem it = SetItems[x].Pop();

                    if (it.type == 0) continue;
                    for (byte i = 0; i < it.count; i++)
                        items.Add(new DropTableItem(it.type, 1, it.bind));
                }

                return items;
            }
        }

        public class DropTableSetItems
        {
            public byte bind = 1;

            public List<DropTableItem> SetItems = new List<DropTableItem>();
            ShuffleList<byte> ChanceTable = new ShuffleList<byte>();

            public void AddSetItem(int ItemType, byte count, int percent, byte bind)
            {
                SetItems.Add(new DropTableItem(ItemType, count, bind));
                byte id = (byte)(SetItems.Count);

                for (int x = 0; x < percent; x++)
                    ChanceTable.Add(id, true);
            }

            public void Build()
            {

                if (ChanceTable.Count < 100)
                    ChanceTable.AddRange(new byte[100 - ChanceTable.Count]);

                ChanceTable.ShuffleInplace();
                ChanceTable.ShuffleShift();
                ChanceTable.ShuffleInplace();
            }

            public DropTableItem Pop()
            {
                byte id = ChanceTable.SelectRandom();

                if (id == 0) return new DropTableItem();
                return SetItems[id - 1];
            }

        }

        public struct DropTableItem
        {
            public int type;
            public byte count;
            public byte bind;

            public DropTableItem(int Type, byte Count, byte Bind)
            {
                type = Type;
                count = Count;
                bind = Bind;
            }
        }

        public void Add(int id)
        {
            DropSets.Add(id, new DropTableSet());
        }
    }

    public struct drop
    {
        /* public int id;
         public bool type;
         public string app;
         */
        public int id, type, time;
        public byte x, y;
        public int roleid;
        public byte bind;
        public drop(int id1, int type1, int roleid1, byte x1, byte y1, byte bind1)
        {
            id = id1;
            type = type1;
            roleid = roleid1;
            x = x1;
            y = y1;
            time = (int)DateUtil.GetDateIntZone() + 60;
            bind = bind1;
        }

    }

    public static class MonsterAI
    {


    }
}
