using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class ManagerExpenseHandler : ExpenseHandler
    {
        public override void ApproveExpense(Expense expense)
        {
            if (expense.Amount <= 500)
            {
                Console.WriteLine($"Manager approved expense of ${expense.Amount}");
            }
            
            else //if (NextHandler != null)
            {
                NextHandler?.ApproveExpense(expense);
            }
        }
    }
}
