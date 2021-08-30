using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetBodyTouchTimesResponse
	{

		[ProtoMember(2)]
		public int bodyid{ get; set; }

		[ProtoMember(3)]
		public int touchtimes{ get; set; }

		[ProtoMember(4)]
		public int isfirst{ get; set; }


		internal GetBodyTouchTimesResponse()
		{
			this.bodyid = 0;
			this.touchtimes = 0;
			this.isfirst = 0;
		}

	}

}
