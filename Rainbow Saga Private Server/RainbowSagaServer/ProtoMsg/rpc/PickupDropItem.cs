using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class PickupDropItem
	{

		[ProtoMember(1, IsRequired=true)]
		public ulong uuid{ get; set; }

		[ProtoMember(2)]
		public int id{ get; set; }

		[ProtoMember(3)]
		public int charid{ get; set; }


		internal PickupDropItem()
		{
			this.uuid = 0;
			this.id = 0;
			this.charid = 0;
		}

	}

}
