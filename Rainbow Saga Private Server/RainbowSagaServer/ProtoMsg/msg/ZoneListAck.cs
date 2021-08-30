using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ZoneListAck
	{

		[ProtoMember(1)]
		public List<ZoneInfo> zonelist{ get; set; }

		[ProtoMember(3)]
		public uint curWorldNum{ get; set; }

		[ProtoMember(4)]
		public uint totalWorldNum{ get; set; }

		[ProtoMember(2)]
		public int enterZoneType{ get; set; }

		[ProtoMember(5)]
		public uint areaid{ get; set; }


		internal ZoneListAck()
		{
			this.zonelist = new List<ZoneInfo>();
			this.curWorldNum = 0;
			this.totalWorldNum = 0;
			this.enterZoneType = 0;
			this.areaid = 0;
		}

	}

}
