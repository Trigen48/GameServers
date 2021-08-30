using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class FestivalGiftInfo
	{

		[ProtoMember(1)]
		public int getedgiftids{ get; set; }


		internal FestivalGiftInfo()
		{
			this.getedgiftids = 0;
		}

	}

}
