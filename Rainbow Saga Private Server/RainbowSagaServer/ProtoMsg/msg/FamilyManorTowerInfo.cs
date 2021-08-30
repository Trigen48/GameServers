using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class FamilyManorTowerInfo
	{

		[ProtoMember(1)]
		public uint id{ get; set; }

		[ProtoMember(2)]
		public uint state{ get; set; }


		internal FamilyManorTowerInfo()
		{
			this.id = 0;
			this.state = 0;
		}

	}

}
