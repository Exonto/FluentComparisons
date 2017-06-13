using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentOperands.Core
{
	internal abstract class OperandContext
	{
		public Delegate PreviousOperation { get; private set; }
		public object Caller { get; private set; }

		private void EnsureCaller(object caller)
		{
			Caller = Caller ?? caller;
		}

		protected bool InvokePreviousOperation(object rhs)
		{
			return (bool)PreviousOperation.DynamicInvoke(Caller, rhs);
		}
	}
}
