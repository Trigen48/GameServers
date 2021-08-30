using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class QueryCharInfoRequest
	{

		[ProtoMember(1, IsRequired=true)]
		public string accname{ get; set; }


		internal QueryCharInfoRequest()
		{
			this.accname ="";
		}

	}

}
