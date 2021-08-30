using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class BuyMachinariumDgnTimesResp
	{

		[ProtoMember(1)]
		public int result{ get; set; }


		internal BuyMachinariumDgnTimesResp()
		{
			this.result = 0;
		}

	}

}
