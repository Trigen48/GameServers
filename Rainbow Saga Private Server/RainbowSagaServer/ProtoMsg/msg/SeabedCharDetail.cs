using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SeabedCharDetail
	{

		[ProtoMember(1)]
		public int charid{ get; set; }

		[ProtoMember(2)]
		public string charname{ get; set; }

		[ProtoMember(3)]
		public int level{ get; set; }

		[ProtoMember(4)]
		public int profession{ get; set; }

		[ProtoMember(5)]
		public int worldid{ get; set; }

		[ProtoMember(6)]
		public string worldname{ get; set; }

		[ProtoMember(7)]
		public int killPlayerNum{ get; set; }

		[ProtoMember(8)]
		public int killNpcNum{ get; set; }

		[ProtoMember(9)]
		public int trans{ get; set; }

		[ProtoMember(10)]
		public int mvp{ get; set; }

		[ProtoMember(11)]
		public int escape{ get; set; }

		[ProtoMember(12)]
		public int score{ get; set; }

		[ProtoMember(13)]
		public int seabedBonus{ get; set; }

		[ProtoMember(14)]
		public int priesthoodBonus{ get; set; }


		internal SeabedCharDetail()
		{
			this.charid = 0;
			this.charname ="";
			this.level = 0;
			this.profession = 0;
			this.worldid = 0;
			this.worldname ="";
			this.killPlayerNum = 0;
			this.killNpcNum = 0;
			this.trans = 0;
			this.mvp = 0;
			this.escape = 0;
			this.score = 0;
			this.seabedBonus = 0;
			this.priesthoodBonus = 0;
		}

	}

}
