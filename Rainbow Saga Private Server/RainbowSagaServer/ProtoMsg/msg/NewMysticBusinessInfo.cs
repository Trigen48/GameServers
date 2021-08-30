using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class NewMysticBusinessInfo
	{

		[ProtoMember(1)]
		public int tiggertimes{ get; set; }

		[ProtoMember(2)]
		public int canmaxfinishedtimes{ get; set; }

		[ProtoMember(3)]
		public int finishedtimes{ get; set; }

		[ProtoMember(4)]
		public int purlefttimes{ get; set; }

		[ProtoMember(5)]
		public int isinvalid{ get; set; }

		[ProtoMember(6)]
		public int tiggertime{ get; set; }

		[ProtoMember(7)]
		public int type{ get; set; }

		[ProtoMember(8)]
		public List<NewMysticBusinessItem> items{ get; set; }

		[ProtoMember(9)]
		public int lasttime{ get; set; }

		[ProtoMember(10)]
		public int refreshtimes{ get; set; }


		internal NewMysticBusinessInfo()
		{
			this.tiggertimes = 0;
			this.canmaxfinishedtimes = 0;
			this.finishedtimes = 0;
			this.purlefttimes = 0;
			this.isinvalid = 0;
			this.tiggertime = 0;
			this.type = 0;
			this.items = new List<NewMysticBusinessItem>();
			this.lasttime = 0;
			this.refreshtimes = 0;
		}

	}

}
