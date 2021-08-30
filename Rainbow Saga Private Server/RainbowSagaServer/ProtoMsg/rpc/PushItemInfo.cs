using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class PushItemInfo
	{

		[ProtoMember(1)]
		public int module{ get; set; }

		[ProtoMember(2)]
		public int lefttime{ get; set; }


		internal PushItemInfo()
		{
			this.module = 0;
			this.lefttime = 0;
		}

	}

}
