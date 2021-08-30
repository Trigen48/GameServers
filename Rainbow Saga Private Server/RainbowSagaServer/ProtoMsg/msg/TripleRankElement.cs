using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class TripleRankElement
	{

		[ProtoMember(1)]
		public string charname{ get; set; }

		[ProtoMember(2)]
		public int charid{ get; set; }

		[ProtoMember(3)]
		public int score{ get; set; }

		[ProtoMember(4)]
		public int rank{ get; set; }


		internal TripleRankElement()
		{
			this.charname ="";
			this.charid = 0;
			this.score = 0;
			this.rank = 0;
		}

	}

}
