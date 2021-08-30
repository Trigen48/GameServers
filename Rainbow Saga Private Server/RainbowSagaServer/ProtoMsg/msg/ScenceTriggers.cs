using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ScenceTriggers
	{

		[ProtoMember(1)]
		public List<ScenceTriggerConditions> triggers{ get; set; }


		internal ScenceTriggers()
		{
			this.triggers = new List<ScenceTriggerConditions>();
		}

	}

}
