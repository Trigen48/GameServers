using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OffLine1V1TimeStamps
	{

		[ProtoMember(1)]
		public int getInfoTime{ get; set; }

		[ProtoMember(2)]
		public int getGiftedTime{ get; set; }

		[ProtoMember(3)]
		public int refreshTime{ get; set; }

		[ProtoMember(4)]
		public int cdCheckTime{ get; set; }

		[ProtoMember(5)]
		public int refreshLeftTime{ get; set; }


		internal OffLine1V1TimeStamps()
		{
			this.getInfoTime = 0;
			this.getGiftedTime = 0;
			this.refreshTime = 0;
			this.cdCheckTime = 0;
			this.refreshLeftTime = 0;
		}

	}

}
