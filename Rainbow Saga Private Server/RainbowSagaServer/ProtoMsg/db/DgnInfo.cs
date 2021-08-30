using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class DgnInfo
	{

		[ProtoMember(1)]
		public int instanceid{ get; set; }

		[ProtoMember(2)]
		public int templateid{ get; set; }

		[ProtoMember(3)]
		public int createtime{ get; set; }

		[ProtoMember(4)]
		public int realmapid{ get; set; }

		[ProtoMember(5)]
		public CheckPoint checkpoint{ get; set; }

		[ProtoMember(6)]
		public int dgnzoneid{ get; set; }

		[ProtoMember(7)]
		public int haveEnterDgnZone{ get; set; }


		internal DgnInfo()
		{
			this.instanceid = 0;
			this.templateid = 0;
			this.createtime = 0;
			this.realmapid = 0;
			this.checkpoint = new CheckPoint();
			this.dgnzoneid = 0;
			this.haveEnterDgnZone = 0;
		}

	}

}
