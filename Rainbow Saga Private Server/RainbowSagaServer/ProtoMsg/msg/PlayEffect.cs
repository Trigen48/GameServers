using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PlayEffect
	{

		[ProtoMember(1)]
		public string group{ get; set; }

		[ProtoMember(2)]
		public int id{ get; set; }

		[ProtoMember(3)]
		public int x{ get; set; }

		[ProtoMember(4)]
		public int y{ get; set; }

		[ProtoMember(5)]
		public int times{ get; set; }

		[ProtoMember(6)]
		public int delay{ get; set; }

		[ProtoMember(7)]
		public int playPos{ get; set; }


		internal PlayEffect()
		{
			this.group ="";
			this.id = 0;
			this.x = 0;
			this.y = 0;
			this.times = 0;
			this.delay = 0;
			this.playPos = 0;
		}

	}

}
