using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class PhoneDisplay : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Phone Display: " + message);
        }
    }
}
