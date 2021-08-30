using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SyncLimitTimeSaleState
	{

		[ProtoMember(1)]
		public int state{ get; set; }

		[ProtoMember(2)]
		public uint remaintime{ get; set; }


		internal SyncLimitTimeSaleState()
		{
			this.state = 0;
			this.remaintime = 0;
		}

	}

}
