using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ArenaDgnInfo
	{

		[ProtoMember(2)]
		public int dgnid{ get; set; }

		[ProtoMember(3)]
		public uint instanceid{ get; set; }

		[ProtoMember(4)]
		public uint zonesrvid{ get; set; }

		[ProtoMember(5)]
		public uint targetmapid{ get; set; }

		[ProtoMember(6)]
		public int targetx{ get; set; }

		[ProtoMember(7)]
		public int targety{ get; set; }

		[ProtoMember(10)]
		public List<JoinArenaPlayer> friends{ get; set; }

		[ProtoMember(11)]
		public List<JoinArenaPlayer> enemies{ get; set; }

		[ProtoMember(12)]
		public List<JoinSeabedPlayer> seabedFriends{ get; set; }

		[ProtoMember(13)]
		public List<JoinSeabedPlayer> seabedEnemies{ get; set; }


		internal ArenaDgnInfo()
		{
			this.dgnid = 0;
			this.instanceid = 0;
			this.zonesrvid = 0;
			this.targetmapid = 0;
			this.targetx = 0;
			this.targety = 0;
			this.friends = new List<JoinArenaPlayer>();
			this.enemies = new List<JoinArenaPlayer>();
			this.seabedFriends = new List<JoinSeabedPlayer>();
			this.seabedEnemies = new List<JoinSeabedPlayer>();
		}

	}

}
