using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class QueryDailyGift
	{

		[ProtoMember(1, IsRequired=true)]
		public string type{ get; set; }

		[ProtoMember(2, IsRequired=true)]
		public int giftType{ get; set; }


		internal QueryDailyGift()
		{
			this.type ="";
			this.giftType = 0;
		}

	}

}
