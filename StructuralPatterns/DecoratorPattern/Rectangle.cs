using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StructuralPatterns.DecoratorPattern
{
	class Rectangle : Shape
	{
		public void draw()
		{
			Console.WriteLine("drawing rectangle...");
		}
	}
}
