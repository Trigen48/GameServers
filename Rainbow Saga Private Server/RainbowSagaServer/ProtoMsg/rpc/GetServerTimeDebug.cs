using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetServerTimeDebug
	{

		[ProtoMember(1)]
		public int time{ get; set; }


		internal GetServerTimeDebug()
		{
			this.time = 0;
		}

	}

}
