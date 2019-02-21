using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryPattern
{
	class RedCar : Car
	{
		public RedCar(string name) : base(name)
		{
			this.Color = Color.RED;
		}
	}
}
