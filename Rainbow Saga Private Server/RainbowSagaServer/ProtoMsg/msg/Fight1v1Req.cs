using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Fight1v1Req
	{

		[ProtoMember(1)]
		public string toPlayer{ get; set; }

		[ProtoMember(2)]
		public string fromPlayer{ get; set; }

		[ProtoMember(3)]
		public int level{ get; set; }

		[ProtoMember(4)]
		public int profession{ get; set; }

		[ProtoMember(5, IsRequired=true)]
		public int gender{ get; set; }

		[ProtoMember(6)]
		public int hair{ get; set; }

		[ProtoMember(7)]
		public int face{ get; set; }

		[ProtoMember(8)]
		public int skintype{ get; set; }


		internal Fight1v1Req()
		{
			this.toPlayer ="";
			this.fromPlayer ="";
			this.level = 0;
			this.profession = 0;
			this.gender = 0;
			this.hair = 0;
			this.face = 0;
			this.skintype = 0;
		}

	}

}
