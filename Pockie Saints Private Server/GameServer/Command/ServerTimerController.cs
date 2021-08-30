using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class ServerTimerController
	{

        internal static void TimerEvent(ConnectionInfo c)
        {
            if (c.Player.active.day != DateUtil.GetZoneDate().Day)
            {
                c.Player.Reset(c);
            }
            else
            {
                if (c.Player.reward.remain > 0)
                {
                    c.Player.reward.remain = (c.Player.reward.targettime - c.Player.active.lasttime);
                   // c.Player.reward.Save(c);
                }
            }
        }

		internal static void GetServerTime(ConnectionInfo c)
		{

            if (c.Player != null)
            {
                c.Player.active.lasttime = (int)DateUtil.GetDateIntZone();
                TimerEvent(c);
                c.Player.active.Save();

                c.Player.title.CheckTitle();

            }
            c.ot.WriteInt((int)DateUtil.GetDateInt());
            c.ot.PackArray(10006);
		}

	}
}
