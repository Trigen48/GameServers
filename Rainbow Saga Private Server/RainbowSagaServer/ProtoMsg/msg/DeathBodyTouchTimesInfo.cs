using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DeathBodyTouchTimesInfo
	{

		[ProtoMember(1)]
		public int bodyid{ get; set; }

		[ProtoMember(2)]
		public int posx{ get; set; }

		[ProtoMember(3)]
		public int posy{ get; set; }

		[ProtoMember(4)]
		public int touchtimes{ get; set; }


		internal DeathBodyTouchTimesInfo()
		{
			this.bodyid = 0;
			this.posx = 0;
			this.posy = 0;
			this.touchtimes = 0;
		}

	}

}
