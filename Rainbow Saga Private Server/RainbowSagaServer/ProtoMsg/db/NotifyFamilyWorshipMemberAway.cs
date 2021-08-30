using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class NotifyFamilyWorshipMemberAway
	{

		[ProtoMember(1)]
		public int charid{ get; set; }

		[ProtoMember(2)]
		public int away{ get; set; }


		internal NotifyFamilyWorshipMemberAway()
		{
			this.charid = 0;
			this.away = 0;
		}

	}

}
