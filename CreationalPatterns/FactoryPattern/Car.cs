using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryPattern
{
	public enum Color {
		RED,
		GREEN,
		PINK
	}

	abstract class Car
	{
		private string name;
		private Color color;

		public Car(string name)
		{
			this.name = name;
		}

		public string Name { get { return name; } set { name = value; } }
		public Color Color { get { return color; } set { color = value; } }
	}
}
