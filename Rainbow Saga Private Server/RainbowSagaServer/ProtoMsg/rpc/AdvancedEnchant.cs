using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class AdvancedEnchant
	{

		[ProtoMember(1)]
		public int index{ get; set; }

		[ProtoMember(2)]
		public string slot{ get; set; }


		internal AdvancedEnchant()
		{
			this.index = 0;
			this.slot ="";
		}

	}

}
