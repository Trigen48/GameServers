using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MultiGroupDungeonInform
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int groupId{ get; set; }

		[ProtoMember(3)]
		public List<DungeonPlayerInfo> playerInfos{ get; set; }

		[ProtoMember(4)]
		public int safeLeave{ get; set; }

		[ProtoMember(6)]
		public uint srcPlayerId{ get; set; }

		[ProtoMember(7)]
		public uint destPlayerId{ get; set; }

		[ProtoMember(8)]
		public uint serialKills{ get; set; }

		[ProtoMember(9)]
		public int gameObjId{ get; set; }

		[ProtoMember(10)]
		public int mobId{ get; set; }

		[ProtoMember(11)]
		public int activityTime{ get; set; }

		[ProtoMember(12)]
		public int serverTime{ get; set; }

		[ProtoMember(13)]
		public int activityDuration{ get; set; }


		internal MultiGroupDungeonInform()
		{
			this.op = 0;
			this.groupId = 0;
			this.playerInfos = new List<DungeonPlayerInfo>();
			this.safeLeave = 0;
			this.srcPlayerId = 0;
			this.destPlayerId = 0;
			this.serialKills = 0;
			this.gameObjId = 0;
			this.mobId = 0;
			this.activityTime = 0;
			this.serverTime = 0;
			this.activityDuration = 0;
		}

	}

}
