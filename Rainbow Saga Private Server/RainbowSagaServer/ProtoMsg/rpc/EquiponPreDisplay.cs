using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class EquiponPreDisplay
	{

		[ProtoMember(1)]
		public int fashionEquiponPreDisplay{ get; set; }


		internal EquiponPreDisplay()
		{
			this.fashionEquiponPreDisplay = 0;
		}

	}

}
