using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ChangeSceneResponse
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public uint scene{ get; set; }

		[ProtoMember(3)]
		public string portal{ get; set; }

		[ProtoMember(4)]
		public int x{ get; set; }

		[ProtoMember(5)]
		public int y{ get; set; }

		[ProtoMember(6)]
		public uint dgnresid{ get; set; }


		internal ChangeSceneResponse()
		{
			this.result = 0;
			this.scene = 0;
			this.portal ="";
			this.x = 0;
			this.y = 0;
			this.dgnresid = 0;
		}

	}

}
