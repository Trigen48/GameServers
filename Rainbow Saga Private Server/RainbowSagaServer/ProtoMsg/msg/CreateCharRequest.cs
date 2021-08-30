using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CreateCharRequest
	{

		[ProtoMember(1, IsRequired=true)]
		public int gender{ get; set; }


		internal CreateCharRequest()
		{
			this.gender = 0;
		}

	}

}
