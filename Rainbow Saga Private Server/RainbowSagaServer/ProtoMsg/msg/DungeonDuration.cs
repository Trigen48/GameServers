using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DungeonDuration
	{

		[ProtoMember(1)]
		public int duration{ get; set; }


		internal DungeonDuration()
		{
			this.duration = 0;
		}

	}

}
