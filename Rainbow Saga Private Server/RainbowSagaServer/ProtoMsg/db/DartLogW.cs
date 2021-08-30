using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class DartLogW
	{

		[ProtoMember(1)]
		public string charname{ get; set; }

		[ProtoMember(2)]
		public DartItem item{ get; set; }


		internal DartLogW()
		{
			this.charname ="";
			this.item = new DartItem();
		}

	}

}
