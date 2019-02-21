using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Patterns.CreationalPatterns.PrototypePattern
{
	class CustomerCache : ICache<Customer>
	{
		Dictionary<long, Customer> cache = new Dictionary<long, Customer>();

		public Customer GetFromCache(long id)
		{
			Customer defaultCustomer = null;
			if (cache.TryGetValue(id, out defaultCustomer))
			{
				Console.WriteLine("Got from cache!");
				return defaultCustomer.Clone();
			}

			// no data in cache so we need to make the expensive operation, which is access to database in that context
			Thread.Sleep(1000);
			Customer fromDB = new Customer();
			fromDB.id = 1;

			LoadToCache(id, fromDB);

			Console.WriteLine("Got from database!");
			return fromDB.Clone();
		}

		public void LoadToCache(long id, Customer customer)
		{
			this.cache.Add(id, customer);
		}
	}
}
