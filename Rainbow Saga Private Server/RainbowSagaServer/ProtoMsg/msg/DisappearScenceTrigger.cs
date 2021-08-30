using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DisappearScenceTrigger
	{

		[ProtoMember(1)]
		public int mapid{ get; set; }

		[ProtoMember(2)]
		public int triggerid{ get; set; }


		internal DisappearScenceTrigger()
		{
			this.mapid = 0;
			this.triggerid = 0;
		}

	}

}
