using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class DgnEvalution
	{

		[ProtoMember(1)]
		public int difficulty{ get; set; }

		[ProtoMember(2)]
		public int score{ get; set; }


		internal DgnEvalution()
		{
			this.difficulty = 0;
			this.score = 0;
		}

	}

}
