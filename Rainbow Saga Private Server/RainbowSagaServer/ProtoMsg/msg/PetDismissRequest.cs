using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PetDismissRequest
	{

		[ProtoMember(1)]
		public ulong uuid{ get; set; }


		internal PetDismissRequest()
		{
			this.uuid = 0;
		}

	}

}
