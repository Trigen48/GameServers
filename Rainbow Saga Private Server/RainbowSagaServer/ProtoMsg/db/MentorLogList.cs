using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorLogList
	{

		[ProtoMember(1)]
		public List<MentorLogInfo> infos{ get; set; }


		internal MentorLogList()
		{
			this.infos = new List<MentorLogInfo>();
		}

	}

}
