using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class KillerModeReq
	{

		[ProtoMember(1)]
		public int switchOn{ get; set; }


		internal KillerModeReq()
		{
			this.switchOn = 0;
		}

	}

}
