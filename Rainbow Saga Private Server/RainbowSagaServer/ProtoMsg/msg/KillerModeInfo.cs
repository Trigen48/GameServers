using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class KillerModeInfo
	{

		[ProtoMember(1)]
		public int killerMode{ get; set; }


		internal KillerModeInfo()
		{
			this.killerMode = 0;
		}

	}

}
