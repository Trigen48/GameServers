using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.db;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetFamilyPetDgnHistoryAck
	{

		[ProtoMember(1)]
		public List<FmlyPetHistory> history{ get; set; }


		internal GetFamilyPetDgnHistoryAck()
		{
			this.history = new List<FmlyPetHistory>();
		}

	}

}
