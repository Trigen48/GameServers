using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GroupMember
	{

		[ProtoMember(1, IsRequired=true)]
		public string rolename{ get; set; }

		[ProtoMember(2, IsRequired=true)]
		public int level{ get; set; }

		[ProtoMember(3, IsRequired=true)]
		public int profession{ get; set; }

		[ProtoMember(4, IsRequired=true)]
		public int hp{ get; set; }

		[ProtoMember(5, IsRequired=true)]
		public int maxhp{ get; set; }

		[ProtoMember(6, IsRequired=true)]
		public int mp{ get; set; }

		[ProtoMember(7, IsRequired=true)]
		public int maxmp{ get; set; }

		[ProtoMember(8, IsRequired=true)]
		public int mapid{ get; set; }

		[ProtoMember(9, IsRequired=true)]
		public int zoneid{ get; set; }

		[ProtoMember(10, IsRequired=true)]
		public int leader{ get; set; }

		[ProtoMember(11, IsRequired=true)]
		public int online{ get; set; }

		[ProtoMember(12, IsRequired=true)]
		public int gender{ get; set; }

		[ProtoMember(13)]
		public int roleid{ get; set; }

		[ProtoMember(14)]
		public int hair{ get; set; }

		[ProtoMember(15)]
		public int face{ get; set; }

		[ProtoMember(16)]
		public int skintype{ get; set; }

		[ProtoMember(17)]
		public int realmapid{ get; set; }


		internal GroupMember()
		{
			this.rolename ="";
			this.level = 0;
			this.profession = 0;
			this.hp = 0;
			this.maxhp = 0;
			this.mp = 0;
			this.maxmp = 0;
			this.mapid = 0;
			this.zoneid = 0;
			this.leader = 0;
			this.online = 0;
			this.gender = 0;
			this.roleid = 0;
			this.hair = 0;
			this.face = 0;
			this.skintype = 0;
			this.realmapid = 0;
		}

	}

}
