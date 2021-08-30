using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ScenceTriggerBaseInfo
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public List<TriggerMobInfo> mobinfos{ get; set; }


		internal ScenceTriggerBaseInfo()
		{
			this.type = 0;
			this.mobinfos = new List<TriggerMobInfo>();
		}

	}

}
