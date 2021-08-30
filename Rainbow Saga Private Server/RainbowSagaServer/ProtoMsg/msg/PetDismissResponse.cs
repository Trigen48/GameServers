using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PetDismissResponse
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public ulong uuid{ get; set; }


		internal PetDismissResponse()
		{
			this.result = 0;
			this.uuid = 0;
		}

	}

}
