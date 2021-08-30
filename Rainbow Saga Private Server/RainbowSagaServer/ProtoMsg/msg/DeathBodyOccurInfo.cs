using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DeathBodyOccurInfo
	{

		[ProtoMember(1)]
		public int bodyid{ get; set; }

		[ProtoMember(2)]
		public int posX{ get; set; }

		[ProtoMember(3)]
		public int posY{ get; set; }


		internal DeathBodyOccurInfo()
		{
			this.bodyid = 0;
			this.posX = 0;
			this.posY = 0;
		}

	}

}
