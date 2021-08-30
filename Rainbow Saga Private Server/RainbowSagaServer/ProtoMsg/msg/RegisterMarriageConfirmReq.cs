using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class RegisterMarriageConfirmReq
	{

		[ProtoMember(1)]
		public int cpId{ get; set; }

		[ProtoMember(2)]
		public string cpName{ get; set; }

		[ProtoMember(3)]
		public int ringLevel{ get; set; }


		internal RegisterMarriageConfirmReq()
		{
			this.cpId = 0;
			this.cpName ="";
			this.ringLevel = 0;
		}

	}

}
