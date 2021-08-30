using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DeliveryExtraInfo
	{

		[ProtoMember(1)]
		public int level{ get; set; }

		[ProtoMember(2)]
		public string familyname{ get; set; }

		[ProtoMember(3)]
		public int refreshcount{ get; set; }

		[ProtoMember(4)]
		public int freetimes{ get; set; }

		[ProtoMember(5)]
		public int resettime{ get; set; }

		[ProtoMember(6)]
		public PitCar pitcar{ get; set; }


		internal DeliveryExtraInfo()
		{
			this.level = 0;
			this.familyname ="";
			this.refreshcount = 0;
			this.freetimes = 0;
			this.resettime = 0;
			this.pitcar = new PitCar();
		}

	}

}
