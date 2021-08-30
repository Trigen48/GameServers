using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class LoginPhase
	{

		[ProtoMember(1)]
		public string username{ get; set; }

		[ProtoMember(2)]
		public int phaseid{ get; set; }


		internal LoginPhase()
		{
			this.username ="";
			this.phaseid = 0;
		}

	}

}
