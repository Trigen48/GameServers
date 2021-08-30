using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorGetLogsAck
	{

		[ProtoMember(1)]
		public MentorLogList logs{ get; set; }


		internal MentorGetLogsAck()
		{
			this.logs = new MentorLogList();
		}

	}

}
