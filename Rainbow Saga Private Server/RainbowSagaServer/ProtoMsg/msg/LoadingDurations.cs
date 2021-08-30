using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class LoadingDurations
	{

		[ProtoMember(1)]
		public string uin{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }

		[ProtoMember(3)]
		public uint durations{ get; set; }

		[ProtoMember(5)]
		public int sceneid{ get; set; }


		internal LoadingDurations()
		{
			this.uin ="";
			this.type = 0;
			this.durations = 0;
			this.sceneid = 0;
		}

	}

}
