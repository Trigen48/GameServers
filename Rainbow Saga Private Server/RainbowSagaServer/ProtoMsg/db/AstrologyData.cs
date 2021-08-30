using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class AstrologyData
	{

		[ProtoMember(1)]
		public AstrologyDivineData divine{ get; set; }

		[ProtoMember(2)]
		public AstrologyEquipData equip{ get; set; }

		[ProtoMember(3)]
		public AstrologyBagData bag{ get; set; }

		[ProtoMember(4)]
		public AstrologyEtcData etc{ get; set; }


		internal AstrologyData()
		{
			this.divine = new AstrologyDivineData();
			this.equip = new AstrologyEquipData();
			this.bag = new AstrologyBagData();
			this.etc = new AstrologyEtcData();
		}

	}

}
