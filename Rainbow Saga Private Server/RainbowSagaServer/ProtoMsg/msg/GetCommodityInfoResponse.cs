using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetCommodityInfoResponse
	{

		[ProtoMember(1, IsRequired=true)]
		public int result{ get; set; }

		[ProtoMember(2, IsRequired=true)]
		public int source{ get; set; }

		[ProtoMember(5)]
		public List<Commodity> commoditiy{ get; set; }


		internal GetCommodityInfoResponse()
		{
			this.result = 0;
			this.source = 0;
			this.commoditiy = new List<Commodity>();
		}

	}

}
