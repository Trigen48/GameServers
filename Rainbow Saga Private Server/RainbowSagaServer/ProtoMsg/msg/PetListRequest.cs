using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PetListRequest
	{

		[ProtoMember(1)]
		public int dummy{ get; set; }


		internal PetListRequest()
		{
			this.dummy = 0;
		}

	}

}
