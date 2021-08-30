using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DeliveryInfo
	{

		[ProtoMember(1)]
		public string charname{ get; set; }

		[ProtoMember(2)]
		public int deliverycount{ get; set; }

		[ProtoMember(3)]
		public int robcount{ get; set; }

		[ProtoMember(4)]
		public int protecttime{ get; set; }

		[ProtoMember(5)]
		public DeliveryExtraInfo bExtra{ get; set; }


		internal DeliveryInfo()
		{
			this.charname ="";
			this.deliverycount = 0;
			this.robcount = 0;
			this.protecttime = 0;
			this.bExtra = new DeliveryExtraInfo();
		}

	}

}
