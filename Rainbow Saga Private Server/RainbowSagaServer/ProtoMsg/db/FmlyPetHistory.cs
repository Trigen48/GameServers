using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FmlyPetHistory
	{

		[ProtoMember(1)]
		public int petLevel{ get; set; }


		internal FmlyPetHistory()
		{
			this.petLevel = 0;
		}

	}

}
