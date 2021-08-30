using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Seabed
	{

		[ProtoMember(1)]
		public int seabedBonus{ get; set; }

		[ProtoMember(2)]
		public int joinDate{ get; set; }

		[ProtoMember(3)]
		public int joinTimes{ get; set; }


		internal Seabed()
		{
			this.seabedBonus = 0;
			this.joinDate = 0;
			this.joinTimes = 0;
		}

	}

}
