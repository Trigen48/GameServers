using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ExpMoneyItem
	{

		[ProtoMember(1)]
		public int money{ get; set; }

		[ProtoMember(2)]
		public int exp{ get; set; }


		internal ExpMoneyItem()
		{
			this.money = 0;
			this.exp = 0;
		}

	}

}
