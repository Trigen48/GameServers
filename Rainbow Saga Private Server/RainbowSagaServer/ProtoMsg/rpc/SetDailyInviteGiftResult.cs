using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class SetDailyInviteGiftResult
	{

		[ProtoMember(1, IsRequired=true)]
		public int ret{ get; set; }

		[ProtoMember(2)]
		public int deadline{ get; set; }


		internal SetDailyInviteGiftResult()
		{
			this.ret = 0;
			this.deadline = 0;
		}

	}

}
