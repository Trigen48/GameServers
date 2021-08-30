using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.msg;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetFamilyWorshipData
	{

		[ProtoMember(1)]
		public FamilyWorshipData data{ get; set; }


		internal GetFamilyWorshipData()
		{
			this.data = new FamilyWorshipData();
		}

	}

}
