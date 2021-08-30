using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetFamilyNameAck
	{

		[ProtoMember(1)]
		public long familyid{ get; set; }

		[ProtoMember(2)]
		public string familyname{ get; set; }


		internal GetFamilyNameAck()
		{
			this.familyid = 0;
			this.familyname ="";
		}

	}

}
