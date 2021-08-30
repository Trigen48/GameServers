using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ConsumeBonusInfo
	{

		[ProtoMember(1)]
		public int consume{ get; set; }

		[ProtoMember(2)]
		public int usedBonus{ get; set; }

		[ProtoMember(3)]
		public long startTime{ get; set; }


		internal ConsumeBonusInfo()
		{
			this.consume = 0;
			this.usedBonus = 0;
			this.startTime = 0;
		}

	}

}
