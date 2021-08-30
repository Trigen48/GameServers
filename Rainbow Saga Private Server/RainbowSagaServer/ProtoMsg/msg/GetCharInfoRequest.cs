using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetCharInfoRequest
	{

		[ProtoMember(1, IsRequired=true)]
		public string charName{ get; set; }

		[ProtoMember(2, IsRequired=true)]
		public string selfCharName{ get; set; }


		internal GetCharInfoRequest()
		{
			this.charName ="";
			this.selfCharName ="";
		}

	}

}
