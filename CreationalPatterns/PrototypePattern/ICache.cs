using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.CreationalPatterns.PrototypePattern
{
	interface ICache<T>
	{
		T GetFromCache(long id);
		void LoadToCache(long id, T source);
	}
}
