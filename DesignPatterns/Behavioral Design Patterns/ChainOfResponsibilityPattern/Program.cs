namespace ChainOfResponsibilityPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var expenseHandlerChain = ExpenseHandlerChainBuilder.BuildExpenseHandlerChain();

            var expense1 = new Expense("Office supplies", 300);
            expenseHandlerChain.ApproveExpense(expense1);

            var expense2 = new Expense("Business trip", 1500);
            expenseHandlerChain.ApproveExpense(expense2);

            var expense3 = new Expense("New equipment", 6000);
            expenseHandlerChain.ApproveExpense(expense3);
        }
    }
}