using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CreateCharResponse
	{

		[ProtoMember(1, IsRequired=true)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public int charid{ get; set; }


		internal CreateCharResponse()
		{
			this.result = 0;
			this.charid = 0;
		}

	}

}
