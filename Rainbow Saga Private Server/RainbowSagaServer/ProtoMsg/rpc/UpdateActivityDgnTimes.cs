using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpdateActivityDgnTimes
	{

		[ProtoMember(1)]
		public int times{ get; set; }

		[ProtoMember(2)]
		public int addTimes{ get; set; }


		internal UpdateActivityDgnTimes()
		{
			this.times = 0;
			this.addTimes = 0;
		}

	}

}
