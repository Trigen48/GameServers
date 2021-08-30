using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CommodityItem
	{

		[ProtoMember(1, IsRequired=true)]
		public int id{ get; set; }

		[ProtoMember(3)]
		public int category{ get; set; }

		[ProtoMember(4)]
		public int discount{ get; set; }

		[ProtoMember(5)]
		public int spType{ get; set; }

		[ProtoMember(9)]
		public uint count{ get; set; }

		[ProtoMember(10)]
		public int deadline{ get; set; }

		[ProtoMember(15)]
		public int behavior{ get; set; }


		internal CommodityItem()
		{
			this.id = 0;
			this.category = 0;
			this.discount = 0;
			this.spType = 0;
			this.count = 0;
			this.deadline = 0;
			this.behavior = 0;
		}

	}

}
