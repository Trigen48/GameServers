using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OffLine1V1Record
	{

		[ProtoMember(1)]
		public uint pvptime{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }

		[ProtoMember(3)]
		public string opponent{ get; set; }

		[ProtoMember(4)]
		public int result{ get; set; }

		[ProtoMember(5)]
		public int prerank{ get; set; }

		[ProtoMember(6)]
		public int nowrank{ get; set; }

		[ProtoMember(7)]
		public int gender{ get; set; }


		internal OffLine1V1Record()
		{
			this.pvptime = 0;
			this.type = 0;
			this.opponent ="";
			this.result = 0;
			this.prerank = 0;
			this.nowrank = 0;
			this.gender = 0;
		}

	}

}
