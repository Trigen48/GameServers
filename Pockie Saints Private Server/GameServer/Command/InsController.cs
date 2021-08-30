using System;

using System.Collections;

namespace GameServer.Command
{

	internal static class InsController
	{

		internal static void c12031(ConnectionInfo c)
		{

            if (World.World.Instances[c.rlid] == null || World.World.Instances[c.rlid].Floors.Count == 0) return;

            int time = (int)(World.World.Instances[c.rlid].RemoveTime - DateUtil.GetDateIntZone());

            c.ot.WriteInt(World.World.Instances[c.rlid].StartTime);
            c.ot.WriteInt(time);

            c.ot.WriteInt(c.Player.role.map_id);

            c.ot.WriteInt(World.World.Instances[c.rlid].StartTime);
            c.ot.WriteInt(time);

            c.ot.PackArray(12031);
			
		}

		internal static void c24030(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"InsController 24030");
			
			
		}

		internal static void c30015(ConnectionInfo c)
		{
			Program.Write(">Command invoked: " +"InsController 30015");
			
			
		}

	}
}
