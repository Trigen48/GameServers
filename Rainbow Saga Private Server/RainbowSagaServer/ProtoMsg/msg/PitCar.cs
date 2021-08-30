using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PitCar
	{

		[ProtoMember(1)]
		public int cartype{ get; set; }

		[ProtoMember(2)]
		public int carruntime{ get; set; }

		[ProtoMember(3)]
		public int carrobcount{ get; set; }

		[ProtoMember(4)]
		public int starttime{ get; set; }

		[ProtoMember(5)]
		public int ratio{ get; set; }

		[ProtoMember(6)]
		public int carstatus{ get; set; }

		[ProtoMember(7)]
		public CarReward carreward{ get; set; }


		internal PitCar()
		{
			this.cartype = 0;
			this.carruntime = 0;
			this.carrobcount = 0;
			this.starttime = 0;
			this.ratio = 0;
			this.carstatus = 0;
			this.carreward = new CarReward();
		}

	}

}
