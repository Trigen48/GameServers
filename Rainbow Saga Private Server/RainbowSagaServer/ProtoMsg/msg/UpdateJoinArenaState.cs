using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class UpdateJoinArenaState
	{

		[ProtoMember(1)]
		public int charid{ get; set; }

		[ProtoMember(2)]
		public int state{ get; set; }

		[ProtoMember(3)]
		public PlayerArenaInfo arenaInfo{ get; set; }

		[ProtoMember(4)]
		public ArenaDgnInfo dgnInfo{ get; set; }

		[ProtoMember(5)]
		public uint seqId{ get; set; }

		[ProtoMember(6)]
		public int combatPowerWithoutPet{ get; set; }


		internal UpdateJoinArenaState()
		{
			this.charid = 0;
			this.state = 0;
			this.arenaInfo = new PlayerArenaInfo();
			this.dgnInfo = new ArenaDgnInfo();
			this.seqId = 0;
			this.combatPowerWithoutPet = 0;
		}

	}

}
