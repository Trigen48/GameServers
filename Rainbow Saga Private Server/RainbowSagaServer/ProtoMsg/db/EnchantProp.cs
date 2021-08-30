using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class EnchantProp
	{

		[ProtoMember(1)]
		public string prop{ get; set; }

		[ProtoMember(2)]
		public int value{ get; set; }

		[ProtoMember(3)]
		public int star{ get; set; }

		[ProtoMember(4)]
		public int isLocked{ get; set; }

		[ProtoMember(5)]
		public int value0{ get; set; }


		internal EnchantProp()
		{
			this.prop ="";
			this.value = 0;
			this.star = 0;
			this.isLocked = 0;
			this.value0 = 0;
		}

	}

}
