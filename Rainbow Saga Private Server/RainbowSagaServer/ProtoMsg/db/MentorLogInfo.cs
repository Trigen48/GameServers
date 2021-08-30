using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.msg;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorLogInfo
	{

		[ProtoMember(1)]
		public SystemPrompt log{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }

		[ProtoMember(3)]
		public int time{ get; set; }


		internal MentorLogInfo()
		{
			this.log = new SystemPrompt();
			this.type = 0;
			this.time = 0;
		}

	}

}
