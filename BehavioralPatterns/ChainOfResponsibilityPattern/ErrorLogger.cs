using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.BehavioralPatterns
{
	class ErrorLogger : AbstractLogger
	{
		public ErrorLogger(int level) : base(level)
		{
		}

		protected override void Write(string message)
		{
			Console.WriteLine("ERROR: " + message);
		}
	}
}
