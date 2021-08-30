using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class BodyTouchTimesInfo
	{

		[ProtoMember(1)]
		public int bodyid{ get; set; }

		[ProtoMember(2)]
		public int touchtimes{ get; set; }


		internal BodyTouchTimesInfo()
		{
			this.bodyid = 0;
			this.touchtimes = 0;
		}

	}

}
