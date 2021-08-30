using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ZoneInfo
	{

		[ProtoMember(1, IsRequired=true)]
		public uint id{ get; set; }

		[ProtoMember(2, IsRequired=true)]
		public string name{ get; set; }

		[ProtoMember(3, IsRequired=true)]
		public uint curNum{ get; set; }

		[ProtoMember(4, IsRequired=true)]
		public uint maxNum{ get; set; }

		[ProtoMember(5)]
		public int busyStatus{ get; set; }


		internal ZoneInfo()
		{
			this.id = 0;
			this.name ="";
			this.curNum = 0;
			this.maxNum = 0;
			this.busyStatus = 0;
		}

	}

}
