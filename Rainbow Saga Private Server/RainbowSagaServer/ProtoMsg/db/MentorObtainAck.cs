using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorObtainAck
	{

		[ProtoMember(1)]
		public int ret{ get; set; }


		internal MentorObtainAck()
		{
			this.ret = 0;
		}

	}

}
