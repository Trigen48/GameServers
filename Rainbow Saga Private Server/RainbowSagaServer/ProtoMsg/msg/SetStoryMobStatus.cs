using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SetStoryMobStatus
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int enabled{ get; set; }


		internal SetStoryMobStatus()
		{
			this.id = 0;
			this.enabled = 0;
		}

	}

}
