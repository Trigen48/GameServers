using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GameObject
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int infoId{ get; set; }

		[ProtoMember(3)]
		public int x{ get; set; }

		[ProtoMember(4)]
		public int y{ get; set; }

		[ProtoMember(5)]
		public int num{ get; set; }


		internal GameObject()
		{
			this.id = 0;
			this.infoId = 0;
			this.x = 0;
			this.y = 0;
			this.num = 0;
		}

	}

}
