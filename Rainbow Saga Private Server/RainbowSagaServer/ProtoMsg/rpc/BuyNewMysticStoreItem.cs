using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class BuyNewMysticStoreItem
	{

		[ProtoMember(1)]
		public int itemid{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }

		[ProtoMember(3)]
		public int tabnumber{ get; set; }

		[ProtoMember(4)]
		public int id{ get; set; }


		internal BuyNewMysticStoreItem()
		{
			this.itemid = 0;
			this.type = 0;
			this.tabnumber = 0;
			this.id = 0;
		}

	}

}
