using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StructuralPatterns.AdapterPattern
{
	interface IAdvancedMediaPlayer
	{
		void playVLC(string fileName);
		void playMP4(string fileName);
	}
}
