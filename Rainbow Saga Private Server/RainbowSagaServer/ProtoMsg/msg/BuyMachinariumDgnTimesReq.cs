using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class BuyMachinariumDgnTimesReq
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }

		[ProtoMember(2)]
		public uint count{ get; set; }


		internal BuyMachinariumDgnTimesReq()
		{
			this.dgnid = 0;
			this.count = 0;
		}

	}

}
