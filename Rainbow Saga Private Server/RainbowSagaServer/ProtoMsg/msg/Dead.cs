using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Dead
	{

		[ProtoMember(1)]
		public int attackerType{ get; set; }

		[ProtoMember(2)]
		public int attackerId{ get; set; }

		[ProtoMember(3)]
		public int soulNum{ get; set; }

		[ProtoMember(4)]
		public int deathState{ get; set; }


		internal Dead()
		{
			this.attackerType = 0;
			this.attackerId = 0;
			this.soulNum = 0;
			this.deathState = 0;
		}

	}

}
