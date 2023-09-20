using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioApplicationPlayerAbstract
{
    internal class WindowsStopButton : IStopButton
    {
        public void Stop()
        {
            Console.WriteLine("In Windows, Stop Buttton is clicked!!!");
        }
    }
}
