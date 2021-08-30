using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class EnchantProps
	{

		[ProtoMember(1)]
		public List<PartEnchantProp> partEnchantProp{ get; set; }


		internal EnchantProps()
		{
			this.partEnchantProp = new List<PartEnchantProp>();
		}

	}

}
