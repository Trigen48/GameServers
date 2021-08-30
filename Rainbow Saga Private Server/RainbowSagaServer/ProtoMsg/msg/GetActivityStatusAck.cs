using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetActivityStatusAck
	{

		[ProtoMember(1)]
		public List<ActivityStatus> infos{ get; set; }


		internal GetActivityStatusAck()
		{
			this.infos = new List<ActivityStatus>();
		}

	}

}
