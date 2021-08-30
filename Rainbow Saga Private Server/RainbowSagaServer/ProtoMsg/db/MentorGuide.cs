using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorGuide
	{

		[ProtoMember(1)]
		public int guidenum{ get; set; }

		[ProtoMember(2)]
		public int lastguidetime{ get; set; }


		internal MentorGuide()
		{
			this.guidenum = 0;
			this.lastguidetime = 0;
		}

	}

}
