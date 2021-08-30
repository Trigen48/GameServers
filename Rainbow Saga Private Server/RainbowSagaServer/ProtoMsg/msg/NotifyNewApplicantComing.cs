using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class NotifyNewApplicantComing
	{

		[ProtoMember(1, IsRequired=true)]
		public int type{ get; set; }


		internal NotifyNewApplicantComing()
		{
			this.type = 0;
		}

	}

}
