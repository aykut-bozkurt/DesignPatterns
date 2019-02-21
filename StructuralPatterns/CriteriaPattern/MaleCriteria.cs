using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.CriteriaPattern
{
	public class MaleCriteria : ICriteria<Person>
	{
		public List<Person> Filter(List<Person> persons)
		{
			List<Person> males = persons.Where(person => person.Gender == Gender.MALE).ToList();
			return males;
		}
	}
}
