using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CommodityInfo
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int category{ get; set; }

		[ProtoMember(3)]
		public int subtype{ get; set; }


		internal CommodityInfo()
		{
			this.id = 0;
			this.category = 0;
			this.subtype = 0;
		}

	}

}
