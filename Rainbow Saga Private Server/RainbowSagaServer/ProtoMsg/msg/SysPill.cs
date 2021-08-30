using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SysPill
	{

		[ProtoMember(1)]
		public int sType{ get; set; }

		[ProtoMember(2)]
		public List<PropPill> pills{ get; set; }


		internal SysPill()
		{
			this.sType = 0;
			this.pills = new List<PropPill>();
		}

	}

}
