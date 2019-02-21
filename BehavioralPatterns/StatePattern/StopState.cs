using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.BehavioralPatterns.StatePattern
{
	class StopState : State
	{
		public void DoAction(Context context)
		{
			Console.WriteLine("Player in the stop state.");
			Console.WriteLine("Do generic operations for stop state.");

			context.State = this;
		}
	}
}
