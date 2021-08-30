using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Hurt
	{

		[ProtoMember(1)]
		public int attacker{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }

		[ProtoMember(3)]
		public int damage{ get; set; }

		[ProtoMember(4)]
		public int hp{ get; set; }

		[ProtoMember(5)]
		public int mp{ get; set; }

		[ProtoMember(6)]
		public int repelx{ get; set; }

		[ProtoMember(7)]
		public int repely{ get; set; }


		internal Hurt()
		{
			this.attacker = 0;
			this.type = 0;
			this.damage = 0;
			this.hp = 0;
			this.mp = 0;
			this.repelx = 0;
			this.repely = 0;
		}

	}

}
