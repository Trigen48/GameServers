using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class ForgeMountEquip
	{

		[ProtoMember(1)]
		public string templateName{ get; set; }

		[ProtoMember(2)]
		public ulong sourceUuid{ get; set; }

		[ProtoMember(3)]
		public int itemid{ get; set; }

		[ProtoMember(4)]
		public ulong uuid{ get; set; }

		[ProtoMember(5)]
		public int type{ get; set; }


		internal ForgeMountEquip()
		{
			this.templateName ="";
			this.sourceUuid = 0;
			this.itemid = 0;
			this.uuid = 0;
			this.type = 0;
		}

	}

}
