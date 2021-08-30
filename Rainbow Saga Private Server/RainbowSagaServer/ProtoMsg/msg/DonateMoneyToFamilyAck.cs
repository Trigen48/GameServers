using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DonateMoneyToFamilyAck
	{

		[ProtoMember(1)]
		public int ret{ get; set; }


		internal DonateMoneyToFamilyAck()
		{
			this.ret = 0;
		}

	}

}
