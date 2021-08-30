using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class DragonSoulOp
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int result{ get; set; }

		[ProtoMember(3)]
		public int id{ get; set; }

		[ProtoMember(4)]
		public int level{ get; set; }

		[ProtoMember(5)]
		public int difficult{ get; set; }

		[ProtoMember(6)]
		public int successTimes{ get; set; }

		[ProtoMember(7)]
		public int maxLevel{ get; set; }

		[ProtoMember(8)]
		public int bossrush{ get; set; }

		[ProtoMember(9)]
		public int towerloot{ get; set; }

		[ProtoMember(10)]
		public int canbeginlist{ get; set; }

		[ProtoMember(11)]
		public int passedlist{ get; set; }


		internal DragonSoulOp()
		{
			this.op = 0;
			this.result = 0;
			this.id = 0;
			this.level = 0;
			this.difficult = 0;
			this.successTimes = 0;
			this.maxLevel = 0;
			this.bossrush = 0;
			this.towerloot = 0;
			this.canbeginlist = 0;
			this.passedlist = 0;
		}

	}

}
