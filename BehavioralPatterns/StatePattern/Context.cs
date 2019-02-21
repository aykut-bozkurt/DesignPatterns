using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.BehavioralPatterns.StatePattern
{
	class Context
	{
		private State state;
		public State State { get { return state; } set { state = value; } }

		public Context()
		{
			this.state = null;
		}
	}
}
