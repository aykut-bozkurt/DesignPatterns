using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StructuralPatterns.BridgePattern
{
	class DrawAPI
	{
		public void drawCircle(string color) {
			Console.WriteLine("drawing colored circle...");
		}

		public void drawRectangle(string color)
		{
			Console.WriteLine("drawing colored rectangle...");
		}
	}
}
