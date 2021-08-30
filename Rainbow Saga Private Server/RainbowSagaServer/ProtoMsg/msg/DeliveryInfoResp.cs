using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DeliveryInfoResp
	{

		[ProtoMember(1)]
		public List<DeliveryInfo> cars{ get; set; }


		internal DeliveryInfoResp()
		{
			this.cars = new List<DeliveryInfo>();
		}

	}

}
