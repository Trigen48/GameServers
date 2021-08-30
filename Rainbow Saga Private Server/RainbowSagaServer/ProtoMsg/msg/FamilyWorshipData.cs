using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class FamilyWorshipData
	{

		[ProtoMember(1)]
		public int remaintimes{ get; set; }


		internal FamilyWorshipData()
		{
			this.remaintimes = 0;
		}

	}

}
