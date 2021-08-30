using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ShowGrpDungeonsChannel
	{

		[ProtoMember(1)]
		public int zoneid{ get; set; }


		internal ShowGrpDungeonsChannel()
		{
			this.zoneid = 0;
		}

	}

}
