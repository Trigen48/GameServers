using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class UpdatePetCaressInfo
	{

		[ProtoMember(1)]
		public int caressNum{ get; set; }

		[ProtoMember(2)]
		public int lastCaressTime{ get; set; }


		internal UpdatePetCaressInfo()
		{
			this.caressNum = 0;
			this.lastCaressTime = 0;
		}

	}

}
