using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioApplicationPlayerAbstract
{
    internal class WindowsPlayButton : IPlayButton
    {
        public void Play()
        {
            Console.WriteLine("In Windows, Play Button is clicked");
        }
    }
}
