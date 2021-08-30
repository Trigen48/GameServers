using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class WorldBossRank
	{

		[ProtoMember(1)]
		public string charname{ get; set; }

		[ProtoMember(2)]
		public int level{ get; set; }

		[ProtoMember(3)]
		public int profession{ get; set; }

		[ProtoMember(4)]
		public int damage{ get; set; }

		[ProtoMember(5)]
		public int pos{ get; set; }


		internal WorldBossRank()
		{
			this.charname ="";
			this.level = 0;
			this.profession = 0;
			this.damage = 0;
			this.pos = 0;
		}

	}

}
