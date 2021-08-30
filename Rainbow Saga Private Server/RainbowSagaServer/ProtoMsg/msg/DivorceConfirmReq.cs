using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DivorceConfirmReq
	{

		[ProtoMember(1)]
		public int charId{ get; set; }

		[ProtoMember(2)]
		public int cpId{ get; set; }


		internal DivorceConfirmReq()
		{
			this.charId = 0;
			this.cpId = 0;
		}

	}

}
