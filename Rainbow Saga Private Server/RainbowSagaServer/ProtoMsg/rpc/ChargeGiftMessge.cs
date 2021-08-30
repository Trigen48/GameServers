using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class ChargeGiftMessge
	{

		[ProtoMember(1)]
		public uint index{ get; set; }


		internal ChargeGiftMessge()
		{
			this.index = 0;
		}

	}

}
