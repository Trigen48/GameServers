using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Teleport
	{

		[ProtoMember(1)]
		public int x{ get; set; }

		[ProtoMember(2)]
		public int y{ get; set; }


		internal Teleport()
		{
			this.x = 0;
			this.y = 0;
		}

	}

}
