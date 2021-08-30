using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DispatchBoxReq
	{

		[ProtoMember(1)]
		public int charId{ get; set; }

		[ProtoMember(2)]
		public string charName{ get; set; }

		[ProtoMember(3)]
		public int giveNum{ get; set; }


		internal DispatchBoxReq()
		{
			this.charId = 0;
			this.charName ="";
			this.giveNum = 0;
		}

	}

}
