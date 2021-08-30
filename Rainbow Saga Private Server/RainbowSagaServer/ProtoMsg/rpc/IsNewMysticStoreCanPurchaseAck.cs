using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class IsNewMysticStoreCanPurchaseAck
	{

		[ProtoMember(1)]
		public int iscanpurchase{ get; set; }


		internal IsNewMysticStoreCanPurchaseAck()
		{
			this.iscanpurchase = 0;
		}

	}

}
