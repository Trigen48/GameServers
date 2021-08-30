using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetFamilyApplicants
	{

		[ProtoMember(1, IsRequired=true)]
		public long familyid{ get; set; }


		internal GetFamilyApplicants()
		{
			this.familyid = 0;
		}

	}

}
