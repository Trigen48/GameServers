using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class WBSBuffInfo
	{

		[ProtoMember(1)]
		public int wbsBuffLv{ get; set; }

		[ProtoMember(2)]
		public int expired{ get; set; }


		internal WBSBuffInfo()
		{
			this.wbsBuffLv = 0;
			this.expired = 0;
		}

	}

}
