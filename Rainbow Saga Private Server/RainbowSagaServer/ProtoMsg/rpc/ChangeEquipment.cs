using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class ChangeEquipment
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public string slotId1{ get; set; }

		[ProtoMember(3)]
		public string slotId2{ get; set; }

		[ProtoMember(4)]
		public int packageId{ get; set; }


		internal ChangeEquipment()
		{
			this.type = 0;
			this.slotId1 ="";
			this.slotId2 ="";
			this.packageId = 0;
		}

	}

}
