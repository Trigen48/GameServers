using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OfflineAFKAwardResult
	{

		[ProtoMember(1)]
		public int ret{ get; set; }

		[ProtoMember(2)]
		public int exp{ get; set; }


		internal OfflineAFKAwardResult()
		{
			this.ret = 0;
			this.exp = 0;
		}

	}

}
