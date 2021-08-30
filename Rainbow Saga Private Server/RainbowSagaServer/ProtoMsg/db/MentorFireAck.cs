using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorFireAck
	{

		[ProtoMember(1)]
		public int ret{ get; set; }


		internal MentorFireAck()
		{
			this.ret = 0;
		}

	}

}
