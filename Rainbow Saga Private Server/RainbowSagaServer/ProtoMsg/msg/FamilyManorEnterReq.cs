using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class FamilyManorEnterReq
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int manorId{ get; set; }


		internal FamilyManorEnterReq()
		{
			this.op = 0;
			this.manorId = 0;
		}

	}

}
