using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MountDgnCurrentInfo
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }

		[ProtoMember(2)]
		public int state{ get; set; }

		[ProtoMember(3)]
		public int curlevel{ get; set; }

		[ProtoMember(4)]
		public int cangetgiftlevel{ get; set; }

		[ProtoMember(5)]
		public int getgiftlevel{ get; set; }


		internal MountDgnCurrentInfo()
		{
			this.dgnid = 0;
			this.state = 0;
			this.curlevel = 0;
			this.cangetgiftlevel = 0;
			this.getgiftlevel = 0;
		}

	}

}
