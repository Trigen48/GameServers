using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class AddFriendAck
	{

		[ProtoMember(1)]
		public string charname{ get; set; }

		[ProtoMember(2)]
		public int result{ get; set; }

		[ProtoMember(3)]
		public int needprompt{ get; set; }


		internal AddFriendAck()
		{
			this.charname ="";
			this.result = 0;
			this.needprompt = 0;
		}

	}

}
