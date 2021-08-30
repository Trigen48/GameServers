using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class AutoPlayDisplayInfo
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public int param{ get; set; }

		[ProtoMember(3)]
		public int status{ get; set; }

		[ProtoMember(4)]
		public int crystal{ get; set; }

		[ProtoMember(5)]
		public int selected{ get; set; }


		internal AutoPlayDisplayInfo()
		{
			this.type = 0;
			this.param = 0;
			this.status = 0;
			this.crystal = 0;
			this.selected = 0;
		}

	}

}
