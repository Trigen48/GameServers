using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GrpDgnPrepareConfirm
	{

		[ProtoMember(1)]
		public string charname{ get; set; }

		[ProtoMember(2)]
		public int profession{ get; set; }

		[ProtoMember(3)]
		public int level{ get; set; }

		[ProtoMember(4)]
		public int hair{ get; set; }

		[ProtoMember(5)]
		public int face{ get; set; }

		[ProtoMember(6)]
		public int skintype{ get; set; }

		[ProtoMember(7)]
		public int ready{ get; set; }

		[ProtoMember(8)]
		public int gender{ get; set; }


		internal GrpDgnPrepareConfirm()
		{
			this.charname ="";
			this.profession = 0;
			this.level = 0;
			this.hair = 0;
			this.face = 0;
			this.skintype = 0;
			this.ready = 0;
			this.gender = 0;
		}

	}

}
