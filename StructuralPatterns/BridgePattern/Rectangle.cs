using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StructuralPatterns.BridgePattern
{
	class Rectangle : Shape
	{
		public Rectangle(DrawAPI drawAPI) : base(drawAPI)
		{
		}

		public override void drawCircle()
		{
			throw new NotImplementedException();
		}

		public override void drawRectangle()
		{
			this.drawAPI.drawRectangle("RED");
		}
	}
}
