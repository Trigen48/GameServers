using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class DoDailyRefresh
	{

		[ProtoMember(1)]
		public int srvtime{ get; set; }

		[ProtoMember(2)]
		public int srvopentime{ get; set; }


		internal DoDailyRefresh()
		{
			this.srvtime = 0;
			this.srvopentime = 0;
		}

	}

}
