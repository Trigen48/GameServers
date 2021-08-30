using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class LimitTimeSaleSyncInfo
	{

		[ProtoMember(1)]
		public int startTime{ get; set; }

		[ProtoMember(2)]
		public int duration{ get; set; }

		[ProtoMember(3)]
		public int prepare{ get; set; }

		[ProtoMember(4)]
		public int keepTime{ get; set; }

		[ProtoMember(5)]
		public int itemid{ get; set; }

		[ProtoMember(6)]
		public int oriPrice{ get; set; }

		[ProtoMember(7)]
		public int curPrice{ get; set; }

		[ProtoMember(8)]
		public int maxNum{ get; set; }

		[ProtoMember(9)]
		public int remain{ get; set; }

		[ProtoMember(10)]
		public int sortIndex{ get; set; }


		internal LimitTimeSaleSyncInfo()
		{
			this.startTime = 0;
			this.duration = 0;
			this.prepare = 0;
			this.keepTime = 0;
			this.itemid = 0;
			this.oriPrice = 0;
			this.curPrice = 0;
			this.maxNum = 0;
			this.remain = 0;
			this.sortIndex = 0;
		}

	}

}
