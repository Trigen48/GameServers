using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MountDgnGift
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }

		[ProtoMember(2)]
		public int cangetgiftlevel{ get; set; }

		[ProtoMember(3)]
		public int getgiftlevel{ get; set; }

		[ProtoMember(4)]
		public int cost{ get; set; }


		internal MountDgnGift()
		{
			this.dgnid = 0;
			this.cangetgiftlevel = 0;
			this.getgiftlevel = 0;
			this.cost = 0;
		}

	}

}
