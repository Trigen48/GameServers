using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ItemOwnInfo
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int num{ get; set; }

		[ProtoMember(3)]
		public int resetTime{ get; set; }


		internal ItemOwnInfo()
		{
			this.id = 0;
			this.num = 0;
			this.resetTime = 0;
		}

	}

}
