using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class EnchantPropsOnEquip
	{

		[ProtoMember(1)]
		public List<EnchantProp> enchantProp{ get; set; }


		internal EnchantPropsOnEquip()
		{
			this.enchantProp = new List<EnchantProp>();
		}

	}

}
