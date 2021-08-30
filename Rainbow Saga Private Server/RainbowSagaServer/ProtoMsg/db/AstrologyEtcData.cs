using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class AstrologyEtcData
	{

		[ProtoMember(1)]
		public int starSoul{ get; set; }

		[ProtoMember(2)]
		public int divineFrees{ get; set; }

		[ProtoMember(3)]
		public int count3{ get; set; }

		[ProtoMember(4)]
		public int count4{ get; set; }

		[ProtoMember(5)]
		public int divineCount{ get; set; }


		internal AstrologyEtcData()
		{
			this.starSoul = 0;
			this.divineFrees = 0;
			this.count3 = 0;
			this.count4 = 0;
			this.divineCount = 0;
		}

	}

}
