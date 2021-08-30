using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class BuffInfos
	{

		[ProtoMember(1)]
		public List<BuffUpdate> buffUpdates{ get; set; }

		[ProtoMember(2)]
		public int unitType{ get; set; }

		[ProtoMember(3)]
		public int unitId{ get; set; }

		[ProtoMember(5)]
		public int unused{ get; set; }


		internal BuffInfos()
		{
			this.buffUpdates = new List<BuffUpdate>();
			this.unitType = 0;
			this.unitId = 0;
			this.unused = 0;
		}

	}

}
