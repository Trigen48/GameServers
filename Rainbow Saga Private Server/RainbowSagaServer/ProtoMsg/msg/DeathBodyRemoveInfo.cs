using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DeathBodyRemoveInfo
	{

		[ProtoMember(1)]
		public int bodyid{ get; set; }


		internal DeathBodyRemoveInfo()
		{
			this.bodyid = 0;
		}

	}

}
