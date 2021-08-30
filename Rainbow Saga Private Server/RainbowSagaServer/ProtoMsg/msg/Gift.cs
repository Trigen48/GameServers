using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Gift
	{

		[ProtoMember(1)]
		public uint giftIndex{ get; set; }

		[ProtoMember(2)]
		public uint offerFlag{ get; set; }


		internal Gift()
		{
			this.giftIndex = 0;
			this.offerFlag = 0;
		}

	}

}
