using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class VechileEquipProp
	{

		[ProtoMember(1)]
		public string prop{ get; set; }

		[ProtoMember(2)]
		public int value{ get; set; }

		[ProtoMember(3)]
		public int star{ get; set; }

		[ProtoMember(4)]
		public int quality{ get; set; }


		internal VechileEquipProp()
		{
			this.prop ="";
			this.value = 0;
			this.star = 0;
			this.quality = 0;
		}

	}

}
