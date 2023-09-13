﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class CoffeeDecorator : IBlackCoffee
    {
        protected IBlackCoffee _coffee;

        public CoffeeDecorator(IBlackCoffee coffee)
        {
            _coffee = coffee;
        }

        public virtual double GetCost()
        {
            return _coffee.GetCost();
        }

        public virtual string GetDescription()
        {
            return _coffee.GetDescription();
        }
    }
}
