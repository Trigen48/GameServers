using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MentorInfo
	{

		[ProtoMember(1)]
		public long mentorid{ get; set; }

		[ProtoMember(2)]
		public int mentorlevel{ get; set; }

		[ProtoMember(3)]
		public int receivedAward{ get; set; }

		[ProtoMember(4)]
		public int guidetime{ get; set; }


		internal MentorInfo()
		{
			this.mentorid = 0;
			this.mentorlevel = 0;
			this.receivedAward = 0;
			this.guidetime = 0;
		}

	}

}
