using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.db;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class EquipmentSlot
	{

		[ProtoMember(1)]
		public string equipSlot{ get; set; }

		[ProtoMember(2)]
		public Item equipItem{ get; set; }


		internal EquipmentSlot()
		{
			this.equipSlot ="";
			this.equipItem = new Item();
		}

	}

}
