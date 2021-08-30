using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class LoadingResStatistics
	{

		[ProtoMember(1)]
		public string uin{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }

		[ProtoMember(3)]
		public string path{ get; set; }

		[ProtoMember(5)]
		public int result{ get; set; }


		internal LoadingResStatistics()
		{
			this.uin ="";
			this.type = 0;
			this.path ="";
			this.result = 0;
		}

	}

}
