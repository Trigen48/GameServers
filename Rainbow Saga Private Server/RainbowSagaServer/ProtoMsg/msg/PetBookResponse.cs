using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PetBookResponse
	{

		[ProtoMember(1)]
		public int ownerId{ get; set; }

		[ProtoMember(2)]
		public int petBook{ get; set; }


		internal PetBookResponse()
		{
			this.ownerId = 0;
			this.petBook = 0;
		}

	}

}
