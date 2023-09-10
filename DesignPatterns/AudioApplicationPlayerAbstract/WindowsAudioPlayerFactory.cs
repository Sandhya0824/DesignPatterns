using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioApplicationPlayerAbstract
{
    public class WindowsAudioPlayerFactory : IAudioPlayerFactory
    {
        public IAudioPlayer CreateAudioPlayer()
        {
            IAudioPlayer audioPlayer = new AudioPlayer(CreatePlayButton(), CreateStopButton(), CreateDisplay(), CreateNotification());
            return audioPlayer;
        }
        public IDisplay CreateDisplay()
        {
            return new WindowsDisplayPanel();
        }

        public INotification CreateNotification()
        {
            return new WindowsNotificationPanel();
        }

        public IPlayButton CreatePlayButton()
        {
            return new WindowsPlayButton();
        }

        public IStopButton CreateStopButton()
        {
            return new WindowsStopButton();
        }

    }
}
