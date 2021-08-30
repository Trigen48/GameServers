using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ArenaInfo
	{

		[ProtoMember(4)]
		public int lastJoinTime{ get; set; }

		[ProtoMember(5)]
		public int totayJoinTimes{ get; set; }

		[ProtoMember(6)]
		public int honorPoints{ get; set; }

		[ProtoMember(7)]
		public int inArenaHall{ get; set; }


		internal ArenaInfo()
		{
			this.lastJoinTime = 0;
			this.totayJoinTimes = 0;
			this.honorPoints = 0;
			this.inArenaHall = 0;
		}

	}

}
