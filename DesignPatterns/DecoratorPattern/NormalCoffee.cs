using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class NormalCoffee : IBlackCoffee
    {
        public double GetCost()
        {
            return 150.0;
        }

        public string GetDescription()
        {
            return "Normal black coffee";
        }
    }
}
