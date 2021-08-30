using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class IsNewMysticStoreFreeRefreshAck
	{

		[ProtoMember(1)]
		public int tabnumber{ get; set; }

		[ProtoMember(2)]
		public int isfree{ get; set; }


		internal IsNewMysticStoreFreeRefreshAck()
		{
			this.tabnumber = 0;
			this.isfree = 0;
		}

	}

}
