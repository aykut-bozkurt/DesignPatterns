using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.BehavioralPatterns.ObserverDispatcherPattern
{
	class SumDispatcher : AbstractDispatcher
	{
		public SumEvent SumEvent { get; set; }

		public override void Dispatch(IEvent sumEvent)
		{
			this.observers.ForEach(observer => observer.Handler(sumEvent) );
		}
	}
}
