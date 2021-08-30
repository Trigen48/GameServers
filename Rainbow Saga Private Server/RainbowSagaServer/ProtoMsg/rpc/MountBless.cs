using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class MountBless
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int quality{ get; set; }

		[ProtoMember(3)]
		public int exp{ get; set; }

		[ProtoMember(4)]
		public int lastTime{ get; set; }

		[ProtoMember(5)]
		public int now{ get; set; }

		[ProtoMember(6)]
		public int animExp{ get; set; }

		[ProtoMember(7)]
		public int critNum{ get; set; }

		[ProtoMember(8)]
		public int num{ get; set; }

		[ProtoMember(9)]
		public int gainExp{ get; set; }


		internal MountBless()
		{
			this.op = 0;
			this.quality = 0;
			this.exp = 0;
			this.lastTime = 0;
			this.now = 0;
			this.animExp = 0;
			this.critNum = 0;
			this.num = 0;
			this.gainExp = 0;
		}

	}

}
