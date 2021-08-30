using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GroupInfo
	{

		[ProtoMember(1)]
		public List<GroupMember> members{ get; set; }


		internal GroupInfo()
		{
			this.members = new List<GroupMember>();
		}

	}

}
