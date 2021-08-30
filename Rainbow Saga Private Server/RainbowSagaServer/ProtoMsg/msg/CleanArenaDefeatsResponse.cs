using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CleanArenaDefeatsResponse
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public int cleanDefeats{ get; set; }

		[ProtoMember(3)]
		public int cleanDraws{ get; set; }

		[ProtoMember(4)]
		public int charid{ get; set; }


		internal CleanArenaDefeatsResponse()
		{
			this.result = 0;
			this.cleanDefeats = 0;
			this.cleanDraws = 0;
			this.charid = 0;
		}

	}

}
