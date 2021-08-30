using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class QueryInviteGiftReult
	{

		[ProtoMember(1, IsRequired=true)]
		public int ret{ get; set; }

		[ProtoMember(2)]
		public int giftType{ get; set; }

		[ProtoMember(3)]
		public int count{ get; set; }

		[ProtoMember(4)]
		public int dailyState{ get; set; }


		internal QueryInviteGiftReult()
		{
			this.ret = 0;
			this.giftType = 0;
			this.count = 0;
			this.dailyState = 0;
		}

	}

}
