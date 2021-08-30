using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class RegainNum
	{

		[ProtoMember(1)]
		public int lastLevel{ get; set; }

		[ProtoMember(2)]
		public List<RegainInfo> regainNums{ get; set; }

		[ProtoMember(3)]
		public int lastTime{ get; set; }


		internal RegainNum()
		{
			this.lastLevel = 0;
			this.regainNums = new List<RegainInfo>();
			this.lastTime = 0;
		}

	}

}
