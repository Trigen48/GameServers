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
	internal class OffLine1V1Resp
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int result{ get; set; }

		[ProtoMember(3)]
		public int leftTimes{ get; set; }

		[ProtoMember(4)]
		public int coolDown{ get; set; }

		[ProtoMember(5)]
		public int lockTimes{ get; set; }

		[ProtoMember(6)]
		public int conWinTimes{ get; set; }

		[ProtoMember(7)]
		public int rank{ get; set; }

		[ProtoMember(8)]
		public int oldRank{ get; set; }

		[ProtoMember(9)]
		public int gifted{ get; set; }

		[ProtoMember(10)]
		public OffLine1V1Record record{ get; set; }

		[ProtoMember(11)]
		public List<OfflineCharInfo> refreshList{ get; set; }

		[ProtoMember(12)]
		public int selfDps{ get; set; }

		[ProtoMember(13)]
		public int oppDps{ get; set; }

		[ProtoMember(14)]
		public OffLine1V1TimeStamps timeStamps{ get; set; }

		[ProtoMember(15)]
		public int buyTimes{ get; set; }

		[ProtoMember(16)]
		public List<OffLineItem> bonusList{ get; set; }


		internal OffLine1V1Resp()
		{
			this.op = 0;
			this.result = 0;
			this.leftTimes = 0;
			this.coolDown = 0;
			this.lockTimes = 0;
			this.conWinTimes = 0;
			this.rank = 0;
			this.oldRank = 0;
			this.gifted = 0;
			this.record = new OffLine1V1Record();
			this.refreshList = new List<OfflineCharInfo>();
			this.selfDps = 0;
			this.oppDps = 0;
			this.timeStamps = new OffLine1V1TimeStamps();
			this.buyTimes = 0;
			this.bonusList = new List<OffLineItem>();
		}

	}

}
