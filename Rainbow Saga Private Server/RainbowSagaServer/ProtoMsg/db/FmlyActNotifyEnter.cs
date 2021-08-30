using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FmlyActNotifyEnter
	{

		[ProtoMember(1)]
		public int op{ get; set; }


		internal FmlyActNotifyEnter()
		{
			this.op = 0;
		}

	}

}
