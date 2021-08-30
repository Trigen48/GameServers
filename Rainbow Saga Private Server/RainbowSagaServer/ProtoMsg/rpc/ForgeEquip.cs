using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class ForgeEquip
	{

		[ProtoMember(1)]
		public string templateName{ get; set; }

		[ProtoMember(2)]
		public int time{ get; set; }

		[ProtoMember(3)]
		public int autoBuy{ get; set; }


		internal ForgeEquip()
		{
			this.templateName ="";
			this.time = 0;
			this.autoBuy = 0;
		}

	}

}
