using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class ArenaRecord
	{

		[ProtoMember(1)]
		public int wins{ get; set; }

		[ProtoMember(2)]
		public int defeats{ get; set; }

		[ProtoMember(3)]
		public int draws{ get; set; }

		[ProtoMember(4)]
		public int score{ get; set; }


		internal ArenaRecord()
		{
			this.wins = 0;
			this.defeats = 0;
			this.draws = 0;
			this.score = 0;
		}

	}

}
