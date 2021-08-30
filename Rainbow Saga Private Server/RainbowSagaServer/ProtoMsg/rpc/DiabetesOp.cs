using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class DiabetesOp
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int index1{ get; set; }

		[ProtoMember(3)]
		public int index2{ get; set; }


		internal DiabetesOp()
		{
			this.op = 0;
			this.index1 = 0;
			this.index2 = 0;
		}

	}

}
