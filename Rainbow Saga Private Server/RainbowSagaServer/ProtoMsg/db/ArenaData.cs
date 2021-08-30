using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class ArenaData
	{

		[ProtoMember(1)]
		public ArenaRecord totalRecord{ get; set; }

		[ProtoMember(2)]
		public ArenaRecord todayRecord{ get; set; }

		[ProtoMember(3)]
		public ArenaRecord seasonRecord{ get; set; }

		[ProtoMember(4)]
		public string charname{ get; set; }

		[ProtoMember(5)]
		public int level{ get; set; }

		[ProtoMember(6)]
		public int profession{ get; set; }

		[ProtoMember(7)]
		public int worldid{ get; set; }

		[ProtoMember(8)]
		public int rank{ get; set; }


		internal ArenaData()
		{
			this.totalRecord = new ArenaRecord();
			this.todayRecord = new ArenaRecord();
			this.seasonRecord = new ArenaRecord();
			this.charname ="";
			this.level = 0;
			this.profession = 0;
			this.worldid = 0;
			this.rank = 0;
		}

	}

}
