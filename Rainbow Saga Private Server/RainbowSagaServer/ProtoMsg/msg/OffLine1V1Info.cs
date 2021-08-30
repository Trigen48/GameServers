using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OffLine1V1Info
	{

		[ProtoMember(1)]
		public int leftTimes{ get; set; }

		[ProtoMember(2)]
		public int coolDown{ get; set; }

		[ProtoMember(3)]
		public int conWinTimes{ get; set; }

		[ProtoMember(4)]
		public int rank{ get; set; }

		[ProtoMember(5)]
		public int oldRank{ get; set; }

		[ProtoMember(6)]
		public int gifted{ get; set; }

		[ProtoMember(7)]
		public int buyTimes{ get; set; }

		[ProtoMember(8)]
		public List<OffLine1V1Selected> selected{ get; set; }

		[ProtoMember(9)]
		public OffLine1V1TimeStamps timeStamps{ get; set; }

		[ProtoMember(10)]
		public int lockTimes{ get; set; }


		internal OffLine1V1Info()
		{
			this.leftTimes = 0;
			this.coolDown = 0;
			this.conWinTimes = 0;
			this.rank = 0;
			this.oldRank = 0;
			this.gifted = 0;
			this.buyTimes = 0;
			this.selected = new List<OffLine1V1Selected>();
			this.timeStamps = new OffLine1V1TimeStamps();
			this.lockTimes = 0;
		}

	}

}
