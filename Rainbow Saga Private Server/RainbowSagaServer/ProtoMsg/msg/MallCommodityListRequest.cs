using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MallCommodityListRequest
	{

		[ProtoMember(1)]
		public int category{ get; set; }

		[ProtoMember(2)]
		public int version{ get; set; }


		internal MallCommodityListRequest()
		{
			this.category = 0;
			this.version = 0;
		}

	}

}
