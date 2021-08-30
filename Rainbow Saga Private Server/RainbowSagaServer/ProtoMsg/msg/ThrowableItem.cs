using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ThrowableItem
	{

		[ProtoMember(1)]
		public int x{ get; set; }

		[ProtoMember(2)]
		public int y{ get; set; }

		[ProtoMember(3)]
		public int targetx{ get; set; }

		[ProtoMember(4)]
		public int targety{ get; set; }


		internal ThrowableItem()
		{
			this.x = 0;
			this.y = 0;
			this.targetx = 0;
			this.targety = 0;
		}

	}

}
