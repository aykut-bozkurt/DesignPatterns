using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.CriteriaPattern
{
	public interface ICriteria<T>
	{
		List<T> Filter(List<T> source);
	}
}
