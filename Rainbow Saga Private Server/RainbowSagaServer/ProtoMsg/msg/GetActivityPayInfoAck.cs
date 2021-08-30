using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetActivityPayInfoAck
	{

		[ProtoMember(1)]
		public uint opt{ get; set; }

		[ProtoMember(2)]
		public uint fixedResult{ get; set; }

		[ProtoMember(3)]
		public uint fixedStartTime{ get; set; }

		[ProtoMember(4)]
		public uint fixedEndTime{ get; set; }

		[ProtoMember(5)]
		public uint fixedGiftId{ get; set; }

		[ProtoMember(6)]
		public uint fixedAmount{ get; set; }

		[ProtoMember(7)]
		public uint fixedGotTimes{ get; set; }

		[ProtoMember(8)]
		public uint fixedCanGetTimes{ get; set; }

		[ProtoMember(9)]
		public uint fixedConfAmount{ get; set; }

		[ProtoMember(14)]
		public uint multiResult{ get; set; }

		[ProtoMember(15)]
		public uint multiAmount{ get; set; }

		[ProtoMember(16)]
		public uint multiStartTime{ get; set; }

		[ProtoMember(17)]
		public uint multiEndTime{ get; set; }

		[ProtoMember(18)]
		public List<MultiSectionPayInfo> multiInfos{ get; set; }


		internal GetActivityPayInfoAck()
		{
			this.opt = 0;
			this.fixedResult = 0;
			this.fixedStartTime = 0;
			this.fixedEndTime = 0;
			this.fixedGiftId = 0;
			this.fixedAmount = 0;
			this.fixedGotTimes = 0;
			this.fixedCanGetTimes = 0;
			this.fixedConfAmount = 0;
			this.multiResult = 0;
			this.multiAmount = 0;
			this.multiStartTime = 0;
			this.multiEndTime = 0;
			this.multiInfos = new List<MultiSectionPayInfo>();
		}

	}

}
