using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.msg;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class DiabetesMoveBox
	{

		[ProtoMember(1)]
		public ThreeDiabetesInfo gameinfo{ get; set; }

		[ProtoMember(2)]
		public ThreeDiabetesMove moveinfo{ get; set; }


		internal DiabetesMoveBox()
		{
			this.gameinfo = new ThreeDiabetesInfo();
			this.moveinfo = new ThreeDiabetesMove();
		}

	}

}
