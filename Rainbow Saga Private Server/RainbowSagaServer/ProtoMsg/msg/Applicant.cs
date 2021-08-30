using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Applicant
	{

		[ProtoMember(1, IsRequired=true)]
		public string rolename{ get; set; }

		[ProtoMember(2, IsRequired=true)]
		public int level{ get; set; }

		[ProtoMember(3, IsRequired=true)]
		public int profession{ get; set; }

		[ProtoMember(4, IsRequired=true)]
		public int mapid{ get; set; }

		[ProtoMember(5)]
		public int apptime{ get; set; }


		internal Applicant()
		{
			this.rolename ="";
			this.level = 0;
			this.profession = 0;
			this.mapid = 0;
			this.apptime = 0;
		}

	}

}
