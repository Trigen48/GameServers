using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MagicDartsData
	{

		[ProtoMember(1)]
		public int ver{ get; set; }

		[ProtoMember(2)]
		public int count{ get; set; }

		[ProtoMember(3)]
		public List<DartLog> history{ get; set; }

		[ProtoMember(4)]
		public int index{ get; set; }


		internal MagicDartsData()
		{
			this.ver = 0;
			this.count = 0;
			this.history = new List<DartLog>();
			this.index = 0;
		}

	}

}
