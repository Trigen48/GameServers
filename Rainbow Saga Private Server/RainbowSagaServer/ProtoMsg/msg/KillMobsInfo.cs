using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class KillMobsInfo
	{

		[ProtoMember(1)]
		public int time{ get; set; }

		[ProtoMember(2)]
		public int num{ get; set; }


		internal KillMobsInfo()
		{
			this.time = 0;
			this.num = 0;
		}

	}

}
