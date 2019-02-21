using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.BehavioralPatterns.ObserverDispatcherPattern
{
	class SumEvent : IEvent
	{
		public Double Number1 { get; set; }
		public Double Number2 { get; set; }

		public SumEvent(Double number1, Double number2)
		{
			this.Number1 = number1;
			this.Number2 = number2;
		}
	}
}
