using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MallCommoditySetRequest
	{

		[ProtoMember(1, IsRequired=true)]
		public int version{ get; set; }


		internal MallCommoditySetRequest()
		{
			this.version = 0;
		}

	}

}
