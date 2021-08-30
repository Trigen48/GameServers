using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DungeonPlayerInfo
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public string charname{ get; set; }

		[ProtoMember(3)]
		public int level{ get; set; }

		[ProtoMember(4)]
		public int profession{ get; set; }

		[ProtoMember(6)]
		public int maxHp{ get; set; }

		[ProtoMember(8)]
		public int maxMp{ get; set; }

		[ProtoMember(9)]
		public int gender{ get; set; }

		[ProtoMember(10)]
		public int hair{ get; set; }

		[ProtoMember(11)]
		public int face{ get; set; }

		[ProtoMember(12)]
		public int skintype{ get; set; }

		[ProtoMember(13)]
		public ulong aid{ get; set; }

		[ProtoMember(14)]
		public ulong familyId{ get; set; }

		[ProtoMember(15)]
		public int familyStoneLv{ get; set; }


		internal DungeonPlayerInfo()
		{
			this.id = 0;
			this.charname ="";
			this.level = 0;
			this.profession = 0;
			this.maxHp = 0;
			this.maxMp = 0;
			this.gender = 0;
			this.hair = 0;
			this.face = 0;
			this.skintype = 0;
			this.aid = 0;
			this.familyId = 0;
			this.familyStoneLv = 0;
		}

	}

}
