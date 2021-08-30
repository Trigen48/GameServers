using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class Beautician
	{

		[ProtoMember(1)]
		public int hair{ get; set; }

		[ProtoMember(2)]
		public int skin{ get; set; }

		[ProtoMember(3)]
		public int face{ get; set; }

		[ProtoMember(4)]
		public int daijinquanFlag{ get; set; }


		internal Beautician()
		{
			this.hair = 0;
			this.skin = 0;
			this.face = 0;
			this.daijinquanFlag = 0;
		}

	}

}
