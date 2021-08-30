using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SeabedOtherInfo
	{

		[ProtoMember(1)]
		public int firstBlood{ get; set; }

		[ProtoMember(2)]
		public int firstTrans{ get; set; }

		[ProtoMember(3)]
		public int leftSecond{ get; set; }

		[ProtoMember(4)]
		public int result{ get; set; }

		[ProtoMember(5)]
		public int state{ get; set; }


		internal SeabedOtherInfo()
		{
			this.firstBlood = 0;
			this.firstTrans = 0;
			this.leftSecond = 0;
			this.result = 0;
			this.state = 0;
		}

	}

}
