using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class EquipmentInventory
	{

		[ProtoMember(1)]
		public List<EquipmentSlot> equips{ get; set; }

		[ProtoMember(2)]
		public int bFoDisplay{ get; set; }


		internal EquipmentInventory()
		{
			this.equips = new List<EquipmentSlot>();
			this.bFoDisplay = 0;
		}

	}

}
