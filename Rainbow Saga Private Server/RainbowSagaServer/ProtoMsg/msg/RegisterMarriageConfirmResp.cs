using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class RegisterMarriageConfirmResp
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public int cpId{ get; set; }

		[ProtoMember(3)]
		public int ringLevel{ get; set; }


		internal RegisterMarriageConfirmResp()
		{
			this.result = 0;
			this.cpId = 0;
			this.ringLevel = 0;
		}

	}

}
