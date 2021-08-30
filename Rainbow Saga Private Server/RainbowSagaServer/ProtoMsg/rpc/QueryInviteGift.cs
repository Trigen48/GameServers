using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class QueryInviteGift
	{

		[ProtoMember(1, IsRequired=true)]
		public int giftType{ get; set; }


		internal QueryInviteGift()
		{
			this.giftType = 0;
		}

	}

}
