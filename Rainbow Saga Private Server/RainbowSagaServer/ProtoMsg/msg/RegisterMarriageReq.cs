using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class RegisterMarriageReq
	{

		[ProtoMember(1)]
		public int cpId{ get; set; }

		[ProtoMember(2)]
		public int ringLevel{ get; set; }


		internal RegisterMarriageReq()
		{
			this.cpId = 0;
			this.ringLevel = 0;
		}

	}

}
