using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class CheckNewMysticBusinessItemInfo
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
		public int originalcrystal{ get; set; }

		[ProtoMember(8)]
		public int originalmoney{ get; set; }

		[ProtoMember(9)]
		public int rank{ get; set; }


		internal CheckNewMysticBusinessItemInfo()
		{
			this.id = 0;
			this.itemid = 0;
			this.type = 0;
			this.crystal = 0;
			this.money = 0;
			this.maxnum = 0;
			this.originalcrystal = 0;
			this.originalmoney = 0;
			this.rank = 0;
		}

	}

}
