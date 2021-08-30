using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ValidateCharNameRequest
	{

		[ProtoMember(1, IsRequired=true)]
		public int charid{ get; set; }

		[ProtoMember(2, IsRequired=true)]
		public string charname{ get; set; }


		internal ValidateCharNameRequest()
		{
			this.charid = 0;
			this.charname ="";
		}

	}

}
