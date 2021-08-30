using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SyncFamilyPetExpRate
	{

		[ProtoMember(1)]
		public uint familyid{ get; set; }

		[ProtoMember(2)]
		public int playernums{ get; set; }

		[ProtoMember(3)]
		public int exprate{ get; set; }


		internal SyncFamilyPetExpRate()
		{
			this.familyid = 0;
			this.playernums = 0;
			this.exprate = 0;
		}

	}

}
