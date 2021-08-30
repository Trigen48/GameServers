using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.msg;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class TencentVipResp
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public int op{ get; set; }

		[ProtoMember(3)]
		public int dailyNormal{ get; set; }

		[ProtoMember(4)]
		public int dailyYear{ get; set; }

		[ProtoMember(5)]
		public List<TencentLvGift> lvGift{ get; set; }

		[ProtoMember(6)]
		public int freshman{ get; set; }

		[ProtoMember(7)]
		public int dailyLuxury{ get; set; }

		[ProtoMember(8)]
		public int level3366{ get; set; }


		internal TencentVipResp()
		{
			this.type = 0;
			this.op = 0;
			this.dailyNormal = 0;
			this.dailyYear = 0;
			this.lvGift = new List<TencentLvGift>();
			this.freshman = 0;
			this.dailyLuxury = 0;
			this.level3366 = 0;
		}

	}

}
