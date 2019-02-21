using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryPattern
{
	class CarFactory
	{
		public Car GetCar(string name, Color color)
		{
			if (color == Color.GREEN)
			{
				return new GreenCar(name);
			}
			else if (color == Color.PINK)
			{
				return new PinkCar(name);
			}
			else if (color == Color.RED)
			{
				return new RedCar(name);
			}

			return null;
		}
	}
}
