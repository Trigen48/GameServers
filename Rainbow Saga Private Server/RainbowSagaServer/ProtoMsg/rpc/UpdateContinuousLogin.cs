using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpdateContinuousLogin
	{

		[ProtoMember(1)]
		public int num{ get; set; }


		internal UpdateContinuousLogin()
		{
			this.num = 0;
		}

	}

}
