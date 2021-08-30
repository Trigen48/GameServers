using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class VipAward
	{

		[ProtoMember(1)]
		public int level{ get; set; }

		[ProtoMember(2)]
		public int dailyGated{ get; set; }

		[ProtoMember(3)]
		public int weeklyGated{ get; set; }

		[ProtoMember(4)]
		public int dailyGatedTime{ get; set; }

		[ProtoMember(5)]
		public int weeklyGatedTime{ get; set; }


		internal VipAward()
		{
			this.level = 0;
			this.dailyGated = 0;
			this.weeklyGated = 0;
			this.dailyGatedTime = 0;
			this.weeklyGatedTime = 0;
		}

	}

}
