using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FmlyRecommend
	{

		[ProtoMember(1)]
		public string charname{ get; set; }

		[ProtoMember(2)]
		public int starttime{ get; set; }


		internal FmlyRecommend()
		{
			this.charname ="";
			this.starttime = 0;
		}

	}

}
