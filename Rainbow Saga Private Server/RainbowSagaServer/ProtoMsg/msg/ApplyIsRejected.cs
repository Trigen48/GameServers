using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ApplyIsRejected
	{

		[ProtoMember(1, IsRequired=true)]
		public string leader{ get; set; }


		internal ApplyIsRejected()
		{
			this.leader ="";
		}

	}

}
