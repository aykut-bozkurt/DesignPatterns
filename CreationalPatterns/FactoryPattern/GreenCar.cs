using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryPattern
{
	class GreenCar : Car
	{
		public GreenCar(string name) : base(name)
		{
			this.Color = Color.GREEN;
		}
	}
}
