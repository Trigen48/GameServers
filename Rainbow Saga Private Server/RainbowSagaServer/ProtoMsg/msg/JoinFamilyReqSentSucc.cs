using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class JoinFamilyReqSentSucc
	{

		[ProtoMember(1)]
		public long familyid{ get; set; }


		internal JoinFamilyReqSentSucc()
		{
			this.familyid = 0;
		}

	}

}
