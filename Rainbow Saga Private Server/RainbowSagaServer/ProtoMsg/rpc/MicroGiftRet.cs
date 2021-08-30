using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.msg;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class MicroGiftRet
	{

		[ProtoMember(1, IsRequired=true)]
		public MicroGift microGift{ get; set; }

		[ProtoMember(2)]
		public int bingo{ get; set; }


		internal MicroGiftRet()
		{
			this.microGift = new MicroGift();
			this.bingo = 0;
		}

	}

}
