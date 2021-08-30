using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class UpdateExpiredEquip
	{

		[ProtoMember(1)]
		public uint itemids{ get; set; }

		[ProtoMember(5)]
		public int unused{ get; set; }


		internal UpdateExpiredEquip()
		{
			this.itemids = 0;
			this.unused = 0;
		}

	}

}
