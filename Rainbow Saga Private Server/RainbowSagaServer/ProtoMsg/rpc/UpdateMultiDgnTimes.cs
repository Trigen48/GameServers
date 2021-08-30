using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpdateMultiDgnTimes
	{

		[ProtoMember(1)]
		public int times{ get; set; }


		internal UpdateMultiDgnTimes()
		{
			this.times = 0;
		}

	}

}
