using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class NewMysticBusinessItem
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int itemid{ get; set; }

		[ProtoMember(3)]
		public int type{ get; set; }

		[ProtoMember(4)]
		public int crystal{ get; set; }

		[ProtoMember(5)]
		public int money{ get; set; }

		[ProtoMember(6)]
		public int maxnum{ get; set; }

		[ProtoMember(7)]
		public int buying{ get; set; }

		[ProtoMember(8)]
		public int originalcrystal{ get; set; }

		[ProtoMember(9)]
		public int originalmoney{ get; set; }

		[ProtoMember(10)]
		public int rank{ get; set; }

		[ProtoMember(11)]
		public int itemprop{ get; set; }

		[ProtoMember(12)]
		public int announcement{ get; set; }


		internal NewMysticBusinessItem()
		{
			this.id = 0;
			this.itemid = 0;
			this.type = 0;
			this.crystal = 0;
			this.money = 0;
			this.maxnum = 0;
			this.buying = 0;
			this.originalcrystal = 0;
			this.originalmoney = 0;
			this.rank = 0;
			this.itemprop = 0;
			this.announcement = 0;
		}

	}

}
