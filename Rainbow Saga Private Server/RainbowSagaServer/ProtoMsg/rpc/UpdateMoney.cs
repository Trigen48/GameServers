using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpdateMoney
	{

		[ProtoMember(1)]
		public int money{ get; set; }


		internal UpdateMoney()
		{
			this.money = 0;
		}

	}

}
