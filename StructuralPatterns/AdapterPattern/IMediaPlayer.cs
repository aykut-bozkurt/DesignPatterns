using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StructuralPatterns.AdapterPattern
{
	interface IMediaPlayer
	{
		void play(string audioType, string fileName);
	}
}
