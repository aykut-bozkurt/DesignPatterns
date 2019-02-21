using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.BehavioralPatterns.StatePattern
{
	class StartState : State
	{
		public void DoAction(Context context)
		{
			Console.WriteLine("Player in the start state.");
			Console.WriteLine("Do generic operations for start state.");

			context.State = this;
		}
	}
}
