using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class TowerRankInfo
	{

		[ProtoMember(1)]
		public string charname{ get; set; }

		[ProtoMember(2)]
		public int level{ get; set; }

		[ProtoMember(3)]
		public int profession{ get; set; }

		[ProtoMember(4)]
		public int floor{ get; set; }

		[ProtoMember(5)]
		public int timeused{ get; set; }

		[ProtoMember(6)]
		public int pos{ get; set; }

		[ProtoMember(7)]
		public ulong passtime{ get; set; }


		internal TowerRankInfo()
		{
			this.charname ="";
			this.level = 0;
			this.profession = 0;
			this.floor = 0;
			this.timeused = 0;
			this.pos = 0;
			this.passtime = 0;
		}

	}

}
