using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class FinishRealNameAuth
	{

		[ProtoMember(1)]
		public uint uin{ get; set; }

		[ProtoMember(3)]
		public uint result{ get; set; }


		internal FinishRealNameAuth()
		{
			this.uin = 0;
			this.result = 0;
		}

	}

}
