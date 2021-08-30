using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MultiDgnTimes
	{

		[ProtoMember(1)]
		public int times{ get; set; }

		[ProtoMember(2)]
		public int updatetime{ get; set; }

		[ProtoMember(3)]
		public int addtimes{ get; set; }


		internal MultiDgnTimes()
		{
			this.times = 0;
			this.updatetime = 0;
			this.addtimes = 0;
		}

	}

}
