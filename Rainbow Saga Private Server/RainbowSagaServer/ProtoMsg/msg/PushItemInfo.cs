using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PushItemInfo
	{

		[ProtoMember(1)]
		public int module{ get; set; }

		[ProtoMember(2)]
		public int startTime{ get; set; }

		[ProtoMember(3)]
		public int awarded{ get; set; }

		[ProtoMember(4)]
		public int levels{ get; set; }


		internal PushItemInfo()
		{
			this.module = 0;
			this.startTime = 0;
			this.awarded = 0;
			this.levels = 0;
		}

	}

}
