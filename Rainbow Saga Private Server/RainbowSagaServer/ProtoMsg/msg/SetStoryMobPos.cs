using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SetStoryMobPos
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int x{ get; set; }

		[ProtoMember(3)]
		public int y{ get; set; }


		internal SetStoryMobPos()
		{
			this.id = 0;
			this.x = 0;
			this.y = 0;
		}

	}

}
