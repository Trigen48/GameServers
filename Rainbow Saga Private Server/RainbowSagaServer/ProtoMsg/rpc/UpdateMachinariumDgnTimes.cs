using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpdateMachinariumDgnTimes
	{

		[ProtoMember(1)]
		public int times{ get; set; }


		internal UpdateMachinariumDgnTimes()
		{
			this.times = 0;
		}

	}

}
