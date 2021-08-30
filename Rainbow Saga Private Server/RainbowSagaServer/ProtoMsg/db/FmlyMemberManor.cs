using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FmlyMemberManor
	{

		[ProtoMember(1)]
		public int got{ get; set; }

		[ProtoMember(2)]
		public int lastGotTime{ get; set; }


		internal FmlyMemberManor()
		{
			this.got = 0;
			this.lastGotTime = 0;
		}

	}

}
