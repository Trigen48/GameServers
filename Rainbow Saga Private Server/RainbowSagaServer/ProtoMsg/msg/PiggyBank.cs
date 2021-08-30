using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PiggyBank
	{

		[ProtoMember(1)]
		public int hammerLevel{ get; set; }

		[ProtoMember(2)]
		public int usedTimes{ get; set; }

		[ProtoMember(3)]
		public int lastSetTime{ get; set; }


		internal PiggyBank()
		{
			this.hammerLevel = 0;
			this.usedTimes = 0;
			this.lastSetTime = 0;
		}

	}

}
