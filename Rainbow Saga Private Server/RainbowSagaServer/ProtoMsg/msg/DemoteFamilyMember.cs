using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DemoteFamilyMember
	{

		[ProtoMember(1)]
		public string targetname{ get; set; }

		[ProtoMember(2)]
		public int position{ get; set; }


		internal DemoteFamilyMember()
		{
			this.targetname ="";
			this.position = 0;
		}

	}

}
