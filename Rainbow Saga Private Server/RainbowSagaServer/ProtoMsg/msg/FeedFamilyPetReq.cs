using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class FeedFamilyPetReq
	{

		[ProtoMember(1)]
		public int num{ get; set; }


		internal FeedFamilyPetReq()
		{
			this.num = 0;
		}

	}

}
