using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorModifyTextAck
	{

		[ProtoMember(1)]
		public int ret{ get; set; }


		internal MentorModifyTextAck()
		{
			this.ret = 0;
		}

	}

}
