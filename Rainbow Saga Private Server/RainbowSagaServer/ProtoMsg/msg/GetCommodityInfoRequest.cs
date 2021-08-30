using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetCommodityInfoRequest
	{

		[ProtoMember(1, IsRequired=true)]
		public int source{ get; set; }

		[ProtoMember(3)]
		public List<CommodityInfo> commoditieInfo{ get; set; }


		internal GetCommodityInfoRequest()
		{
			this.source = 0;
			this.commoditieInfo = new List<CommodityInfo>();
		}

	}

}
