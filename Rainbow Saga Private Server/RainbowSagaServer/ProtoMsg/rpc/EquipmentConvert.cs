using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class EquipmentConvert
	{

		[ProtoMember(1)]
		public int slotids{ get; set; }

		[ProtoMember(2)]
		public int templateid{ get; set; }


		internal EquipmentConvert()
		{
			this.slotids = 0;
			this.templateid = 0;
		}

	}

}
