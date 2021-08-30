using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class DecomposeEquip
	{

		[ProtoMember(1)]
		public string templateName{ get; set; }

		[ProtoMember(2)]
		public ulong itemuuid{ get; set; }

		[ProtoMember(3)]
		public int num{ get; set; }


		internal DecomposeEquip()
		{
			this.templateName ="";
			this.itemuuid = 0;
			this.num = 0;
		}

	}

}
