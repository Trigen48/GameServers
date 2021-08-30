using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class TowerFloorInfo
	{

		[ProtoMember(1)]
		public string charname{ get; set; }

		[ProtoMember(2)]
		public int floor{ get; set; }

		[ProtoMember(3)]
		public string firstPlayer{ get; set; }

		[ProtoMember(4)]
		public string fastestPlayer{ get; set; }

		[ProtoMember(5)]
		public int fastestTime{ get; set; }


		internal TowerFloorInfo()
		{
			this.charname ="";
			this.floor = 0;
			this.firstPlayer ="";
			this.fastestPlayer ="";
			this.fastestTime = 0;
		}

	}

}
