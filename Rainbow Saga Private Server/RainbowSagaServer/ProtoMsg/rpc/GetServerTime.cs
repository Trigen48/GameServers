using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetServerTime
	{

		[ProtoMember(1)]
		public int time{ get; set; }


		internal GetServerTime()
		{
			this.time = 0;
		}

	}

}
