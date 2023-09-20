using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class CMOExpenseHandler : ExpenseHandler
    {
        public override void ApproveExpense(Expense expense)
        {
            if (expense.Amount <= 5000)
            {
                Console.WriteLine($"CMO approved expense of ${expense.Amount}");
            }
            else
            {
                Console.WriteLine($"CMO cannot approve the expense of ${expense.Amount}");
            }
        }
    }
}
