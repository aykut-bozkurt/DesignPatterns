using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StructuralPatterns.DecoratorPattern
{
	class RedShapeDecorator : ShapeDecorator
	{
		public RedShapeDecorator(Shape shape) : base(shape)
		{
		}

		public override void Draw()
		{
			Console.WriteLine("Setting color to red...");
			this.shape.draw();
		}
	}
}
