using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class VariableList
	{

		[ProtoMember(1)]
		public List<Variable> vars{ get; set; }


		internal VariableList()
		{
			this.vars = new List<Variable>();
		}

	}

}
