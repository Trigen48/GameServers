using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class KickOutGroupResp
	{

		[ProtoMember(1, IsRequired=true)]
		public int result{ get; set; }


		internal KickOutGroupResp()
		{
			this.result = 0;
		}

	}

}
