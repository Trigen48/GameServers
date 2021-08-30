using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MysticStoreItem
	{

		[ProtoMember(1)]
		public int itemid{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }

		[ProtoMember(3)]
		public int crystal{ get; set; }

		[ProtoMember(4)]
		public int money{ get; set; }

		[ProtoMember(5)]
		public int maxnum{ get; set; }

		[ProtoMember(6)]
		public int buying{ get; set; }


		internal MysticStoreItem()
		{
			this.itemid = 0;
			this.type = 0;
			this.crystal = 0;
			this.money = 0;
			this.maxnum = 0;
			this.buying = 0;
		}

	}

}
