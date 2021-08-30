using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class AllBodyTouchTimesInfo
	{

		[ProtoMember(1)]
		public List<BodyTouchTimesInfo> bodyTouchTimesInfo{ get; set; }


		internal AllBodyTouchTimesInfo()
		{
			this.bodyTouchTimesInfo = new List<BodyTouchTimesInfo>();
		}

	}

}
