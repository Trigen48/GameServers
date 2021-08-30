using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{
    public partial class Scene
    {
        public short[][] Directions =new short[][]{new short[] { 0, 1 }, new short[] { 1, 0 }, new short[] { 1, 1 }, new short[] { -1, 1 },
             new short[] { 0, -1 }, new short[] { -1, 0 }, new short[] { -1, -1 },new short[] { 1, -1 } };
    
        public ShuffleList<byte> steps = new ShuffleList<byte>();
        public static int MonsterPatrolTimeOut = 5;
        public bool Behave = true;

        public virtual void MonsterBehave(ByteArray ot)
        {
            ShuffleList<SceneMonster> ms = new ShuffleList<SceneMonster>();
            lock (Monsters)
            {

                for (int x = 0; x < Monsters.Count; x++)
                {
                    SceneMonster m = Monsters[x];
                    if (m.CanWalk)
                    {
                        if (CreateLife(ref m))
                        {
                            // Update Movement or attack

                            if (m.MonsterActivity == MonsterState.IDLE)
                            {

                                ot.WriteShort(12);
                                ot.WriteShort(12008);
                                ot.WriteShort(m.x);
                                ot.WriteShort(m.y);
                                ot.WriteInt(m.id);


                            }

                        }
                        Monsters[x] = m;
                    }

                }

                if (ot.Length() > 0)
                    Broadcast(ot.GetByteArray());
                ot.Clear();
            }
        }

        public bool CreateLife(ref SceneMonster m)
        {
            switch (m.MonsterActivity)
            {
                case MonsterState.IDLE:
                    return IDLE(ref m);
            }
            return false;
        }

        public bool IDLE(ref SceneMonster m)
        {

            if (m.NextMoveTime > 0)
            {
                m.NextMoveTime--;
            }
            else
            {

                int mstep = steps.SelectRandom();
                m.NextMoveTime = MonsterPatrolTimeOut * mstep;

                ShuffleList<short[]> Direct = new ShuffleList<short[]>();

                Direct.AddRange(Directions);
                Direct.ShuffleShift();

                for (int x = 0; x < 6; x++)
                {
                    short[] mv = Direct[x];

                    int x2, y2;
                    x2 = m.x + (mv[0] * mstep);
                    y2 = m.y + (mv[1] * mstep);

                    if (!IsBlockedRange(m.x, m.y, mstep, mv[0], mv[1]) && !IsFarFromOrigin(m.ox, m.oy, x2, y2))
                    {
                        // PlotOnMap(m.x, m.y, 0);
                        m.x = (byte)(x2);
                        m.y = (byte)(y2);
                        return true;
                    }

                }

            }

            return false;
        }

        public static int Distance(int x1, int y1, int x2, int y2)
        {
            int distance = (int)Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)), 0);
            return distance;
        }

        public bool IsFarFromOrigin(int x1, int y1, int x2, int y2)
        {
            return Distance(x1, y1, x2, y2) > 4;
        }

        public bool IsBlockedRange(int x, int y, int step, short mx, short my)
        {
            if (mapcol != null )
            {
                for (int xx = 1; xx <= step; xx++)
                {
                    if (IsBlocked(x + (mx * xx), y + (my * xx)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsBlocked(int x, int y)
        {
            if (mapcol != null)
            {
                if (mapy > x && x > -1 && y > -1 && y < mapx && mapcol[y][x] == 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
