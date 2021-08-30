using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class SignUserData
	{

		[ProtoMember(1)]
		public uint totaldays{ get; set; }

		[ProtoMember(2)]
		public uint maxcondays{ get; set; }

		[ProtoMember(3)]
		public uint daysmark{ get; set; }

		[ProtoMember(4)]
		public uint getedMaxConDays{ get; set; }

		[ProtoMember(5)]
		public uint getedTotDays{ get; set; }

		[ProtoMember(6)]
		public uint curDay{ get; set; }

		[ProtoMember(7)]
		public uint fillupdaysmark{ get; set; }

		[ProtoMember(8)]
		public string osDate{ get; set; }

		[ProtoMember(9)]
		public uint createtime{ get; set; }


		internal SignUserData()
		{
			this.totaldays = 0;
			this.maxcondays = 0;
			this.daysmark = 0;
			this.getedMaxConDays = 0;
			this.getedTotDays = 0;
			this.curDay = 0;
			this.fillupdaysmark = 0;
			this.osDate ="";
			this.createtime = 0;
		}

	}

}
