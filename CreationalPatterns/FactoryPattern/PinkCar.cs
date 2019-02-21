using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryPattern
{
	class PinkCar : Car
	{
		public PinkCar(string name) : base(name)
		{
			this.Color = Color.PINK;
		}
	}
}
