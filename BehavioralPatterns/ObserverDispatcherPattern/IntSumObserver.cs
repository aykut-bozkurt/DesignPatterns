using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.BehavioralPatterns.ObserverDispatcherPattern
{
	class IntSumObserver : IObserver
	{
		public void Handler(IEvent sumEvent)
		{
			Console.WriteLine((Int32)(sumEvent as SumEvent).Number1 + (Int32)(sumEvent as SumEvent).Number2);
		}
	}
}
