using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class Refine
	{

		[ProtoMember(1)]
		public string slotId{ get; set; }

		[ProtoMember(4)]
		public int conItemId{ get; set; }

		[ProtoMember(5)]
		public int conItemNum{ get; set; }

		[ProtoMember(3)]
		public int refineLv{ get; set; }

		[ProtoMember(6)]
		public int refineExp{ get; set; }

		[ProtoMember(7)]
		public int isCrital{ get; set; }

		[ProtoMember(8)]
		public int addExp{ get; set; }


		internal Refine()
		{
			this.slotId ="";
			this.conItemId = 0;
			this.conItemNum = 0;
			this.refineLv = 0;
			this.refineExp = 0;
			this.isCrital = 0;
			this.addExp = 0;
		}

	}

}
