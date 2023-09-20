using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(IBlackCoffee coffee) : base(coffee)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 50.0;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " but with milk";
        }
    }
}
