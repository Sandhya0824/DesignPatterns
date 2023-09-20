using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class Expense
    {
        public string Description { get; }
        public double Amount { get; }

        public Expense(string description, double amount)
        {
            Description = description;
            Amount = amount;
        }
    }
}
