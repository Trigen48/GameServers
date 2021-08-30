using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorFireReq
	{

		[ProtoMember(1)]
		public string charname{ get; set; }


		internal MentorFireReq()
		{
			this.charname ="";
		}

	}

}
