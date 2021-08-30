using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorAcceptAck
	{

		[ProtoMember(1)]
		public int ret{ get; set; }

		[ProtoMember(2)]
		public string charname{ get; set; }


		internal MentorAcceptAck()
		{
			this.ret = 0;
			this.charname ="";
		}

	}

}
