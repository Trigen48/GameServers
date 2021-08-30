using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ScenceTriggerConditions
	{

		[ProtoMember(1)]
		public int triggerid{ get; set; }

		[ProtoMember(2)]
		public List<ScenceTriggerBaseInfo> conditions{ get; set; }


		internal ScenceTriggerConditions()
		{
			this.triggerid = 0;
			this.conditions = new List<ScenceTriggerBaseInfo>();
		}

	}

}
