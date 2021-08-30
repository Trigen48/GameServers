using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class DeleteMail
	{

		[ProtoMember(1)]
		public int unused{ get; set; }

		[ProtoMember(2)]
		public long mailids{ get; set; }


		internal DeleteMail()
		{
			this.unused = 0;
			this.mailids = 0;
		}

	}

}
