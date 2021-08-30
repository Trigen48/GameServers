using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GroupSetting
	{

		[ProtoMember(1, IsRequired=true)]
		public int flag{ get; set; }


		internal GroupSetting()
		{
			this.flag = 0;
		}

	}

}
