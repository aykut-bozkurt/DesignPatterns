using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.BehavioralPatterns.ObserverDispatcherPattern
{
	abstract class AbstractDispatcher
	{
		public List<IObserver> observers;

		public AbstractDispatcher()
		{
			observers = new List<IObserver>();
		}

		public virtual void Dispatch(IEvent e)
		{
			this.observers.ForEach(observer => observer.Handler(e));
		}

		public void Attach(IObserver observer)
		{
			this.observers.Add(observer);
		}
	}
}
