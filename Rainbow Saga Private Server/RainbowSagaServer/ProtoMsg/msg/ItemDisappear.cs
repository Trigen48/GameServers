using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ItemDisappear
	{

		[ProtoMember(1, IsRequired=true)]
		public ulong uuid{ get; set; }

		[ProtoMember(2)]
		public int id{ get; set; }

		[ProtoMember(3)]
		public int charid{ get; set; }

		[ProtoMember(4)]
		public int type{ get; set; }


		internal ItemDisappear()
		{
			this.uuid = 0;
			this.id = 0;
			this.charid = 0;
			this.type = 0;
		}

	}

}
