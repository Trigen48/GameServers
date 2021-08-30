using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ClearFamilyUpgradeCDAck
	{

		[ProtoMember(1)]
		public int ret{ get; set; }


		internal ClearFamilyUpgradeCDAck()
		{
			this.ret = 0;
		}

	}

}
