using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Skill
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int lv{ get; set; }

		[ProtoMember(3)]
		public int maxLv{ get; set; }


		internal Skill()
		{
			this.id = 0;
			this.lv = 0;
			this.maxLv = 0;
		}

	}

}
