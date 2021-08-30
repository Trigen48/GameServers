using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DeliveryConfigUsed
	{

		[ProtoMember(1)]
		public List<DeliveryConfigUsedItem> items{ get; set; }

		[ProtoMember(2)]
		public ExpMoneyConfig moneyexp{ get; set; }


		internal DeliveryConfigUsed()
		{
			this.items = new List<DeliveryConfigUsedItem>();
			this.moneyexp = new ExpMoneyConfig();
		}

	}

}
