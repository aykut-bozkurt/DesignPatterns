using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.BehavioralPatterns.ObserverDispatcherPattern
{
	interface IObserver
	{
		void Handler(IEvent e);
	}
}
