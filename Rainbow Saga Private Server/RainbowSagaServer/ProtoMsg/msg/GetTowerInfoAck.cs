using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetTowerInfoAck
	{

		[ProtoMember(1)]
		public int currentfloor{ get; set; }

		[ProtoMember(2)]
		public int isfail{ get; set; }

		[ProtoMember(3)]
		public int maxfloorreached{ get; set; }

		[ProtoMember(4)]
		public int lefttimes{ get; set; }


		internal GetTowerInfoAck()
		{
			this.currentfloor = 0;
			this.isfail = 0;
			this.maxfloorreached = 0;
			this.lefttimes = 0;
		}

	}

}
