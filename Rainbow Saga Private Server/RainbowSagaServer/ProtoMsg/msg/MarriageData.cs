using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MarriageData
	{

		[ProtoMember(1)]
		public long cpId{ get; set; }

		[ProtoMember(2)]
		public int marriageLevel{ get; set; }

		[ProtoMember(3)]
		public string cpName{ get; set; }

		[ProtoMember(4)]
		public int weddingCount{ get; set; }

		[ProtoMember(5)]
		public int ringLevel{ get; set; }


		internal MarriageData()
		{
			this.cpId = 0;
			this.marriageLevel = 0;
			this.cpName ="";
			this.weddingCount = 0;
			this.ringLevel = 0;
		}

	}

}
