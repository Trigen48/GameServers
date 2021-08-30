using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetGroupApplicantsResp
	{

		[ProtoMember(1)]
		public int unused{ get; set; }

		[ProtoMember(2)]
		public List<Applicant> infos{ get; set; }


		internal GetGroupApplicantsResp()
		{
			this.unused = 0;
			this.infos = new List<Applicant>();
		}

	}

}
