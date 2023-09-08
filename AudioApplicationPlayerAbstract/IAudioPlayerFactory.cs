using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioApplicationPlayerAbstract
{
    public interface IAudioPlayerFactory
    {
        IAudioPlayer CreateAudioPlayer();

        /*   IPlayButton CreatePlayButton();
           IStopButton CreateStopButton();
           IDisplay CreateDisplay();
           INotification CreateNotification(); */
    }
}