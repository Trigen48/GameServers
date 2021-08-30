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
	internal class Enchant
	{

		[ProtoMember(1)]
		public int locks{ get; set; }

		[ProtoMember(2)]
		public string slot{ get; set; }

		[ProtoMember(3)]
		public List<EnchantProp> enchantProps{ get; set; }

		[ProtoMember(4)]
		public int autoBuy{ get; set; }

		[ProtoMember(5)]
		public int result{ get; set; }


		internal Enchant()
		{
			this.locks = 0;
			this.slot ="";
			this.enchantProps = new List<EnchantProp>();
			this.autoBuy = 0;
			this.result = 0;
		}

	}

}
