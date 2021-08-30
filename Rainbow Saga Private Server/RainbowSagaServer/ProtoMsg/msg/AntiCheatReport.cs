using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class AntiCheatReport
	{

		[ProtoMember(1)]
		public int frameCount{ get; set; }


		internal AntiCheatReport()
		{
			this.frameCount = 0;
		}

	}

}
