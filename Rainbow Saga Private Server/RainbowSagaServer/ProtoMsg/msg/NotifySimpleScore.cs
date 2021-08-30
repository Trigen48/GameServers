using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class NotifySimpleScore
	{

		[ProtoMember(1)]
		public int dgninstanceid{ get; set; }

		[ProtoMember(2)]
		public int success{ get; set; }

		[ProtoMember(3)]
		public int dgnclass{ get; set; }

		[ProtoMember(4)]
		public int totaltime{ get; set; }

		[ProtoMember(5)]
		public int failReason{ get; set; }


		internal NotifySimpleScore()
		{
			this.dgninstanceid = 0;
			this.success = 0;
			this.dgnclass = 0;
			this.totaltime = 0;
			this.failReason = 0;
		}

	}

}
