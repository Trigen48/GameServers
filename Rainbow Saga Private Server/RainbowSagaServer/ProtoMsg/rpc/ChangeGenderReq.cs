using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class ChangeGenderReq
	{

		[ProtoMember(1)]
		public int gender{ get; set; }

		[ProtoMember(2)]
		public int face{ get; set; }

		[ProtoMember(3)]
		public int hair{ get; set; }


		internal ChangeGenderReq()
		{
			this.gender = 0;
			this.face = 0;
			this.hair = 0;
		}

	}

}
