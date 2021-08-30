using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class NotifyDeliveryInfo
	{

		[ProtoMember(1)]
		public DeliveryInfo car{ get; set; }


		internal NotifyDeliveryInfo()
		{
			this.car = new DeliveryInfo();
		}

	}

}
