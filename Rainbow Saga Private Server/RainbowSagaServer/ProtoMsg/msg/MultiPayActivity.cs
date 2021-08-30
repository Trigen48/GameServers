using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MultiPayActivity
	{

		[ProtoMember(1)]
		public uint amount{ get; set; }

		[ProtoMember(2)]
		public uint startdate{ get; set; }

		[ProtoMember(3)]
		public uint enddate{ get; set; }

		[ProtoMember(4)]
		public List<MultiPayActData> datas{ get; set; }


		internal MultiPayActivity()
		{
			this.amount = 0;
			this.startdate = 0;
			this.enddate = 0;
			this.datas = new List<MultiPayActData>();
		}

	}

}
