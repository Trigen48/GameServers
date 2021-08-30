using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FunctionSwitchInfo
	{

		[ProtoMember(1)]
		public int funcId{ get; set; }

		[ProtoMember(6)]
		public int onOff{ get; set; }


		internal FunctionSwitchInfo()
		{
			this.funcId = 0;
			this.onOff = 0;
		}

	}

}
