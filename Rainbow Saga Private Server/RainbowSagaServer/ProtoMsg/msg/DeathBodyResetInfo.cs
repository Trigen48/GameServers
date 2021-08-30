using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DeathBodyResetInfo
	{

		[ProtoMember(1)]
		public int bodyid{ get; set; }


		internal DeathBodyResetInfo()
		{
			this.bodyid = 0;
		}

	}

}
