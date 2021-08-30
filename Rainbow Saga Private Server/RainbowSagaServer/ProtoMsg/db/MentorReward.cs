using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorReward
	{

		[ProtoMember(1)]
		public int exp{ get; set; }

		[ProtoMember(2)]
		public int crystal{ get; set; }


		internal MentorReward()
		{
			this.exp = 0;
			this.crystal = 0;
		}

	}

}
