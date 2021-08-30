using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class RobCarResult
	{

		[ProtoMember(1)]
		public CarReward rewards{ get; set; }

		[ProtoMember(2)]
		public string robbedname{ get; set; }

		[ProtoMember(3)]
		public int ret{ get; set; }


		internal RobCarResult()
		{
			this.rewards = new CarReward();
			this.robbedname ="";
			this.ret = 0;
		}

	}

}
