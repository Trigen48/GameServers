using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class AssignLeaderReq
	{

		[ProtoMember(1, IsRequired=true)]
		public string rolename{ get; set; }


		internal AssignLeaderReq()
		{
			this.rolename ="";
		}

	}

}
