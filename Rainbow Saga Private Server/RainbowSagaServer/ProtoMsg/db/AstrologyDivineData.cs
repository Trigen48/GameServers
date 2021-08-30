using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class AstrologyDivineData
	{

		[ProtoMember(1)]
		public int starList1{ get; set; }

		[ProtoMember(2)]
		public int starList2{ get; set; }


		internal AstrologyDivineData()
		{
			this.starList1 = 0;
			this.starList2 = 0;
		}

	}

}
