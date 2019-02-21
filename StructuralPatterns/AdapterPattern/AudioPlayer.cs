using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StructuralPatterns.AdapterPattern
{
	class AudioPlayer : IMediaPlayer
	{
		public void play(string audioType, string fileName)
		{
			if(audioType == "MP3")
			{
				Console.WriteLine("Playing MP3 audio.");
			}

		}
	}
}
