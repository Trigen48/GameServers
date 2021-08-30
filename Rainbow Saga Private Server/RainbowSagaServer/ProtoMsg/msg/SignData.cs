using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SignData
	{

		[ProtoMember(1)]
		public uint totalsigndays{ get; set; }

		[ProtoMember(2)]
		public uint continuesigndays{ get; set; }

		[ProtoMember(3)]
		public uint maxcontinuesigndays{ get; set; }

		[ProtoMember(4)]
		public uint signtime{ get; set; }

		[ProtoMember(5)]
		public uint mothmark{ get; set; }

		[ProtoMember(6)]
		public uint getedtotaldays{ get; set; }

		[ProtoMember(7)]
		public uint getedmaxcondays{ get; set; }

		[ProtoMember(8)]
		public uint lastSignTime{ get; set; }

		[ProtoMember(9)]
		public uint fillupmark{ get; set; }


		internal SignData()
		{
			this.totalsigndays = 0;
			this.continuesigndays = 0;
			this.maxcontinuesigndays = 0;
			this.signtime = 0;
			this.mothmark = 0;
			this.getedtotaldays = 0;
			this.getedmaxcondays = 0;
			this.lastSignTime = 0;
			this.fillupmark = 0;
		}

	}

}
