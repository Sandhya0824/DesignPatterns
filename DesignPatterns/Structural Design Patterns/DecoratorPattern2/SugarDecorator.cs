using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(IBlackCoffee coffee) : base(coffee)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 25;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " but with sugar";
        }
    }
}
