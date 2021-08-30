using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class EnterMountDgnReq
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }


		internal EnterMountDgnReq()
		{
			this.dgnid = 0;
		}

	}

}
