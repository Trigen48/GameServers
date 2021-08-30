using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OffLineRecords
	{

		[ProtoMember(1)]
		public List<OffLine1V1Record> records{ get; set; }


		internal OffLineRecords()
		{
			this.records = new List<OffLine1V1Record>();
		}

	}

}
