using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ItemInventory
	{

		[ProtoMember(1)]
		public int slotNum{ get; set; }

		[ProtoMember(2)]
		public List<Slot> slots{ get; set; }


		internal ItemInventory()
		{
			this.slotNum = 0;
			this.slots = new List<Slot>();
		}

	}

}
