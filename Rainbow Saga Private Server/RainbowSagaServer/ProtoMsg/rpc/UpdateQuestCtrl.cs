using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpdateQuestCtrl
	{

		[ProtoMember(1)]
		public string k{ get; set; }

		[ProtoMember(2)]
		public int v{ get; set; }


		internal UpdateQuestCtrl()
		{
			this.k ="";
			this.v = 0;
		}

	}

}
