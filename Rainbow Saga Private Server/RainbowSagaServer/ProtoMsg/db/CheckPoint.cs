using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class CheckPoint
	{

		[ProtoMember(1)]
		public int sn{ get; set; }

		[ProtoMember(2)]
		public int x{ get; set; }

		[ProtoMember(3)]
		public int y{ get; set; }


		internal CheckPoint()
		{
			this.sn = 0;
			this.x = 0;
			this.y = 0;
		}

	}

}
