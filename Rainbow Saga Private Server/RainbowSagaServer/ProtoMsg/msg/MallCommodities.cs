using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MallCommodities
	{

		[ProtoMember(1)]
		public List<Commodity> commodities{ get; set; }


		internal MallCommodities()
		{
			this.commodities = new List<Commodity>();
		}

	}

}
