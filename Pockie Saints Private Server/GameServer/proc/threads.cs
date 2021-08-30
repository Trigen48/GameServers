using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GameServer.proc
{
    static class threads
    {

        internal static Thread tMakeBeach, tRanks, tSuperClock, tRemBeach,tBattleField;


        internal static void StopAll()
        {
            StopThread(tMakeBeach);
            StopThread(tRemBeach);
            StopThread(tRanks);
            StopThread(tSuperClock);
            StopThread(tBattleField);
        }


        internal static void StopThread(Thread s)
        {

            if (s != null && (s.ThreadState == ThreadState.Running ||s.ThreadState == ThreadState.Background ||s.ThreadState == ThreadState.WaitSleepJoin ||s.ThreadState == ThreadState.Suspended))
            {
                s.Abort();
                Thread.Sleep(100);

                if (s.ThreadState != ThreadState.Aborted || s.ThreadState!= ThreadState.AbortRequested)
                {
                    s.Abort();
                }

            }
            s = null;
        }

    }
}
