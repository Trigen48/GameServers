using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetPlayerGVGStatusRsp
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public ulong startTime{ get; set; }

		[ProtoMember(3)]
		public ulong leaveTime{ get; set; }


		internal GetPlayerGVGStatusRsp()
		{
			this.op = 0;
			this.startTime = 0;
			this.leaveTime = 0;
		}

	}

}
