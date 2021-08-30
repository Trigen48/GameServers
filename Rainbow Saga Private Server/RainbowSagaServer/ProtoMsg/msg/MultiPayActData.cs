using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MultiPayActData
	{

		[ProtoMember(1)]
		public uint giftid{ get; set; }

		[ProtoMember(2)]
		public uint status{ get; set; }


		internal MultiPayActData()
		{
			this.giftid = 0;
			this.status = 0;
		}

	}

}
