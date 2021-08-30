using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.db;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class EquipDegreeUp
	{

		[ProtoMember(1)]
		public string slotId{ get; set; }

		[ProtoMember(2)]
		public Item item{ get; set; }


		internal EquipDegreeUp()
		{
			this.slotId ="";
			this.item = new Item();
		}

	}

}
