using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class JoinSeabedPlayer
	{

		[ProtoMember(1)]
		public int charid{ get; set; }

		[ProtoMember(2)]
		public string charname{ get; set; }

		[ProtoMember(3)]
		public int profession{ get; set; }

		[ProtoMember(4)]
		public int level{ get; set; }

		[ProtoMember(5)]
		public int maxHp{ get; set; }

		[ProtoMember(6)]
		public int maxMp{ get; set; }

		[ProtoMember(7)]
		public int worldid{ get; set; }

		[ProtoMember(8)]
		public string worldname{ get; set; }

		[ProtoMember(9)]
		public int playerCombat{ get; set; }


		internal JoinSeabedPlayer()
		{
			this.charid = 0;
			this.charname ="";
			this.profession = 0;
			this.level = 0;
			this.maxHp = 0;
			this.maxMp = 0;
			this.worldid = 0;
			this.worldname ="";
			this.playerCombat = 0;
		}

	}

}
