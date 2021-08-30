using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DisableCharRequest
	{

		[ProtoMember(1, IsRequired=true)]
		public string charname{ get; set; }

		[ProtoMember(2)]
		public int charid{ get; set; }

		[ProtoMember(3)]
		public string username{ get; set; }

		[ProtoMember(4)]
		public int jobid{ get; set; }

		[ProtoMember(5)]
		public int level{ get; set; }

		[ProtoMember(6)]
		public int gender{ get; set; }


		internal DisableCharRequest()
		{
			this.charname ="";
			this.charid = 0;
			this.username ="";
			this.jobid = 0;
			this.level = 0;
			this.gender = 0;
		}

	}

}
