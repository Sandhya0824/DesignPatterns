using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioApplicationPlayerAbstract
{
    public class AudioPlayerFactory
    {

        public static IAudioPlayerFactory CreateAudioPlayerFactoryFromSelection(int choice)
        {
            IAudioPlayerFactory audioPlayerFactory = choice switch
            {
                1 => new WindowsAudioPlayerFactory(),
                2 => new LinuxAudioPlayerFactory(),
                _ => default,
            };

            return audioPlayerFactory;
        }

    }
}