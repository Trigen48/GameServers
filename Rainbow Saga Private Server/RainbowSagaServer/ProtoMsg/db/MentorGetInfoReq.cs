using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorGetInfoReq
	{

		[ProtoMember(1)]
		public int unused{ get; set; }


		internal MentorGetInfoReq()
		{
			this.unused = 0;
		}

	}

}
