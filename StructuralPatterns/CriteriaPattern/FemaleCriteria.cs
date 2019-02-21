using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.CriteriaPattern
{
	public class FemaleCriteria : ICriteria<Person>
	{
		public List<Person> Filter(List<Person> persons)
		{
			List<Person> females = persons.Where(person => person.Gender == Gender.FEMALE).ToList();
			return females;
		}
	}

}
