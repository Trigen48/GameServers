using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class IsNewMysticBusinessItemCanBuyAck
	{

		[ProtoMember(1)]
		public int result{ get; set; }


		internal IsNewMysticBusinessItemCanBuyAck()
		{
			this.result = 0;
		}

	}

}
