using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class JoinFamilyAck
	{

		[ProtoMember(1, IsRequired=true)]
		public string reqname{ get; set; }

		[ProtoMember(2, IsRequired=true)]
		public int result{ get; set; }


		internal JoinFamilyAck()
		{
			this.reqname ="";
			this.result = 0;
		}

	}

}
