using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorReportReq
	{

		[ProtoMember(1)]
		public string charname{ get; set; }


		internal MentorReportReq()
		{
			this.charname ="";
		}

	}

}
