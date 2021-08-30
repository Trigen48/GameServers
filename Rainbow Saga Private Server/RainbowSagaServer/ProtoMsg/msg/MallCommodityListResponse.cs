using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MallCommodityListResponse
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public int category{ get; set; }

		[ProtoMember(3)]
		public int version{ get; set; }

		[ProtoMember(4)]
		public int svrtime{ get; set; }

		[ProtoMember(5)]
		public MallCommodities commodities{ get; set; }

		[ProtoMember(6)]
		public MallCommodities hotranking{ get; set; }


		internal MallCommodityListResponse()
		{
			this.result = 0;
			this.category = 0;
			this.version = 0;
			this.svrtime = 0;
			this.commodities = new MallCommodities();
			this.hotranking = new MallCommodities();
		}

	}

}
