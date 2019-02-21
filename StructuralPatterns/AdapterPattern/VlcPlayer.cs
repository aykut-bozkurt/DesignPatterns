using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StructuralPatterns.AdapterPattern
{
	class VlcPlayer : IAdvancedMediaPlayer
	{
		public void playMP4(string fileName)
		{
			throw new NotImplementedException();
		}

		public void playVLC(string fileName)
		{
			Console.WriteLine("Playing VLC audio.");
		}
	}
}
