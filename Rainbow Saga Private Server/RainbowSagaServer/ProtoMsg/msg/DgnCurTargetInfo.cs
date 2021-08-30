using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DgnCurTargetInfo
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }

		[ProtoMember(3)]
		public int stridx{ get; set; }

		[ProtoMember(4)]
		public DgnKillMobNum killmob{ get; set; }

		[ProtoMember(5)]
		public int bossid{ get; set; }

		[ProtoMember(6)]
		public int curtargetfinish{ get; set; }


		internal DgnCurTargetInfo()
		{
			this.dgnid = 0;
			this.type = 0;
			this.stridx = 0;
			this.killmob = new DgnKillMobNum();
			this.bossid = 0;
			this.curtargetfinish = 0;
		}

	}

}
