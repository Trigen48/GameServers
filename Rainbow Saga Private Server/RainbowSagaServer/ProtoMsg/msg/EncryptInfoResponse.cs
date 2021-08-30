using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class EncryptInfoResponse
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public uint maxLen{ get; set; }

		[ProtoMember(3)]
		public uint secretKey{ get; set; }


		internal EncryptInfoResponse()
		{
			this.type = 0;
			this.maxLen = 0;
			this.secretKey = 0;
		}

	}

}
