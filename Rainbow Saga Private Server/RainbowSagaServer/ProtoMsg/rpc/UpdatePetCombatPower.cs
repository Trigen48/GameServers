using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpdatePetCombatPower
	{

		[ProtoMember(1)]
		public ulong uuid{ get; set; }

		[ProtoMember(2)]
		public int combatPower{ get; set; }


		internal UpdatePetCombatPower()
		{
			this.uuid = 0;
			this.combatPower = 0;
		}

	}

}
