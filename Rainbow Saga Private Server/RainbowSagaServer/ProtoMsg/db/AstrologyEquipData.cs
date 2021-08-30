using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class AstrologyEquipData
	{

		[ProtoMember(1)]
		public int starList1{ get; set; }

		[ProtoMember(2)]
		public int starList2{ get; set; }

		[ProtoMember(3)]
		public int starList3{ get; set; }


		internal AstrologyEquipData()
		{
			this.starList1 = 0;
			this.starList2 = 0;
			this.starList3 = 0;
		}

	}

}
