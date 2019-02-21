using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.CriteriaPattern
{
	public class AndCriteria : ICriteria<Person>
	{
		ICriteria<Person> criteria1;
		ICriteria<Person> criteria2;

		public AndCriteria(ICriteria<Person> criteria1, ICriteria<Person> criteria2)
		{
			this.criteria1 = criteria1;
			this.criteria2 = criteria2;
		}

		public List<Person> Filter(List<Person> persons)
		{
			return criteria1.Filter(persons).Intersect(criteria2.Filter(persons)).ToList();
		}
	}

}
