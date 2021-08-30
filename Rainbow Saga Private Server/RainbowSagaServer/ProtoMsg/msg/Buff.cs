using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Buff
	{

		[ProtoMember(1)]
		public List<BufferInfo> buffs{ get; set; }


		internal Buff()
		{
			this.buffs = new List<BufferInfo>();
		}

	}

}
