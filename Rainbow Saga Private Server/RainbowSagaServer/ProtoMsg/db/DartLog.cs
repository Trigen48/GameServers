using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class DartLog
	{

		[ProtoMember(1)]
		public int time{ get; set; }

		[ProtoMember(2)]
		public int num{ get; set; }

		[ProtoMember(3)]
		public List<DartItem> itemList{ get; set; }


		internal DartLog()
		{
			this.time = 0;
			this.num = 0;
			this.itemList = new List<DartItem>();
		}

	}

}
