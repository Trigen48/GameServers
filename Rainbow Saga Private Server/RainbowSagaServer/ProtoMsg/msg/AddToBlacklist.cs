using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class AddToBlacklist
	{

		[ProtoMember(1)]
		public string charname{ get; set; }


		internal AddToBlacklist()
		{
			this.charname ="";
		}

	}

}
