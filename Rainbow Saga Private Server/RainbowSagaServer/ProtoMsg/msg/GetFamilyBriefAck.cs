using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.db;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetFamilyBriefAck
	{

		[ProtoMember(1, IsRequired=true)]
		public FmlyBrief familyinfo{ get; set; }


		internal GetFamilyBriefAck()
		{
			this.familyinfo = new FmlyBrief();
		}

	}

}
