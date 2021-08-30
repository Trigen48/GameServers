using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ScheduleFamilyPetDgnReq
	{

		[ProtoMember(1)]
		public int petLevel{ get; set; }

		[ProtoMember(2)]
		public int startTime{ get; set; }


		internal ScheduleFamilyPetDgnReq()
		{
			this.petLevel = 0;
			this.startTime = 0;
		}

	}

}
