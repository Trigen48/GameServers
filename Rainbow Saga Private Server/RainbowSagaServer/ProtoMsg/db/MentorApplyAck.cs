using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorApplyAck
	{

		[ProtoMember(1)]
		public int ret{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }

		[ProtoMember(3)]
		public MentorApplyInfo info{ get; set; }


		internal MentorApplyAck()
		{
			this.ret = 0;
			this.type = 0;
			this.info = new MentorApplyInfo();
		}

	}

}
