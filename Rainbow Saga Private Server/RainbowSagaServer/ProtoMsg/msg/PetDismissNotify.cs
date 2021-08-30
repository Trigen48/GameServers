using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PetDismissNotify
	{

		[ProtoMember(1)]
		public ulong uuid{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }


		internal PetDismissNotify()
		{
			this.uuid = 0;
			this.type = 0;
		}

	}

}
