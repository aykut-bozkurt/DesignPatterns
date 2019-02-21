using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StructuralPatterns.AdapterPattern
{
	class MediaAdapter : IMediaPlayer
	{
		// I implemented advanced media player interface
		IAdvancedMediaPlayer advancedMediaPlayer;
		// My colleague implemented media player interface
		IMediaPlayer mediaPlayer;

		// to merge functionality of those 2 interfaces of similar responsibility, we implemented media adapter
		public void play(string audioType, string fileName)
		{
			if (audioType == "MP3") {
				mediaPlayer = new AudioPlayer();
				mediaPlayer.play(audioType,fileName);
			}
			else if(audioType == "VLC")
			{
				advancedMediaPlayer = new VlcPlayer();
				advancedMediaPlayer.playVLC(fileName);
			}
			else if (audioType == "MP4")
			{
				advancedMediaPlayer = new Mp4Player();
				advancedMediaPlayer.playMP4(fileName);
			}
		}
	}
}
