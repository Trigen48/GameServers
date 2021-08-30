using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class EnterToMachinariumDgnReq
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }


		internal EnterToMachinariumDgnReq()
		{
			this.dgnid = 0;
		}

	}

}
