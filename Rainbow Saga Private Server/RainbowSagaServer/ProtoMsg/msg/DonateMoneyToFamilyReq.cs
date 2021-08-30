using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DonateMoneyToFamilyReq
	{

		[ProtoMember(1)]
		public int money{ get; set; }


		internal DonateMoneyToFamilyReq()
		{
			this.money = 0;
		}

	}

}
