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
	internal class CanShowMysticBusiness
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public int starttime{ get; set; }

		[ProtoMember(3)]
		public int lefttime{ get; set; }

		[ProtoMember(4)]
		public List<NewMysticBusinessItem> items{ get; set; }


		internal CanShowMysticBusiness()
		{
			this.type = 0;
			this.starttime = 0;
			this.lefttime = 0;
			this.items = new List<NewMysticBusinessItem>();
		}

	}

}
