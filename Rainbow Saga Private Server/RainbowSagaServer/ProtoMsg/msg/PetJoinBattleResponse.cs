using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PetJoinBattleResponse
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public ulong uuid{ get; set; }

		[ProtoMember(3)]
		public int unitId{ get; set; }

		[ProtoMember(4)]
		public int hp{ get; set; }

		[ProtoMember(5)]
		public uint maxHp{ get; set; }


		internal PetJoinBattleResponse()
		{
			this.result = 0;
			this.uuid = 0;
			this.unitId = 0;
			this.hp = 0;
			this.maxHp = 0;
		}

	}

}
