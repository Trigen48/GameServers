using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class SaveEnchantProps
	{

		[ProtoMember(1)]
		public string slot{ get; set; }


		internal SaveEnchantProps()
		{
			this.slot ="";
		}

	}

}
