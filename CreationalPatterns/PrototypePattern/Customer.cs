using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.CreationalPatterns.PrototypePattern
{
	class Customer
	{
		public long id;
		public string name;
		public int age;

		public Customer Clone()
		{
			Customer deepCopy = new Customer();
			deepCopy.id = this.id;
			deepCopy.age = this.age;
			deepCopy.name = this.name;

			return deepCopy;
		}
	}
}
