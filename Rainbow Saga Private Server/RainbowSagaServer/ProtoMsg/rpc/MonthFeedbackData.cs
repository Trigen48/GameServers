using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class MonthFeedbackData
	{

		[ProtoMember(1)]
		public int resetTime{ get; set; }

		[ProtoMember(2)]
		public int actValue{ get; set; }

		[ProtoMember(3)]
		public int consumeCrystal{ get; set; }

		[ProtoMember(4)]
		public int lastActValue{ get; set; }

		[ProtoMember(5)]
		public int lastConsumeCrystal{ get; set; }

		[ProtoMember(6)]
		public int actGiftState{ get; set; }

		[ProtoMember(7)]
		public int consumeGiftState{ get; set; }


		internal MonthFeedbackData()
		{
			this.resetTime = 0;
			this.actValue = 0;
			this.consumeCrystal = 0;
			this.lastActValue = 0;
			this.lastConsumeCrystal = 0;
			this.actGiftState = 0;
			this.consumeGiftState = 0;
		}

	}

}
