using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class SignInResult
	{

		[ProtoMember(1)]
		public uint result{ get; set; }

		[ProtoMember(2)]
		public SignUserData data{ get; set; }


		internal SignInResult()
		{
			this.result = 0;
			this.data = new SignUserData();
		}

	}

}
