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
	internal class EquipOnInfo
	{

		[ProtoMember(1)]
		public string equipSlot{ get; set; }

		[ProtoMember(2)]
		public Item item{ get; set; }

		[ProtoMember(3)]
		public int onOrOff{ get; set; }

		[ProtoMember(4)]
		public int gainType{ get; set; }


		internal EquipOnInfo()
		{
			this.equipSlot ="";
			this.item = new Item();
			this.onOrOff = 0;
			this.gainType = 0;
		}

	}

}
