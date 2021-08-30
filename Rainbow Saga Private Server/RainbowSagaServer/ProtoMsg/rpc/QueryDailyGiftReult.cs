using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class QueryDailyGiftReult
	{

		[ProtoMember(1, IsRequired=true)]
		public int ret{ get; set; }

		[ProtoMember(2)]
		public int giftType{ get; set; }

		[ProtoMember(3)]
		public string type{ get; set; }


		internal QueryDailyGiftReult()
		{
			this.ret = 0;
			this.giftType = 0;
			this.type ="";
		}

	}

}
