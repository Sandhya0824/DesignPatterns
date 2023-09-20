using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class TVDisplay : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("TV Display: " + message);
        }
    }
}
