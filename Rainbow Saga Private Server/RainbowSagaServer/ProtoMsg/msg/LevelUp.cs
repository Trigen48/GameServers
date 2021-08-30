using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class LevelUp
	{

		[ProtoMember(1)]
		public int level{ get; set; }

		[ProtoMember(2)]
		public int hp{ get; set; }

		[ProtoMember(3)]
		public int mp{ get; set; }

		[ProtoMember(4)]
		public int exp{ get; set; }

		[ProtoMember(5)]
		public int maxExp{ get; set; }

		[ProtoMember(6)]
		public int propPoint{ get; set; }


		internal LevelUp()
		{
			this.level = 0;
			this.hp = 0;
			this.mp = 0;
			this.exp = 0;
			this.maxExp = 0;
			this.propPoint = 0;
		}

	}

}
