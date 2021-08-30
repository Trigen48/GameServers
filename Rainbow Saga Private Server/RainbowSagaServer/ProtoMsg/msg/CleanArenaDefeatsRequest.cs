using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CleanArenaDefeatsRequest
	{

		[ProtoMember(1)]
		public int cleanDefeats{ get; set; }

		[ProtoMember(2)]
		public int cleanDraws{ get; set; }

		[ProtoMember(3)]
		public int charid{ get; set; }


		internal CleanArenaDefeatsRequest()
		{
			this.cleanDefeats = 0;
			this.cleanDraws = 0;
			this.charid = 0;
		}

	}

}
