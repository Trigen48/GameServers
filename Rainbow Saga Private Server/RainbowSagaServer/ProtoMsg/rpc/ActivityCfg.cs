using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class ActivityCfg
	{

		[ProtoMember(1)]
		public int startdate{ get; set; }

		[ProtoMember(2)]
		public int enddate{ get; set; }


		internal ActivityCfg()
		{
			this.startdate = 0;
			this.enddate = 0;
		}

	}

}
