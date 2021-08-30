using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SeabedOpRsp
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int result{ get; set; }

		[ProtoMember(3)]
		public int charid{ get; set; }

		[ProtoMember(4)]
		public int worldid{ get; set; }


		internal SeabedOpRsp()
		{
			this.op = 0;
			this.result = 0;
			this.charid = 0;
			this.worldid = 0;
		}

	}

}
