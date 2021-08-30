using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MallCommoditiesSet
	{

		[ProtoMember(1)]
		public int unused{ get; set; }

		[ProtoMember(5)]
		public List<CommoditySet> comset{ get; set; }


		internal MallCommoditiesSet()
		{
			this.unused = 0;
			this.comset = new List<CommoditySet>();
		}

	}

}
