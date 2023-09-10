using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioApplicationPlayerAbstract
{
    public class LinuxAudioPlayerFactory : IAudioPlayerFactory
    {
        public IAudioPlayer CreateAudioPlayer()
        {
            IAudioPlayer audioPlayer = new AudioPlayer(CreatePlayButton(), CreateStopButton(), CreateDisplay(), CreateNotification());
            return audioPlayer;
        }

        public IDisplay CreateDisplay()
        {
            return new LinuxDisplayPanel();
        }

        public INotification CreateNotification()
        {
            return new LinuxNotificationPanel();
        }

        public IPlayButton CreatePlayButton()
        {
            return new LinuxPlayButton();
        }

        public IStopButton CreateStopButton()
        {
            return new LinuxStopButton();
        }
    }
}
