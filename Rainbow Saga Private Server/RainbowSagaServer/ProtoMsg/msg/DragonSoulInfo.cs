using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DragonSoulInfo
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int level{ get; set; }

		[ProtoMember(3)]
		public int difficult{ get; set; }

		[ProtoMember(4)]
		public int lastSuccessTime{ get; set; }

		[ProtoMember(5)]
		public int successTimes{ get; set; }


		internal DragonSoulInfo()
		{
			this.id = 0;
			this.level = 0;
			this.difficult = 0;
			this.lastSuccessTime = 0;
			this.successTimes = 0;
		}

	}

}
