using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetTowerMopInfoAck
	{

		[ProtoMember(1)]
		public int autofloor{ get; set; }

		[ProtoMember(2)]
		public int maxfloorreached{ get; set; }

		[ProtoMember(3)]
		public int lefttimes{ get; set; }


		internal GetTowerMopInfoAck()
		{
			this.autofloor = 0;
			this.maxfloorreached = 0;
			this.lefttimes = 0;
		}

	}

}
