using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorGetInfoAck
	{

		[ProtoMember(1)]
		public MentorInfo info{ get; set; }


		internal MentorGetInfoAck()
		{
			this.info = new MentorInfo();
		}

	}

}
