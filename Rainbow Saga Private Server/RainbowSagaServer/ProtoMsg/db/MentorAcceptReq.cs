using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorAcceptReq
	{

		[ProtoMember(1)]
		public string charname{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }


		internal MentorAcceptReq()
		{
			this.charname ="";
			this.type = 0;
		}

	}

}
