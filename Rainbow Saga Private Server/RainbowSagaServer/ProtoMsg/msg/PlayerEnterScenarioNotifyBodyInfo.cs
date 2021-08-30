using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PlayerEnterScenarioNotifyBodyInfo
	{

		[ProtoMember(1)]
		public List<DeathBodyTouchTimesInfo> deathBodyTouchTimesInfo{ get; set; }


		internal PlayerEnterScenarioNotifyBodyInfo()
		{
			this.deathBodyTouchTimesInfo = new List<DeathBodyTouchTimesInfo>();
		}

	}

}
