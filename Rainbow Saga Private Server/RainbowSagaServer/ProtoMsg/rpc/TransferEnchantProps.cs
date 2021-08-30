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
	internal class TransferEnchantProps
	{

		[ProtoMember(1)]
		public string slot{ get; set; }

		[ProtoMember(2)]
		public List<EnchantProp> enchantProps{ get; set; }


		internal TransferEnchantProps()
		{
			this.slot ="";
			this.enchantProps = new List<EnchantProp>();
		}

	}

}
