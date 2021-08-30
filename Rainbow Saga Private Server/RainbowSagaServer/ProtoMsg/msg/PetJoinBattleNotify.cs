using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PetJoinBattleNotify
	{

		[ProtoMember(1)]
		public Pet pet{ get; set; }

		[ProtoMember(2)]
		public int unitId{ get; set; }

		[ProtoMember(3)]
		public int hp{ get; set; }

		[ProtoMember(4)]
		public uint maxHp{ get; set; }

		[ProtoMember(5)]
		public int deathState{ get; set; }


		internal PetJoinBattleNotify()
		{
			this.pet = new Pet();
			this.unitId = 0;
			this.hp = 0;
			this.maxHp = 0;
			this.deathState = 0;
		}

	}

}
