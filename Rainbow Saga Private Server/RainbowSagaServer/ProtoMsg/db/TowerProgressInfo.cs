using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class TowerProgressInfo
	{

		[ProtoMember(1)]
		public int currentfloor{ get; set; }

		[ProtoMember(2)]
		public int status{ get; set; }

		[ProtoMember(3)]
		public int maxfloorreached{ get; set; }

		[ProtoMember(4)]
		public int challengetimes{ get; set; }

		[ProtoMember(5)]
		public int lastresettime{ get; set; }

		[ProtoMember(6)]
		public int autofloor{ get; set; }

		[ProtoMember(7)]
		public int autoresettime{ get; set; }

		[ProtoMember(8)]
		public int autotimes{ get; set; }


		internal TowerProgressInfo()
		{
			this.currentfloor = 0;
			this.status = 0;
			this.maxfloorreached = 0;
			this.challengetimes = 0;
			this.lastresettime = 0;
			this.autofloor = 0;
			this.autoresettime = 0;
			this.autotimes = 0;
		}

	}

}
