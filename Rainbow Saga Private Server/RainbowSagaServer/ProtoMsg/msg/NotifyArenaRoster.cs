using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class NotifyArenaRoster
	{

		[ProtoMember(1)]
		public List<JoinArenaPlayer> arenaTeam0{ get; set; }

		[ProtoMember(2)]
		public List<JoinArenaPlayer> arenaTeam1{ get; set; }


		internal NotifyArenaRoster()
		{
			this.arenaTeam0 = new List<JoinArenaPlayer>();
			this.arenaTeam1 = new List<JoinArenaPlayer>();
		}

	}

}
