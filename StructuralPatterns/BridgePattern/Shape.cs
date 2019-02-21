using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StructuralPatterns.BridgePattern
{
	abstract class Shape
	{
		protected DrawAPI drawAPI;

		public Shape(DrawAPI drawAPI)
		{
			this.drawAPI = drawAPI;
		}

		public abstract void drawCircle();
		public abstract void drawRectangle();
	}
}
