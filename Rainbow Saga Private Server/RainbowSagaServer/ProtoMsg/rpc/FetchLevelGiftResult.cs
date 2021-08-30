using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class FetchLevelGiftResult
	{

		[ProtoMember(1)]
		public int result{ get; set; }


		internal FetchLevelGiftResult()
		{
			this.result = 0;
		}

	}

}
