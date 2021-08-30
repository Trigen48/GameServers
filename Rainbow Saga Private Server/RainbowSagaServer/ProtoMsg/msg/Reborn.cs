using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Reborn
	{

		[ProtoMember(1)]
		public int targetScene{ get; set; }

		[ProtoMember(2)]
		public int x{ get; set; }

		[ProtoMember(3)]
		public int y{ get; set; }

		[ProtoMember(4)]
		public int hp{ get; set; }

		[ProtoMember(5)]
		public int mp{ get; set; }


		internal Reborn()
		{
			this.targetScene = 0;
			this.x = 0;
			this.y = 0;
			this.hp = 0;
			this.mp = 0;
		}

	}

}
