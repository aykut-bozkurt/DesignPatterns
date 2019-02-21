using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.CriteriaPattern
{
	public class TeenCriteria : ICriteria<Person>
	{
		public List<Person> Filter(List<Person> persons)
		{
			List<Person> teens = persons.Where(person => person.Age <= 16).ToList();
			return teens;
		}
	}
}
