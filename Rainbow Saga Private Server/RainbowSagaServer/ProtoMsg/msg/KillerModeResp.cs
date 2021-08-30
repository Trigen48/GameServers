using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class KillerModeResp
	{

		[ProtoMember(1)]
		public int charId{ get; set; }

		[ProtoMember(2)]
		public int switchOn{ get; set; }

		[ProtoMember(3)]
		public int isBanned{ get; set; }


		internal KillerModeResp()
		{
			this.charId = 0;
			this.switchOn = 0;
			this.isBanned = 0;
		}

	}

}
