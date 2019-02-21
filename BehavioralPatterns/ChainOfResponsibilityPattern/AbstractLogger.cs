using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.BehavioralPatterns
{
	abstract class AbstractLogger
	{
		public static int ERROR = 3;
		public static int DEBUG = 2;
		public static int INFO = 1;

		protected int level;
		public AbstractLogger NextLogger { get; set; }

		public AbstractLogger(int level)
		{
			this.level = level;
		}

		public void LogMessage(int level, string message) {
			if (this.level <= level)
			{
				this.Write(message);
			}
			if (this.NextLogger != null) {
				this.NextLogger.LogMessage(level, message);
			}
		}

		protected abstract void Write(string message);
	}
}
