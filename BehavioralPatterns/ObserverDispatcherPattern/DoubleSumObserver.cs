using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.BehavioralPatterns.ObserverDispatcherPattern
{
	class DoubleSumObserver : IObserver
	{
		public void Handler(IEvent sumEvent)
		{
			Console.WriteLine((sumEvent as SumEvent).Number1 + (sumEvent as SumEvent).Number2);
		}
	}
}
