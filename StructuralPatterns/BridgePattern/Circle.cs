using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StructuralPatterns.BridgePattern
{
	class Circle : Shape
	{
		public Circle(DrawAPI drawAPI) : base(drawAPI)
		{
		}

		public override void drawCircle()
		{
			this.drawAPI.drawCircle("RED");
		}

		public override void drawRectangle()
		{
			throw new NotImplementedException();
		}
	}
}
