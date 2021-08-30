using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class RequestToJoinGroupResp
	{

		[ProtoMember(1, IsRequired=true)]
		public int result{ get; set; }

		[ProtoMember(2, IsRequired=true)]
		public string destname{ get; set; }


		internal RequestToJoinGroupResp()
		{
			this.result = 0;
			this.destname ="";
		}

	}

}
