using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class WingLevelUpResp
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int result{ get; set; }

		[ProtoMember(3)]
		public int expAdd{ get; set; }

		[ProtoMember(4)]
		public int critNum{ get; set; }

		[ProtoMember(5)]
		public int levelNow{ get; set; }

		[ProtoMember(6)]
		public int expNow{ get; set; }

		[ProtoMember(7)]
		public int levelBefore{ get; set; }

		[ProtoMember(8)]
		public int expBefore{ get; set; }

		[ProtoMember(9)]
		public int remainGoldTrainNum{ get; set; }


		internal WingLevelUpResp()
		{
			this.op = 0;
			this.result = 0;
			this.expAdd = 0;
			this.critNum = 0;
			this.levelNow = 0;
			this.expNow = 0;
			this.levelBefore = 0;
			this.expBefore = 0;
			this.remainGoldTrainNum = 0;
		}

	}

}
