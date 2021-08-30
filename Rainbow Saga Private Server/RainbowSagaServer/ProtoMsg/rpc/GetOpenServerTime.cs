using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetOpenServerTime
	{

		[ProtoMember(1)]
		public int time{ get; set; }


		internal GetOpenServerTime()
		{
			this.time = 0;
		}

	}

}
