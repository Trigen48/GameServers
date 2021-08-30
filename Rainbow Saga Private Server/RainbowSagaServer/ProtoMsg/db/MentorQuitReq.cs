using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorQuitReq
	{

		[ProtoMember(1)]
		public int unused{ get; set; }


		internal MentorQuitReq()
		{
			this.unused = 0;
		}

	}

}
