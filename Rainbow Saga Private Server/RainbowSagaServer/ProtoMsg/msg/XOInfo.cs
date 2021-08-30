using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class XOInfo
	{

		[ProtoMember(1)]
		public int isDouble{ get; set; }

		[ProtoMember(2)]
		public int isCheat{ get; set; }

		[ProtoMember(3)]
		public int leftDoubleTimes{ get; set; }

		[ProtoMember(4)]
		public int totalMoney{ get; set; }

		[ProtoMember(5)]
		public int questionNum{ get; set; }

		[ProtoMember(6)]
		public int conBingo{ get; set; }

		[ProtoMember(7)]
		public int resetTime{ get; set; }


		internal XOInfo()
		{
			this.isDouble = 0;
			this.isCheat = 0;
			this.leftDoubleTimes = 0;
			this.totalMoney = 0;
			this.questionNum = 0;
			this.conBingo = 0;
			this.resetTime = 0;
		}

	}

}
