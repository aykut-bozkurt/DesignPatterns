using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StructuralPatterns.DecoratorPattern
{
	abstract class ShapeDecorator
	{
		protected Shape shape;

		public ShapeDecorator(Shape shape) {
			this.shape = shape;
		}

		public abstract void Draw();
	}
}
