using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class BuyLimitItemResponse
	{

		[ProtoMember(1)]
		public int result{ get; set; }


		internal BuyLimitItemResponse()
		{
			this.result = 0;
		}

	}

}
