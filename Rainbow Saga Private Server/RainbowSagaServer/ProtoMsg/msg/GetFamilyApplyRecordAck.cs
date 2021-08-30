using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetFamilyApplyRecordAck
	{

		[ProtoMember(1)]
		public int unused{ get; set; }

		[ProtoMember(2)]
		public long familyids{ get; set; }


		internal GetFamilyApplyRecordAck()
		{
			this.unused = 0;
			this.familyids = 0;
		}

	}

}
