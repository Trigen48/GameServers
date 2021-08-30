using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetGrpDgnQueueInfoAck
	{

		[ProtoMember(1)]
		public int multidgntimes{ get; set; }

		[ProtoMember(2)]
		public int inqueue{ get; set; }

		[ProtoMember(3)]
		public List<GroupDungeonQueue> infos{ get; set; }

		[ProtoMember(4)]
		public int activitydgntimes{ get; set; }

		[ProtoMember(5)]
		public int activitydgnaddtimes{ get; set; }


		internal GetGrpDgnQueueInfoAck()
		{
			this.multidgntimes = 0;
			this.inqueue = 0;
			this.infos = new List<GroupDungeonQueue>();
			this.activitydgntimes = 0;
			this.activitydgnaddtimes = 0;
		}

	}

}
