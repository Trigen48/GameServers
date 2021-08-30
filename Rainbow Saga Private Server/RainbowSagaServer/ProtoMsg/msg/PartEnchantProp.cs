using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.db;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PartEnchantProp
	{

		[ProtoMember(1)]
		public string part{ get; set; }

		[ProtoMember(2)]
		public List<EnchantProp> enchantProp{ get; set; }


		internal PartEnchantProp()
		{
			this.part ="";
			this.enchantProp = new List<EnchantProp>();
		}

	}

}
