using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public abstract class ExpenseHandler : IExpenseHandler
    {
        protected IExpenseHandler NextHandler;

        public void SetNextHandler(IExpenseHandler nextHandler)
        {
            NextHandler = nextHandler;
        }

        public abstract void ApproveExpense(Expense expense);
    }
}
