using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MallCommoditySetResponse
	{

		[ProtoMember(1, IsRequired=true)]
		public int result{ get; set; }

		[ProtoMember(3, IsRequired=true)]
		public int version{ get; set; }

		[ProtoMember(9)]
		public MallCommoditiesSet commodsets{ get; set; }


		internal MallCommoditySetResponse()
		{
			this.result = 0;
			this.version = 0;
			this.commodsets = new MallCommoditiesSet();
		}

	}

}
