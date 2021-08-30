using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ReactorEvent
	{

		[ProtoMember(1)]
		public int seqno{ get; set; }

		[ProtoMember(2)]
		public string name{ get; set; }

		[ProtoMember(3)]
		public int from{ get; set; }

		[ProtoMember(4)]
		public int to{ get; set; }

		[ProtoMember(5)]
		public int method{ get; set; }

		[ProtoMember(6)]
		public int bulletId{ get; set; }

		[ProtoMember(7)]
		public int bulletNum{ get; set; }


		internal ReactorEvent()
		{
			this.seqno = 0;
			this.name ="";
			this.from = 0;
			this.to = 0;
			this.method = 0;
			this.bulletId = 0;
			this.bulletNum = 0;
		}

	}

}
