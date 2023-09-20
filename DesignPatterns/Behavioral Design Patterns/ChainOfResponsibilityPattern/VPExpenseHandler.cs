using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class VPExpenseHandler : ExpenseHandler
    {
        public override void ApproveExpense(Expense expense)
        {
            if (expense.Amount <= 1000)
            {
                Console.WriteLine($"VP approved expense of ${expense.Amount}");
            }
            else if (NextHandler != null)
            {
                NextHandler.ApproveExpense(expense);
            }
        }
    }
}
