using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ShowDungeonWindow
	{

		[ProtoMember(1)]
		public int dgngroupid{ get; set; }

		[ProtoMember(2)]
		public List<DgnDisplayInfo> infos{ get; set; }


		internal ShowDungeonWindow()
		{
			this.dgngroupid = 0;
			this.infos = new List<DgnDisplayInfo>();
		}

	}

}
