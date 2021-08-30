using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SingleMopupStartNotify
	{

		[ProtoMember(1)]
		public int number{ get; set; }

		[ProtoMember(2)]
		public int consumeEnergy{ get; set; }

		[ProtoMember(3)]
		public int consumeMoney{ get; set; }

		[ProtoMember(4)]
		public int freeMopupAcc{ get; set; }

		[ProtoMember(5)]
		public int dgnid{ get; set; }

		[ProtoMember(6)]
		public int needItemId{ get; set; }


		internal SingleMopupStartNotify()
		{
			this.number = 0;
			this.consumeEnergy = 0;
			this.consumeMoney = 0;
			this.freeMopupAcc = 0;
			this.dgnid = 0;
			this.needItemId = 0;
		}

	}

}
