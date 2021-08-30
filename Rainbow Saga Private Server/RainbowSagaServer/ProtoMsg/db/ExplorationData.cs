using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class ExplorationData
	{

		[ProtoMember(1)]
		public int area{ get; set; }

		[ProtoMember(2)]
		public int step{ get; set; }

		[ProtoMember(3)]
		public int onlinetime{ get; set; }

		[ProtoMember(4)]
		public int times{ get; set; }


		internal ExplorationData()
		{
			this.area = 0;
			this.step = 0;
			this.onlinetime = 0;
			this.times = 0;
		}

	}

}
