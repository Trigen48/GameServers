using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class TransferProfession
	{

		[ProtoMember(1)]
		public int recommendProfId{ get; set; }

		[ProtoMember(3)]
		public int chooseProfId{ get; set; }


		internal TransferProfession()
		{
			this.recommendProfId = 0;
			this.chooseProfId = 0;
		}

	}

}
