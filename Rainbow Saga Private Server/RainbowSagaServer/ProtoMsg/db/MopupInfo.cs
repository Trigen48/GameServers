using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MopupInfo
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }

		[ProtoMember(2)]
		public int times{ get; set; }

		[ProtoMember(3)]
		public int finishtimes{ get; set; }

		[ProtoMember(4)]
		public int starttime{ get; set; }

		[ProtoMember(5)]
		public int difficulty{ get; set; }


		internal MopupInfo()
		{
			this.dgnid = 0;
			this.times = 0;
			this.finishtimes = 0;
			this.starttime = 0;
			this.difficulty = 0;
		}

	}

}
