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
	internal class GetMagicDartsData
	{

		[ProtoMember(1)]
		public MagicDartsCfg cfg{ get; set; }

		[ProtoMember(2)]
		public List<DartLog> logs{ get; set; }


		internal GetMagicDartsData()
		{
			this.cfg = new MagicDartsCfg();
			this.logs = new List<DartLog>();
		}

	}

}
