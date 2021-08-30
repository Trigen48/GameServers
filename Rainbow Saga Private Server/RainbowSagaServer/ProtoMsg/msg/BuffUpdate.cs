using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class BuffUpdate
	{

		[ProtoMember(1)]
		public int visualSlot{ get; set; }

		[ProtoMember(2)]
		public int skillId{ get; set; }

		[ProtoMember(3)]
		public int flags{ get; set; }

		[ProtoMember(4)]
		public int stackCount{ get; set; }

		[ProtoMember(5)]
		public int duration{ get; set; }

		[ProtoMember(6)]
		public int timeLeft{ get; set; }

		[ProtoMember(7)]
		public int prio{ get; set; }

		[ProtoMember(8)]
		public int skillLevel{ get; set; }

		[ProtoMember(9)]
		public string buffCode{ get; set; }

		[ProtoMember(10)]
		public int action{ get; set; }

		[ProtoMember(11)]
		public int unitType{ get; set; }

		[ProtoMember(12)]
		public int unitId{ get; set; }

		[ProtoMember(13)]
		public int casterType{ get; set; }

		[ProtoMember(14)]
		public int casterId{ get; set; }


		internal BuffUpdate()
		{
			this.visualSlot = 0;
			this.skillId = 0;
			this.flags = 0;
			this.stackCount = 0;
			this.duration = 0;
			this.timeLeft = 0;
			this.prio = 0;
			this.skillLevel = 0;
			this.buffCode ="";
			this.action = 0;
			this.unitType = 0;
			this.unitId = 0;
			this.casterType = 0;
			this.casterId = 0;
		}

	}

}
