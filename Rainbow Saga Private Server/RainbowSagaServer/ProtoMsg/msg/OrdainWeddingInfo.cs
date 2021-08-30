using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OrdainWeddingInfo
	{

		[ProtoMember(1)]
		public string charName{ get; set; }

		[ProtoMember(2)]
		public int time{ get; set; }

		[ProtoMember(3)]
		public int index{ get; set; }


		internal OrdainWeddingInfo()
		{
			this.charName ="";
			this.time = 0;
			this.index = 0;
		}

	}

}
