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
	internal class GetFamilyApplicantsAck
	{

		[ProtoMember(1, IsRequired=true)]
		public long familyid{ get; set; }

		[ProtoMember(2, IsRequired=true)]
		public FmlyApplicantList applist{ get; set; }


		internal GetFamilyApplicantsAck()
		{
			this.familyid = 0;
			this.applist = new FmlyApplicantList();
		}

	}

}
