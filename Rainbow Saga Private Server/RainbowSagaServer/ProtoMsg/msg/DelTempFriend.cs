using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DelTempFriend
	{

		[ProtoMember(1)]
		public string charname{ get; set; }


		internal DelTempFriend()
		{
			this.charname ="";
		}

	}

}
