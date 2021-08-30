using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DivorceConfirmResp
	{

		[ProtoMember(1)]
		public int charId{ get; set; }

		[ProtoMember(2)]
		public int cpId{ get; set; }

		[ProtoMember(3)]
		public int result{ get; set; }


		internal DivorceConfirmResp()
		{
			this.charId = 0;
			this.cpId = 0;
			this.result = 0;
		}

	}

}
