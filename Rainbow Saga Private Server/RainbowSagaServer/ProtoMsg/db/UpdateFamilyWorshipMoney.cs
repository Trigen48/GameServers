using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class UpdateFamilyWorshipMoney
	{

		[ProtoMember(1)]
		public FamilyWorshipMoney money{ get; set; }

		[ProtoMember(2)]
		public string charname{ get; set; }

		[ProtoMember(3)]
		public int moneynum{ get; set; }


		internal UpdateFamilyWorshipMoney()
		{
			this.money = new FamilyWorshipMoney();
			this.charname ="";
			this.moneynum = 0;
		}

	}

}
