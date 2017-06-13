using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentOperands.Core
{
	public static class Operands
	{
		public static bool Or(this bool resultant, object rhs)
		{
			return InvokePreviousOperation(rhs);
		}

		public static bool And(this bool resultant, object rhs)
		{
			return resultant && InvokePreviousOperation(rhs);
		}
	}
}
