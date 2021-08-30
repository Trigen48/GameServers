using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CreateCharTimeOut
	{

		[ProtoMember(1)]
		public int timeout{ get; set; }


		internal CreateCharTimeOut()
		{
			this.timeout = 0;
		}

	}

}
