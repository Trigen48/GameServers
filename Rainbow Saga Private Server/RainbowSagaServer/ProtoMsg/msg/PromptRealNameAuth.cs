using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PromptRealNameAuth
	{

		[ProtoMember(1)]
		public uint uin{ get; set; }

		[ProtoMember(2)]
		public uint charid{ get; set; }


		internal PromptRealNameAuth()
		{
			this.uin = 0;
			this.charid = 0;
		}

	}

}
