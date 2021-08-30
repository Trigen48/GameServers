using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class EnterZoneResponse
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public uint scene{ get; set; }

		[ProtoMember(3)]
		public uint xpos{ get; set; }

		[ProtoMember(4)]
		public uint ypos{ get; set; }

		[ProtoMember(8)]
		public uint dgnresid{ get; set; }

		[ProtoMember(7)]
		public int sessionId{ get; set; }

		[ProtoMember(10)]
		public CharInfo info{ get; set; }

		[ProtoMember(15)]
		public List<CharEquipInfo> equipInfos{ get; set; }

		[ProtoMember(16)]
		public int afkOffLineExp{ get; set; }

		[ProtoMember(17)]
		public int afkOffLineLeftSeconds{ get; set; }


		internal EnterZoneResponse()
		{
			this.result = 0;
			this.scene = 0;
			this.xpos = 0;
			this.ypos = 0;
			this.dgnresid = 0;
			this.sessionId = 0;
			this.info = new CharInfo();
			this.equipInfos = new List<CharEquipInfo>();
			this.afkOffLineExp = 0;
			this.afkOffLineLeftSeconds = 0;
		}

	}

}
