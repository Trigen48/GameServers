using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PetBookRequest
	{

		[ProtoMember(1)]
		public int ownerId{ get; set; }


		internal PetBookRequest()
		{
			this.ownerId = 0;
		}

	}

}
