using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class ProgressInfo
	{

		[ProtoMember(1)]
		public int dgnclass{ get; set; }

		[ProtoMember(2)]
		public int progress{ get; set; }

		[ProtoMember(3)]
		public int totaltime{ get; set; }

		[ProtoMember(4)]
		public int lastresettime{ get; set; }


		internal ProgressInfo()
		{
			this.dgnclass = 0;
			this.progress = 0;
			this.totaltime = 0;
			this.lastresettime = 0;
		}

	}

}
