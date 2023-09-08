using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioApplicationPlayerAbstract
{
    internal class AudioPlayer : IAudioPlayer
    {

        private readonly IPlayButton _playButton;
        private readonly IStopButton _stopButton;
        private readonly IDisplay _display;
        private readonly INotification _notification;

        public AudioPlayer(IPlayButton playButton, IStopButton stopButton, IDisplay display, INotification notification)
        {
            _playButton = playButton;
            _stopButton = stopButton;
            _display = display;
            _notification = notification;
        }

        public void Play()
        {
            _playButton.Play();
            _display.DisplayMessage("Audio is played!!!!");
        }

        public void Stop()
        {
            _stopButton.Stop();
            _display.DisplayMessage($"{nameof(AudioPlayer)} stop");
        }

        public void Notify()
        {
            int notificationType = NotificationMenu.ChooseNotificationType();
            NotificationPanel.NotificationClassification((NotificationType)notificationType);
        }
    }
}