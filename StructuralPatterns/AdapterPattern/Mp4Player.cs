using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StructuralPatterns.AdapterPattern
{
	class Mp4Player : IAdvancedMediaPlayer
	{
		public void playMP4(string fileName)
		{
			Console.WriteLine("Playing MP4 audio.");
		}

		public void playVLC(string fileName)
		{
			throw new NotImplementedException();
		}
	}
}
