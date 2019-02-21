using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StructuralPatterns.DecoratorPattern
{
	class Circle : Shape
	{
		public void draw()
		{
			Console.WriteLine("drawing circle...");
		}
	}
}
