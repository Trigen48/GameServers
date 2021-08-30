using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class InviteToFamilyAck
	{

		[ProtoMember(1)]
		public string srcname{ get; set; }

		[ProtoMember(2)]
		public string destname{ get; set; }

		[ProtoMember(3)]
		public int result{ get; set; }


		internal InviteToFamilyAck()
		{
			this.srcname ="";
			this.destname ="";
			this.result = 0;
		}

	}

}
