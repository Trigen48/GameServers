using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.db;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class DoMagicDarts
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public DartLog log{ get; set; }


		internal DoMagicDarts()
		{
			this.type = 0;
			this.log = new DartLog();
		}

	}

}
