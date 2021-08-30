using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class UseWeddingInvationRequest
	{

		[ProtoMember(1)]
		public string wedding{ get; set; }


		internal UseWeddingInvationRequest()
		{
			this.wedding ="";
		}

	}

}
