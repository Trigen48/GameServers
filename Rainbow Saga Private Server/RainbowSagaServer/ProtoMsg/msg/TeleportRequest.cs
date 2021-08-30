using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class TeleportRequest
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public string portal{ get; set; }


		internal TeleportRequest()
		{
			this.type = 0;
			this.portal ="";
		}

	}

}
