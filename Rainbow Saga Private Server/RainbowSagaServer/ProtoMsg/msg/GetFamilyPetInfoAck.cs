using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetFamilyPetInfoAck
	{

		[ProtoMember(1)]
		public string name{ get; set; }

		[ProtoMember(2)]
		public int level{ get; set; }

		[ProtoMember(3)]
		public int exp{ get; set; }

		[ProtoMember(4)]
		public int maxExp{ get; set; }

		[ProtoMember(5)]
		public int mobid{ get; set; }


		internal GetFamilyPetInfoAck()
		{
			this.name ="";
			this.level = 0;
			this.exp = 0;
			this.maxExp = 0;
			this.mobid = 0;
		}

	}

}
